
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
            this.BuilderTab = new System.Windows.Forms.TabControl();
            this.CommSetTab = new System.Windows.Forms.TabPage();
            this.IEC104group = new System.Windows.Forms.GroupBox();
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
            this.SQLsetTab = new System.Windows.Forms.TabPage();
            this.MQTTsetTab = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.BuilderTab.SuspendLayout();
            this.CommSetTab.SuspendLayout();
            this.IEC104group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asduIEC)).BeginInit();
            this.ModbusRTUgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveIDRTU)).BeginInit();
            this.ModbusTCPgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveIDTCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commDt)).BeginInit();
            this.SuspendLayout();
            // 
            // BuilderTab
            // 
            this.BuilderTab.Controls.Add(this.CommSetTab);
            this.BuilderTab.Controls.Add(this.SignalSetTab);
            this.BuilderTab.Controls.Add(this.SQLsetTab);
            this.BuilderTab.Controls.Add(this.MQTTsetTab);
            this.BuilderTab.Location = new System.Drawing.Point(13, 94);
            this.BuilderTab.Name = "BuilderTab";
            this.BuilderTab.SelectedIndex = 0;
            this.BuilderTab.Size = new System.Drawing.Size(806, 397);
            this.BuilderTab.TabIndex = 0;
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
            this.IEC104group.Location = new System.Drawing.Point(472, 49);
            this.IEC104group.Name = "IEC104group";
            this.IEC104group.Size = new System.Drawing.Size(250, 306);
            this.IEC104group.TabIndex = 5;
            this.IEC104group.TabStop = false;
            this.IEC104group.Text = "IEC 104 Settings";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 261);
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
            this.IECaddButton.Location = new System.Drawing.Point(6, 221);
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
            this.commDt.AllowUserToResizeRows = false;
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
            this.SignalSetTab.Location = new System.Drawing.Point(4, 22);
            this.SignalSetTab.Name = "SignalSetTab";
            this.SignalSetTab.Padding = new System.Windows.Forms.Padding(3);
            this.SignalSetTab.Size = new System.Drawing.Size(798, 371);
            this.SignalSetTab.TabIndex = 1;
            this.SignalSetTab.Text = "Signal Settings";
            this.SignalSetTab.UseVisualStyleBackColor = true;
            // 
            // SQLsetTab
            // 
            this.SQLsetTab.Location = new System.Drawing.Point(4, 22);
            this.SQLsetTab.Name = "SQLsetTab";
            this.SQLsetTab.Size = new System.Drawing.Size(798, 371);
            this.SQLsetTab.TabIndex = 2;
            this.SQLsetTab.Text = "SQL Settings ";
            this.SQLsetTab.UseVisualStyleBackColor = true;
            // 
            // MQTTsetTab
            // 
            this.MQTTsetTab.Location = new System.Drawing.Point(4, 22);
            this.MQTTsetTab.Name = "MQTTsetTab";
            this.MQTTsetTab.Size = new System.Drawing.Size(798, 371);
            this.MQTTsetTab.TabIndex = 3;
            this.MQTTsetTab.Text = "MQTT Settings";
            this.MQTTsetTab.UseVisualStyleBackColor = true;
            // 
            // ConfigBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 503);
            this.Controls.Add(this.BuilderTab);
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
            this.ResumeLayout(false);

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
    }
}

