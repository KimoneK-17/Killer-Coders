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
    public partial class frmVehicles : Form
    {
        string V_MILEAGE;
        string V_RN;
        string V_TYPE;
        string V_MAKE;
        string V_MODEL;
        string V_YEAR;
        
     
        public frmVehicles()
        {
            InitializeComponent();
            dtpVehicleYear.Format = DateTimePickerFormat.Custom;
            dtpVehicleYear.CustomFormat = "yyyy";
            dtpVehicleYear.ShowUpDown = true;
            cboType.SelectedItem = "Log"; // Sets the Default value showing in the Drop Down list as Log
            cboType.DropDownStyle = ComboBoxStyle.DropDownList; // Prevents User from inputting Values in the Combo Box, makes the style of the combo box a Drop Down List  
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
                MessageBox.Show("Error! You Cannot Go Back To Previous Form: " + ex.Message);
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
                MessageBox.Show("Error! You Cannot Exit This Application: " + ex.Message); // Shows an error message
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtRegNum.Clear();
                txtMileage.Clear();
                txtModel.Clear();
                txtMake.Clear();
            }
            catch(Exception ex)
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Error! You Cannot Clear The Form: " + ex.Message); // Shows an error message
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            getValues();
            
            Check check = new Check();
            bool exit = false;

            exit = check.CheckEmpty(V_MILEAGE, "Vehicle Milage", exit);
            exit = check.CheckEmpty(V_MAKE, "Vehicle Make", exit);
            exit = check.CheckEmpty(V_MODEL, "Vehicle Model", exit);
            exit = check.CheckEmpty(V_RN, "Registration Number", exit);
            exit = check.CheckEmpty(V_TYPE, "Type of Vehicle", exit);
            exit = check.CheckForLetters(V_MILEAGE, "Vehicle Milage");

            if (exit == false)
            {
                try
                {
                    DBConnect objDBConnect = new DBConnect();

                    objDBConnect.OpenConnection();

                    objDBConnect.sqlCmd = new SqlCommand("INSERT INTO Vehicle VALUES (@Vehicle_RegNumber, @Vehicle_Type, @Vehicle_Make, @Vehicle_Model, @Vehicle_Year, @Vehicle_TotalMileage)", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_Type", V_TYPE);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_Make", V_MAKE);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_Model", V_MODEL);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_Year", V_YEAR);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_TotalMileage", V_MILEAGE);

                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                    MessageBox.Show("Successfully Inserted");
                    objDBConnect.sqlDR.Close();
                    objDBConnect.sqlConn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error here"+ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! You Cannot Submit Vehicle Details: " + ex.Message);
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

                string sql = "DELETE FROM Vehicle WHERE (Vehicle_RegNumber ='" + V_RN + "');";

                objDBConnect.sqlCmd = new SqlCommand();
                objDBConnect.sqlCmd.CommandText = sql;
                objDBConnect.sqlCmd.Connection = objDBConnect.sqlConn;

                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                MessageBox.Show("SUCCESSFUL");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! You Cannot Delete Vehicle Details: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getValues();
            try
            {
              DBConnect objDBConnect = new DBConnect();

              objDBConnect.OpenConnection();
              objDBConnect.sqlCmd = new SqlCommand("UPDATE Vehicle SET Vehicle_Type=@Vehicle_Type, Vehicle_Make=@Vehicle_Make, Vehicle_Model=@Vehicle_Model, Vehicle_Year=@Vehicle_Year,Vehicle_TotalMileage= @Vehicle_TotalMileage WHERE Vehicle_RegNumber=@Vehicle_RegNumber ", objDBConnect.sqlConn);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_Type", V_TYPE);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_Make", V_MAKE);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_Model", V_MODEL);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_Year", V_YEAR);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_TotalMileage", V_MILEAGE);
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
                MessageBox.Show("Error! You Cannot Update Vehicle Details: " + ex.Message);
            }
        }
        private void getValues()
        {
            V_MILEAGE = txtMileage.Text;
            V_MAKE = txtMake.Text;
            try
            {
                V_TYPE = this.cboType.GetItemText(this.cboType.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cobobox error: " + ex.Message);
            }
            V_MODEL = txtModel.Text;
            V_YEAR = dtpVehicleYear.Text;
            V_RN = txtRegNum.Text;
        }
    }
}
