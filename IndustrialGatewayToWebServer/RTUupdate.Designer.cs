
namespace IndustrialGatewayToWebServer
{
    partial class RTUupdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connectionDeleteRTU = new System.Windows.Forms.Button();
            this.connectionUpdateRTU = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.deviceNameRTU = new System.Windows.Forms.TextBox();
            this.addedDeviceName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveIDRTU)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionDeleteRTU
            // 
            this.connectionDeleteRTU.Location = new System.Drawing.Point(6, 294);
            this.connectionDeleteRTU.Name = "connectionDeleteRTU";
            this.connectionDeleteRTU.Size = new System.Drawing.Size(200, 29);
            this.connectionDeleteRTU.TabIndex = 53;
            this.connectionDeleteRTU.Text = "Delete Connection";
            this.connectionDeleteRTU.UseVisualStyleBackColor = true;
            // 
            // connectionUpdateRTU
            // 
            this.connectionUpdateRTU.Location = new System.Drawing.Point(6, 259);
            this.connectionUpdateRTU.Name = "connectionUpdateRTU";
            this.connectionUpdateRTU.Size = new System.Drawing.Size(200, 29);
            this.connectionUpdateRTU.TabIndex = 52;
            this.connectionUpdateRTU.Text = "Update Connection";
            this.connectionUpdateRTU.UseVisualStyleBackColor = true;
            this.connectionUpdateRTU.Click += new System.EventHandler(this.connectionUpdateRTU_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Device Name";
            // 
            // deviceNameRTU
            // 
            this.deviceNameRTU.Location = new System.Drawing.Point(15, 52);
            this.deviceNameRTU.Name = "deviceNameRTU";
            this.deviceNameRTU.Size = new System.Drawing.Size(197, 20);
            this.deviceNameRTU.TabIndex = 50;
            // 
            // addedDeviceName
            // 
            this.addedDeviceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addedDeviceName.FormattingEnabled = true;
            this.addedDeviceName.Location = new System.Drawing.Point(15, 12);
            this.addedDeviceName.Name = "addedDeviceName";
            this.addedDeviceName.Size = new System.Drawing.Size(196, 21);
            this.addedDeviceName.TabIndex = 40;
            this.addedDeviceName.SelectedIndexChanged += new System.EventHandler(this.addedDeviceName_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.Visible = false;
            // 
            // SlaveIDRTU
            // 
            this.SlaveIDRTU.Location = new System.Drawing.Point(115, 97);
            this.SlaveIDRTU.Name = "SlaveIDRTU";
            this.SlaveIDRTU.Size = new System.Drawing.Size(45, 20);
            this.SlaveIDRTU.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Slave ID";
            // 
            // ParityRTU
            // 
            this.ParityRTU.FormattingEnabled = true;
            this.ParityRTU.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.ParityRTU.Location = new System.Drawing.Point(15, 210);
            this.ParityRTU.Margin = new System.Windows.Forms.Padding(2);
            this.ParityRTU.Name = "ParityRTU";
            this.ParityRTU.Size = new System.Drawing.Size(92, 21);
            this.ParityRTU.TabIndex = 58;
            // 
            // DataBitsRTU
            // 
            this.DataBitsRTU.FormattingEnabled = true;
            this.DataBitsRTU.Items.AddRange(new object[] {
            "7",
            "8"});
            this.DataBitsRTU.Location = new System.Drawing.Point(15, 172);
            this.DataBitsRTU.Margin = new System.Windows.Forms.Padding(2);
            this.DataBitsRTU.Name = "DataBitsRTU";
            this.DataBitsRTU.Size = new System.Drawing.Size(92, 21);
            this.DataBitsRTU.TabIndex = 57;
            // 
            // baudRateRTU
            // 
            this.baudRateRTU.FormattingEnabled = true;
            this.baudRateRTU.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.baudRateRTU.Location = new System.Drawing.Point(15, 134);
            this.baudRateRTU.Margin = new System.Windows.Forms.Padding(2);
            this.baudRateRTU.Name = "baudRateRTU";
            this.baudRateRTU.Size = new System.Drawing.Size(92, 21);
            this.baudRateRTU.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Data Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "COM Port";
            // 
            // COMPortRTU
            // 
            this.COMPortRTU.FormattingEnabled = true;
            this.COMPortRTU.Location = new System.Drawing.Point(15, 97);
            this.COMPortRTU.Margin = new System.Windows.Forms.Padding(2);
            this.COMPortRTU.Name = "COMPortRTU";
            this.COMPortRTU.Size = new System.Drawing.Size(92, 21);
            this.COMPortRTU.TabIndex = 54;
            // 
            // RTUupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 340);
            this.Controls.Add(this.SlaveIDRTU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ParityRTU);
            this.Controls.Add(this.DataBitsRTU);
            this.Controls.Add(this.baudRateRTU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.COMPortRTU);
            this.Controls.Add(this.connectionDeleteRTU);
            this.Controls.Add(this.connectionUpdateRTU);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.deviceNameRTU);
            this.Controls.Add(this.addedDeviceName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RTUupdate";
            this.Text = "RTUupdate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveIDRTU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectionDeleteRTU;
        private System.Windows.Forms.Button connectionUpdateRTU;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox deviceNameRTU;
        private System.Windows.Forms.ComboBox addedDeviceName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown SlaveIDRTU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ParityRTU;
        private System.Windows.Forms.ComboBox DataBitsRTU;
        private System.Windows.Forms.ComboBox baudRateRTU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox COMPortRTU;
        private System.IO.Ports.SerialPort serialPort1;
    }
}