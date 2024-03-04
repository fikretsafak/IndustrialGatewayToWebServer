using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using NModbus;
using EasyModbus;
using System.Data.SQLite;
using System.Timers;

namespace IGW_modbusTCPService
{
    public partial class ModbusTCPreader : ServiceBase
    {
        string sqllitedb_constr = "Data source=C:\\KONTROLMATIK\\SystemFiles\\config.db; Version=3; default timeout=10000; Pooling=True; Max Pool Size=100";
        DataTable connTable = new DataTable();
        DataTable modbusTCPTagsTable = new DataTable();
        ModbusClient _client;
        Timer _timer;

        public ModbusTCPreader()
        {
            InitializeComponent();
            _timer = new Timer();
        }

        protected override void OnStart(string[] args)
        {
            _timer.Interval = 1000;
            _timer.Elapsed += _timer_Elapsed;
            _timer.Start();
        }




        public float GetHoldingRegisterData(int startAddress)
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


        public int GetInputRegisterData(int startAddress)
        {
            if (_client.Connected)
            {
                int[] inputValues = _client.ReadInputRegisters(startAddress, 1);
                return inputValues[0];

            }
            else
            {
                throw new ArgumentException("Cannot Connect To The Device.");
            }
        }

        public bool GetCoilData(int startAddress)
        {
            if (_client.Connected)
            {
                bool[] inputValues = _client.ReadCoils(startAddress, 1);
                return inputValues[0];

            }
            else
            {
                throw new ArgumentException("Cannot Connect To The Device.");
            }
        }

        public bool GetDiscreteData(int startAddress)
        {
            if (_client.Connected)
            {
                bool[] inputValues = _client.ReadDiscreteInputs(startAddress, 1);
                return inputValues[0];
            }
            else
            {
                throw new ArgumentException("Cannot Connect To The Device.");
            }
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
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
                            _client.ConnectionTimeout = 300;
                            _client.Connect();
                            DateTime tag_time = DateTime.Now;
                            if (_client.Connected)
                            {
                                if (rowTag[3].ToString() == "Measurement")
                                {
                                    if (rowTag[4].ToString() == "03 Read Holding Registers (4x)")
                                    {
                                        string tag_value = GetHoldingRegisterData(tagAddress).ToString();
                                        Console.WriteLine(tag + " = " + tag_value + " ");

                                        using (var connectDb = new SQLiteConnection(sqllitedb_constr))
                                        {
                                            using (var cmdDb = new SQLiteCommand($"UPDATE TAGS SET TAG_VALUE='{tag_value}', READ_TIME='{tag_time.ToString("dd/MM/yyyy HH:mm:ss")}' WHERE TAG_NAME = '{tag}'", connectDb))
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
                                    }
                                    else if (rowTag[4].ToString() == "04 Read Input Registers (3x)")
                                    {
                                        string tag_value = GetInputRegisterData(tagAddress).ToString();
                                        Console.WriteLine(tag + " = " + tag_value + " ");

                                        using (var connectDb = new SQLiteConnection(sqllitedb_constr))
                                        {
                                            using (var cmdDb = new SQLiteCommand($"UPDATE TAGS SET TAG_VALUE='{tag_value}', READ_TIME='{tag_time.ToString("dd/MM/yyyy HH:mm:ss")}' WHERE TAG_NAME = '{tag}'", connectDb))
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
                                    }
                                }

                                if (rowTag[3].ToString() == "Input")
                                {
                                    if (rowTag[4].ToString() == "01 Read Coils (0x)")
                                    {
                                        string tag_value = GetCoilData(tagAddress).ToString();
                                        Console.WriteLine(tag + " = " + tag_value + " ");

                                        using (var connectDb = new SQLiteConnection(sqllitedb_constr))
                                        {
                                            using (var cmdDb = new SQLiteCommand($"UPDATE TAGS SET TAG_VALUE='{tag_value}', READ_TIME='{tag_time.ToString("dd/MM/yyyy HH:mm:ss")}' WHERE TAG_NAME = '{tag}'", connectDb))
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
                                    }
                                    else if (rowTag[4].ToString() == "02 Read Discrete Inputs (1x)")
                                    {
                                        string tag_value = GetDiscreteData(tagAddress).ToString();
                                        Console.WriteLine(tag + " = " + tag_value + " ");

                                        using (var connectDb = new SQLiteConnection(sqllitedb_constr))
                                        {
                                            using (var cmdDb = new SQLiteCommand($"UPDATE TAGS SET TAG_VALUE='{tag_value}', READ_TIME='{tag_time.ToString("dd/MM/yyyy HH:mm:ss")}' WHERE TAG_NAME = '{tag}'", connectDb))
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
        protected override void OnStop()
        {
            _timer.Stop();
            _timer.Dispose();
        }
    } 


}

