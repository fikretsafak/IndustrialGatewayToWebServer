using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SQLite;

namespace IndustrialGatewayToWebServer
{
    public partial class TCPupdate : Form
    {
        string sqllitedb_constr = "Data source=C:\\KONTROLMATIK\\SystemFiles\\config.db; Version=3; default timeout=10000; Pooling=True; Max Pool Size=100";

        public TCPupdate()
        {
            InitializeComponent();
            DataViewFill($"SELECT * FROM COMMUNICATION");
           // addedDeviceIP.SelectedIndex = 0;
            fillIPaddressCombo();

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

        private void fillIPaddressCombo()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                string IPaddress = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string CommType = dataGridView1.Rows[i].Cells[2].Value.ToString();

                if (CommType == "Modbus TCP")
                {
                    addedDeviceIP.Items.Add(IPaddress);
                }
            }
        }

        private void addedDeviceIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            String SelectedIP = addedDeviceIP.SelectedItem.ToString();
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {
                
                    using (var cmdDb = new SQLiteCommand($"SELECT * FROM COMMUNICATION WHERE IP_ADDRESS='{SelectedIP}'", connectDb))
                    {

                        try
                        {
                            cmdDb.Connection.Open();
                            SQLiteDataReader dtr = cmdDb.ExecuteReader();
                            if (dtr.Read())
                            {
                                IPadressTCP.Text = dtr["IP_ADDRESS"].ToString();
                                PortNumberTCP.Text = dtr["COMM_PORT"].ToString();
                                SlaveIDTCP.Value = Int32.Parse(dtr["DEVICE_ID"].ToString());
                                deviceNameTCP.Text = dtr["DEVICE_NAME"].ToString();
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

        private void connectionUpdateTCP_Click(object sender, EventArgs e)
        {

            String SelectedIP = addedDeviceIP.SelectedItem.ToString();

            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                if (string.IsNullOrEmpty(IPadressTCP.Text) || string.IsNullOrEmpty(PortNumberTCP.Text) || string.IsNullOrEmpty(deviceNameTCP.Text)) 
                {

                    MessageBox.Show("Make sure all info is filled.");
                }
                else
                {
                    DialogResult diar = MessageBox.Show("Are you sure update connection ?", "Update Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diar == DialogResult.Yes)
                    {
                        using (var cmdDb = new SQLiteCommand($"UPDATE COMMUNICATION SET  DEVICE_NAME='{deviceNameTCP.Text}', IP_ADDRESS = '{IPadressTCP.Text}', COMM_PORT = '{PortNumberTCP.Text}', DEVICE_ID = '{SlaveIDTCP.Value}' WHERE IP_ADDRESS = '{SelectedIP}'", connectDb))
                        {
                            try
                            {
                                cmdDb.Connection.Open();
                                cmdDb.ExecuteNonQuery();
                                MessageBox.Show("Connection Updated");
                                DataViewFill($"SELECT * FROM COMMUNICATION");
                            }

                            catch (Exception)
                            {
                                
                            }
                        }

                    }

                }

            }





        }

        private void connectionDeleteTCP_Click(object sender, EventArgs e)
        {
            String SelectedIP = addedDeviceIP.SelectedItem.ToString();

            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {
                DialogResult diar = MessageBox.Show("Are you sure delete connection ?", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diar == DialogResult.Yes)
                {
                    using (var cmdDb = new SQLiteCommand($"DELETE FROM COMMUNICATION WHERE IP_ADDRESS = '{SelectedIP}'", connectDb))
                    {
                        try
                        {
                            cmdDb.Connection.Open();
                            cmdDb.ExecuteNonQuery();
                            MessageBox.Show("Connection Deleted");
                            DataViewFill($"SELECT * FROM COMMUNICATION");
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
