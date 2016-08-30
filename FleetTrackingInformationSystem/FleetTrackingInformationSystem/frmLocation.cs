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
    public partial class frmLocation : Form
    {
        string L_MANAGER;
        string L_ID;
        string L_NAME;
        string L_CITY;
        int L_VEHICLES;
        int L_EMPLOYEES;
        string L_PROVINCE;
        
        string[] numbers = new string[10];
        public frmLocation()
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtLocationID.Clear();
                txtManager.Clear();
                updEmployees.Value = 0;
                updVehicles.Value = 0;
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

        public void CheckForNumbers(string manager)
        {
            for (int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = (x + 1).ToString();
                if (manager.Contains(numbers[x]))
                {
                    MessageBox.Show("The 'Manager In Charge' field cannot contain numbers");
                }
            }
        }

        public void CheckEmpty()
        {
            if(txtLocationID.Text == string.Empty)
            {
                MessageBox.Show("The 'Location ID' field is empty");
            }
            if(txtManager.Text == string.Empty)
            {
                MessageBox.Show("The 'Manager In Charge' field is empty");
            }
            if(cboCity.Text == string.Empty)
            {
                MessageBox.Show("Please select a city from the drop down list");
            }
            if(cboLocationName.Text == string.Empty)
            {
                MessageBox.Show("Please select a location from the drop down list");
            }
            if(cboProvince.Text == string.Empty)
            {
                MessageBox.Show("Please select a province from the drop down list");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            L_ID = txtLocationID.Text;
            L_NAME = cboLocationName.SelectedItem.ToString();
            L_CITY = cboCity.SelectedItem.ToString();
            L_PROVINCE = cboProvince.SelectedItem.ToString();
            L_VEHICLES = int.Parse(updVehicles.Text);
            L_EMPLOYEES = int.Parse(updEmployees.Text);
            L_MANAGER = txtManager.Text;
            CheckEmpty();
            CheckForNumbers(L_MANAGER);


            try
            {


                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("INSERT INTO LOCATION VALUES (@Location_ID, @Location_Name, @Location_City, @Location_NumVehicles, @Location_NumEmployees, @Location_Manager)", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_ID", L_ID);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_Name", L_NAME);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_City", L_CITY);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_NumVehicles", L_VEHICLES);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_NumEmployees", L_EMPLOYEES);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_Manager", L_MANAGER);

                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();


                MessageBox.Show("SUCCESSFULLY INSERTED");
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

                    string sql = "DELETE FROM Location WHERE (Location_ID ='"+ L_ID +"');";

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
    }
}
