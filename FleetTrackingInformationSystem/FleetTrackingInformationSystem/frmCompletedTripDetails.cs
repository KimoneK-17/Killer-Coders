using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetTrackingInformationSystem
{
    public partial class frmCompletedTripDetails : Form
    {
        public frmCompletedTripDetails()
        {
            InitializeComponent();
        }
        DBConnect objDBConnect = new DBConnect();
        private void frmCompletedTripDetails_Load(object sender, EventArgs e)
        {
            try
            {

                string query = "SELECT Trip_ID from TripUsage WHERE Trip_Completed like 'NO';";
                objDBConnect.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, objDBConnect.sqlConn);

                DataSet ds = new DataSet();
                da.Fill(ds, "TripUsage");
                cboT_ID.ValueMember = "Trip_ID";
                cboT_ID.DisplayMember = "Trip_ID";
                cboT_ID.DataSource = ds.Tables["TripUsage"];
                objDBConnect.sqlConn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Shows an error message
            }
        }
        string T_ID;
        string T_FUEL;
        string T_INCIDENTS;
        string T_MILEAGE;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            T_ID = this.cboT_ID.GetItemText(this.cboT_ID.SelectedItem);

            T_FUEL = txtFuelUsage.Text;
            T_INCIDENTS = txtVehicleIncidents.Text;
            T_MILEAGE = txtKM.Text;

            try
            {
                //Check check = new Check();
                //bool executeSQL = check.CheckDB("TripUsage", "Trip_ID", T_ID);
                //if(executeSQL == false)
                //{
                DBConnect objDBConnect = new DBConnect();
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("UPDATE TripUsage SET Trip_FuelUsed=@Trip_FuelUsed, Trip_Incidents=@Trip_Incidents, Trip_Mileage=@Trip_Mileage, Trip_Completed = @Trip_Completed WHERE Trip_ID = @Trip_ID", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_ID", T_ID);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_FuelUsed", T_FUEL);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_Incidents", T_INCIDENTS);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_Mileage", T_MILEAGE);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_Completed", "YES");


                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                MessageBox.Show("Succesfully inserted");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();
                //}
                //else
                //{
                //    MessageBox.Show("That Trip ID already exists in the database");
                //}
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Submit Details: " + ex.Message);
            }

        }
    }
}
