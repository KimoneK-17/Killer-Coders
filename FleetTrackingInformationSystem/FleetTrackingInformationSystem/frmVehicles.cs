﻿using System;
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
        double doubleTryParseOut;
        string V_RN;
        string V_TYPE;
        string V_MAKE;
        string V_MODEL;
        string V_YEAR;

       
        public frmVehicles()
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
                txtRegNum.Clear();
                txtMileage.Clear();
                txtModel.Clear();
                txtMake.Clear();
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

        public void CheckForLetters(string mileage)
        {
            if (double.TryParse(mileage, out doubleTryParseOut) == false)
            {
                MessageBox.Show("The 'Vehicle Mileage' field cannot contain letters");
            }
        }

        public void CheckEmpty()
        {
            if (txtMake.Text == string.Empty)
            {
                MessageBox.Show("The 'Vehicle Make' field is empty");
            }
            if (txtMileage.Text == string.Empty)
            {
                MessageBox.Show("The 'Vehicle Mileage' field is empty");
            }
            if (txtModel.Text == string.Empty)
            {
                MessageBox.Show("The 'Vehicle Model' field is empty");
            }
            if (txtRegNum.Text == string.Empty)
            {
                MessageBox.Show("The 'Registration Number' field is empty");
            }
            if (cboType.Text == string.Empty)
            {
                MessageBox.Show("Please select a vehicle type from the drop down list");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            V_MILEAGE = txtMileage.Text;
            V_MAKE = txtMake.Text;
            V_TYPE = cboType.SelectedItem.ToString();
            V_MODEL = txtModel.Text;
            V_YEAR = dtpVehicleYear.Value.ToString();
            V_RN = txtRegNum.Text;
            CheckEmpty();
            CheckForLetters(V_MILEAGE);

            try
            {


                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("INSERT INTO Vehicle VALUES (@Vehicle_RegNumber, @Vehicle_Type, @Vehicle_Make, @Vehicle_Model, @Vehicle_Year, @Vehicle_TotalMileage, @Vehicle_RecordNumber)", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_Type", V_TYPE);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_Make", V_MAKE);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_Model", V_MODEL);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_Year", V_YEAR);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_TotalMileage", V_MILEAGE);


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


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                string sql = "DELETE FROM Vehicle WHERE (Vehicle_RegNumber ='" + V_RN + "');";

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
