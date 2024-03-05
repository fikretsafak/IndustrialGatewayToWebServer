using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using System.Timers;

namespace IGW_mqttService
{
    public partial class mqttPublisher : ServiceBase
    {
        string sqllitedb_constr = "Data source=C:\\KONTROLMATIK\\SystemFiles\\config.db; Version=3; default timeout=10000; Pooling=True; Max Pool Size=100";
        DataTable mqttDevice = new DataTable();
        DataTable mqttTags = new DataTable();
        List<string> jsonList = new List<string>();
        MqttClient mqClient;
        Timer _timer;

        public mqttPublisher()
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

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {

                using (var connectDb = new SQLiteConnection(sqllitedb_constr))
                {
                    using (var adap = new SQLiteDataAdapter($"SELECT * FROM MQTT", connectDb))
                    {
                        try
                        {
                            connectDb.Open();
                            adap.Fill(mqttDevice);

                        }
                        catch (Exception)
                        {

                        }
                        connectDb.Close();
                    }
                }
                foreach (DataRow row in mqttDevice.Rows)
                {
                    string deviceName = row[0].ToString();
                    //Console.WriteLine("Connection: " + deviceName);
                    mqClient = new MqttClient(row[2].ToString());
                    try
                    {
                        mqClient.Connect(row[1].ToString(), row[4].ToString(), row[5].ToString());
                    }
                    catch (Exception)
                    {

                    }

                    if (mqClient.IsConnected)
                    {
                        //Console.WriteLine($"Connecting to {row[0].ToString()} ");
                    }
                    else
                    {

                    }
                    using (var connectDb2 = new SQLiteConnection(sqllitedb_constr))
                    {
                        using (var adap = new SQLiteDataAdapter($"SELECT * FROM TAGS", connectDb2))
                        {
                            try
                            {
                                connectDb2.Open();
                                adap.Fill(mqttTags);
                            }
                            catch (Exception)
                            {

                            }
                            connectDb2.Close();
                        }
                    }
                    string tagNamesTemp = row[7].ToString();
                    string[] tagNames = tagNamesTemp.Split(';');
                    string sendData = "{";

                    for (int i = 0; i < tagNames.Length; i++)
                    {
                        foreach (DataRow mqttTagName in mqttTags.Rows)
                        {
                            string tag_Name = mqttTagName[0].ToString();
                            string tag_Value = mqttTagName[7].ToString();
                            if (tagNames[i] == tag_Name)
                            {
                                sendData = sendData + @"""" + tagNames[i] + @"""" + ":" + @"""" + tag_Value + @""",";
                            }
                            else
                            {

                            }

                        }
                    }

                    sendData = sendData.Substring(0, sendData.Length - 1) + "}";
                    //Console.WriteLine(sendData);
                    mqClient.Publish(row[6].ToString(), Encoding.UTF8.GetBytes(sendData));
                    sendData = "";
                    mqttTags.Clear();
                }
                // Thread.Sleep(2000); 
                mqttDevice.Clear();

            

        }
    

        protected override void OnStop()
        {
            _timer.Stop();
            _timer.Dispose();
        }
    }
}
