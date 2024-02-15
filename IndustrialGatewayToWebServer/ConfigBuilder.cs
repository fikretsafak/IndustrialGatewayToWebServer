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
        public ConfigBuilder()
        {
            InitializeComponent();
        }

        private void ConfigBuilder_Load(object sender, EventArgs e)
        {
            InitFileCreate();
            DbCreate();
            //DataViewFill($"SELECT * FROM COMMUNICATION WHERE COMM_TYPE LIKE 'MODBUS'");
            //DataViewFill($"SELECT * FROM COMMUNICATION ");
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
                                                                                COMM_TYPE TEXT,
                                                                                IP_ADDRESS TEXT,
                                                                                COMM_PORT INTEGER NOT NULL,
                                                                                DEVICE_ID  INTEGER NOT NULL); ", connectDb))
                        cmdDb.ExecuteNonQuery();

                    using (var cmdDb = new SQLiteCommand(@"CREATE TABLE SIGNALS (
                                                                                SIGNAL_NAME  TEXT NOT NULL,
                                                                                SIGNAL_TYPE TEXT NOT NULL,
                                                                                COMM_TYPE  TEXT NOT NULL,
                                                                                SIGNAL_ADDRESS TEXT NOT NULL); ", connectDb))
                        cmdDb.ExecuteNonQuery();
                    connectDb.Close();
                }
                /*
                 using (var baglan2 = new sqliteconnection("data source=" + systemfilepath + "config.db; version=3; default timeout=10000; pooling=true; max pool size=100"))
                 {
                     using (var komut2 = new sqlitecommand($"ınsert ınto parametre(ıd,sabah,ogle,aksam) values('{id}','{sabah}','{ogle}','{aksam}')", baglan2))
                     {
                         try
                         {
                             komut2.connection.open();
                             komut2.executenonquery();
                         }
                         catch (exception)
                         {


                         }

                     }
                 }
                 */
            }

        }


        /*
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
               //DataViewIslemleri();
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
}*/
    }
}
