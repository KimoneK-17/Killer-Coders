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
    public partial class frmService : Form
    {
        string S_ID;
        string V_RN;
        string E_ID;
        string S_DATE;
        string S_TIME;
        string S_DES;
        DBConnect objDBConnect = new DBConnect();
        public frmService()
        {
            InitializeComponent();

            cboAppointTime.SelectedItem = "8:00"; // Sets the Default value showing in the Drop Down list as 8:00 
            cboAppointTime.DropDownStyle = ComboBoxStyle.DropDownList; // Prevents User from inputting Values in the Combo Box, makes the style of the combo box a Drop Down List 

            cboV_RN.DropDownStyle = ComboBoxStyle.DropDownList; // Prevents User from inputting Values in the Combo Box, makes the style of the combo box a Drop Down List 
            cboE_ID.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0); // Exits the Entire Application
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Exit The Application: " + ex.Message); // Shows an error message 
            }
        }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtServiceID.Clear();
                rtfAppointDescription.Clear(); // Clears text Box


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Clear The Form: " + ex.Message); // Shows an error message
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            getValues();
            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                string sql = "DELETE FROM tblService WHERE (Service_ID ='" + S_ID + "');";

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
                MessageBox.Show("Error Cannot Delete Record From Service Table in Database: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getValues();
            try
            {
                Check check = new Check();
                bool executeSQL = check.CheckDB("tblService", "Service_ID", S_ID);
                if (executeSQL == false)
                {
                DBConnect objDBConnect = new DBConnect();
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("INSERT INTO tblService VALUES (@Service_ID, @Vehicle_RegNumber, @Emp_ID, @Service_Date, @Service_Time,@Service_Description)", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Service_ID", S_ID);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ID", E_ID);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Service_Date", SqlDbType.Date).Value = dtpAppointmentDate.Value.Date;
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Service_Time", S_TIME);

                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Service_Description", S_DES);

                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                MessageBox.Show("Succesfully inserted");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();
                }
                else
                {
                    MessageBox.Show("That Service ID already exists in the database");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Add Record to Service Table in Database: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getValues();
            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("UPDATE tblService SET Vehicle_RegNumber=@Vehicle_RegNumber,Emp_ID= @Emp_ID,Service_Date= @Service_Date,Service_Time = @Service_Time,Service_Description = @Service_Description WHERE Service_ID = @Service_ID", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Service_ID", S_ID);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ID", E_ID);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Service_Date", SqlDbType.Date).Value = dtpAppointmentDate.Value.Date ;
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Service_Time", S_TIME);

                objDBConnect.sqlCmd.Parameters.AddWithValue("@Service_Description", S_DES);

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
                MessageBox.Show("Error Cannot Update Details in Service Table: " + ex.Message);
            }
        }

        public void getValues()
        {
            S_ID = txtServiceID.Text; ;
            try
            {
                V_RN = this.cboV_RN.GetItemText(this.cboV_RN.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cobobox error: " + ex.Message);
            }
            try
            {
                E_ID = this.cboE_ID.GetItemText(this.cboE_ID.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cobobox error: " + ex.Message);
            }
            S_DATE = dtpAppointmentDate.Text;
            try
            {
                S_TIME = this.cboAppointTime.GetItemText(this.cboAppointTime.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cobobox error: " + ex.Message);
            }
            S_DES = rtfAppointDescription.Text;
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            populateV_RN();
            populateE_ID();
        }

        public  void populateE_ID()
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Shows an error message
            }
        }

        public void populateV_RN()
        {
            try
            {
                string query = "SELECT Vehicle_RegNumber from Vehicle;";
                objDBConnect.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, objDBConnect.sqlConn);

                DataSet ds = new DataSet();
                da.Fill(ds, "Vehicle");
                cboV_RN.ValueMember = "Vehicle_RegNumber";
                cboV_RN.DisplayMember = "Vehicle_RegNumber";
                cboV_RN.DataSource = ds.Tables["Vehicle"];
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
    }
}
