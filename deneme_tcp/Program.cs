using EasyModbus;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;



namespace deneme_tcp
{

    internal class Program
    {

        static void Main()
        {
            string sqllitedb_constr = "Data source=C:\\KONTROLMATIK\\SystemFiles\\config.db; Version=3; default timeout=10000; Pooling=True; Max Pool Size=100";
            DataTable connTable = new DataTable();
            DataTable modbusTCPTagsTable = new DataTable();
            ModbusClient _client;

            float GetHoldingRegisterData(int startAddress)
            {
                if (_client.Connected)
                {
                    int[] holdingValues = _client.ReadHoldingRegisters(startAddress, 2);

                    float value = ModbusClient.ConvertRegistersToFloat(holdingValues, ModbusClient.RegisterOrder.HighLow);
                    return value;

                }
                else
                {
                    throw new ArgumentException("Cannot Connect To The Device.");
                }
            }


            while (true)
            {
                using (var connectDb = new SQLiteConnection(sqllitedb_constr))
                {
                    using (var adap = new SQLiteDataAdapter($"SELECT * FROM COMMUNICATION", connectDb))
                    {
                        try
                        {
                            connectDb.Open();
                            adap.Fill(connTable);

                        }
                        catch (Exception)
                        {

                        }
                    }
                    // connectDb.Close();
                }


                using (var connectDb2 = new SQLiteConnection(sqllitedb_constr))
                {
                    using (var adap = new SQLiteDataAdapter($"SELECT * FROM TAGS", connectDb2))
                    {
                        try
                        {
                            connectDb2.Open();
                            adap.Fill(modbusTCPTagsTable);

                        }
                        catch (Exception)
                        {

                        }
                    }
                    //connectDb2.Close(); 
                }

                foreach (DataRow rowTag in modbusTCPTagsTable.Rows)
                {
                    string tag = rowTag[0].ToString();
                    ushort tagAddress = ushort.Parse(rowTag[6].ToString());
                    foreach (DataRow row in connTable.Rows)
                    {
                        if (rowTag[1].ToString() == row[1].ToString())
                        {
                            string device = row[1].ToString();
                            string ipAddress = row[3].ToString();
                            int port = Int32.Parse(row[4].ToString());
                            byte slaveId = byte.Parse(row[5].ToString());

                            try
                            {

                                _client = new ModbusClient(ipAddress, port);
                                _client.UnitIdentifier = slaveId;
                                _client.Available(10);
                                _client.ConnectionTimeout =300;
                                _client.Connect();
                                if (_client.Connected)
                                {
                                    string tag_value = GetHoldingRegisterData(tagAddress).ToString();
                                    Console.WriteLine(tag + " = " + tag_value + " ");

                                    using (var connectDb = new SQLiteConnection(sqllitedb_constr))
                                    {
                                        using (var cmdDb = new SQLiteCommand($"UPDATE TAGS SET TAG_VALUE='{tag_value}' WHERE TAG_NAME = '{tag}'", connectDb))
                                        {
                                            try
                                            {
                                                cmdDb.Connection.Open();
                                                cmdDb.ExecuteNonQuery();

                                            }

                                            catch (Exception)
                                            {

                                            }
                                        }
                                    }
                                    _client.Disconnect();
                                }
                                else
                                {
                                    _client.Disconnect();
                                }
                                //modbus_client = new TcpClient(ipAddress, port);


                            }
                            catch (Exception)
                            {
                                break;
                                Console.WriteLine(tag + " " + device + " " + ipAddress + " bağlanmadı");
                            }
                        }

                    }
                }

            }


        }


       

    }

}
