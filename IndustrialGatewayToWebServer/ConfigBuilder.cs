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
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;


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
        bool SameNameStatusTAG;
        bool SameNameStatusMQTT;
        bool SameNameStatusTAGupdate;
        string SelectedTreeNode;
        string SelectedNAMEforUpdate;
        string[] tagTypeArray = new string[10000];
        string[ , ] groupCount = new string[10000,10000];
        string mySQLconString;
        string SQLiteconString;
        string SQLiteCreatefolderPath;
        int n = 0;
        string tempTagName;
        string selectedTag;
        bool groupFilledstatus;
        string mqttTagNameString = "";
        


        public ConfigBuilder()
        {
            InitializeComponent();
            findConnectedPorts();
        }

        DataTable dtReadTag = new DataTable();

        private void ConfigBuilder_Load(object sender, EventArgs e)
        {
            InitFileCreate();
            DbCreate();
            DataViewFill($"SELECT * FROM COMMUNICATION");
            DataViewFillForTags($"SELECT * FROM TAGS");
            DataViewFillForReadData($"SELECT * FROM TAGS");
            DataViewFillForGroup($"SELECT * FROM TAG_GROUP");
            CommTypeCombo.SelectedIndex = 0;
            commDt.Columns[0].Visible = false;
            fillDeviceNameCombo();
            fillTagsNameComboProperties();
            mySQLserverAddress.Enabled = false;
            mySQLusername.Enabled = false;
            mySQLpassword.Enabled = false;
            mySQLdatabaseName.Enabled = false;
            connIDSetButton.Enabled = false;
            MySQLtableNameSet.Enabled = false;
            MySQLdt.Enabled = false;
            addTableMySQLbutton.Enabled = false;
            selectFolderButton.Enabled = false;
            SQLiteDbName.Enabled = false;
            SQLiteCreateDBbutton.Enabled = false;
            SQLiteAddConnectString.Enabled = false;
            SQLiteTableName.Enabled = false;
            SQLiteDt.Enabled = false;
            SQLiteAddTableButton.Enabled = false;
            checkMySQLEnable();
            checkSQLiteEnable();
            SelectTagName.Enabled = false;
            SelectDeviceName.Enabled = false;
            tagGroupNameUpdate.Enabled = false;
            SelectTagType.Enabled = false;
            SelectFunction.Enabled = false;
            SelectDisplayMode.Enabled = false;
            SelectTagAddress.Enabled = false;
            updateTagButton.Enabled = false;
            deleteTagButton.Enabled = false;
            MQTTTreeViewFill();
            DataViewFillForMQTT($"SELECT * FROM MQTT");
            mqttDt.Columns[5].Visible = false;
            mqttDt.Columns[7].Visible = false;
            backgroundWorker1.RunWorkerAsync();

            try
            {
                serviceStatusControl("IGW_ModbusTCPService", ModbusTCPServiceStatus);
                serviceStatusControl("IGW_MQTTService", MQTTserviceStatus);
                //serviceStatusControl("IGW_ModbusRTUService", ModbusRTUServiceStatus);
                //serviceStatusControl("IGW_SQLService", SQLserviceStatus);
            }
            catch (Exception)
            {

            }


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
                                                                                IP_ADDRESS TEXT NOT NULL,
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

                    using (var cmdDb = new SQLiteCommand(@"CREATE TABLE TAG_GROUP (
                                                                                GROUP_NAME TEXT NOT NULL,
                                                                                DEVICE_NAME TEXT NOT NULL); ", connectDb))
                        cmdDb.ExecuteNonQuery();

                    using (var cmdDb = new SQLiteCommand(@"CREATE TABLE TAGS (
                                                                                TAG_NAME  TEXT NOT NULL UNIQUE,
                                                                                DEVICE_NAME  TEXT NOT NULL,
                                                                                GROUP_NAME  TEXT NOT NULL,
                                                                                TAG_TYPE TEXT NOT NULL,
                                                                                FUNCTION  TEXT NOT NULL,
                                                                                DISPLAY_MODE  TEXT NOT NULL,
                                                                                TAG_ADDRESS TEXT NOT NULL,
                                                                                TAG_VALUE  TEXT,
                                                                                READ_TIME  TEXT); ", connectDb))
                        cmdDb.ExecuteNonQuery();



                    using (var cmdDb = new SQLiteCommand(@"CREATE TABLE MYSQLSERVER (
                                                                                STATUS TEXT NOT NULL,
                                                                                SERVER_IP TEXT NOT NULL,
                                                                                USERNAME  TEXT NOT NULL,
                                                                                PASSWORD TEXT ,
                                                                                DATABASE TEXT NOT NULL,
                                                                                CONN_STRING TEXT NOT NULL,
                                                                                TABLE_CREATE_STRING TEXT NOT NULL); ", connectDb))
                      cmdDb.ExecuteNonQuery();

                     using (var cmdDb = new SQLiteCommand($"INSERT INTO MYSQLSERVER(STATUS,SERVER_IP,USERNAME,PASSWORD,DATABASE,CONN_STRING,TABLE_CREATE_STRING) values('False',' ',' ','',' ',' ',' ')", connectDb))
  
                     
                     cmdDb.ExecuteNonQuery();

                    using (var cmdDb = new SQLiteCommand(@"CREATE TABLE SQLITESERVER (
                                                                                STATUS TEXT NOT NULL,
                                                                                FILE_PATH TEXT NOT NULL,
                                                                                CONN_STRING TEXT NOT NULL,
                                                                                TABLE_CREATE_STRING TEXT NOT NULL); ", connectDb))
                    cmdDb.ExecuteNonQuery();

                    using (var cmdDb = new SQLiteCommand($"INSERT INTO SQLITESERVER(STATUS,FILE_PATH,CONN_STRING,TABLE_CREATE_STRING) values('False',' ',' ',' ')", connectDb))


                    cmdDb.ExecuteNonQuery();

                    using (var cmdDb = new SQLiteCommand(@"CREATE TABLE MQTT (
                                                                                CONN_NAME  TEXT NOT NULL,
                                                                                CLIENT_ID TEXT NOT NULL,
                                                                                HOST_ADDRESS TEXT NOT NULL,
                                                                                HOST_PORT TEXT NOT NULL,
                                                                                USERNAME  TEXT,
                                                                                PASSWORD TEXT, 
                                                                                TOPIC TEXT,
                                                                                TAGS TEXT NOT NULL); ", connectDb))
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



        private void DataViewFillForTags(string SQLite)
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
                        tagDt.DataSource = dt;
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void DataViewFillForGroup(string SQLite)
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
                        groupDt.DataSource = dt;
                    }
                    catch (Exception)
                    {

                    }
                }
            }

        }

        private void DataViewFillForReadData(string SQLite)
        {
            dtReadTag.Clear();
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {
                using (var adap = new SQLiteDataAdapter(SQLite, connectDb))
                {
                    try
                    {
                        connectDb.Open();
                        adap.Fill(dtReadTag);
                        readTagDt.DataSource = dtReadTag;
                        //readTagDt.Columns[3].Visible = false;
                        //readTagDt.Columns[4].Visible = false;
                    }
                    catch (Exception)
                    {

                    }
                }
            }

        }

        private void DataViewFillForMQTT(string SQLite)
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
                        mqttDt.DataSource = dt;
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

        public void checkSameDeviceNameMQTT()
        {
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                using (var cmdDb = new SQLiteCommand($"SELECT * FROM MQTT WHERE CONN_NAME='{mqttNameAdd.Text}'", connectDb))
                {

                    try
                    {
                        cmdDb.Connection.Open();
                        SQLiteDataReader dtr = cmdDb.ExecuteReader();
                        if (dtr.Read())
                        {
                            SameNameStatusMQTT = true;
                            cmdDb.Connection.Close();
                        }

                        else
                        {
                            SameNameStatusMQTT = false;
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

        public void checkSameTagName()
        {
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                using (var cmdDb = new SQLiteCommand($"SELECT * FROM TAGS WHERE TAG_NAME='{tagNameAdd.Text}'", connectDb))
                {

                    try
                    {
                        cmdDb.Connection.Open();
                        SQLiteDataReader dtr = cmdDb.ExecuteReader();
                        if (dtr.Read())
                        {
                            SameNameStatusTAG = true;
                            cmdDb.Connection.Close();
                        }

                        else
                        {
                            SameNameStatusTAG = false;
                        }

                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        public void checkSameTagNameUpdate()
        {
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                using (var cmdDb = new SQLiteCommand($"SELECT * FROM TAGS WHERE TAG_NAME='{SelectTagName.Text}'", connectDb))
                {

                    try
                    {
                        cmdDb.Connection.Open();
                        SQLiteDataReader dtr = cmdDb.ExecuteReader();
                        if (dtr.Read())
                        {
                            SameNameStatusTAGupdate = true;
                            cmdDb.Connection.Close();
                        }

                        else
                        {
                            SameNameStatusTAGupdate = false;
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

        public void checkMySQLEnable()
        {
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                using (var cmdDb = new SQLiteCommand($"SELECT * FROM MYSQLSERVER WHERE STATUS ='True'", connectDb))
                {
                    try
                    {
                        cmdDb.Connection.Open();
                        SQLiteDataReader dtr = cmdDb.ExecuteReader();
                        if (dtr.Read())
                        {
                            MySQLenableCB.Checked = true;
                            cmdDb.Connection.Close();
                        }

                        else
                        {
                            MySQLenableCB.Checked = false;
                        }

                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        public void ChangeMySQLEnableStatus()
        {
            using (var connectDb = new SQLiteConnection("data source=" + systemFilePath + "config.db; version=3; default timeout=10000; pooling=true; max pool size=100"))
            {
                    using (var cmdDb = new SQLiteCommand($"UPDATE MYSQLSERVER SET STATUS = '{MySQLenableCB.Checked}'", connectDb))
                    {

                        try
                        {
                            cmdDb.Connection.Open();
                            cmdDb.ExecuteNonQuery();
                            cmdDb.Connection.Close();
                         }
                        catch (Exception)
                        {
                        }
                    }
            }
        }

        public void UpdateMySQL()
        {
            using (var connectDb = new SQLiteConnection("data source=" + systemFilePath + "config.db; version=3; default timeout=10000; pooling=true; max pool size=100"))
            {
                using (var cmdDb = new SQLiteCommand($"UPDATE MYSQLSERVER  SET SERVER_IP = '{mySQLserverAddress.Text}',USERNAME='{mySQLusername.Text}',PASSWORD='{mySQLpassword.Text}',DATABASE='{mySQLdatabaseName.Text}',CONN_STRING='{mySQLconString}' " , connectDb))
                {
                    try
                    {
                        cmdDb.Connection.Open();
                        cmdDb.ExecuteNonQuery();
                        cmdDb.Connection.Close();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        public void ChangeSQLiteEnableStatus()
        {
            using (var connectDb = new SQLiteConnection("data source=" + systemFilePath + "config.db; version=3; default timeout=10000; pooling=true; max pool size=100"))
            {
                using (var cmdDb = new SQLiteCommand($"UPDATE SQLITESERVER SET STATUS = '{SQLiteEnableCB.Checked}'", connectDb))
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

        public void checkSQLiteEnable()
        {
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                using (var cmdDb = new SQLiteCommand($"SELECT * FROM SQLITESERVER WHERE STATUS ='True'", connectDb))
                {
                    try
                    {
                        cmdDb.Connection.Open();
                        SQLiteDataReader dtr = cmdDb.ExecuteReader();
                        if (dtr.Read())
                        {
                            SQLiteEnableCB.Checked = true;
                            cmdDb.Connection.Close();
                        }

                        else
                        {
                            SQLiteEnableCB.Checked = false;
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
                            using (var cmdDb = new SQLiteCommand($"INSERT INTO COMMUNICATION(DEVICE_NAME,COMM_TYPE,IP_ADDRESS,COMM_PORT,DEVICE_ID) values('{deviceNameRTU.Text}','{CommTypeCombo.SelectedItem}',' ','{COMPortRTU.SelectedItem}','{SlaveIDRTU.Value}')", connectDb))
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

        private void fillDeviceNameCombo()
        {
            TagDeviceNameCombo.Items.Clear();
           for (int i = 0; i < commDt.Rows.Count; i++)
            {
                string devName = commDt.Rows[i].Cells[1].Value.ToString();
                TagDeviceNameCombo.Items.Add(devName);
            }
        }

        private void fillDeviceNameComboProperties()
        {
            SelectDeviceName.Items.Clear();
            for (int i = 0; i < commDt.Rows.Count; i++)
            {
                string devName = commDt.Rows[i].Cells[1].Value.ToString();
                SelectDeviceName.Items.Add(devName);
            }
        }

        private void fillTagsNameComboProperties()
        {
            TagNameDt.Items.Clear();
            for (int i = 0; i < readTagDt.Rows.Count; i++)
            {
                string tagName = readTagDt.Rows[i].Cells[0].Value.ToString();
                TagNameDt.Items.Add(tagName);
            }
        }

        private void TagSetRefreshButton_Click(object sender, EventArgs e)
        {
            fillDeviceNameCombo();
            DataViewFillForTags($"SELECT * FROM TAGS");
            DataViewFillForGroup($"SELECT * FROM TAG_GROUP");
            TreeViewFill();
        }

        private void BuilderTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDeviceNameCombo();
            DataViewFill($"SELECT * FROM COMMUNICATION ");
            DataViewFillForTags($"SELECT * FROM TAGS");
            DataViewFillForReadData($"SELECT * FROM TAGS");
            DataViewFillForGroup($"SELECT * FROM TAG_GROUP");
            DataViewFillForMQTT($"SELECT * FROM MQTT");
            TreeViewFill();
            MQTTTreeViewFill();

        }

        private void TreeViewFill()
        {
            TagTreeView.Nodes.Clear();
            n = 0;

            for (int q = 0; q < TagTreeView.Nodes.Count; q++)
            {
                TagTreeView.Nodes[q].ImageIndex = 3;
            }


            for (int i = 0; i < commDt.Rows.Count; i++)
            {
                string devName = commDt.Rows[i].Cells[1].Value.ToString();
                string IPaddress = commDt.Rows[i].Cells[3].Value.ToString();
                string comPort = commDt.Rows[i].Cells[4].Value.ToString();
                if (IPaddress == " ")
                {
                    TagTreeView.Nodes.Add(comPort + " - " + devName);
                }
                else
                {
                    TagTreeView.Nodes.Add(IPaddress + " - " + devName);
                }
                for (int m = 0; m < groupDt.Rows.Count; m++)
                {
                    string groupName = groupDt.Rows[m].Cells[0].Value.ToString();
                    groupCount[i, m] = groupName;
                }

                    for (int k = 0; k < groupDt.Rows.Count; k++)
                    {
                    string groupDevName = groupDt.Rows[k].Cells[1].Value.ToString();
                    string groupName = groupDt.Rows[k].Cells[0].Value.ToString();
                    TagTreeView.Nodes[i].ImageIndex = 1;
                    if (devName == groupDevName)
                        {
                            TagTreeView.Nodes[i].Nodes.Add(groupName);
                            TagTreeView.Nodes[i].ImageIndex = 1;
                        
                            for (int j = 0; j < tagDt.Rows.Count; j++)
                            {
                                string tagName = tagDt.Rows[j].Cells[0].Value.ToString();
                                string tagGroup = tagDt.Rows[j].Cells[2].Value.ToString();
                                if (tagGroup == groupName)
                                {
                                    TagTreeView.Nodes[i].Nodes[n].Nodes.Add(tagName);
                                    TagTreeView.Nodes[i].Nodes[n].ImageIndex = 2;
                                }
                                else
                                {
                                     //TagTreeView.Nodes[i].Nodes[n].ImageIndex = 5;
                                 }
                            }
                            n = n + 1;
                        }

                        else
                        {

                        }

                    }
                      n = 0;
            }
            
        }


        private void MQTTTreeViewFill()
        {

            mqttTreeView.Nodes.Clear();
            n = 0;

            for (int q = 0; q < mqttTreeView.Nodes.Count; q++)
            {
                mqttTreeView.Nodes[q].ImageIndex = 3;
            }


            for (int i = 0; i < commDt.Rows.Count; i++)
            {
                string devName = commDt.Rows[i].Cells[1].Value.ToString();
                string IPaddress = commDt.Rows[i].Cells[3].Value.ToString();
                string comPort = commDt.Rows[i].Cells[4].Value.ToString();
                if (IPaddress == " ")
                {
                    mqttTreeView.Nodes.Add(comPort + " - " + devName);
                }
                else
                {
                    mqttTreeView.Nodes.Add(IPaddress + " - " + devName);
                }
                for (int m = 0; m < groupDt.Rows.Count; m++)
                {
                    string groupName = groupDt.Rows[m].Cells[0].Value.ToString();
                    groupCount[i, m] = groupName;
                }

                for (int k = 0; k < groupDt.Rows.Count; k++)
                {
                    string groupDevName = groupDt.Rows[k].Cells[1].Value.ToString();
                    string groupName = groupDt.Rows[k].Cells[0].Value.ToString();
                    mqttTreeView.Nodes[i].ImageIndex = 1;
                    if (devName == groupDevName)
                    {
                        mqttTreeView.Nodes[i].Nodes.Add(groupName);
                        mqttTreeView.Nodes[i].ImageIndex = 1;

                        for (int j = 0; j < tagDt.Rows.Count; j++)
                        {
                            string tagName = tagDt.Rows[j].Cells[0].Value.ToString();
                            string tagGroup = tagDt.Rows[j].Cells[2].Value.ToString();
                            if (tagGroup == groupName )
                            {
                                if(mqttTreeView.Nodes[i].Checked)
                                {
                                    mqttTreeView.Nodes[i].Nodes[n].Nodes.Add(tagName);
                                    mqttTreeView.Nodes[i].Nodes[n].ImageIndex = 2;
                                    mqttTreeView.Nodes[i].Nodes[n].Checked = true;
                                }
                                else
                                {
                                    mqttTreeView.Nodes[i].Nodes[n].Nodes.Add(tagName);
                                    mqttTreeView.Nodes[i].Nodes[n].ImageIndex = 2;
                                }

                            }
                            else
                            {
                                //mqttTreeView.Nodes[i].Nodes[n].ImageIndex = 5;
                            }
                        }
                        n = n + 1;
                    }

                    else
                    {

                    }

                }
                n = 0;
            }
        }


        private void DeleteEmptyGroup(string group)
        {
            string groupName = group;
            string[] devName = group.Split('.');


            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {
                for (int i = 0; i < tagDt.Rows.Count; i++)
                {
                    string tagGroupName = tagDt.Rows[i].Cells[2].Value.ToString();
                    if (tagGroupName == groupName)
                    {
                        groupFilledstatus = true;
                    }
                    else
                    {
                        using (var cmdDb = new SQLiteCommand($"DELETE FROM TAG_GROUP WHERE GROUP_NAME = '{groupName}' AND DEVICE_NAME = '{devName[0]}'", connectDb))
                        {
                            try
                            {
                                cmdDb.Connection.Open();
                                cmdDb.ExecuteNonQuery();
                                DataViewFill($"SELECT * FROM COMMUNICATION ");
                                DataViewFillForTags($"SELECT * FROM TAGS");
                                DataViewFillForGroup($"SELECT * FROM TAG_GROUP");
                                TreeViewFill();
                                groupFilledstatus = false;
                            }

                            catch (Exception)
                            {
                            }
                        }
                    }
                    if(groupFilledstatus)
                    {
                        MessageBox.Show("Not deleted group because it is filled");
                    }
                }

                if(tagDt.Rows.Count == 0)
                {
                    using (var cmdDb = new SQLiteCommand($"DELETE FROM TAG_GROUP WHERE GROUP_NAME = '{groupName}' AND DEVICE_NAME = '{devName[0]}'", connectDb))
                    {
                        try
                        {
                            cmdDb.Connection.Open();
                            cmdDb.ExecuteNonQuery();
                            DataViewFill($"SELECT * FROM COMMUNICATION ");
                            DataViewFillForTags($"SELECT * FROM TAGS");
                            DataViewFillForGroup($"SELECT * FROM TAG_GROUP");
                            TreeViewFill();
                        }

                        catch (Exception)
                        {
                        }
                    }
                }

            }



        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            string[] devName = selectedTag.Split('.');

            if (devName.Length != 2)
            {
                MessageBox.Show("Selected item is not group");
            }
            else
            {

                DialogResult diar = MessageBox.Show("Are you sure delete group ?", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diar == DialogResult.Yes)
                {
                    DeleteEmptyGroup(selectedTag);
                }

            }



        }

        private void readTreeView(string selectedTag)
        {
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                using (var cmdDb1 = new SQLiteCommand($"SELECT * FROM TAGS WHERE TAG_NAME ='{selectedTag}'", connectDb))
                {

                    try
                    {
                        cmdDb1.Connection.Open();
                        SQLiteDataReader dtr1 = cmdDb1.ExecuteReader();
                        if (dtr1.Read())
                        {
                            fillDeviceNameComboProperties();
                            string tempGroupName = dtr1["GROUP_NAME"].ToString();
                            tagGroupNameUpdate.Text = tempGroupName.Replace(@dtr1["DEVICE_NAME"].ToString() + ".", @"");
                            tempTagName = dtr1["TAG_NAME"].ToString();
                            SelectTagName.Text = tempTagName.Replace(@dtr1["GROUP_NAME"].ToString()+".", @"");
                            SelectDeviceName.SelectedItem = dtr1["DEVICE_NAME"].ToString();
                            SelectTagType.SelectedItem = dtr1["TAG_TYPE"].ToString();
                            SelectFunction.SelectedItem = dtr1["FUNCTION"].ToString();
                            SelectDisplayMode.SelectedItem = dtr1["DISPLAY_MODE"].ToString();
                            SelectTagAddress.Text = dtr1["TAG_ADDRESS"].ToString();

                            SelectedNAMEforUpdate = tempTagName;

                            cmdDb1.Connection.Close();
                        }

                        else
                        {
                        }

                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }




        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SelectedTreeNode = e.Node.ToString();
            selectedTag = SelectedTreeNode.Substring(10);
            string[] isThatTag = selectedTag.Split('.');
            if(isThatTag.Length != 3)
            {
                SelectTagName.Text = "";
                SelectDeviceName.SelectedItem = "" ;
                tagGroupNameUpdate.Text = "";
                SelectTagType.SelectedItem = " ";
                SelectFunction.SelectedItem = " ";
                SelectDisplayMode.SelectedItem = " ";
                SelectTagAddress.Text = "";

                SelectTagName.Enabled = false;
                SelectDeviceName.Enabled = false;
                tagGroupNameUpdate.Enabled = false;
                SelectTagType.Enabled = false;
                SelectFunction.Enabled = false;
                SelectDisplayMode.Enabled = false;
                SelectTagAddress.Enabled = false;
                updateTagButton.Enabled = false;
                deleteTagButton.Enabled = false;
            }
            else
            {
                SelectTagName.Enabled = true;
                SelectDeviceName.Enabled = true;
                tagGroupNameUpdate.Enabled = true;
                SelectTagType.Enabled = true;
                SelectFunction.Enabled = true;
                SelectDisplayMode.Enabled = true;
                SelectTagAddress.Enabled = true;
                updateTagButton.Enabled = true;
                deleteTagButton.Enabled = true;
            }
            label44.Text = selectedTag;
            readTreeView(selectedTag);




        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            checkSameTagName();
            if (string.IsNullOrEmpty(tagNameAdd.Text) || string.IsNullOrEmpty(tagGroupNameAdd.Text) || string.IsNullOrEmpty(TagDeviceNameCombo.Text) || string.IsNullOrEmpty(tagFunctionAdd.Text) || string.IsNullOrEmpty(tagDisplayAdd.Text) || string.IsNullOrEmpty(tagAddressAdd.Text))
            {
                MessageBox.Show("Make sure all info is filled.");
            }
            else
            {
                using (var connectDb = new SQLiteConnection("data source=" + systemFilePath + "config.db; version=3; default timeout=10000; pooling=true; max pool size=100"))
                {
                    if (SameNameStatusTAG)
                    {
                        MessageBox.Show("Check Tag Name Must be Unique.");
                    }
                    else
                    {
                        using (var cmdDb = new SQLiteCommand($"INSERT INTO TAGS (TAG_NAME,DEVICE_NAME,GROUP_NAME,TAG_TYPE,FUNCTION,DISPLAY_MODE,TAG_ADDRESS) values('{TagDeviceNameCombo.SelectedItem + "." + tagGroupNameAdd.Text + "." + tagNameAdd.Text}','{TagDeviceNameCombo.SelectedItem}','{TagDeviceNameCombo.SelectedItem + "."+ tagGroupNameAdd.Text}','{tagTypeAdd.SelectedItem}','{tagFunctionAdd.SelectedItem}','{tagDisplayAdd.SelectedItem}','{tagAddressAdd.Text}')", connectDb))
                        {

                            try
                            {
                                cmdDb.Connection.Open();
                                cmdDb.ExecuteNonQuery();
                                
                                using (var cmdDb2 = new SQLiteCommand($"SELECT * FROM TAG_GROUP WHERE GROUP_NAME ='{TagDeviceNameCombo.SelectedItem + "."+ tagGroupNameAdd.Text}'", connectDb))
                                {
                                     SQLiteDataReader dtr1 = cmdDb2.ExecuteReader();
                                     if (dtr1.Read())
                                     {

                                     }
                                     else
                                     {
                                        using (var cmdDb1 = new SQLiteCommand($"INSERT INTO TAG_GROUP (GROUP_NAME,DEVICE_NAME) values('{TagDeviceNameCombo.SelectedItem + "." + tagGroupNameAdd.Text}','{TagDeviceNameCombo.SelectedItem}')", connectDb))
                                        {
                                           try
                                           {
                                             cmdDb1.ExecuteNonQuery();
                                           }
                                                        catch (Exception)
                                                         {
                                                         }
                                        }
                                     }

                                }

                               MessageBox.Show("Tag Added succesfuly.");
                               DataViewFillForTags($"SELECT * FROM TAGS");
                               DataViewFillForGroup($"SELECT * FROM TAG_GROUP");
                               TreeViewFill();
                                MQTTTreeViewFill();



                            }
                            catch (Exception)
                            {
                            }


                        }


                    }

                }
            }
        }

        private void tagTypeAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tagTypeAdd.SelectedItem.ToString() == "Input")
            {
                tagFunctionAdd.Items.Clear();
                tagDisplayAdd.SelectedIndex = 0;
                tagDisplayAdd.Enabled = false;
                tagFunctionAdd.Items.Add("01 Read Coils (0x)");
                tagFunctionAdd.Items.Add("02 Read Discrete Inputs (1x)");
            }
            else if (tagTypeAdd.SelectedItem.ToString() == "Output")
            {
                tagFunctionAdd.Items.Clear();
                tagDisplayAdd.SelectedIndex = 0;
                tagDisplayAdd.Enabled = false;
                tagFunctionAdd.Items.Add("05 Write Single Coil");
                tagFunctionAdd.Items.Add("06 Write Single Register");
                tagFunctionAdd.Items.Add("15 Write Multiple Coils");
                tagFunctionAdd.Items.Add("16 Write Multiple Registers");
            }
            else if (tagTypeAdd.SelectedItem.ToString() == "Measurement")
            {
                tagFunctionAdd.Items.Clear();
                tagDisplayAdd.SelectedIndex = 1;
                tagDisplayAdd.Enabled = true;
                tagFunctionAdd.Items.Add("03 Read Holding Registers (4x)");
                tagFunctionAdd.Items.Add("04 Read Input Registers (3x)");

            }
            else
            {
                tagDisplayAdd.SelectedIndex = 1;
                tagDisplayAdd.Enabled = true;
            }
        }

        private void SelectTagType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectTagType.SelectedItem.ToString() == "Input")
            {
                SelectFunction.Items.Clear();
                SelectDisplayMode.SelectedIndex = 0;
                SelectDisplayMode.Enabled = false;
                SelectFunction.Items.Add("01 Read Coils (0x)");
                SelectFunction.Items.Add("02 Read Discrete Inputs (1x)");
            }
            else if (SelectTagType.SelectedItem.ToString() == "Output")
            {
                SelectFunction.Items.Clear();
                SelectDisplayMode.SelectedIndex = 0;
                SelectDisplayMode.Enabled = false;
                SelectFunction.Items.Add("05 Write Single Coil");
                SelectFunction.Items.Add("06 Write Single Register");
                SelectFunction.Items.Add("15 Write Multiple Coils");
                SelectFunction.Items.Add("16 Write Multiple Registers");
            }
            else if (SelectTagType.SelectedItem.ToString() == "Measurement")
            {
                SelectFunction.Items.Clear();
                SelectDisplayMode.SelectedIndex = 1;
                SelectDisplayMode.Enabled = true;
                SelectFunction.Items.Add("03 Read Holding Registers (4x)");
                SelectFunction.Items.Add("04 Read Input Registers (3x)");

            }
            else
            {
                SelectDisplayMode.SelectedIndex = 1;
                SelectDisplayMode.Enabled = true;
            }

        }

        private void updateTagButton_Click(object sender, EventArgs e)
        {
            String SelectedNAME = SelectTagName.Text;
            checkSameTagName();
            //DeleteEmptyGroup();
            if (string.IsNullOrEmpty(SelectTagName.Text) || string.IsNullOrEmpty(tagGroupNameUpdate.Text) || string.IsNullOrEmpty(SelectDeviceName.Text) || string.IsNullOrEmpty(SelectTagType.Text) || string.IsNullOrEmpty(SelectFunction.Text) || string.IsNullOrEmpty(SelectTagAddress.Text))
            {
                MessageBox.Show("Make sure all info is filled.");
            }
            else
            {
                using (var connectDb = new SQLiteConnection("data source=" + systemFilePath + "config.db; version=3; default timeout=10000; pooling=true; max pool size=100"))
                {
                    if (SameNameStatusTAGupdate)
                    {
                        MessageBox.Show("Check Tag Name Must be Unique.");
                    }
                    else
                    {
                        using (var cmdDb = new SQLiteCommand($"UPDATE TAGS SET TAG_NAME = '{SelectDeviceName.SelectedItem + "." + tagGroupNameUpdate.Text+"."+SelectTagName.Text}',GROUP_NAME = '{SelectDeviceName.SelectedItem + "."+tagGroupNameUpdate.Text}' , DEVICE_NAME = '{SelectDeviceName.SelectedItem}',TAG_TYPE='{SelectTagType.SelectedItem}',FUNCTION = '{SelectFunction.SelectedItem}',DISPLAY_MODE='{SelectDisplayMode.SelectedItem}',TAG_ADDRESS = '{SelectTagAddress.Text}' WHERE TAG_NAME = '{SelectedNAMEforUpdate}'", connectDb))
                        {

                            try
                            {
                                cmdDb.Connection.Open();
                                cmdDb.ExecuteNonQuery();

                                using (var cmdDb2 = new SQLiteCommand($"SELECT * FROM TAG_GROUP WHERE GROUP_NAME ='{SelectDeviceName.SelectedItem + "." + tagGroupNameUpdate.Text}' AND DEVICE_NAME = '{SelectDeviceName.SelectedItem}'", connectDb))
                                {
                                    SQLiteDataReader dtr1 = cmdDb2.ExecuteReader();
                                    if (dtr1.Read())
                                    {

                                    }
                                    else
                                    {
                                        using (var cmdDb1 = new SQLiteCommand($"INSERT INTO TAG_GROUP (GROUP_NAME,DEVICE_NAME) values('{SelectDeviceName.SelectedItem + "." + tagGroupNameUpdate.Text}','{SelectDeviceName.SelectedItem}')", connectDb))
                                        {
                                            try
                                            {
                                                using (var cmdDb3 = new SQLiteCommand($"UPDATE TAGS SET TAG_NAME = '{SelectTagName.Text}',GROUP_NAME = '{SelectDeviceName.SelectedItem + "." + tagGroupNameUpdate.Text}' , DEVICE_NAME = '{SelectDeviceName.SelectedItem}',TAG_TYPE='{SelectTagType.SelectedItem}',FUNCTION = '{SelectFunction.SelectedItem}',DISPLAY_MODE='{SelectDisplayMode.SelectedItem}',TAG_ADDRESS = '{SelectTagAddress.Text}' WHERE TAG_NAME = '{SelectedNAMEforUpdate}'", connectDb))
                                                {
                                                    try
                                                    {

                                                        cmdDb3.ExecuteNonQuery();
                                                    }
                                                    catch (Exception)
                                                    {
                                                    }
                                                }
                                                cmdDb1.ExecuteNonQuery();
                                            }
                                            catch (Exception)
                                            {
                                            }
                                        }
                                    }

                                }



                                MessageBox.Show("Tag updated succesfuly.");
                                DataViewFillForTags($"SELECT * FROM TAGS");
                                DataViewFillForGroup($"SELECT * FROM TAG_GROUP");
                                TreeViewFill();
                                MQTTTreeViewFill();
                            }
                            catch (Exception)
                            {
                            }
                        }

                    }

                }
            }
        }

        private void deleteTagButton_Click(object sender, EventArgs e)
        {
            String SelectedNAME = SelectTagName.Text;

            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {
                DialogResult diar = MessageBox.Show("Are you sure delete tag ?", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diar == DialogResult.Yes)
                {
                    using (var cmdDb = new SQLiteCommand($"DELETE FROM TAGS WHERE TAG_NAME = '{tempTagName}'", connectDb))
                    {
                        try
                        {
                            cmdDb.Connection.Open();
                            cmdDb.ExecuteNonQuery();
                            DataViewFillForTags($"SELECT * FROM TAGS");
                            
                            TreeViewFill();
                        }

                        catch (Exception)
                        {
                        }
                    }
                }
            }
        }

        private void SelectTagName_MouseClick(object sender, MouseEventArgs e)
        {

        }


        private void readTagDt_FilterStringChanged(object sender, EventArgs e)
        {
            dtReadTag.DefaultView.RowFilter = readTagDt.FilterString;
        }

        private void readTagDt_SortStringChanged(object sender, EventArgs e)
        {
            dtReadTag.DefaultView.Sort = readTagDt.SortString;
        }

        private void connIDcreateButton_Click(object sender, EventArgs e)
        {
            mySQLconString = "server = " + mySQLserverAddress.Text + "; uid = " + mySQLusername.Text + "; pwd = " + mySQLpassword.Text + "; database = " + mySQLdatabaseName.Text;
            UpdateMySQL();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.ShowDialog();
            SQLiteCreatefolderPath = folderBrowserDialog1.SelectedPath;
            selectedSQLiteFolder.Text = SQLiteCreatefolderPath;
        }

        private void SQLiteCreateDBbutton_Click(object sender, EventArgs e)
        {
            string filePathDb = SQLiteCreatefolderPath.Replace(@"\", @"\\");

            if (string.IsNullOrEmpty(selectedSQLiteFolder.Text) || string.IsNullOrEmpty(SQLiteDbName.Text) )
            {
                MessageBox.Show("Make sure all info is filled.");
            }
            else
            {
                if (!File.Exists(filePathDb + @"\\" + SQLiteDbName.Text + ".db"))
                {
                    SQLiteConnection.CreateFile(filePathDb + @"\\" + SQLiteDbName.Text + ".db");
                    MessageBox.Show("Database Created");
                    SQLiteDbName.Text = "";
                }
                else
                {
                    MessageBox.Show("Database already exist !");
                }

            }

        }

        private void SQLiteAddConnectString_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Database File (*.db)| *.db";
            openFileDialog1.ShowDialog();
            string selectedDbFilePath = openFileDialog1.FileName;
            currentSQLiteString.Text = selectedDbFilePath;
            string convertSelectedDbFilePath = selectedDbFilePath.Replace(@"\", @"\\");
            SQLiteconString = "Data source=" + convertSelectedDbFilePath + "; Version=3; default timeout=10000; Pooling=True; Max Pool Size=100";
        }

        private void MySQLenableCB_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMySQLEnableStatus();
            if (MySQLenableCB.Checked)
            {
                mySQLserverAddress.Enabled = true;
                mySQLusername.Enabled = true;
                mySQLpassword.Enabled = true;
                mySQLdatabaseName.Enabled = true;
                connIDSetButton.Enabled = true;
                MySQLtableNameSet.Enabled = true;
                MySQLdt.Enabled = true;
                addTableMySQLbutton.Enabled = true;

                using (var connectDb = new SQLiteConnection(sqllitedb_constr))
                {

                    using (var cmdDb1 = new SQLiteCommand($"SELECT * FROM MYSQLSERVER", connectDb))
                    {

                        try
                        {
                            cmdDb1.Connection.Open();
                            SQLiteDataReader dtr1 = cmdDb1.ExecuteReader();
                            if (dtr1.Read())
                            {
                                fillDeviceNameComboProperties();
                                mySQLserverAddress.Text = dtr1["SERVER_IP"].ToString();
                                mySQLusername.Text = dtr1["USERNAME"].ToString();
                                mySQLpassword.Text = dtr1["PASSWORD"].ToString();
                                mySQLdatabaseName.Text = dtr1["DATABASE"].ToString();

                                cmdDb1.Connection.Close();
                            }

                            else
                            {
                            }

                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
            else
            {
                mySQLserverAddress.Enabled = false;
                mySQLusername.Enabled = false;
                mySQLpassword.Enabled = false;
                mySQLdatabaseName.Enabled = false;
                connIDSetButton.Enabled = false;
                MySQLtableNameSet.Enabled = false;
                MySQLdt.Enabled = false;
                addTableMySQLbutton.Enabled = false;

                mySQLserverAddress.Text = "";
                mySQLusername.Text = "";
                mySQLpassword.Text = "";
                mySQLdatabaseName.Text = "";
                MySQLtableNameSet.Text = "";

            }
        }

        private void SQLiteEnableCB_CheckedChanged(object sender, EventArgs e)
        {
            ChangeSQLiteEnableStatus();
            if (SQLiteEnableCB.Checked)
            {
                selectFolderButton.Enabled = true;
                SQLiteDbName.Enabled = true;
                SQLiteCreateDBbutton.Enabled = true;
                SQLiteAddConnectString.Enabled = true;
                SQLiteTableName.Enabled = true;
                SQLiteDt.Enabled = true;
                SQLiteAddTableButton.Enabled = true;



            }
            else
            {
                selectFolderButton.Enabled = false;
                SQLiteDbName.Enabled = false;
                SQLiteCreateDBbutton.Enabled = false;
                SQLiteAddConnectString.Enabled = false;
                SQLiteTableName.Enabled = false;
                SQLiteDt.Enabled = false;
                SQLiteAddTableButton.Enabled = false;
            }
        }

        private void mqttAddButton_Click(object sender, EventArgs e)
        {
            checkSameDeviceNameMQTT();
            if (string.IsNullOrEmpty(mqttNameAdd.Text) || string.IsNullOrEmpty(mqttClientIDadd.Text) || string.IsNullOrEmpty(mqttHostAdd.Text) || string.IsNullOrEmpty(mqttPortAdd.Text))
            {
                MessageBox.Show("Make sure all info is filled.");
            }
            else
            {
                using (var connectDb = new SQLiteConnection("data source=" + systemFilePath + "config.db; version=3; default timeout=10000; pooling=true; max pool size=100"))
                {
                    if (SameNameStatusMQTT)
                    {
                        MessageBox.Show("Check connection name must be Unique.");
                    }
                    else
                    {
                        using (var cmdDb = new SQLiteCommand($"INSERT INTO MQTT (CONN_NAME,CLIENT_ID,HOST_ADDRESS,HOST_PORT,USERNAME,PASSWORD,TOPIC,TAGS) values('{mqttNameAdd.Text}','{mqttClientIDadd.Text}','{mqttHostAdd.Text}','{mqttPortAdd.Text}','{mqttUserNameAdd.Text}','{mqttPasswordAdd.Text}','{mqttTopicAdd.Text}','{mqttTagNameString}')", connectDb))
                        {

                            try
                            {
                                cmdDb.Connection.Open();
                                cmdDb.ExecuteNonQuery();

                                
                                MessageBox.Show("MQTT Device Added succesfuly.");
                                DataViewFillForMQTT($"SELECT * FROM MQTT");
                                TreeViewFill();


                            }
                            catch (Exception)
                            {
                            }


                        }


                    }

                }
            }
        }

        private void mqttTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode checkedNode = e.Node;
            foreach (TreeNode node in checkedNode.Nodes)
            {
                node.Checked = checkedNode.Checked;
            }
            listBox1.Items.Clear();
            mqttTagNameString = "";
            var Taglist = new List<TreeNode>();
            LookupChecks(mqttTreeView.Nodes, Taglist);
            label49.Text = mqttTagNameString;

        }

        void LookupChecks(TreeNodeCollection nodes, List<TreeNode> list)
        {
            foreach (TreeNode node in nodes)
            {

                if (node.Checked)
                {
                    string[] temp = node.Text.Split('.');
                    if(temp.Length !=3)
                    {

                    }
                    else
                    {
                      list.Add(node);
                      listBox1.Items.Add(node.ToString().Substring(10));
                      mqttTagNameString = mqttTagNameString+node.ToString().Substring(10)+";";
                    }
                
                }

                LookupChecks(node.Nodes, list);
            }
        }

        private void mqttUpdateButton_Click(object sender, EventArgs e)
        {
            MQTTupdate openForm1_update = new MQTTupdate();
            openForm1_update.ShowDialog();
        }

        private void excelExportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setupServicesMenuButton_Click(object sender, EventArgs e)
        {
            string[] newPath = projectPath.Split('\\');
            string newPathTemp = newPath[0];
            for (int i = 1; i < newPath.Length - 3; i++)
            {
                newPathTemp = newPathTemp + "\\" + newPath[i];
            }
            string modbusPath = newPathTemp + "\\" + "IGW_modbusTCPService\\bin\\Debug\\IGW_modbusTCPService.exe";
            string mqttPath = newPathTemp + "\\" + "IGW_mqttService\\bin\\Debug\\IGW_mqttService.exe";

            Process.Start(@"C:\Windows\system32\sc.exe", "create IGW_MQTTService binPath="+mqttPath+" start= auto ");
            Process.Start(@"C:\Windows\system32\sc.exe", "create IGW_ModbusTCPService binPath="+modbusPath+" start= auto");
        }

        private void ınfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string[] newPath = projectPath.Split('\\');
            string newPathTemp = newPath[0];
            for (int i = 1; i < newPath.Length-3; i++)
            {
                newPathTemp = newPathTemp +"\\"+ newPath[i];
            }
            string modbusPath = newPathTemp + "\\" + "IGW_modbusTCPService\\bin\\Debug\\IGW_modbusTCPService.exe";
            string mqttPath = newPathTemp + "\\" + "IGW_mqttService\\bin\\Debug\\IGW_mqttService.exe";
        }

        public void serviceStatusControl(string ServiceName,Label statusLabel)
        {
            ServiceController serviceController = new ServiceController(ServiceName);
            switch (serviceController.Status)
            {
                case ServiceControllerStatus.ContinuePending:
                    statusLabel.Text = "Continue Pending";
                    break;
                case ServiceControllerStatus.Paused:
                    statusLabel.Text = "Paused";
                    break;
                case ServiceControllerStatus.PausePending:
                    statusLabel.Text = "Pause Pending";
                    break;
                case ServiceControllerStatus.Running:
                    statusLabel.Text = "Running";
                    statusLabel.BackColor = Color.LimeGreen ;
                    break;
                case ServiceControllerStatus.StartPending:
                    statusLabel.Text = "Start Pending";
                    break;
                case ServiceControllerStatus.Stopped:
                    statusLabel.Text="Stopped";
                    statusLabel.BackColor = Color.Red;
                    break;
                case ServiceControllerStatus.StopPending:
                    statusLabel.Text = "Stop Pending";
                    break;
                default:
                    break;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void serviceStatusRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                serviceStatusControl("IGW_ModbusTCPService", ModbusTCPServiceStatus);
                serviceStatusControl("IGW_MQTTService", MQTTserviceStatus);

                //serviceStatusControl("IGW_ModbusRTUService", ModbusRTUServiceStatus);
                //serviceStatusControl("IGW_SQLService", SQLserviceStatus);
            }
            catch (Exception)
            {

            }
            fillDeviceNameCombo();
            DataViewFill($"SELECT * FROM COMMUNICATION ");
            DataViewFillForTags($"SELECT * FROM TAGS");
            DataViewFillForReadData($"SELECT * FROM TAGS");
            DataViewFillForGroup($"SELECT * FROM TAG_GROUP");
            DataViewFillForMQTT($"SELECT * FROM MQTT");
            TreeViewFill();
            MQTTTreeViewFill();


        }

        private void ServiceStartButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\system32\sc.exe", "start IGW_MQTTService");
            Process.Start(@"C:\Windows\system32\sc.exe", "start IGW_ModbusTCPService");
            Thread.Sleep(500);

            try
            {
                serviceStatusControl("IGW_ModbusTCPService", ModbusTCPServiceStatus);
                serviceStatusControl("IGW_MQTTService", MQTTserviceStatus);

                //serviceStatusControl("IGW_ModbusRTUService", ModbusRTUServiceStatus);
                //serviceStatusControl("IGW_SQLService", SQLserviceStatus);
            }
            catch (Exception)
            {

            }
        }

        private void ServiceStopButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\system32\sc.exe", "stop IGW_MQTTService");
            Process.Start(@"C:\Windows\system32\sc.exe", "stop IGW_ModbusTCPService");
            Thread.Sleep(500);
            try
            {
                serviceStatusControl("IGW_ModbusTCPService", ModbusTCPServiceStatus);
                serviceStatusControl("IGW_MQTTService", MQTTserviceStatus);

                //serviceStatusControl("IGW_ModbusRTUService", ModbusRTUServiceStatus);
                //serviceStatusControl("IGW_SQLService", SQLserviceStatus);
            }
            catch (Exception)
            {

            }
        }

        private void RestartServiceButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\system32\sc.exe", "restart IGW_MQTTService");
            Process.Start(@"C:\Windows\system32\sc.exe", "restart IGW_ModbusTCPService");
            Thread.Sleep(500);
            try
            {
                serviceStatusControl("IGW_ModbusTCPService", ModbusTCPServiceStatus);
                serviceStatusControl("IGW_MQTTService", MQTTserviceStatus);

                //serviceStatusControl("IGW_ModbusRTUService", ModbusRTUServiceStatus);
                //serviceStatusControl("IGW_SQLService", SQLserviceStatus);
            }
            catch (Exception)
            {

            }
        }
    }
}
