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
        int V_RN;
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

        public void CheckForLetters(string fuelUsage, string kmTravelled)
        {
            if (double.TryParse(fuelUsage, out doubleTryParseOut) == false)
            {
                MessageBox.Show("The 'Fuel Usage' field cannot contain letters");
            }
            if (double.TryParse(kmTravelled, out doubleTryParseOut) == false)
            {
                MessageBox.Show("The 'KM Travelled' field cannot contain letters");
            }
        }

        public void CheckEmpty()
        {
            if(txtFuelUsage.Text == string.Empty)
            {
                MessageBox.Show("The 'Fuel Usage' field is empty");
            }
            if(txtKM.Text == string.Empty)
            {
                MessageBox.Show("The 'KM Travelled' field is empty");
            }
            if(txtTripID.Text == string.Empty)
            {
                MessageBox.Show("The 'Trip ID' field is empty");
            }
            if(txtVehicleIncidents.Text == string.Empty)
            {
                MessageBox.Show("The 'Vehicle Incidents' field is empty");
            }
            if(txtVehicleRegNumber.Text == string.Empty)
            {
                MessageBox.Show("The 'Vehicle Reg Number' field is empty");
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fuelUsage = txtFuelUsage.Text;
            kmTravelled = txtKM.Text;
            CheckEmpty();
            CheckForLetters(fuelUsage, kmTravelled);

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