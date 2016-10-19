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
    public partial class frmTimesheet : Form
    {
        public frmTimesheet()
        {
            InitializeComponent();
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
            catch(Exception ex)
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
            catch(Exception ex)
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
            catch(Exception ex)
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
            T_HOURS = int.Parse(updHoursWorked.Text);



            try
            {
                Check check = new Check();
                bool executeSQL = check.CheckDB("Timesheet", "T_ID", T_ID.ToString());
                if (executeSQL == false)
                {
                    DBConnect objDBConnect = new DBConnect();

                    objDBConnect.OpenConnection();

                    objDBConnect.sqlCmd = new SqlCommand("INSERT INTO Timesheet VALUES (@T_ID, @Emp_ID, @T_HOURS,T_DATE = GETDATE())", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@T_ID", T_ID);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ID", E_ID);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@T_HOURS", T_HOURS);


                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                    MessageBox.Show("SUCCESSFULLY INSERTED");
                    objDBConnect.sqlDR.Close();
                    objDBConnect.sqlConn.Close();
                }
                else
                {
                    MessageBox.Show("That Timesheet ID already exists in the database");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Submit Vehicle Details: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

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
        }
    }
}
