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
                men.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Go Back to Previous Form: " + ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0); // Exits the Entire Application
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Exit the Application: " + ex); // Shows an error message 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtLocationID.Clear();
                txtManager.Clear();
                updEmployees.Value = 0;
                updVehicles.Value = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Clear the Form: " + ex); // Shows an error message 
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            getValues();
            Check check = new Check();
            bool exit = false;

            exit = check.CheckEmpty(L_ID, "Location ID");
            exit = check.CheckEmpty(L_MANAGER, "Manager In Charge");
            exit = check.CheckEmpty(L_CITY, "City");
            exit = check.CheckEmpty(L_NAME, "Location");
            exit = check.CheckEmpty(L_PROVINCE, "Province");
            exit = check.CheckForNumbers(L_MANAGER, "Manager In Charge");

            if (exit == false)
            {
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
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Cannot Submit Location Details: " + ex.Message);
                }
                try
                {
                    L_NAME = this.cboLocationName.GetItemText(this.cboLocationName.SelectedItem);
                }
                catch (Exception  ex)
                {
                    MessageBox.Show("Cobobox error: " + ex.Message);
                }
                try
                {
                    L_CITY = this.cboCity.GetItemText(this.cboCity.SelectedItem); 
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Cobobox error: " + ex.Message);
                }
                try
                {
                    L_PROVINCE = this.cboProvince.GetItemText(this.cboProvince.SelectedItem); 
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Cobobox error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            getValues();
            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                string sql = "DELETE FROM Location WHERE (Location_ID ='" + L_ID + "');";

                objDBConnect.sqlCmd = new SqlCommand();
                objDBConnect.sqlCmd.CommandText = sql;
                objDBConnect.sqlCmd.Connection = objDBConnect.sqlConn;

                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();


                MessageBox.Show("SUCCESS");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Delete Location Details: " + ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getValues();
            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();
                objDBConnect.sqlCmd = new SqlCommand("UPDATE LOCATION SET Location_Name=@Location_Name , Location_City=@Location_City, Location_NumVehicles = @Location_NumVehicles,Location_NumEmployees= @Location_NumEmployees,Location_Manager= @Location_Manager WHERE Location_ID = @Location_ID", objDBConnect.sqlConn);
		        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_ID", L_ID);
		        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_Name", L_NAME);
		        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_City", L_CITY);
		        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_NumVehicles", L_VEHICLES);
		        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_NumEmployees", L_EMPLOYEES);
		        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_Manager", L_MANAGER);
                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                MessageBox.Show("SUCCESSFULLY UPDATED");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Update Location Details: " + ex.Message);
            }

        }

        public void getValues()
        {
            L_ID = txtLocationID.Text;
            L_NAME = cboLocationName.SelectedItem.ToString();
            L_CITY = cboCity.SelectedItem.ToString();
            L_PROVINCE = cboProvince.SelectedItem.ToString();
            L_VEHICLES = int.Parse(updVehicles.Text);
            L_EMPLOYEES = int.Parse(updEmployees.Text);
            L_MANAGER = txtManager.Text;
        }

        private void cboLocationName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
   }
}

