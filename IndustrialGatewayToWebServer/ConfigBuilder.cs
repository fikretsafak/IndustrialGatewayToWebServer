using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.IO.Ports;


namespace IndustrialGatewayToWebServer
{
    public partial class ConfigBuilder : Form
    {
        string systemFilePath = "C:\\KONTROLMATIK\\SystemFiles\\";
        string sqllitedb_constr = "Data source=C:\\KONTROLMATIK\\SystemFiles\\config.db; Version=3; default timeout=10000; Pooling=True; Max Pool Size=100";
        string projectPath = Application.StartupPath;
        bool SameIPstatusTCP;
        bool SameNameStatusTCP;
        bool SameNameStatusRTU;
        bool SameSlaveIDforRTU;

        public ConfigBuilder()
        {
            InitializeComponent();
            findConnectedPorts();

        }

        private void ConfigBuilder_Load(object sender, EventArgs e)
        {
            InitFileCreate();
            DbCreate();
            DataViewFill($"SELECT * FROM COMMUNICATION");
            CommTypeCombo.SelectedIndex = 0;
            commDt.Columns[0].Visible = false;
        }

        private void InitFileCreate()
        {
            if (!File.Exists(systemFilePath))
            {
                Directory.CreateDirectory(systemFilePath);
                File.SetAttributes(systemFilePath, FileAttributes.Hidden);
            }
        }

        private void DbCreate()
        {
            if (!File.Exists(systemFilePath + "config.db"))
            {
                SQLiteConnection.CreateFile(systemFilePath + "config.db");

                using (var connectDb = new SQLiteConnection("Data source=" + systemFilePath + "config.db" + "; Version=3; default timeout=10000; Pooling=True; Max Pool Size=100"))
                {
                    connectDb.Open();
                    using (var cmdDb = new SQLiteCommand(@"CREATE TABLE COMMUNICATION (
                                                                                ID  INTEGER NOT NULL,
                                                                                DEVICE_NAME TEXT NOT NULL,
                                                                                COMM_TYPE TEXT NOT NULL,
                                                                                IP_ADDRESS TEXT NOT NULL ,
                                                                                COMM_PORT TEXT NOT NULL,
                                                                                DEVICE_ID  INTEGER NOT NULL,
                                                                                PRIMARY KEY(ID AUTOINCREMENT)); ", connectDb))
                        cmdDb.ExecuteNonQuery();

                    using (var cmdDb = new SQLiteCommand(@"CREATE TABLE MODBUS_RTU (
                                                                                DEVICE_NAME TEXT NOT NULL,
                                                                                COM_PORT TEXT NOT NULL,
                                                                                BAUDRATE TEXT NOT NULL,
                                                                                DATABITS TEXT NOT NULL,
                                                                                PARITY TEXT NOT NULL); ", connectDb))
                        cmdDb.ExecuteNonQuery();

                    using (var cmdDb = new SQLiteCommand(@"CREATE TABLE SIGNALS (
                                                                                SIGNAL_NAME  TEXT NOT NULL,
                                                                                SIGNAL_TYPE TEXT NOT NULL,
                                                                                COMM_TYPE  TEXT NOT NULL,
                                                                                SIGNAL_ADDRESS TEXT NOT NULL); ", connectDb))
                        cmdDb.ExecuteNonQuery();

                    using (var cmdDb = new SQLiteCommand(@"CREATE TABLE SQLSERVER (
                                                                                SERVER_NAME  TEXT NOT NULL,
                                                                                SERVER_IP TEXT NOT NULL,
                                                                                USERNAME  TEXT NOT NULL,
                                                                                PASSWORD TEXT NOT NULL); ", connectDb))
                        cmdDb.ExecuteNonQuery();

                    using (var cmdDb = new SQLiteCommand(@"CREATE TABLE MQTT (
                                                                                SERVER_NAME  TEXT NOT NULL,
                                                                                SERVER_ADDRESS TEXT NOT NULL,
                                                                                SERVER_PORT TEXT NOT NULL,
                                                                                USERNAME  TEXT NOT NULL,
                                                                                PASSWORD TEXT NOT NULL); ", connectDb))
                        cmdDb.ExecuteNonQuery();
                    connectDb.Close();
                }
            }

        }



        private void DataViewFill(string SQLite)
        {
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {
                using (var adap = new SQLiteDataAdapter(SQLite, connectDb))
                {
                    try
                    {
                        connectDb.Open();
                        DataTable dt = new DataTable();
                        adap.Fill(dt);

                        commDt.DataSource = dt;
                    }
                    catch (Exception)
                    {

                    }
                }
            }

        }

        private void Comm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CommTypeCombo.SelectedIndex == 0)
            {
                ModbusTCPgroup.Visible = true;
                ModbusRTUgroup.Visible = false;
                IEC104group.Visible = false;
            }

            if (CommTypeCombo.SelectedIndex == 1)
            {
                ModbusTCPgroup.Visible = false;
                ModbusRTUgroup.Visible = true;
                IEC104group.Visible = false;
            }

            if (CommTypeCombo.SelectedIndex == 2)
            {
                ModbusTCPgroup.Visible = false;
                ModbusRTUgroup.Visible = false;
                IEC104group.Visible = true;
            }
        }

        public void findConnectedPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                COMPortRTU.Items.Add(port);
            }
        }

        public void checkSameIPforTCP()
        {
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                using (var cmdDb = new SQLiteCommand($"SELECT * FROM COMMUNICATION WHERE IP_ADDRESS='{IPadressTCP.Text}'", connectDb))
                {

                    try
                    {
                        cmdDb.Connection.Open();
                        SQLiteDataReader dtr = cmdDb.ExecuteReader();
                        if (dtr.Read())
                        {
                            SameIPstatusTCP = true;
                            cmdDb.Connection.Close();
                        }

                        else
                        {
                            SameIPstatusTCP = false;
                        }

                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        public void checkSameDeviceNameTCP()
        {
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                using (var cmdDb = new SQLiteCommand($"SELECT * FROM COMMUNICATION WHERE DEVICE_NAME='{deviceNameTCP.Text}'", connectDb))
                {

                    try
                    {
                        cmdDb.Connection.Open();
                        SQLiteDataReader dtr = cmdDb.ExecuteReader();
                        if (dtr.Read())
                        {
                            SameNameStatusTCP = true;
                            cmdDb.Connection.Close();
                        }

                        else
                        {
                            SameNameStatusTCP = false;
                        }

                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        public void checkSameDeviceNameRTU()
        {
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                using (var cmdDb = new SQLiteCommand($"SELECT * FROM COMMUNICATION WHERE DEVICE_NAME='{deviceNameRTU.Text}'", connectDb))
                {

                    try
                    {
                        cmdDb.Connection.Open();
                        SQLiteDataReader dtr = cmdDb.ExecuteReader();
                        if (dtr.Read())
                        {
                            SameNameStatusRTU = true;
                            cmdDb.Connection.Close();
                        }

                        else
                        {
                            SameNameStatusRTU = false;
                        }

                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        public void checkSameSlaveIDforRTU()
        {
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                using (var cmdDb = new SQLiteCommand($"SELECT * FROM COMMUNICATION WHERE DEVICE_ID ='{SlaveIDRTU.Value}' and COMM_TYPE = 'Modbus RTU' and COMM_PORT = '{COMPortRTU.SelectedItem}' ", connectDb))
                {

                    try
                    {
                        cmdDb.Connection.Open();
                        SQLiteDataReader dtr = cmdDb.ExecuteReader();
                        if (dtr.Read())
                        {
                            SameSlaveIDforRTU = true;
                            cmdDb.Connection.Close();
                        }

                        else
                        {
                            SameSlaveIDforRTU = false;
                        }

                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }


        private void ModbusTCPaddButton_Click(object sender, EventArgs e)
        {
            checkSameIPforTCP();
            checkSameDeviceNameTCP();


            if (string.IsNullOrEmpty(IPadressTCP.Text) || string.IsNullOrEmpty(PortNumberTCP.Text) || string.IsNullOrEmpty(deviceNameTCP.Text))
            {
                MessageBox.Show("Make sure all info is filled.");
            }
            else
            {

                using (var connectDb = new SQLiteConnection("data source=" + systemFilePath + "config.db; version=3; default timeout=10000; pooling=true; max pool size=100"))
                {
                    if (SameIPstatusTCP)
                    {
                        MessageBox.Show("Check IP Address Must be Unique.");
                    }
                    else
                    {
                        if (SameNameStatusTCP)
                        {
                            MessageBox.Show("Check Device Name Must be Unique.");
                        }
                        else
                        {
                            using (var cmdDb = new SQLiteCommand($"INSERT INTO COMMUNICATION(DEVICE_NAME,COMM_TYPE,IP_ADDRESS,COMM_PORT,DEVICE_ID) values('{deviceNameTCP.Text}','{CommTypeCombo.SelectedItem}','{IPadressTCP.Text}','{PortNumberTCP.Text}','{SlaveIDTCP.Value}')", connectDb))
                            {

                                try
                                {
                                    cmdDb.Connection.Open();
                                    cmdDb.ExecuteNonQuery();
                                    MessageBox.Show("Modbus TCP Device added.");
                                    DataViewFill($"SELECT * FROM COMMUNICATION ");
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Check parameters.");
                                }
                            }
                        }
                    }

                }


            }
        }




        private void ModbusTCPupdateButton_Click(object sender, EventArgs e)
        {
            TCPupdate openForm_update = new TCPupdate();
            openForm_update.ShowDialog();


        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DataViewFill($"SELECT * FROM COMMUNICATION ");
        }

        private void ModbusRTUaddButton_Click(object sender, EventArgs e)
        {
            checkSameDeviceNameRTU();
            checkSameSlaveIDforRTU();
            if (string.IsNullOrEmpty(deviceNameRTU.Text) || string.IsNullOrEmpty(COMPortRTU.Text) || string.IsNullOrEmpty(baudRateRTU.Text) || string.IsNullOrEmpty(DataBitsRTU.Text) || string.IsNullOrEmpty(ParityRTU.Text))
            {
                MessageBox.Show("Make sure all info is filled.");
            }
            else
            {
                using (var connectDb = new SQLiteConnection("data source=" + systemFilePath + "config.db; version=3; default timeout=10000; pooling=true; max pool size=100"))
                {
                    if(SameNameStatusRTU)
                    {
                        MessageBox.Show("Check Device Name Must be Unique.");
                    }
                    else
                    {
                        if (SameSlaveIDforRTU)
                        {
                            MessageBox.Show("Check Slave ID Must be Unique.");
                        }
                        else
                        {
                            using (var cmdDb = new SQLiteCommand($"INSERT INTO COMMUNICATION(DEVICE_NAME,COMM_TYPE,IP_ADDRESS,COMM_PORT,DEVICE_ID) values('{deviceNameRTU.Text}','{CommTypeCombo.SelectedItem}','Disabled','{COMPortRTU.SelectedItem}','{SlaveIDRTU.Value}')", connectDb))
                            {

                                try
                                {
                                    cmdDb.Connection.Open();
                                    cmdDb.ExecuteNonQuery();
                                    using (var connectDb2 = new SQLiteConnection("data source=" + systemFilePath + "config.db; version=3; default timeout=10000; pooling=true; max pool size=100"))
                                    {
                                        using (var cmdDb2 = new SQLiteCommand($"INSERT INTO MODBUS_RTU(DEVICE_NAME,COM_PORT,BAUDRATE,DATABITS,PARITY) values('{deviceNameRTU.Text}','{COMPortRTU.SelectedItem}','{baudRateRTU.SelectedItem}','{DataBitsRTU.SelectedItem}','{ParityRTU.SelectedItem}')", connectDb2))
                                        {

                                            try
                                            {
                                                cmdDb2.Connection.Open();
                                                cmdDb2.ExecuteNonQuery();
                                                MessageBox.Show("Modbus RTU Device added.");
                                                DataViewFill($"SELECT * FROM COMMUNICATION ");
                                            }
                                            catch (Exception)
                                            {
                                                MessageBox.Show("Check parameters.");
                                            }
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                }
                            }
                        }
                    }
                    
                }
            }
        }

        private void ModbusRTUupdateButton_Click(object sender, EventArgs e)
        {
            RTUupdate openForm1_update = new RTUupdate();
            openForm1_update.ShowDialog();

        }
    }
}
