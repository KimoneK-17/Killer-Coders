using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FleetTrackingInformationSystem
{
    public partial class Search1 : Form
    {
        public Search1()
        {
            InitializeComponent();
        }
        DBConnect objDBConnect = new DBConnect();
        private void Search1_Load(object sender, EventArgs e)
        {

        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                objDBConnect.GiveCommand("SELECT  from Customer  WHERE Cust_ID LIKE C_ID; ");
                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("", typeof(string));
                dt.Load(objDBConnect.sqlDR);

                cboC_ID.ValueMember = "C_ID";
                cboC_ID.DisplayMember = "C_ID";
                cboC_ID.DataSource = "C_ID";

                objDBConnect.sqlConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(""); // Shows an error message
            }
        }

        private void cboT_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                objDBConnect.GiveCommand("SELECT  from TripUsage WHERE T_ID LIKE T_ID; ");
                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("", typeof(string));
                dt.Load(objDBConnect.sqlDR);

                cboT_ID.ValueMember = "T_ID";
                cboT_ID.DisplayMember = "T_ID";
                cboT_ID.DataSource = "T_ID";

                objDBConnect.sqlConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(""); // Shows an error message
            }
        }

        private void cboE_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                objDBConnect.GiveCommand("SELECT  from Employee  WHERE E_ID LIKE E_ID; ");
                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("", typeof(string));
                dt.Load(objDBConnect.sqlDR);

                cboE_ID.ValueMember = "E_ID";
                cboE_ID.DisplayMember = "E_ID";
                cboE_ID.DataSource = "E_ID";

                objDBConnect.sqlConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(""); // Shows an error message
            }
        }

        private void cboL_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                objDBConnect.GiveCommand("SELECT  from Customer  WHERE Cust_ID LIKE C_ID; ");
                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("", typeof(string));
                dt.Load(objDBConnect.sqlDR);

                cboL_ID.ValueMember = "L_ID";
                cboL_ID.DisplayMember = "L_ID";
                cboL_ID.DataSource = "L_ID";

                objDBConnect.sqlConn.Close();

            }
    catch (Exception ex)
            {
                MessageBox.Show(""); // Shows an error message
            }
        }

        private void cboV_RN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                objDBConnect.GiveCommand("SELECT * from Vehicle  WHERE Vehicle_RegNumber LIKE @V_RN");
                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("", typeof(string));
                dt.Load(objDBConnect.sqlDR);

                cboV_RN.ValueMember = "V_RN";
                cboV_RN.DisplayMember = "V_RN";
                cboV_RN.DataSource = "V_RN";

                objDBConnect.sqlConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(""); // Shows an error message
            }

        }

        private void cboS_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                objDBConnect.GiveCommand("SELECT * from Service  WHERE Service_ID LIKE @S_ID");
                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("", typeof(string));
                dt.Load(objDBConnect.sqlDR);

                cboS_ID.ValueMember = "S_ID ";
                cboS_ID.DisplayMember = "S_ID ";
                cboS_ID.DataSource = "S_ID ";

                objDBConnect.sqlConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(""); // Shows an error message
            }
        }


    }
}
