namespace IndustrialGatewayToWebServer
{
    partial class MQTTupdate
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
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mqttTreeView = new System.Windows.Forms.TreeView();
            this.label48 = new System.Windows.Forms.Label();
            this.mqttTopicAdd = new System.Windows.Forms.TextBox();
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
            this.mqttUpdateButton = new System.Windows.Forms.Button();
            this.mqttDeleteButton = new System.Windows.Forms.Button();
            this.connNameCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.commDt = new System.Windows.Forms.DataGridView();
            this.groupDt = new System.Windows.Forms.DataGridView();
            this.tagDt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagDt)).BeginInit();
            this.SuspendLayout();
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(202, 212);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(71, 13);
            this.label51.TabIndex = 33;
            this.label51.Text = "Selected Tag";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(9, 212);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(59, 13);
            this.label50.TabIndex = 32;
            this.label50.Text = "Select Tag";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(205, 228);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(187, 173);
            this.listBox1.TabIndex = 31;
            // 
            // mqttTreeView
            // 
            this.mqttTreeView.CheckBoxes = true;
            this.mqttTreeView.Location = new System.Drawing.Point(12, 228);
            this.mqttTreeView.Name = "mqttTreeView";
            this.mqttTreeView.Size = new System.Drawing.Size(187, 173);
            this.mqttTreeView.TabIndex = 30;
            this.mqttTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.mqttTreeView_AfterCheck);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(202, 155);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(34, 13);
            this.label48.TabIndex = 47;
            this.label48.Text = "Topic";
            // 
            // mqttTopicAdd
            // 
            this.mqttTopicAdd.Location = new System.Drawing.Point(205, 173);
            this.mqttTopicAdd.Name = "mqttTopicAdd";
            this.mqttTopicAdd.Size = new System.Drawing.Size(162, 20);
            this.mqttTopicAdd.TabIndex = 6;
            this.mqttTopicAdd.Text = "v1/devices/me/telemetry";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(202, 115);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(53, 13);
            this.label47.TabIndex = 45;
            this.label47.Text = "Password";
            // 
            // mqttPasswordAdd
            // 
            this.mqttPasswordAdd.Location = new System.Drawing.Point(205, 131);
            this.mqttPasswordAdd.Name = "mqttPasswordAdd";
            this.mqttPasswordAdd.PasswordChar = '*';
            this.mqttPasswordAdd.Size = new System.Drawing.Size(162, 20);
            this.mqttPasswordAdd.TabIndex = 5;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(202, 74);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(60, 13);
            this.label46.TabIndex = 43;
            this.label46.Text = "User Name";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(143, 155);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(33, 13);
            this.label45.TabIndex = 42;
            this.label45.Text = "Port *";
            // 
            // mqttPortAdd
            // 
            this.mqttPortAdd.Location = new System.Drawing.Point(146, 173);
            this.mqttPortAdd.Name = "mqttPortAdd";
            this.mqttPortAdd.Size = new System.Drawing.Size(34, 20);
            this.mqttPortAdd.TabIndex = 41;
            this.mqttPortAdd.Text = "1883";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(11, 155);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(36, 13);
            this.label43.TabIndex = 40;
            this.label43.Text = "Host *";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(11, 116);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(54, 13);
            this.label39.TabIndex = 39;
            this.label39.Text = "Client ID *";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(11, 74);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(99, 13);
            this.label34.TabIndex = 38;
            this.label34.Text = "Connection Name *";
            // 
            // mqttUserNameAdd
            // 
            this.mqttUserNameAdd.Location = new System.Drawing.Point(205, 90);
            this.mqttUserNameAdd.Name = "mqttUserNameAdd";
            this.mqttUserNameAdd.Size = new System.Drawing.Size(162, 20);
            this.mqttUserNameAdd.TabIndex = 4;
            // 
            // mqttHostAdd
            // 
            this.mqttHostAdd.Location = new System.Drawing.Point(14, 173);
            this.mqttHostAdd.Name = "mqttHostAdd";
            this.mqttHostAdd.Size = new System.Drawing.Size(123, 20);
            this.mqttHostAdd.TabIndex = 3;
            // 
            // mqttClientIDadd
            // 
            this.mqttClientIDadd.Location = new System.Drawing.Point(14, 132);
            this.mqttClientIDadd.Name = "mqttClientIDadd";
            this.mqttClientIDadd.Size = new System.Drawing.Size(162, 20);
            this.mqttClientIDadd.TabIndex = 2;
            // 
            // mqttNameAdd
            // 
            this.mqttNameAdd.Location = new System.Drawing.Point(14, 90);
            this.mqttNameAdd.Name = "mqttNameAdd";
            this.mqttNameAdd.Size = new System.Drawing.Size(162, 20);
            this.mqttNameAdd.TabIndex = 1;
            // 
            // mqttUpdateButton
            // 
            this.mqttUpdateButton.Location = new System.Drawing.Point(12, 411);
            this.mqttUpdateButton.Name = "mqttUpdateButton";
            this.mqttUpdateButton.Size = new System.Drawing.Size(187, 34);
            this.mqttUpdateButton.TabIndex = 48;
            this.mqttUpdateButton.Text = "Update Connection";
            this.mqttUpdateButton.UseVisualStyleBackColor = true;
            this.mqttUpdateButton.Click += new System.EventHandler(this.mqttUpdateButton_Click);
            // 
            // mqttDeleteButton
            // 
            this.mqttDeleteButton.Location = new System.Drawing.Point(205, 411);
            this.mqttDeleteButton.Name = "mqttDeleteButton";
            this.mqttDeleteButton.Size = new System.Drawing.Size(187, 34);
            this.mqttDeleteButton.TabIndex = 49;
            this.mqttDeleteButton.Text = "Delete Connection";
            this.mqttDeleteButton.UseVisualStyleBackColor = true;
            // 
            // connNameCombo
            // 
            this.connNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connNameCombo.FormattingEnabled = true;
            this.connNameCombo.Location = new System.Drawing.Point(15, 35);
            this.connNameCombo.Name = "connNameCombo";
            this.connNameCombo.Size = new System.Drawing.Size(375, 21);
            this.connNameCombo.TabIndex = 50;
            this.connNameCombo.SelectedIndexChanged += new System.EventHandler(this.connNameCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Select Connection";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(15, 10);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.Visible = false;
            // 
            // commDt
            // 
            this.commDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commDt.Location = new System.Drawing.Point(90, 269);
            this.commDt.Name = "commDt";
            this.commDt.Size = new System.Drawing.Size(15, 10);
            this.commDt.TabIndex = 53;
            this.commDt.Visible = false;
            // 
            // groupDt
            // 
            this.groupDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupDt.Location = new System.Drawing.Point(128, 269);
            this.groupDt.Name = "groupDt";
            this.groupDt.Size = new System.Drawing.Size(15, 10);
            this.groupDt.TabIndex = 54;
            this.groupDt.Visible = false;
            // 
            // tagDt
            // 
            this.tagDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagDt.Location = new System.Drawing.Point(165, 269);
            this.tagDt.Name = "tagDt";
            this.tagDt.Size = new System.Drawing.Size(15, 10);
            this.tagDt.TabIndex = 55;
            this.tagDt.Visible = false;
            // 
            // MQTTupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connNameCombo);
            this.Controls.Add(this.mqttDeleteButton);
            this.Controls.Add(this.mqttUpdateButton);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.mqttTopicAdd);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.mqttPasswordAdd);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.mqttPortAdd);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.mqttUserNameAdd);
            this.Controls.Add(this.mqttHostAdd);
            this.Controls.Add(this.mqttClientIDadd);
            this.Controls.Add(this.mqttNameAdd);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mqttTreeView);
            this.Controls.Add(this.tagDt);
            this.Controls.Add(this.groupDt);
            this.Controls.Add(this.commDt);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MQTTupdate";
            this.Text = "MQTTupdate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagDt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView mqttTreeView;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox mqttTopicAdd;
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
        private System.Windows.Forms.Button mqttUpdateButton;
        private System.Windows.Forms.Button mqttDeleteButton;
        private System.Windows.Forms.ComboBox connNameCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView commDt;
        private System.Windows.Forms.DataGridView groupDt;
        private System.Windows.Forms.DataGridView tagDt;
    }
}