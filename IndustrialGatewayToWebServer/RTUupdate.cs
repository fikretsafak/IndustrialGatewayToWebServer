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
using System.IO.Ports;

namespace IndustrialGatewayToWebServer
{
    public partial class RTUupdate : Form
    {
        string sqllitedb_constr = "Data source=C:\\KONTROLMATIK\\SystemFiles\\config.db; Version=3; default timeout=10000; Pooling=True; Max Pool Size=100";
        public int baudRateComboSelector;
        public RTUupdate()
        {
            InitializeComponent();
            DataViewFill($"SELECT * FROM COMMUNICATION");
            fillnameAddressCombo();
        }

        private void addedDeviceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            String SelectedNAME = addedDeviceName.SelectedItem.ToString();
            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                using (var cmdDb = new SQLiteCommand($"SELECT * FROM COMMUNICATION WHERE DEVICE_NAME='{SelectedNAME}'", connectDb))
                {

                    try
                    {
                        cmdDb.Connection.Open();
                        SQLiteDataReader dtr = cmdDb.ExecuteReader();
                        if (dtr.Read())
                        {
                            deviceNameRTU.Text = dtr["DEVICE_NAME"].ToString();
                            COMPortRTU.Text = dtr["COMM_PORT"].ToString();
                            SlaveIDRTU.Value = Int32.Parse(dtr["DEVICE_ID"].ToString());
                            cmdDb.Connection.Close();
                            using (var cmdDb1 = new SQLiteCommand($"SELECT * FROM MODBUS_RTU WHERE DEVICE_NAME='{SelectedNAME}'", connectDb))
                            {
                                try
                                {
                                    cmdDb1.Connection.Open();
                                    SQLiteDataReader dtr1 = cmdDb1.ExecuteReader();
                                    if (dtr1.Read())
                                    {
                                        baudRateRTU.SelectedItem = dtr1["BAUDRATE"].ToString();
                                        DataBitsRTU.SelectedItem = dtr1["DATABITS"].ToString();
                                        ParityRTU.SelectedItem = dtr1["PARITY"].ToString();
                                        findConnectedPorts();

                                        cmdDb1.Connection.Close();
                                    }

                                }
                                catch (Exception)
                                {

                                }

                            }
                        }


                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.Message);
                    }
                }

            }
        }

        private void fillnameAddressCombo()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                string Name = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string CommType = dataGridView1.Rows[i].Cells[2].Value.ToString();

                if (CommType == "Modbus RTU")
                {
                    addedDeviceName.Items.Add(Name);
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

                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception)
                    {

                    }
                }
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
        private void connectionUpdateRTU_Click(object sender, EventArgs e)
        {
            String SelectedNAME = addedDeviceName.SelectedItem.ToString();

            using (var connectDb = new SQLiteConnection(sqllitedb_constr))
            {

                if (string.IsNullOrEmpty(deviceNameRTU.Text) || string.IsNullOrEmpty(COMPortRTU.Text) || string.IsNullOrEmpty(baudRateRTU.Text))
                {

                    MessageBox.Show("Make sure all info is filled.");
                }
                else
                {
                    DialogResult diar = MessageBox.Show("Are you sure update connection ?", "Update Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diar == DialogResult.Yes)
                    {
                        using (var cmdDb = new SQLiteCommand($"UPDATE COMMUNICATION SET  DEVICE_NAME='{deviceNameRTU.Text}', COMM_PORT = '{COMPortRTU.Text}', DEVICE_ID = '{SlaveIDRTU.Value}' WHERE DEVICE_NAME = '{SelectedNAME}'", connectDb))
                        {
                            try
                            {
                                cmdDb.Connection.Open();
                                cmdDb.ExecuteNonQuery();
                                using (var cmdDb1 = new SQLiteCommand($"UPDATE MODBUS_RTU SET  DEVICE_NAME='{deviceNameRTU.Text}', COMM_PORT = '{COMPortRTU.Text}', BAUDRATE = '{baudRateRTU.Text}', DATABITS = '{DataBitsRTU.Text}', PARITY = '{ParityRTU.Text}' WHERE DEVICE_NAME = '{SelectedNAME}'", connectDb))
                                {
                                    try
                                    {
                                        cmdDb1.Connection.Open();
                                        cmdDb1.ExecuteNonQuery();
                                        MessageBox.Show("Connection Updated");
                                        DataViewFill($"SELECT * FROM COMMUNICATION");
                                    }
                                    catch (Exception)
                                    {
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
}
