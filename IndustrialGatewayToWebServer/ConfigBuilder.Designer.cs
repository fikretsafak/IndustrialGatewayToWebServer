
namespace IndustrialGatewayToWebServer
{
    partial class ConfigBuilder
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigBuilder));
            this.BuilderTab = new System.Windows.Forms.TabControl();
            this.CommSetTab = new System.Windows.Forms.TabPage();
            this.IEC104group = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.asduIEC = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PortNumberIEC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.IPadressIEC = new System.Windows.Forms.TextBox();
            this.IECaddButton = new System.Windows.Forms.Button();
            this.ModbusRTUgroup = new System.Windows.Forms.GroupBox();
            this.ModbusRTUupdateButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.deviceNameRTU = new System.Windows.Forms.TextBox();
            this.SlaveIDRTU = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ParityRTU = new System.Windows.Forms.ComboBox();
            this.DataBitsRTU = new System.Windows.Forms.ComboBox();
            this.baudRateRTU = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.COMPortRTU = new System.Windows.Forms.ComboBox();
            this.ModbusRTUaddButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.ModbusTCPgroup = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.deviceNameTCP = new System.Windows.Forms.TextBox();
            this.ModbusTCPupdateButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.TimeoutTCP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PortNumberTCP = new System.Windows.Forms.TextBox();
            this.SlaveIDTCP = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IPadressTCP = new System.Windows.Forms.TextBox();
            this.ModbusTCPaddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CommTypeCombo = new System.Windows.Forms.ComboBox();
            this.commDt = new System.Windows.Forms.DataGridView();
            this.SignalSetTab = new System.Windows.Forms.TabPage();
            this.groupDt = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tagGroupNameAdd = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.TagSetRefreshButton = new System.Windows.Forms.Button();
            this.tagTypeAdd = new System.Windows.Forms.ComboBox();
            this.tagAddressAdd = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tagDisplayAdd = new System.Windows.Forms.ComboBox();
            this.tagFunctionAdd = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tagNameAdd = new System.Windows.Forms.TextBox();
            this.addTagButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TagDeviceNameCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tagGroupNameUpdate = new System.Windows.Forms.TextBox();
            this.updateTagButton = new System.Windows.Forms.Button();
            this.SelectTagType = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.SelectDisplayMode = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.SelectTagAddress = new System.Windows.Forms.TextBox();
            this.SelectDeviceName = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.SelectTagName = new System.Windows.Forms.TextBox();
            this.SelectFunction = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.TagTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tagDt = new System.Windows.Forms.DataGridView();
            this.tagRead = new System.Windows.Forms.TabPage();
            this.readTagDt = new ADGV.AdvancedDataGridView();
            this.SQLsetTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MySQLenableCB = new System.Windows.Forms.CheckBox();
            this.addTableMySQLbutton = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.MySQLtableNameSet = new System.Windows.Forms.TextBox();
            this.connIDSetButton = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.mySQLdatabaseName = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.mySQLpassword = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.mySQLusername = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.mySQLserverAddress = new System.Windows.Forms.TextBox();
            this.MySQLdt = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagNameDt = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SQLiteEnableCB = new System.Windows.Forms.CheckBox();
            this.label40 = new System.Windows.Forms.Label();
            this.currentSQLiteString = new System.Windows.Forms.TextBox();
            this.SQLiteAddConnectString = new System.Windows.Forms.Button();
            this.SQLiteCreateDBbutton = new System.Windows.Forms.Button();
            this.SQLiteDbName = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.selectedSQLiteFolder = new System.Windows.Forms.TextBox();
            this.SQLiteAddTableButton = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.SQLiteTableName = new System.Windows.Forms.TextBox();
            this.SQLiteDt = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label35 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.MQTTsetTab = new System.Windows.Forms.TabPage();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.mqttUpdateButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mqttTreeView = new System.Windows.Forms.TreeView();
            this.label48 = new System.Windows.Forms.Label();
            this.mqttTopicAdd = new System.Windows.Forms.TextBox();
            this.mqttDt = new System.Windows.Forms.DataGridView();
            this.mqttAddButton = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.mqttPasswordAdd = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.mqttPortAdd = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.mqttUserNameAdd = new System.Windows.Forms.TextBox();
            this.mqttHostAdd = new System.Windows.Forms.TextBox();
            this.mqttClientIDadd = new System.Windows.Forms.TextBox();
            this.mqttNameAdd = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label44 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Services = new System.Windows.Forms.GroupBox();
            this.label52 = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.ModbusTCPServiceStatus = new System.Windows.Forms.Label();
            this.MQTTserviceStatus = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModbusRTUServiceStatus = new System.Windows.Forms.Label();
            this.SQLserviceStatus = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.serviceStatusRefresh = new System.Windows.Forms.Button();
            this.ServiceStartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceStopButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartServiceButton = new System.Windows.Forms.ToolStripMenuItem();
            this.setupServicesMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.excelExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationDeviceExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLSettingsExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteTagButton = new System.Windows.Forms.Button();
            this.BuilderTab.SuspendLayout();
            this.CommSetTab.SuspendLayout();
            this.IEC104group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asduIEC)).BeginInit();
            this.ModbusRTUgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveIDRTU)).BeginInit();
            this.ModbusTCPgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveIDTCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commDt)).BeginInit();
            this.SignalSetTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDt)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagDt)).BeginInit();
            this.tagRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readTagDt)).BeginInit();
            this.SQLsetTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MySQLdt)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQLiteDt)).BeginInit();
            this.MQTTsetTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mqttDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BuilderTab
            // 
            this.BuilderTab.Controls.Add(this.CommSetTab);
            this.BuilderTab.Controls.Add(this.SignalSetTab);
            this.BuilderTab.Controls.Add(this.tagRead);
            this.BuilderTab.Controls.Add(this.SQLsetTab);
            this.BuilderTab.Controls.Add(this.MQTTsetTab);
            this.BuilderTab.Location = new System.Drawing.Point(6, 94);
            this.BuilderTab.Name = "BuilderTab";
            this.BuilderTab.SelectedIndex = 0;
            this.BuilderTab.Size = new System.Drawing.Size(806, 397);
            this.BuilderTab.TabIndex = 0;
            this.BuilderTab.SelectedIndexChanged += new System.EventHandler(this.BuilderTab_SelectedIndexChanged);
            // 
            // CommSetTab
            // 
            this.CommSetTab.Controls.Add(this.IEC104group);
            this.CommSetTab.Controls.Add(this.ModbusRTUgroup);
            this.CommSetTab.Controls.Add(this.refreshButton);
            this.CommSetTab.Controls.Add(this.ModbusTCPgroup);
            this.CommSetTab.Controls.Add(this.label1);
            this.CommSetTab.Controls.Add(this.CommTypeCombo);
            this.CommSetTab.Controls.Add(this.commDt);
            this.CommSetTab.Location = new System.Drawing.Point(4, 22);
            this.CommSetTab.Name = "CommSetTab";
            this.CommSetTab.Padding = new System.Windows.Forms.Padding(3);
            this.CommSetTab.Size = new System.Drawing.Size(798, 371);
            this.CommSetTab.TabIndex = 0;
            this.CommSetTab.Text = "Communication Settings";
            this.CommSetTab.UseVisualStyleBackColor = true;
            // 
            // IEC104group
            // 
            this.IEC104group.Controls.Add(this.label17);
            this.IEC104group.Controls.Add(this.button2);
            this.IEC104group.Controls.Add(this.label16);
            this.IEC104group.Controls.Add(this.textBox2);
            this.IEC104group.Controls.Add(this.asduIEC);
            this.IEC104group.Controls.Add(this.label10);
            this.IEC104group.Controls.Add(this.label11);
            this.IEC104group.Controls.Add(this.PortNumberIEC);
            this.IEC104group.Controls.Add(this.label12);
            this.IEC104group.Controls.Add(this.IPadressIEC);
            this.IEC104group.Controls.Add(this.IECaddButton);
            this.IEC104group.Location = new System.Drawing.Point(16, 58);
            this.IEC104group.Name = "IEC104group";
            this.IEC104group.Size = new System.Drawing.Size(250, 310);
            this.IEC104group.TabIndex = 5;
            this.IEC104group.TabStop = false;
            this.IEC104group.Text = "IEC 104 Settings";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Coral;
            this.label17.Location = new System.Drawing.Point(85, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "not finish yet";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 34);
            this.button2.TabIndex = 36;
            this.button2.Text = "Update Connection";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Device Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 20);
            this.textBox2.TabIndex = 12;
            // 
            // asduIEC
            // 
            this.asduIEC.Location = new System.Drawing.Point(6, 126);
            this.asduIEC.Name = "asduIEC";
            this.asduIEC.Size = new System.Drawing.Size(45, 20);
            this.asduIEC.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "ASDU";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Port";
            // 
            // PortNumberIEC
            // 
            this.PortNumberIEC.Location = new System.Drawing.Point(191, 84);
            this.PortNumberIEC.Name = "PortNumberIEC";
            this.PortNumberIEC.Size = new System.Drawing.Size(34, 20);
            this.PortNumberIEC.TabIndex = 14;
            this.PortNumberIEC.Text = "2404";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "IP Address";
            // 
            // IPadressIEC
            // 
            this.IPadressIEC.Location = new System.Drawing.Point(6, 84);
            this.IPadressIEC.Name = "IPadressIEC";
            this.IPadressIEC.Size = new System.Drawing.Size(177, 20);
            this.IPadressIEC.TabIndex = 13;
            // 
            // IECaddButton
            // 
            this.IECaddButton.Location = new System.Drawing.Point(6, 224);
            this.IECaddButton.Name = "IECaddButton";
            this.IECaddButton.Size = new System.Drawing.Size(238, 34);
            this.IECaddButton.TabIndex = 0;
            this.IECaddButton.Text = "Add Connection";
            this.IECaddButton.UseVisualStyleBackColor = true;
            // 
            // ModbusRTUgroup
            // 
            this.ModbusRTUgroup.Controls.Add(this.ModbusRTUupdateButton);
            this.ModbusRTUgroup.Controls.Add(this.label15);
            this.ModbusRTUgroup.Controls.Add(this.deviceNameRTU);
            this.ModbusRTUgroup.Controls.Add(this.SlaveIDRTU);
            this.ModbusRTUgroup.Controls.Add(this.label6);
            this.ModbusRTUgroup.Controls.Add(this.ParityRTU);
            this.ModbusRTUgroup.Controls.Add(this.DataBitsRTU);
            this.ModbusRTUgroup.Controls.Add(this.baudRateRTU);
            this.ModbusRTUgroup.Controls.Add(this.label4);
            this.ModbusRTUgroup.Controls.Add(this.label3);
            this.ModbusRTUgroup.Controls.Add(this.label5);
            this.ModbusRTUgroup.Controls.Add(this.label2);
            this.ModbusRTUgroup.Controls.Add(this.COMPortRTU);
            this.ModbusRTUgroup.Controls.Add(this.ModbusRTUaddButton);
            this.ModbusRTUgroup.Location = new System.Drawing.Point(16, 58);
            this.ModbusRTUgroup.Name = "ModbusRTUgroup";
            this.ModbusRTUgroup.Size = new System.Drawing.Size(250, 310);
            this.ModbusRTUgroup.TabIndex = 4;
            this.ModbusRTUgroup.TabStop = false;
            this.ModbusRTUgroup.Text = "Modbus RTU Settings";
            // 
            // ModbusRTUupdateButton
            // 
            this.ModbusRTUupdateButton.Location = new System.Drawing.Point(6, 263);
            this.ModbusRTUupdateButton.Name = "ModbusRTUupdateButton";
            this.ModbusRTUupdateButton.Size = new System.Drawing.Size(238, 34);
            this.ModbusRTUupdateButton.TabIndex = 34;
            this.ModbusRTUupdateButton.Text = "Update Connection";
            this.ModbusRTUupdateButton.UseVisualStyleBackColor = true;
            this.ModbusRTUupdateButton.Click += new System.EventHandler(this.ModbusRTUupdateButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Device Name";
            // 
            // deviceNameRTU
            // 
            this.deviceNameRTU.Location = new System.Drawing.Point(6, 44);
            this.deviceNameRTU.Name = "deviceNameRTU";
            this.deviceNameRTU.Size = new System.Drawing.Size(226, 20);
            this.deviceNameRTU.TabIndex = 6;
            // 
            // SlaveIDRTU
            // 
            this.SlaveIDRTU.Location = new System.Drawing.Point(113, 82);
            this.SlaveIDRTU.Name = "SlaveIDRTU";
            this.SlaveIDRTU.Size = new System.Drawing.Size(45, 20);
            this.SlaveIDRTU.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Slave ID";
            // 
            // ParityRTU
            // 
            this.ParityRTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityRTU.FormattingEnabled = true;
            this.ParityRTU.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.ParityRTU.Location = new System.Drawing.Point(6, 195);
            this.ParityRTU.Margin = new System.Windows.Forms.Padding(2);
            this.ParityRTU.Name = "ParityRTU";
            this.ParityRTU.Size = new System.Drawing.Size(92, 21);
            this.ParityRTU.TabIndex = 10;
            // 
            // DataBitsRTU
            // 
            this.DataBitsRTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitsRTU.FormattingEnabled = true;
            this.DataBitsRTU.Items.AddRange(new object[] {
            "7",
            "8"});
            this.DataBitsRTU.Location = new System.Drawing.Point(6, 157);
            this.DataBitsRTU.Margin = new System.Windows.Forms.Padding(2);
            this.DataBitsRTU.Name = "DataBitsRTU";
            this.DataBitsRTU.Size = new System.Drawing.Size(92, 21);
            this.DataBitsRTU.TabIndex = 9;
            // 
            // baudRateRTU
            // 
            this.baudRateRTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateRTU.FormattingEnabled = true;
            this.baudRateRTU.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.baudRateRTU.Location = new System.Drawing.Point(6, 119);
            this.baudRateRTU.Margin = new System.Windows.Forms.Padding(2);
            this.baudRateRTU.Name = "baudRateRTU";
            this.baudRateRTU.Size = new System.Drawing.Size(92, 21);
            this.baudRateRTU.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "COM Port";
            // 
            // COMPortRTU
            // 
            this.COMPortRTU.FormattingEnabled = true;
            this.COMPortRTU.Location = new System.Drawing.Point(6, 82);
            this.COMPortRTU.Margin = new System.Windows.Forms.Padding(2);
            this.COMPortRTU.Name = "COMPortRTU";
            this.COMPortRTU.Size = new System.Drawing.Size(92, 21);
            this.COMPortRTU.TabIndex = 7;
            // 
            // ModbusRTUaddButton
            // 
            this.ModbusRTUaddButton.Location = new System.Drawing.Point(6, 224);
            this.ModbusRTUaddButton.Name = "ModbusRTUaddButton";
            this.ModbusRTUaddButton.Size = new System.Drawing.Size(238, 34);
            this.ModbusRTUaddButton.TabIndex = 0;
            this.ModbusRTUaddButton.Text = "Add Connection";
            this.ModbusRTUaddButton.UseVisualStyleBackColor = true;
            this.ModbusRTUaddButton.Click += new System.EventHandler(this.ModbusRTUaddButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(207, 7);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(58, 22);
            this.refreshButton.TabIndex = 29;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Visible = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // ModbusTCPgroup
            // 
            this.ModbusTCPgroup.Controls.Add(this.label14);
            this.ModbusTCPgroup.Controls.Add(this.deviceNameTCP);
            this.ModbusTCPgroup.Controls.Add(this.ModbusTCPupdateButton);
            this.ModbusTCPgroup.Controls.Add(this.label13);
            this.ModbusTCPgroup.Controls.Add(this.TimeoutTCP);
            this.ModbusTCPgroup.Controls.Add(this.label8);
            this.ModbusTCPgroup.Controls.Add(this.PortNumberTCP);
            this.ModbusTCPgroup.Controls.Add(this.SlaveIDTCP);
            this.ModbusTCPgroup.Controls.Add(this.label9);
            this.ModbusTCPgroup.Controls.Add(this.label7);
            this.ModbusTCPgroup.Controls.Add(this.IPadressTCP);
            this.ModbusTCPgroup.Controls.Add(this.ModbusTCPaddButton);
            this.ModbusTCPgroup.Location = new System.Drawing.Point(16, 59);
            this.ModbusTCPgroup.Name = "ModbusTCPgroup";
            this.ModbusTCPgroup.Size = new System.Drawing.Size(250, 306);
            this.ModbusTCPgroup.TabIndex = 3;
            this.ModbusTCPgroup.TabStop = false;
            this.ModbusTCPgroup.Text = "Modbus TCP Settings";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Device Name";
            // 
            // deviceNameTCP
            // 
            this.deviceNameTCP.Location = new System.Drawing.Point(6, 42);
            this.deviceNameTCP.Name = "deviceNameTCP";
            this.deviceNameTCP.Size = new System.Drawing.Size(226, 20);
            this.deviceNameTCP.TabIndex = 1;
            // 
            // ModbusTCPupdateButton
            // 
            this.ModbusTCPupdateButton.Location = new System.Drawing.Point(6, 266);
            this.ModbusTCPupdateButton.Name = "ModbusTCPupdateButton";
            this.ModbusTCPupdateButton.Size = new System.Drawing.Size(238, 34);
            this.ModbusTCPupdateButton.TabIndex = 28;
            this.ModbusTCPupdateButton.Text = "Update Connection";
            this.ModbusTCPupdateButton.UseVisualStyleBackColor = true;
            this.ModbusTCPupdateButton.Click += new System.EventHandler(this.ModbusTCPupdateButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Connect Timeout";
            // 
            // TimeoutTCP
            // 
            this.TimeoutTCP.Location = new System.Drawing.Point(6, 125);
            this.TimeoutTCP.Name = "TimeoutTCP";
            this.TimeoutTCP.Size = new System.Drawing.Size(86, 20);
            this.TimeoutTCP.TabIndex = 4;
            this.TimeoutTCP.Text = "3000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Port";
            // 
            // PortNumberTCP
            // 
            this.PortNumberTCP.Location = new System.Drawing.Point(198, 86);
            this.PortNumberTCP.Name = "PortNumberTCP";
            this.PortNumberTCP.Size = new System.Drawing.Size(34, 20);
            this.PortNumberTCP.TabIndex = 3;
            this.PortNumberTCP.Text = "502";
            // 
            // SlaveIDTCP
            // 
            this.SlaveIDTCP.Location = new System.Drawing.Point(98, 126);
            this.SlaveIDTCP.Name = "SlaveIDTCP";
            this.SlaveIDTCP.Size = new System.Drawing.Size(45, 20);
            this.SlaveIDTCP.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Slave ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "IP Address";
            // 
            // IPadressTCP
            // 
            this.IPadressTCP.Location = new System.Drawing.Point(6, 86);
            this.IPadressTCP.Name = "IPadressTCP";
            this.IPadressTCP.Size = new System.Drawing.Size(186, 20);
            this.IPadressTCP.TabIndex = 2;
            // 
            // ModbusTCPaddButton
            // 
            this.ModbusTCPaddButton.Location = new System.Drawing.Point(6, 227);
            this.ModbusTCPaddButton.Name = "ModbusTCPaddButton";
            this.ModbusTCPaddButton.Size = new System.Drawing.Size(238, 34);
            this.ModbusTCPaddButton.TabIndex = 0;
            this.ModbusTCPaddButton.Text = "Add Connection";
            this.ModbusTCPaddButton.UseVisualStyleBackColor = true;
            this.ModbusTCPaddButton.Click += new System.EventHandler(this.ModbusTCPaddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Communication Type";
            // 
            // CommTypeCombo
            // 
            this.CommTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommTypeCombo.FormattingEnabled = true;
            this.CommTypeCombo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CommTypeCombo.Items.AddRange(new object[] {
            "Modbus TCP",
            "Modbus RTU",
            "IEC 608070-5-104"});
            this.CommTypeCombo.Location = new System.Drawing.Point(16, 31);
            this.CommTypeCombo.Name = "CommTypeCombo";
            this.CommTypeCombo.Size = new System.Drawing.Size(250, 21);
            this.CommTypeCombo.TabIndex = 1;
            this.CommTypeCombo.SelectedIndexChanged += new System.EventHandler(this.Comm_SelectedIndexChanged);
            // 
            // commDt
            // 
            this.commDt.AllowUserToAddRows = false;
            this.commDt.AllowUserToDeleteRows = false;
            this.commDt.AllowUserToOrderColumns = true;
            this.commDt.AllowUserToResizeRows = false;
            this.commDt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commDt.Location = new System.Drawing.Point(286, 0);
            this.commDt.Name = "commDt";
            this.commDt.ReadOnly = true;
            this.commDt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.commDt.Size = new System.Drawing.Size(512, 371);
            this.commDt.TabIndex = 0;
            // 
            // SignalSetTab
            // 
            this.SignalSetTab.Controls.Add(this.groupDt);
            this.SignalSetTab.Controls.Add(this.groupBox2);
            this.SignalSetTab.Controls.Add(this.groupBox1);
            this.SignalSetTab.Controls.Add(this.TagTreeView);
            this.SignalSetTab.Controls.Add(this.tagDt);
            this.SignalSetTab.Location = new System.Drawing.Point(4, 22);
            this.SignalSetTab.Name = "SignalSetTab";
            this.SignalSetTab.Padding = new System.Windows.Forms.Padding(3);
            this.SignalSetTab.Size = new System.Drawing.Size(798, 371);
            this.SignalSetTab.TabIndex = 1;
            this.SignalSetTab.Text = "Tag Settings";
            this.SignalSetTab.UseVisualStyleBackColor = true;
            // 
            // groupDt
            // 
            this.groupDt.AllowUserToAddRows = false;
            this.groupDt.AllowUserToDeleteRows = false;
            this.groupDt.AllowUserToOrderColumns = true;
            this.groupDt.AllowUserToResizeRows = false;
            this.groupDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupDt.Location = new System.Drawing.Point(546, 358);
            this.groupDt.Name = "groupDt";
            this.groupDt.ReadOnly = true;
            this.groupDt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.groupDt.Size = new System.Drawing.Size(33, 13);
            this.groupDt.TabIndex = 35;
            this.groupDt.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tagGroupNameAdd);
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.TagSetRefreshButton);
            this.groupBox2.Controls.Add(this.tagTypeAdd);
            this.groupBox2.Controls.Add(this.tagAddressAdd);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.tagDisplayAdd);
            this.groupBox2.Controls.Add(this.tagFunctionAdd);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.tagNameAdd);
            this.groupBox2.Controls.Add(this.addTagButton);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.TagDeviceNameCombo);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 362);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Tag";
            // 
            // tagGroupNameAdd
            // 
            this.tagGroupNameAdd.Location = new System.Drawing.Point(9, 117);
            this.tagGroupNameAdd.Name = "tagGroupNameAdd";
            this.tagGroupNameAdd.Size = new System.Drawing.Size(214, 20);
            this.tagGroupNameAdd.TabIndex = 3;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 104);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(67, 13);
            this.label41.TabIndex = 32;
            this.label41.Text = "Group Name";
            // 
            // TagSetRefreshButton
            // 
            this.TagSetRefreshButton.Location = new System.Drawing.Point(165, 14);
            this.TagSetRefreshButton.Name = "TagSetRefreshButton";
            this.TagSetRefreshButton.Size = new System.Drawing.Size(58, 22);
            this.TagSetRefreshButton.TabIndex = 30;
            this.TagSetRefreshButton.Text = "Refresh";
            this.TagSetRefreshButton.UseVisualStyleBackColor = true;
            this.TagSetRefreshButton.Visible = false;
            this.TagSetRefreshButton.Click += new System.EventHandler(this.TagSetRefreshButton_Click);
            // 
            // tagTypeAdd
            // 
            this.tagTypeAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tagTypeAdd.FormattingEnabled = true;
            this.tagTypeAdd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tagTypeAdd.Items.AddRange(new object[] {
            "Measurement",
            "Input",
            "Output"});
            this.tagTypeAdd.Location = new System.Drawing.Point(9, 154);
            this.tagTypeAdd.Name = "tagTypeAdd";
            this.tagTypeAdd.Size = new System.Drawing.Size(214, 21);
            this.tagTypeAdd.TabIndex = 4;
            this.tagTypeAdd.SelectedIndexChanged += new System.EventHandler(this.tagTypeAdd_SelectedIndexChanged);
            // 
            // tagAddressAdd
            // 
            this.tagAddressAdd.Location = new System.Drawing.Point(9, 268);
            this.tagAddressAdd.Name = "tagAddressAdd";
            this.tagAddressAdd.Size = new System.Drawing.Size(214, 20);
            this.tagAddressAdd.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 141);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "Tag Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Function";
            // 
            // tagDisplayAdd
            // 
            this.tagDisplayAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tagDisplayAdd.FormattingEnabled = true;
            this.tagDisplayAdd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tagDisplayAdd.Items.AddRange(new object[] {
            " ",
            "32 bit floating point",
            "32 bit floating point (Reverse)",
            "16 bit signed scaled",
            "32 bit signed scaled",
            "32 bit signed scaled (Reverse)",
            "16 bit unsigned scaled",
            "32 bit unsigned scaled",
            "32 bit unsigned scaled (Reverse)"});
            this.tagDisplayAdd.Location = new System.Drawing.Point(9, 230);
            this.tagDisplayAdd.Name = "tagDisplayAdd";
            this.tagDisplayAdd.Size = new System.Drawing.Size(214, 21);
            this.tagDisplayAdd.TabIndex = 6;
            // 
            // tagFunctionAdd
            // 
            this.tagFunctionAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tagFunctionAdd.FormattingEnabled = true;
            this.tagFunctionAdd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tagFunctionAdd.Location = new System.Drawing.Point(9, 192);
            this.tagFunctionAdd.Name = "tagFunctionAdd";
            this.tagFunctionAdd.Size = new System.Drawing.Size(214, 21);
            this.tagFunctionAdd.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 215);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Display Mode";
            // 
            // tagNameAdd
            // 
            this.tagNameAdd.Location = new System.Drawing.Point(9, 42);
            this.tagNameAdd.Name = "tagNameAdd";
            this.tagNameAdd.Size = new System.Drawing.Size(214, 20);
            this.tagNameAdd.TabIndex = 1;
            // 
            // addTagButton
            // 
            this.addTagButton.Location = new System.Drawing.Point(6, 318);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Size = new System.Drawing.Size(214, 34);
            this.addTagButton.TabIndex = 8;
            this.addTagButton.Text = "Add Tag";
            this.addTagButton.UseVisualStyleBackColor = true;
            this.addTagButton.Click += new System.EventHandler(this.addTagButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Tag Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 252);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Tag Address";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Device Name";
            // 
            // TagDeviceNameCombo
            // 
            this.TagDeviceNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TagDeviceNameCombo.FormattingEnabled = true;
            this.TagDeviceNameCombo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TagDeviceNameCombo.Location = new System.Drawing.Point(9, 79);
            this.TagDeviceNameCombo.Name = "TagDeviceNameCombo";
            this.TagDeviceNameCombo.Size = new System.Drawing.Size(214, 21);
            this.TagDeviceNameCombo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.tagGroupNameUpdate);
            this.groupBox1.Controls.Add(this.deleteTagButton);
            this.groupBox1.Controls.Add(this.updateTagButton);
            this.groupBox1.Controls.Add(this.SelectTagType);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.SelectDisplayMode);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.SelectTagAddress);
            this.groupBox1.Controls.Add(this.SelectDeviceName);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.SelectTagName);
            this.groupBox1.Controls.Add(this.SelectFunction);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Location = new System.Drawing.Point(567, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 361);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag Properties";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(2, 94);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(67, 13);
            this.label42.TabIndex = 39;
            this.label42.Text = "Group Name";
            // 
            // tagGroupNameUpdate
            // 
            this.tagGroupNameUpdate.Location = new System.Drawing.Point(6, 109);
            this.tagGroupNameUpdate.Name = "tagGroupNameUpdate";
            this.tagGroupNameUpdate.Size = new System.Drawing.Size(214, 20);
            this.tagGroupNameUpdate.TabIndex = 38;
            // 
            // updateTagButton
            // 
            this.updateTagButton.Location = new System.Drawing.Point(6, 281);
            this.updateTagButton.Name = "updateTagButton";
            this.updateTagButton.Size = new System.Drawing.Size(208, 34);
            this.updateTagButton.TabIndex = 24;
            this.updateTagButton.Text = "Save Tag";
            this.updateTagButton.UseVisualStyleBackColor = true;
            this.updateTagButton.Click += new System.EventHandler(this.updateTagButton_Click);
            // 
            // SelectTagType
            // 
            this.SelectTagType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectTagType.FormattingEnabled = true;
            this.SelectTagType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SelectTagType.Items.AddRange(new object[] {
            "Measurement",
            "Input",
            "Output"});
            this.SelectTagType.Location = new System.Drawing.Point(6, 146);
            this.SelectTagType.Name = "SelectTagType";
            this.SelectTagType.Size = new System.Drawing.Size(214, 21);
            this.SelectTagType.TabIndex = 34;
            this.SelectTagType.SelectedIndexChanged += new System.EventHandler(this.SelectTagType_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 130);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 13);
            this.label25.TabIndex = 35;
            this.label25.Text = "Tag Type";
            // 
            // SelectDisplayMode
            // 
            this.SelectDisplayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectDisplayMode.FormattingEnabled = true;
            this.SelectDisplayMode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SelectDisplayMode.Items.AddRange(new object[] {
            " ",
            "32 bit floating point",
            "32 bit floating point (Reverse)",
            "16 bit signed scaled",
            "32 bit signed scaled",
            "32 bit signed scaled (Reverse)",
            "16 bit unsigned scaled",
            "32 bit unsigned scaled",
            "32 bit unsigned scaled (Reverse)"});
            this.SelectDisplayMode.Location = new System.Drawing.Point(6, 220);
            this.SelectDisplayMode.Name = "SelectDisplayMode";
            this.SelectDisplayMode.Size = new System.Drawing.Size(214, 21);
            this.SelectDisplayMode.TabIndex = 32;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 206);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 13);
            this.label26.TabIndex = 33;
            this.label26.Text = "Display Mode";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(2, 241);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 13);
            this.label27.TabIndex = 31;
            this.label27.Text = "Tag Address";
            // 
            // SelectTagAddress
            // 
            this.SelectTagAddress.Location = new System.Drawing.Point(6, 256);
            this.SelectTagAddress.Name = "SelectTagAddress";
            this.SelectTagAddress.Size = new System.Drawing.Size(214, 20);
            this.SelectTagAddress.TabIndex = 30;
            // 
            // SelectDeviceName
            // 
            this.SelectDeviceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectDeviceName.FormattingEnabled = true;
            this.SelectDeviceName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SelectDeviceName.Location = new System.Drawing.Point(6, 72);
            this.SelectDeviceName.Name = "SelectDeviceName";
            this.SelectDeviceName.Size = new System.Drawing.Size(214, 21);
            this.SelectDeviceName.TabIndex = 28;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 56);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 13);
            this.label28.TabIndex = 29;
            this.label28.Text = "Device Name";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 18);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 13);
            this.label29.TabIndex = 27;
            this.label29.Text = "Tag Name";
            // 
            // SelectTagName
            // 
            this.SelectTagName.Location = new System.Drawing.Point(6, 33);
            this.SelectTagName.Name = "SelectTagName";
            this.SelectTagName.Size = new System.Drawing.Size(214, 20);
            this.SelectTagName.TabIndex = 26;
            this.SelectTagName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectTagName_MouseClick);
            // 
            // SelectFunction
            // 
            this.SelectFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectFunction.FormattingEnabled = true;
            this.SelectFunction.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SelectFunction.Items.AddRange(new object[] {
            "01 Read Coils (0x)",
            "02 Read Discrete Inputs (1x)",
            "03 Read Holding Registers (4x)",
            "04 Read Input Registers (3x)",
            "05 Write Single Coil",
            "06 Write Single Register",
            "15 Write Multiple Coils",
            "16 Write Multiple Registers"});
            this.SelectFunction.Location = new System.Drawing.Point(6, 183);
            this.SelectFunction.Name = "SelectFunction";
            this.SelectFunction.Size = new System.Drawing.Size(214, 21);
            this.SelectFunction.TabIndex = 24;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(5, 167);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 13);
            this.label30.TabIndex = 25;
            this.label30.Text = "Function";
            // 
            // TagTreeView
            // 
            this.TagTreeView.ContextMenuStrip = this.contextMenuStrip1;
            this.TagTreeView.ImageIndex = 0;
            this.TagTreeView.ImageList = this.ımageList1;
            this.TagTreeView.Location = new System.Drawing.Point(241, 3);
            this.TagTreeView.Name = "TagTreeView";
            this.TagTreeView.SelectedImageIndex = 4;
            this.TagTreeView.Size = new System.Drawing.Size(320, 362);
            this.TagTreeView.TabIndex = 31;
            this.TagTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.TagTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem1.Text = "Delete Group";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "360_F_525617261_5d7kLD3PK8jzwN72U7Zu1W851pbnclRi.jpg");
            this.ımageList1.Images.SetKeyName(1, "IED_FULL kopya.png");
            this.ımageList1.Images.SetKeyName(2, "folder.png");
            this.ımageList1.Images.SetKeyName(3, "IED");
            this.ımageList1.Images.SetKeyName(4, "icons8-select-50.png");
            this.ımageList1.Images.SetKeyName(5, "folder kopya.png");
            // 
            // tagDt
            // 
            this.tagDt.AllowUserToAddRows = false;
            this.tagDt.AllowUserToDeleteRows = false;
            this.tagDt.AllowUserToOrderColumns = true;
            this.tagDt.AllowUserToResizeRows = false;
            this.tagDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagDt.Location = new System.Drawing.Point(493, 6);
            this.tagDt.Name = "tagDt";
            this.tagDt.ReadOnly = true;
            this.tagDt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tagDt.Size = new System.Drawing.Size(299, 13);
            this.tagDt.TabIndex = 32;
            this.tagDt.Visible = false;
            // 
            // tagRead
            // 
            this.tagRead.Controls.Add(this.readTagDt);
            this.tagRead.Location = new System.Drawing.Point(4, 22);
            this.tagRead.Name = "tagRead";
            this.tagRead.Size = new System.Drawing.Size(798, 371);
            this.tagRead.TabIndex = 4;
            this.tagRead.Text = "ReadTag";
            this.tagRead.UseVisualStyleBackColor = true;
            // 
            // readTagDt
            // 
            this.readTagDt.AllowUserToAddRows = false;
            this.readTagDt.AllowUserToDeleteRows = false;
            this.readTagDt.AllowUserToResizeRows = false;
            this.readTagDt.AutoGenerateContextFilters = true;
            this.readTagDt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.readTagDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readTagDt.DateWithTime = false;
            this.readTagDt.Location = new System.Drawing.Point(0, 0);
            this.readTagDt.Name = "readTagDt";
            this.readTagDt.ReadOnly = true;
            this.readTagDt.Size = new System.Drawing.Size(798, 371);
            this.readTagDt.TabIndex = 34;
            this.readTagDt.TimeFilter = false;
            this.readTagDt.SortStringChanged += new System.EventHandler(this.readTagDt_SortStringChanged);
            this.readTagDt.FilterStringChanged += new System.EventHandler(this.readTagDt_FilterStringChanged);
            // 
            // SQLsetTab
            // 
            this.SQLsetTab.Controls.Add(this.tabControl1);
            this.SQLsetTab.Location = new System.Drawing.Point(4, 22);
            this.SQLsetTab.Name = "SQLsetTab";
            this.SQLsetTab.Size = new System.Drawing.Size(798, 371);
            this.SQLsetTab.TabIndex = 2;
            this.SQLsetTab.Text = "SQL Settings ";
            this.SQLsetTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 365);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MySQLenableCB);
            this.tabPage1.Controls.Add(this.addTableMySQLbutton);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.MySQLtableNameSet);
            this.tabPage1.Controls.Add(this.connIDSetButton);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.mySQLdatabaseName);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.mySQLpassword);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.mySQLusername);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.mySQLserverAddress);
            this.tabPage1.Controls.Add(this.MySQLdt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(783, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MySQL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MySQLenableCB
            // 
            this.MySQLenableCB.AutoSize = true;
            this.MySQLenableCB.Location = new System.Drawing.Point(6, 7);
            this.MySQLenableCB.Name = "MySQLenableCB";
            this.MySQLenableCB.Size = new System.Drawing.Size(59, 17);
            this.MySQLenableCB.TabIndex = 13;
            this.MySQLenableCB.Text = "Enable";
            this.MySQLenableCB.UseVisualStyleBackColor = true;
            this.MySQLenableCB.CheckedChanged += new System.EventHandler(this.MySQLenableCB_CheckedChanged);
            // 
            // addTableMySQLbutton
            // 
            this.addTableMySQLbutton.Location = new System.Drawing.Point(442, 306);
            this.addTableMySQLbutton.Name = "addTableMySQLbutton";
            this.addTableMySQLbutton.Size = new System.Drawing.Size(335, 23);
            this.addTableMySQLbutton.TabIndex = 12;
            this.addTableMySQLbutton.Text = "Add Table Create String";
            this.addTableMySQLbutton.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(439, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(65, 13);
            this.label36.TabIndex = 11;
            this.label36.Text = "Table Name";
            // 
            // MySQLtableNameSet
            // 
            this.MySQLtableNameSet.Location = new System.Drawing.Point(510, 6);
            this.MySQLtableNameSet.Name = "MySQLtableNameSet";
            this.MySQLtableNameSet.Size = new System.Drawing.Size(267, 20);
            this.MySQLtableNameSet.TabIndex = 10;
            // 
            // connIDSetButton
            // 
            this.connIDSetButton.Location = new System.Drawing.Point(3, 199);
            this.connIDSetButton.Name = "connIDSetButton";
            this.connIDSetButton.Size = new System.Drawing.Size(171, 23);
            this.connIDSetButton.TabIndex = 9;
            this.connIDSetButton.Text = "Set Connection String";
            this.connIDSetButton.UseVisualStyleBackColor = true;
            this.connIDSetButton.Click += new System.EventHandler(this.connIDcreateButton_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(9, 153);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 13);
            this.label33.TabIndex = 8;
            this.label33.Text = "Database Name";
            // 
            // mySQLdatabaseName
            // 
            this.mySQLdatabaseName.Location = new System.Drawing.Point(6, 169);
            this.mySQLdatabaseName.Name = "mySQLdatabaseName";
            this.mySQLdatabaseName.Size = new System.Drawing.Size(171, 20);
            this.mySQLdatabaseName.TabIndex = 7;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 110);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 13);
            this.label32.TabIndex = 6;
            this.label32.Text = "Password";
            // 
            // mySQLpassword
            // 
            this.mySQLpassword.Location = new System.Drawing.Point(6, 126);
            this.mySQLpassword.Name = "mySQLpassword";
            this.mySQLpassword.PasswordChar = '*';
            this.mySQLpassword.Size = new System.Drawing.Size(171, 20);
            this.mySQLpassword.TabIndex = 5;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 70);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(55, 13);
            this.label31.TabIndex = 4;
            this.label31.Text = "Username";
            // 
            // mySQLusername
            // 
            this.mySQLusername.Location = new System.Drawing.Point(6, 86);
            this.mySQLusername.Name = "mySQLusername";
            this.mySQLusername.Size = new System.Drawing.Size(171, 20);
            this.mySQLusername.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Server Address";
            // 
            // mySQLserverAddress
            // 
            this.mySQLserverAddress.Location = new System.Drawing.Point(6, 45);
            this.mySQLserverAddress.Name = "mySQLserverAddress";
            this.mySQLserverAddress.Size = new System.Drawing.Size(171, 20);
            this.mySQLserverAddress.TabIndex = 1;
            // 
            // MySQLdt
            // 
            this.MySQLdt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MySQLdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MySQLdt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.TagNameDt});
            this.MySQLdt.Location = new System.Drawing.Point(442, 28);
            this.MySQLdt.Name = "MySQLdt";
            this.MySQLdt.Size = new System.Drawing.Size(335, 268);
            this.MySQLdt.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "ColumnName";
            this.ColumnName.Name = "ColumnName";
            // 
            // TagNameDt
            // 
            this.TagNameDt.HeaderText = "Tag Name";
            this.TagNameDt.Name = "TagNameDt";
            this.TagNameDt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TagNameDt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SQLiteEnableCB);
            this.tabPage2.Controls.Add(this.label40);
            this.tabPage2.Controls.Add(this.currentSQLiteString);
            this.tabPage2.Controls.Add(this.SQLiteAddConnectString);
            this.tabPage2.Controls.Add(this.SQLiteCreateDBbutton);
            this.tabPage2.Controls.Add(this.SQLiteDbName);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.selectFolderButton);
            this.tabPage2.Controls.Add(this.selectedSQLiteFolder);
            this.tabPage2.Controls.Add(this.SQLiteAddTableButton);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.SQLiteTableName);
            this.tabPage2.Controls.Add(this.SQLiteDt);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SQLite";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SQLiteEnableCB
            // 
            this.SQLiteEnableCB.AutoSize = true;
            this.SQLiteEnableCB.Location = new System.Drawing.Point(6, 6);
            this.SQLiteEnableCB.Name = "SQLiteEnableCB";
            this.SQLiteEnableCB.Size = new System.Drawing.Size(59, 17);
            this.SQLiteEnableCB.TabIndex = 25;
            this.SQLiteEnableCB.Text = "Enable";
            this.SQLiteEnableCB.UseVisualStyleBackColor = true;
            this.SQLiteEnableCB.CheckedChanged += new System.EventHandler(this.SQLiteEnableCB_CheckedChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(3, 125);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(90, 13);
            this.label40.TabIndex = 24;
            this.label40.Text = "Current Database";
            // 
            // currentSQLiteString
            // 
            this.currentSQLiteString.Enabled = false;
            this.currentSQLiteString.Location = new System.Drawing.Point(6, 141);
            this.currentSQLiteString.Name = "currentSQLiteString";
            this.currentSQLiteString.ReadOnly = true;
            this.currentSQLiteString.Size = new System.Drawing.Size(425, 20);
            this.currentSQLiteString.TabIndex = 23;
            // 
            // SQLiteAddConnectString
            // 
            this.SQLiteAddConnectString.Location = new System.Drawing.Point(260, 86);
            this.SQLiteAddConnectString.Name = "SQLiteAddConnectString";
            this.SQLiteAddConnectString.Size = new System.Drawing.Size(171, 23);
            this.SQLiteAddConnectString.TabIndex = 22;
            this.SQLiteAddConnectString.Text = "Add Connection String";
            this.SQLiteAddConnectString.UseVisualStyleBackColor = true;
            this.SQLiteAddConnectString.Click += new System.EventHandler(this.SQLiteAddConnectString_Click);
            // 
            // SQLiteCreateDBbutton
            // 
            this.SQLiteCreateDBbutton.Location = new System.Drawing.Point(156, 86);
            this.SQLiteCreateDBbutton.Name = "SQLiteCreateDBbutton";
            this.SQLiteCreateDBbutton.Size = new System.Drawing.Size(98, 23);
            this.SQLiteCreateDBbutton.TabIndex = 21;
            this.SQLiteCreateDBbutton.Text = "Create DB";
            this.SQLiteCreateDBbutton.UseVisualStyleBackColor = true;
            this.SQLiteCreateDBbutton.Click += new System.EventHandler(this.SQLiteCreateDBbutton_Click);
            // 
            // SQLiteDbName
            // 
            this.SQLiteDbName.Location = new System.Drawing.Point(6, 86);
            this.SQLiteDbName.Name = "SQLiteDbName";
            this.SQLiteDbName.Size = new System.Drawing.Size(144, 20);
            this.SQLiteDbName.TabIndex = 20;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(3, 69);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(84, 13);
            this.label38.TabIndex = 19;
            this.label38.Text = "Database Name";
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(333, 45);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(98, 23);
            this.selectFolderButton.TabIndex = 18;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // selectedSQLiteFolder
            // 
            this.selectedSQLiteFolder.Enabled = false;
            this.selectedSQLiteFolder.Location = new System.Drawing.Point(6, 45);
            this.selectedSQLiteFolder.Name = "selectedSQLiteFolder";
            this.selectedSQLiteFolder.ReadOnly = true;
            this.selectedSQLiteFolder.Size = new System.Drawing.Size(321, 20);
            this.selectedSQLiteFolder.TabIndex = 17;
            // 
            // SQLiteAddTableButton
            // 
            this.SQLiteAddTableButton.Location = new System.Drawing.Point(442, 308);
            this.SQLiteAddTableButton.Name = "SQLiteAddTableButton";
            this.SQLiteAddTableButton.Size = new System.Drawing.Size(335, 23);
            this.SQLiteAddTableButton.TabIndex = 16;
            this.SQLiteAddTableButton.Text = "Add Table Create String";
            this.SQLiteAddTableButton.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(439, 11);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(65, 13);
            this.label37.TabIndex = 15;
            this.label37.Text = "Table Name";
            // 
            // SQLiteTableName
            // 
            this.SQLiteTableName.Location = new System.Drawing.Point(510, 8);
            this.SQLiteTableName.Name = "SQLiteTableName";
            this.SQLiteTableName.Size = new System.Drawing.Size(267, 20);
            this.SQLiteTableName.TabIndex = 14;
            // 
            // SQLiteDt
            // 
            this.SQLiteDt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SQLiteDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SQLiteDt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn1});
            this.SQLiteDt.Location = new System.Drawing.Point(442, 30);
            this.SQLiteDt.Name = "SQLiteDt";
            this.SQLiteDt.Size = new System.Drawing.Size(335, 268);
            this.SQLiteDt.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Tag Name";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 28);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(48, 13);
            this.label35.TabIndex = 4;
            this.label35.Text = "File Path";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(783, 339);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Microsoft SQL Server";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(783, 339);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Excel CSV";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MQTTsetTab
            // 
            this.MQTTsetTab.Controls.Add(this.label51);
            this.MQTTsetTab.Controls.Add(this.label50);
            this.MQTTsetTab.Controls.Add(this.mqttUpdateButton);
            this.MQTTsetTab.Controls.Add(this.listBox1);
            this.MQTTsetTab.Controls.Add(this.mqttTreeView);
            this.MQTTsetTab.Controls.Add(this.label48);
            this.MQTTsetTab.Controls.Add(this.mqttTopicAdd);
            this.MQTTsetTab.Controls.Add(this.mqttDt);
            this.MQTTsetTab.Controls.Add(this.mqttAddButton);
            this.MQTTsetTab.Controls.Add(this.label47);
            this.MQTTsetTab.Controls.Add(this.mqttPasswordAdd);
            this.MQTTsetTab.Controls.Add(this.label46);
            this.MQTTsetTab.Controls.Add(this.label45);
            this.MQTTsetTab.Controls.Add(this.mqttPortAdd);
            this.MQTTsetTab.Controls.Add(this.label43);
            this.MQTTsetTab.Controls.Add(this.label39);
            this.MQTTsetTab.Controls.Add(this.label34);
            this.MQTTsetTab.Controls.Add(this.mqttUserNameAdd);
            this.MQTTsetTab.Controls.Add(this.mqttHostAdd);
            this.MQTTsetTab.Controls.Add(this.mqttClientIDadd);
            this.MQTTsetTab.Controls.Add(this.mqttNameAdd);
            this.MQTTsetTab.Location = new System.Drawing.Point(4, 22);
            this.MQTTsetTab.Name = "MQTTsetTab";
            this.MQTTsetTab.Size = new System.Drawing.Size(798, 371);
            this.MQTTsetTab.TabIndex = 3;
            this.MQTTsetTab.Text = "MQTT Settings";
            this.MQTTsetTab.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(520, 7);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(71, 13);
            this.label51.TabIndex = 29;
            this.label51.Text = "Selected Tag";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(344, 7);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(59, 13);
            this.label50.TabIndex = 28;
            this.label50.Text = "Select Tag";
            // 
            // mqttUpdateButton
            // 
            this.mqttUpdateButton.Location = new System.Drawing.Point(186, 153);
            this.mqttUpdateButton.Name = "mqttUpdateButton";
            this.mqttUpdateButton.Size = new System.Drawing.Size(155, 34);
            this.mqttUpdateButton.TabIndex = 27;
            this.mqttUpdateButton.Text = "Update Connection";
            this.mqttUpdateButton.UseVisualStyleBackColor = true;
            this.mqttUpdateButton.Click += new System.EventHandler(this.mqttUpdateButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(523, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(267, 173);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 26;
            // 
            // mqttTreeView
            // 
            this.mqttTreeView.CheckBoxes = true;
            this.mqttTreeView.Location = new System.Drawing.Point(347, 23);
            this.mqttTreeView.Name = "mqttTreeView";
            this.mqttTreeView.Size = new System.Drawing.Size(170, 173);
            this.mqttTreeView.TabIndex = 24;
            this.mqttTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.mqttTreeView_AfterCheck);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(183, 98);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(34, 13);
            this.label48.TabIndex = 23;
            this.label48.Text = "Topic";
            // 
            // mqttTopicAdd
            // 
            this.mqttTopicAdd.Location = new System.Drawing.Point(186, 116);
            this.mqttTopicAdd.Name = "mqttTopicAdd";
            this.mqttTopicAdd.Size = new System.Drawing.Size(155, 20);
            this.mqttTopicAdd.TabIndex = 22;
            this.mqttTopicAdd.Text = "v1/devices/me/telemetry";
            // 
            // mqttDt
            // 
            this.mqttDt.AllowUserToAddRows = false;
            this.mqttDt.AllowUserToDeleteRows = false;
            this.mqttDt.AllowUserToOrderColumns = true;
            this.mqttDt.AllowUserToResizeRows = false;
            this.mqttDt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mqttDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mqttDt.Location = new System.Drawing.Point(0, 202);
            this.mqttDt.Name = "mqttDt";
            this.mqttDt.ReadOnly = true;
            this.mqttDt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mqttDt.Size = new System.Drawing.Size(798, 170);
            this.mqttDt.TabIndex = 21;
            // 
            // mqttAddButton
            // 
            this.mqttAddButton.Location = new System.Drawing.Point(12, 153);
            this.mqttAddButton.Name = "mqttAddButton";
            this.mqttAddButton.Size = new System.Drawing.Size(166, 34);
            this.mqttAddButton.TabIndex = 20;
            this.mqttAddButton.Text = "Add Connection";
            this.mqttAddButton.UseVisualStyleBackColor = true;
            this.mqttAddButton.Click += new System.EventHandler(this.mqttAddButton_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(183, 58);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(53, 13);
            this.label47.TabIndex = 19;
            this.label47.Text = "Password";
            // 
            // mqttPasswordAdd
            // 
            this.mqttPasswordAdd.Location = new System.Drawing.Point(186, 74);
            this.mqttPasswordAdd.Name = "mqttPasswordAdd";
            this.mqttPasswordAdd.PasswordChar = '*';
            this.mqttPasswordAdd.Size = new System.Drawing.Size(155, 20);
            this.mqttPasswordAdd.TabIndex = 18;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(183, 17);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(60, 13);
            this.label46.TabIndex = 17;
            this.label46.Text = "User Name";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(141, 98);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(33, 13);
            this.label45.TabIndex = 16;
            this.label45.Text = "Port *";
            // 
            // mqttPortAdd
            // 
            this.mqttPortAdd.Location = new System.Drawing.Point(144, 116);
            this.mqttPortAdd.Name = "mqttPortAdd";
            this.mqttPortAdd.Size = new System.Drawing.Size(34, 20);
            this.mqttPortAdd.TabIndex = 15;
            this.mqttPortAdd.Text = "1883";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(9, 98);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(36, 13);
            this.label43.TabIndex = 6;
            this.label43.Text = "Host *";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(9, 59);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(54, 13);
            this.label39.TabIndex = 5;
            this.label39.Text = "Client ID *";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(9, 17);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(99, 13);
            this.label34.TabIndex = 4;
            this.label34.Text = "Connection Name *";
            // 
            // mqttUserNameAdd
            // 
            this.mqttUserNameAdd.Location = new System.Drawing.Point(186, 33);
            this.mqttUserNameAdd.Name = "mqttUserNameAdd";
            this.mqttUserNameAdd.Size = new System.Drawing.Size(155, 20);
            this.mqttUserNameAdd.TabIndex = 3;
            // 
            // mqttHostAdd
            // 
            this.mqttHostAdd.Location = new System.Drawing.Point(12, 116);
            this.mqttHostAdd.Name = "mqttHostAdd";
            this.mqttHostAdd.Size = new System.Drawing.Size(123, 20);
            this.mqttHostAdd.TabIndex = 2;
            // 
            // mqttClientIDadd
            // 
            this.mqttClientIDadd.Location = new System.Drawing.Point(12, 75);
            this.mqttClientIDadd.Name = "mqttClientIDadd";
            this.mqttClientIDadd.Size = new System.Drawing.Size(162, 20);
            this.mqttClientIDadd.TabIndex = 1;
            // 
            // mqttNameAdd
            // 
            this.mqttNameAdd.Location = new System.Drawing.Point(12, 33);
            this.mqttNameAdd.Name = "mqttNameAdd";
            this.mqttNameAdd.Size = new System.Drawing.Size(162, 20);
            this.mqttNameAdd.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(722, 9);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(79, 13);
            this.label44.TabIndex = 14;
            this.label44.Text = "Server Address";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(341, 12);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(79, 13);
            this.label49.TabIndex = 15;
            this.label49.Text = "Server Address";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.servicesToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelExportToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınformationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ınformationToolStripMenuItem
            // 
            this.ınformationToolStripMenuItem.Name = "ınformationToolStripMenuItem";
            this.ınformationToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ınformationToolStripMenuItem.Text = "Information";
            // 
            // Services
            // 
            this.Services.Controls.Add(this.SQLserviceStatus);
            this.Services.Controls.Add(this.ModbusRTUServiceStatus);
            this.Services.Controls.Add(this.MQTTserviceStatus);
            this.Services.Controls.Add(this.serviceStatusRefresh);
            this.Services.Controls.Add(this.ModbusTCPServiceStatus);
            this.Services.Controls.Add(this.label55);
            this.Services.Controls.Add(this.label54);
            this.Services.Controls.Add(this.label53);
            this.Services.Controls.Add(this.label52);
            this.Services.Location = new System.Drawing.Point(571, 27);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(241, 83);
            this.Services.TabIndex = 18;
            this.Services.TabStop = false;
            this.Services.Text = "Service Status";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(6, 16);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(120, 13);
            this.label52.TabIndex = 3;
            this.label52.Text = "Modbus TCP Service...:";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServiceStartButton,
            this.ServiceStopButton,
            this.RestartServiceButton,
            this.toolStripSeparator1,
            this.setupServicesMenuButton});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(6, 50);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(119, 13);
            this.label53.TabIndex = 4;
            this.label53.Text = "MQTT Service.............:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 33);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(119, 13);
            this.label54.TabIndex = 5;
            this.label54.Text = "Modbus RTU Service..:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 67);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(118, 13);
            this.label55.TabIndex = 6;
            this.label55.Text = "SQL Service................:";
            // 
            // ModbusTCPServiceStatus
            // 
            this.ModbusTCPServiceStatus.AutoSize = true;
            this.ModbusTCPServiceStatus.Location = new System.Drawing.Point(123, 16);
            this.ModbusTCPServiceStatus.Name = "ModbusTCPServiceStatus";
            this.ModbusTCPServiceStatus.Size = new System.Drawing.Size(35, 13);
            this.ModbusTCPServiceStatus.TabIndex = 7;
            this.ModbusTCPServiceStatus.Text = "status";
            // 
            // MQTTserviceStatus
            // 
            this.MQTTserviceStatus.AutoSize = true;
            this.MQTTserviceStatus.Location = new System.Drawing.Point(123, 50);
            this.MQTTserviceStatus.Name = "MQTTserviceStatus";
            this.MQTTserviceStatus.Size = new System.Drawing.Size(35, 13);
            this.MQTTserviceStatus.TabIndex = 8;
            this.MQTTserviceStatus.Text = "status";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConfigToolStripMenuItem,
            this.saveAsConfigToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem2.Text = "Config";
            // 
            // openConfigToolStripMenuItem
            // 
            this.openConfigToolStripMenuItem.Name = "openConfigToolStripMenuItem";
            this.openConfigToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openConfigToolStripMenuItem.Text = "Open Config";
            // 
            // saveAsConfigToolStripMenuItem
            // 
            this.saveAsConfigToolStripMenuItem.Name = "saveAsConfigToolStripMenuItem";
            this.saveAsConfigToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveAsConfigToolStripMenuItem.Text = "Save As Config";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ModbusRTUServiceStatus
            // 
            this.ModbusRTUServiceStatus.AutoSize = true;
            this.ModbusRTUServiceStatus.Location = new System.Drawing.Point(123, 33);
            this.ModbusRTUServiceStatus.Name = "ModbusRTUServiceStatus";
            this.ModbusRTUServiceStatus.Size = new System.Drawing.Size(35, 13);
            this.ModbusRTUServiceStatus.TabIndex = 34;
            this.ModbusRTUServiceStatus.Text = "status";
            // 
            // SQLserviceStatus
            // 
            this.SQLserviceStatus.AutoSize = true;
            this.SQLserviceStatus.Location = new System.Drawing.Point(123, 67);
            this.SQLserviceStatus.Name = "SQLserviceStatus";
            this.SQLserviceStatus.Size = new System.Drawing.Size(35, 13);
            this.SQLserviceStatus.TabIndex = 35;
            this.SQLserviceStatus.Text = "status";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // serviceStatusRefresh
            // 
            this.serviceStatusRefresh.Image = global::IndustrialGatewayToWebServer.Properties.Resources.Ekran_görüntüsü_2024_03_04_1245342;
            this.serviceStatusRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceStatusRefresh.Location = new System.Drawing.Point(201, 15);
            this.serviceStatusRefresh.Name = "serviceStatusRefresh";
            this.serviceStatusRefresh.Size = new System.Drawing.Size(33, 61);
            this.serviceStatusRefresh.TabIndex = 33;
            this.serviceStatusRefresh.UseVisualStyleBackColor = true;
            this.serviceStatusRefresh.Click += new System.EventHandler(this.serviceStatusRefresh_Click);
            // 
            // ServiceStartButton
            // 
            this.ServiceStartButton.Image = global::IndustrialGatewayToWebServer.Properties.Resources.Custom_Icon_Design_Flatastic_9_Start_48_1_;
            this.ServiceStartButton.Name = "ServiceStartButton";
            this.ServiceStartButton.Size = new System.Drawing.Size(150, 22);
            this.ServiceStartButton.Text = "Start Service";
            this.ServiceStartButton.Click += new System.EventHandler(this.ServiceStartButton_Click);
            // 
            // ServiceStopButton
            // 
            this.ServiceStopButton.Image = global::IndustrialGatewayToWebServer.Properties.Resources.Custom_Icon_Design_Flatastic_9_Stop_red_48;
            this.ServiceStopButton.Name = "ServiceStopButton";
            this.ServiceStopButton.Size = new System.Drawing.Size(150, 22);
            this.ServiceStopButton.Text = "Stop Service";
            this.ServiceStopButton.Click += new System.EventHandler(this.ServiceStopButton_Click);
            // 
            // RestartServiceButton
            // 
            this.RestartServiceButton.Image = global::IndustrialGatewayToWebServer.Properties.Resources.Ekran_görüntüsü_2024_03_04_1245342;
            this.RestartServiceButton.Name = "RestartServiceButton";
            this.RestartServiceButton.Size = new System.Drawing.Size(150, 22);
            this.RestartServiceButton.Text = "Restart Service";
            this.RestartServiceButton.Click += new System.EventHandler(this.RestartServiceButton_Click);
            // 
            // setupServicesMenuButton
            // 
            this.setupServicesMenuButton.Image = global::IndustrialGatewayToWebServer.Properties.Resources.Dtafalonso_Modern_Xp_ModernXP_74_Software_Install_48;
            this.setupServicesMenuButton.Name = "setupServicesMenuButton";
            this.setupServicesMenuButton.Size = new System.Drawing.Size(150, 22);
            this.setupServicesMenuButton.Text = "Setup Service";
            // 
            // excelExportToolStripMenuItem
            // 
            this.excelExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tagExportToolStripMenuItem,
            this.communicationDeviceExportToolStripMenuItem,
            this.sQLSettingsExportToolStripMenuItem});
            this.excelExportToolStripMenuItem.Image = global::IndustrialGatewayToWebServer.Properties.Resources.Graphicloads_Filetype_Excel_xls_48;
            this.excelExportToolStripMenuItem.Name = "excelExportToolStripMenuItem";
            this.excelExportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excelExportToolStripMenuItem.Text = "Excel Export";
            this.excelExportToolStripMenuItem.Click += new System.EventHandler(this.excelExportToolStripMenuItem_Click);
            // 
            // tagExportToolStripMenuItem
            // 
            this.tagExportToolStripMenuItem.Name = "tagExportToolStripMenuItem";
            this.tagExportToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.tagExportToolStripMenuItem.Text = "Tag Export";
            // 
            // communicationDeviceExportToolStripMenuItem
            // 
            this.communicationDeviceExportToolStripMenuItem.Name = "communicationDeviceExportToolStripMenuItem";
            this.communicationDeviceExportToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.communicationDeviceExportToolStripMenuItem.Text = "Communication Device Export";
            // 
            // sQLSettingsExportToolStripMenuItem
            // 
            this.sQLSettingsExportToolStripMenuItem.Name = "sQLSettingsExportToolStripMenuItem";
            this.sQLSettingsExportToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.sQLSettingsExportToolStripMenuItem.Text = "SQL Settings Export";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // deleteTagButton
            // 
            this.deleteTagButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteTagButton.Image")));
            this.deleteTagButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteTagButton.Location = new System.Drawing.Point(6, 321);
            this.deleteTagButton.Name = "deleteTagButton";
            this.deleteTagButton.Size = new System.Drawing.Size(208, 34);
            this.deleteTagButton.TabIndex = 37;
            this.deleteTagButton.Text = "Delete Tag";
            this.deleteTagButton.UseVisualStyleBackColor = true;
            this.deleteTagButton.Click += new System.EventHandler(this.deleteTagButton_Click);
            // 
            // ConfigBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 496);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BuilderTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConfigBuilder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConfigBuilder_Load);
            this.BuilderTab.ResumeLayout(false);
            this.CommSetTab.ResumeLayout(false);
            this.CommSetTab.PerformLayout();
            this.IEC104group.ResumeLayout(false);
            this.IEC104group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asduIEC)).EndInit();
            this.ModbusRTUgroup.ResumeLayout(false);
            this.ModbusRTUgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveIDRTU)).EndInit();
            this.ModbusTCPgroup.ResumeLayout(false);
            this.ModbusTCPgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveIDTCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commDt)).EndInit();
            this.SignalSetTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupDt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tagDt)).EndInit();
            this.tagRead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readTagDt)).EndInit();
            this.SQLsetTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MySQLdt)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQLiteDt)).EndInit();
            this.MQTTsetTab.ResumeLayout(false);
            this.MQTTsetTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mqttDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Services.ResumeLayout(false);
            this.Services.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl BuilderTab;
        private System.Windows.Forms.TabPage CommSetTab;
        private System.Windows.Forms.DataGridView commDt;
        private System.Windows.Forms.TabPage SignalSetTab;
        private System.Windows.Forms.TabPage SQLsetTab;
        private System.Windows.Forms.TabPage MQTTsetTab;
        private System.Windows.Forms.ComboBox CommTypeCombo;
        private System.Windows.Forms.GroupBox ModbusTCPgroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ModbusRTUgroup;
        private System.Windows.Forms.Button ModbusRTUaddButton;
        private System.Windows.Forms.Button ModbusTCPaddButton;
        private System.Windows.Forms.GroupBox IEC104group;
        private System.Windows.Forms.Button IECaddButton;
        private System.Windows.Forms.ComboBox COMPortRTU;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox ParityRTU;
        private System.Windows.Forms.ComboBox DataBitsRTU;
        private System.Windows.Forms.ComboBox baudRateRTU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IPadressTCP;
        private System.Windows.Forms.NumericUpDown SlaveIDRTU;
        private System.Windows.Forms.NumericUpDown SlaveIDTCP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown asduIEC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PortNumberIEC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox IPadressIEC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PortNumberTCP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TimeoutTCP;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button ModbusTCPupdateButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox deviceNameTCP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox deviceNameRTU;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ModbusRTUupdateButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox tagFunctionAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tagNameAdd;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tagAddressAdd;
        private System.Windows.Forms.ComboBox TagDeviceNameCombo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox tagTypeAdd;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox tagDisplayAdd;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button addTagButton;
        private System.Windows.Forms.Button TagSetRefreshButton;
        private System.Windows.Forms.TreeView TagTreeView;
        private System.Windows.Forms.DataGridView tagDt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SelectTagType;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox SelectDisplayMode;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox SelectTagAddress;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox SelectTagName;
        private System.Windows.Forms.ComboBox SelectFunction;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox SelectDeviceName;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button updateTagButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteTagButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tagRead;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private ADGV.AdvancedDataGridView readTagDt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView MySQLdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn TagNameDt;
        private System.Windows.Forms.Button connIDSetButton;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox mySQLdatabaseName;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox mySQLpassword;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox mySQLusername;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox mySQLserverAddress;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button addTableMySQLbutton;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox MySQLtableNameSet;
        private System.Windows.Forms.Button SQLiteAddTableButton;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox SQLiteTableName;
        private System.Windows.Forms.DataGridView SQLiteDt;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.TextBox selectedSQLiteFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button SQLiteAddConnectString;
        private System.Windows.Forms.Button SQLiteCreateDBbutton;
        private System.Windows.Forms.TextBox SQLiteDbName;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox currentSQLiteString;
        private System.Windows.Forms.CheckBox MySQLenableCB;
        private System.Windows.Forms.CheckBox SQLiteEnableCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.TextBox tagGroupNameAdd;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DataGridView groupDt;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tagGroupNameUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox mqttPasswordAdd;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox mqttPortAdd;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox mqttUserNameAdd;
        private System.Windows.Forms.TextBox mqttHostAdd;
        private System.Windows.Forms.TextBox mqttClientIDadd;
        private System.Windows.Forms.TextBox mqttNameAdd;
        private System.Windows.Forms.Button mqttAddButton;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox mqttTopicAdd;
        private System.Windows.Forms.DataGridView mqttDt;
        private System.Windows.Forms.TreeView mqttTreeView;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button mqttUpdateButton;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem communicationDeviceExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLSettingsExportToolStripMenuItem;
        private System.Windows.Forms.GroupBox Services;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServiceStartButton;
        private System.Windows.Forms.ToolStripMenuItem ServiceStopButton;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label ModbusTCPServiceStatus;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label MQTTserviceStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button serviceStatusRefresh;
        private System.Windows.Forms.Label SQLserviceStatus;
        private System.Windows.Forms.Label ModbusRTUServiceStatus;
        private System.Windows.Forms.ToolStripMenuItem RestartServiceButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem setupServicesMenuButton;
    }
}

