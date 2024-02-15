
namespace IndustrialGatewayToWebServer
{
    partial class TCPupdate
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
            this.addedDeviceIP = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.TimeoutTCP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PortNumberTCP = new System.Windows.Forms.TextBox();
            this.SlaveIDTCP = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IPadressTCP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.deviceNameTCP = new System.Windows.Forms.TextBox();
            this.connectionUpdateTCP = new System.Windows.Forms.Button();
            this.connectionDeleteTCP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveIDTCP)).BeginInit();
            this.SuspendLayout();
            // 
            // addedDeviceIP
            // 
            this.addedDeviceIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addedDeviceIP.FormattingEnabled = true;
            this.addedDeviceIP.Location = new System.Drawing.Point(12, 12);
            this.addedDeviceIP.Name = "addedDeviceIP";
            this.addedDeviceIP.Size = new System.Drawing.Size(200, 21);
            this.addedDeviceIP.TabIndex = 0;
            this.addedDeviceIP.SelectedIndexChanged += new System.EventHandler(this.addedDeviceIP_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Connect Timeout";
            // 
            // TimeoutTCP
            // 
            this.TimeoutTCP.Location = new System.Drawing.Point(12, 149);
            this.TimeoutTCP.Name = "TimeoutTCP";
            this.TimeoutTCP.Size = new System.Drawing.Size(86, 20);
            this.TimeoutTCP.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Port";
            // 
            // PortNumberTCP
            // 
            this.PortNumberTCP.Location = new System.Drawing.Point(178, 105);
            this.PortNumberTCP.Name = "PortNumberTCP";
            this.PortNumberTCP.Size = new System.Drawing.Size(34, 20);
            this.PortNumberTCP.TabIndex = 32;
            // 
            // SlaveIDTCP
            // 
            this.SlaveIDTCP.Location = new System.Drawing.Point(104, 149);
            this.SlaveIDTCP.Name = "SlaveIDTCP";
            this.SlaveIDTCP.Size = new System.Drawing.Size(45, 20);
            this.SlaveIDTCP.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Slave ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "IP Address";
            // 
            // IPadressTCP
            // 
            this.IPadressTCP.Location = new System.Drawing.Point(12, 105);
            this.IPadressTCP.Name = "IPadressTCP";
            this.IPadressTCP.Size = new System.Drawing.Size(160, 20);
            this.IPadressTCP.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Device Name";
            // 
            // deviceNameTCP
            // 
            this.deviceNameTCP.Location = new System.Drawing.Point(12, 65);
            this.deviceNameTCP.Name = "deviceNameTCP";
            this.deviceNameTCP.Size = new System.Drawing.Size(200, 20);
            this.deviceNameTCP.TabIndex = 36;
            // 
            // connectionUpdateTCP
            // 
            this.connectionUpdateTCP.Location = new System.Drawing.Point(12, 175);
            this.connectionUpdateTCP.Name = "connectionUpdateTCP";
            this.connectionUpdateTCP.Size = new System.Drawing.Size(200, 29);
            this.connectionUpdateTCP.TabIndex = 38;
            this.connectionUpdateTCP.Text = "Update Connection";
            this.connectionUpdateTCP.UseVisualStyleBackColor = true;
            this.connectionUpdateTCP.Click += new System.EventHandler(this.connectionUpdateTCP_Click);
            // 
            // connectionDeleteTCP
            // 
            this.connectionDeleteTCP.Location = new System.Drawing.Point(12, 210);
            this.connectionDeleteTCP.Name = "connectionDeleteTCP";
            this.connectionDeleteTCP.Size = new System.Drawing.Size(200, 29);
            this.connectionDeleteTCP.TabIndex = 39;
            this.connectionDeleteTCP.Text = "Delete Connection";
            this.connectionDeleteTCP.UseVisualStyleBackColor = true;
            this.connectionDeleteTCP.Click += new System.EventHandler(this.connectionDeleteTCP_Click);
            // 
            // TCPupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 247);
            this.Controls.Add(this.connectionDeleteTCP);
            this.Controls.Add(this.connectionUpdateTCP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.deviceNameTCP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TimeoutTCP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PortNumberTCP);
            this.Controls.Add(this.SlaveIDTCP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IPadressTCP);
            this.Controls.Add(this.addedDeviceIP);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TCPupdate";
            this.Text = "TCPupdate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveIDTCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox addedDeviceIP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TimeoutTCP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PortNumberTCP;
        private System.Windows.Forms.NumericUpDown SlaveIDTCP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IPadressTCP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox deviceNameTCP;
        private System.Windows.Forms.Button connectionUpdateTCP;
        private System.Windows.Forms.Button connectionDeleteTCP;
    }
}