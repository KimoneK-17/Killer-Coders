using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FleetTrackingInformationSystem
{
    class DBConnect
    {
        public SqlConnection sqlConn;
        public SqlCommand sqlCmd;
        public SqlDataReader sqlDR;
        public SqlDataAdapter sqlDA;
        //VCDNSTDST04PC22\\VARSITYCOLLEGE
        public void OpenConnection()
        {
            try
            {
                sqlConn = new SqlConnection();
                sqlConn.ConnectionString = ("Data Source = DESKTOP-JU2TQ2K\\MYSQLSERVER; Initial Catalog = FleetTrackingDB; Integrated Security = SSPI");
                sqlConn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR - Connection not established.\n" + ex.Message);
            }
        }

        public void GiveCommand(string sSql)
        {
            OpenConnection();
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = sSql;
        }
    }
}
