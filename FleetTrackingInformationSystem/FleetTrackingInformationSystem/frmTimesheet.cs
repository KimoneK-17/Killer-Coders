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
using Microsoft.VisualBasic;

namespace FleetTrackingInformationSystem
{
    public partial class frmTimesheet : Form
    {
        public frmTimesheet()
        {
            InitializeComponent();

            cboE_ID.SelectedItem = "100"; // Sets the Default value showing in the Drop Down list as 100
            cboE_ID.DropDownStyle = ComboBoxStyle.DropDownList; // Prevents User from inputting Values in the Combo Box, makes the style of the combo box a Drop Down List  
        }

        DBConnect objDBConnect = new DBConnect();
        int T_ID;
        string E_ID;
        double T_HOURS;

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMenu men = new frmMenu(); // Goes back to the Menu Form
                men.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Go Back To Previous Form: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0); // Exits the Entire Application
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Exit the Application: " + ex.Message); // Shows an error message
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                updHoursWorked.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Clear The Form: " + ex.Message); // Shows an error message
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            T_ID = int.Parse(txtT_ID.Text);
            E_ID = cboE_ID.SelectedValue.ToString();
            T_HOURS = double.Parse(updHoursWorked.Text);

            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("INSERT INTO Timesheet VALUES (@T_ID, @Emp_ID, @T_HOURS,GETDATE())", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@T_ID", T_ID);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ID", E_ID);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@T_HOURS", T_HOURS);


                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                MessageBox.Show("SUCCESSFULLY INSERTED");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Submit Vehicle Details: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                T_ID = int.Parse(Interaction.InputBox("Please enter Timesheet ID: ", "Timesheet ID", "Default Text"));
                                            
                T_HOURS = double.Parse(Interaction.InputBox("Please enter Number of hours worked: " + T_ID, "Hours Worked", "Default Text"));

            }
            catch (FormatException f)
            {
                MessageBox.Show("Invalid Format. Please only enter digits: " + f.Message);
            }

            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("UPDATE Timesheet SET T_HOURS = @T_HOURS WHERE T_ID = @T_ID", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@T_ID", T_ID);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@T_HOURS", T_HOURS);

                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                MessageBox.Show("SUCCESSFULLY INSERTED");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Submit Vehicle Details: " + ex.Message);
            }
        }

        private void frmTimesheet_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Emp_ID from Employee;";
                objDBConnect.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, objDBConnect.sqlConn);

                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");
                cboE_ID.ValueMember = "Emp_ID";
                cboE_ID.DisplayMember = "Emp_ID";
                cboE_ID.DataSource = ds.Tables["Employee"];
                objDBConnect.sqlConn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                E_ID = this.cboE_ID.GetItemText(this.cboE_ID.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cobobox error: " + ex.Message);
            }
        }
    }
}
