﻿using System;
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
        public void OpenConnection()
        {
            try
            {
                sqlConn = new SqlConnection();
                //sqlConn.ConnectionString = ("Server=tcp:myserver17.database.windows.net,1433;Initial Catalog=FleetTrackingDB;Persist Security Info=False;User ID=kimmy-17;Password=Gummybear7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                sqlConn.ConnectionString = ("Data Source=DESKTOP-JU2TQ2K;Initial Catalog=FleetTrackingDB;Integrated Security=True");//mlondi
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
