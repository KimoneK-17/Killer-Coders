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
    public partial class frmTripUsage : Form
    {
        string T_ID;
        double doubleTryParseOut;
        string kmTravelled;
        string fuelUsage;
        string V_RN;
        string T_FROM;
        string T_TO;
        string T_FUEL;
        string T_INCIDENTS;
        string T_MILEAGE;

        public frmTripUsage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMenu men = new frmMenu(); // Goes back to the Menu Form
                men.ShowDialog();
            }
            catch
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Application Error");
                    this.Hide();
                    frmLogin log = new frmLogin();
                    log.ShowDialog();
                    --stopper;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0); // Exits the Entire Application
            }
            catch
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Application Error"); // Shows an error message and takes you back to Form Login if an error has to occur
                    this.Hide();
                    frmLogin log = new frmLogin();
                    log.ShowDialog();
                    --stopper;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtTripID.Clear();
                txtFuelUsage.Clear();
                txtVehicleIncidents.Clear(); // Clears Text Box
                txtVehicleRegNumber.Clear();
                txtKM.Clear();
            }
            catch
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Application Error"); // Shows an error message and takes you back to Form Login if an error has to occur
                    this.Hide();
                    frmLogin log = new frmLogin();
                    log.ShowDialog();
                    --stopper;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            bool exit = false;

            fuelUsage = txtFuelUsage.Text;
            kmTravelled = txtKM.Text;

            exit = check.CheckEmpty(T_ID, "Trip ID");
            exit = check.CheckEmpty(fuelUsage, "Fuel Usage");
            exit = check.CheckEmpty(kmTravelled, "KM Travelled");
            exit = check.CheckEmpty(V_RN, "Vehicle Reg Number");
            exit = check.CheckForLetters(kmTravelled, "KM Travelled");
            exit = check.CheckForLetters(fuelUsage, "Fuel Usage");
              
            if(exit == false)
            {
                try
                {
                    DBConnect objDBConnect = new DBConnect();
                    objDBConnect.OpenConnection();

                    objDBConnect.sqlCmd = new SqlCommand("IF NOT EXISTS(SELECT * FROM TripUsage WHERE T_ID = @Trip_ID) BEGIN INSERT INTO TripUsage VALUES(@Trip_ID, @Vehicle_RegNumber, @Trip_DateFrom, @Trip_DateTo, @Trip_FuelUsed, @Trip_Incidents, @Trip_Mileage)", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_ID", T_ID);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_DateFrom", T_FROM);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_DateTo", T_TO);

                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                    MessageBox.Show("Succesfully inserted");
                    objDBConnect.sqlDR.Close();
                    objDBConnect.sqlConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                try
                {
                    DBConnect objDBConnect = new DBConnect();

                    objDBConnect.OpenConnection();

                    string sql = "DELETE FROM TripUsage WHERE (Trip_ID ='"+ T_ID +"');";

                    objDBConnect.sqlCmd = new SqlCommand();
                    objDBConnect.sqlCmd.CommandText = sql;
                    objDBConnect.sqlCmd.Connection = objDBConnect.sqlConn;

                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                 
                    MessageBox.Show("SUCCESS");
                    objDBConnect.sqlDR.Close();
                    objDBConnect.sqlConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {             
              DBConnect objDBConnect = new DBConnect();

              objDBConnect.OpenConnection();

              objDBConnect.sqlCmd = new SqlCommand("UPDATE TripUsage VALUES(@Trip_ID, @Vehicle_RegNumber, @Trip_DateFrom, @Trip_DateTo, @Trip_FuelUsed, @Trip_Incidents, @Trip_Mileage)",objDBConnect.sqlConn);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_ID", T_ID);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_DateFrom", T_FROM);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_DateTo", T_TO);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_FuelUsed", T_FUEL);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_Incidents", T_INCIDENTS);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_Mileage", T_MILEAGE);
              MessageBox.Show("SUCCESSFULLY UPDATED");
              objDBConnect.sqlDR.Close();
              objDBConnect.sqlConn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
   }
}