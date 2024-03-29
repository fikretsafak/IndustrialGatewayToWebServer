using System;
using System.Data;
using System.Data.SQLite;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using uPLibrary.Networking.M2Mqtt;

namespace IGW_mqttService
{
    public partial class mqttPublisher : ServiceBase
    {
        string sqllitedb_constr = "Data source=C:\\KONTROLMATIK\\SystemFiles\\config.db; Version=3; default timeout=10000; Pooling=True; Max Pool Size=100";
        DataTable mqttDevice = new DataTable();
        DataTable mqttTags = new DataTable();
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

        public void SQLadapFiller(string SQLString, DataTable table)
        {
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {
                using (var adap = new SQLiteDataAdapter(SQLString, connectDb))
                {
                    try
                    {
                        connectDb.Open();
                        adap.Fill(table);
                    }
                    catch (Exception)
                    {

                    }
                    connectDb.Close();
                }
            }
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {

            SQLadapFiller("SELECT * FROM MQTT", mqttDevice);
            foreach (DataRow row in mqttDevice.Rows)
            {
                string deviceName = row[0].ToString();
                mqClient = new MqttClient(row[2].ToString());
                try
                {
                    mqClient.Connect(row[1].ToString(), row[4].ToString(), row[5].ToString());
                }
                catch (Exception)
                {

                }

                SQLadapFiller("SELECT * FROM TAGS", mqttTags);

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

                try
                {
                    mqClient.Publish(row[6].ToString(), Encoding.UTF8.GetBytes(sendData));
                }
                catch (Exception)
                {

                }
                sendData = "";
                mqttTags.Clear();

            }
            mqttDevice.Clear();
            // _timer.Dispose();
        }

        protected override void OnStop()
        {
            _timer.Stop();
            _timer.Dispose();

        }
    }
}
