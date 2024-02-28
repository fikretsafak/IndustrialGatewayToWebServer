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
using System.Reflection.Emit;

namespace IndustrialGatewayToWebServer
{

    public partial class MQTTupdate : Form
    {
        string sqllitedb_constr = "Data source=C:\\KONTROLMATIK\\SystemFiles\\config.db; Version=3; default timeout=10000; Pooling=True; Max Pool Size=100";
        int n = 0;
        string mqttTagNameString = "";
        bool SameNameStatusMQTT;
        string[,] groupCount = new string[10000, 10000];
        public MQTTupdate()
        {
            InitializeComponent();
            DataViewFill($"SELECT * FROM MQTT");
            DataViewFillForTags($"SELECT * FROM TAGS");
            DataViewFillForComm($"SELECT * FROM COMMUNICATION");
            DataViewFillForGroup($"SELECT * FROM TAG_GROUP");
            fillMQTTconNameCombo();
            MQTTTreeViewFill();
            mqttNameAdd.Enabled = false;
            mqttClientIDadd.Enabled = false;
            mqttHostAdd.Enabled = false;
            mqttPortAdd.Enabled = false;
            mqttUserNameAdd.Enabled = false;
            mqttPasswordAdd.Enabled = false;
            mqttTopicAdd.Enabled = false;
            mqttTreeView.Enabled = false;
            listBox1.Enabled = false;
            mqttUpdateButton.Enabled = false;
            mqttDeleteButton.Enabled = false;
        }

        private void fillMQTTconNameCombo()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                string Name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                connNameCombo.Items.Add(Name);
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

                        dataGridView1.DataSource = dt;
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

        private void DataViewFillForComm(string SQLite)
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






        private void MQTTTreeViewFill()
        {

            mqttTreeView.Nodes.Clear();
            n = 0;

            for (int q = 0; q < mqttTreeView.Nodes.Count; q++)
            {
                mqttTreeView.Nodes[q].ImageIndex = 3;
            }


            for (int i = 0; i < commDt.Rows.Count - 1; i++)
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
                for (int m = 0; m < groupDt.Rows.Count-1; m++)
                {
                    string groupName = groupDt.Rows[m].Cells[0].Value.ToString();
                    groupCount[i, m] = groupName;
                }

                for (int k = 0; k < groupDt.Rows.Count - 1; k++)
                {
                    string groupDevName = groupDt.Rows[k].Cells[1].Value.ToString();
                    string groupName = groupDt.Rows[k].Cells[0].Value.ToString();
                    mqttTreeView.Nodes[i].ImageIndex = 1;
                    if (devName == groupDevName)
                    {
                        mqttTreeView.Nodes[i].Nodes.Add(groupName);
                        mqttTreeView.Nodes[i].ImageIndex = 1;

                        for (int j = 0; j < tagDt.Rows.Count-1; j++)
                        {
                            string tagName = tagDt.Rows[j].Cells[0].Value.ToString();
                            string tagGroup = tagDt.Rows[j].Cells[2].Value.ToString();
                            if (tagGroup == groupName)
                            {
                                if (mqttTreeView.Nodes[i].Checked)
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
        }

        void LookupChecks(TreeNodeCollection nodes, List<TreeNode> list)
        {
            foreach (TreeNode node in nodes)
            {

                if (node.Checked)
                {
                    string[] temp = node.Text.Split('.');
                    if (temp.Length != 3)
                    {

                    }
                    else
                    {
                        list.Add(node);
                        listBox1.Items.Add(node.ToString().Substring(10));
                        mqttTagNameString = mqttTagNameString + node.ToString().Substring(10) + ";";
                    }

                }

                LookupChecks(node.Nodes, list);
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

        private void connNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String SelectedConn = connNameCombo.SelectedItem.ToString();
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                using (var cmdDb = new SQLiteCommand($"SELECT * FROM MQTT WHERE CONN_NAME='{SelectedConn}'", connectDb))
                {

                    try
                    {
                        cmdDb.Connection.Open();
                        SQLiteDataReader dtr = cmdDb.ExecuteReader();
                        if (dtr.Read())
                        {
                            mqttNameAdd.Enabled = true;
                            mqttClientIDadd.Enabled = true;
                            mqttHostAdd.Enabled = true;
                            mqttPortAdd.Enabled = true;
                            mqttUserNameAdd.Enabled = true;
                            mqttPasswordAdd.Enabled = true;
                            mqttTopicAdd.Enabled = true;
                            mqttTreeView.Enabled = true;
                            listBox1.Enabled = true;
                            mqttUpdateButton.Enabled = true;
                            mqttDeleteButton.Enabled = true;

                            mqttNameAdd.Text = dtr["CONN_NAME"].ToString();
                            mqttClientIDadd.Text = dtr["CLIENT_ID"].ToString();
                            mqttHostAdd.Text = dtr["HOST_ADDRESS"].ToString();
                            mqttPortAdd.Text = dtr["HOST_PORT"].ToString();
                            mqttUserNameAdd.Text = dtr["USERNAME"].ToString();
                            mqttPasswordAdd.Text = dtr["PASSWORD"].ToString();
                            mqttTopicAdd.Text = dtr["TOPIC"].ToString();
                            string[] tags = dtr["TAGS"].ToString().Split(';');
                            foreach (string tag in tags)
                            {
                                listBox1.Items.Add(tag);
                            }

                            cmdDb.Connection.Close();
                            
                        }


                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.Message);
                    }
                }

            }
        }

        private void mqttUpdateButton_Click(object sender, EventArgs e)
        {
            String SelectedCONN = connNameCombo.SelectedItem.ToString();

            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                if (string.IsNullOrEmpty(mqttNameAdd.Text) || string.IsNullOrEmpty(mqttClientIDadd.Text) || string.IsNullOrEmpty(mqttHostAdd.Text) || string.IsNullOrEmpty(mqttPortAdd.Text))
                {

                    MessageBox.Show("Make sure all info is filled.");
                }
                else
                {
                    DialogResult diar = MessageBox.Show("Are you sure update connection ?", "Update Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diar == DialogResult.Yes)
                    {
                        using (var cmdDb = new SQLiteCommand($"UPDATE MQTT SET CONN_NAME='{mqttNameAdd.Text}', CLIENT_ID = '{mqttClientIDadd.Text}', HOST_ADDRESS = '{mqttHostAdd.Text}', HOST_PORT = '{mqttPortAdd.Text}', USERNAME = '{mqttUserNameAdd.Text}', PASSWORD = '{mqttPasswordAdd.Text}', TOPIC = '{mqttTopicAdd.Text}', TAGS = '{mqttTagNameString}' WHERE CONN_NAME = '{SelectedCONN}'", connectDb))
                        {
                            try
                            {
                                cmdDb.Connection.Open();
                                cmdDb.ExecuteNonQuery();

                                MessageBox.Show("Device updated.");
                                this.Close();
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
}
