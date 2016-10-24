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
    public partial class frmEmployee : Form
    {
        string E_ID;
        string E_NAME;
        string E_SNAME;
        string E_POS;
        string E_CONTACT;
        string E_EMAIL;
        string E_SALARY;
        string E_ADDRESS;

        string[] numbers = new string[10];
        bool success = false;
        public frmEmployee()
        {
            InitializeComponent();

            cboPosition.SelectedItem = "Manager"; // Sets the Default value showing in the Drop Down list as Manager
            cboPosition.DropDownStyle = ComboBoxStyle.DropDownList; // Prevents User from inputting Values in the Combo Box, makes the style of the combo box a Drop Down List  
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
                MessageBox.Show("Error Cannot Go Back to Previous Form: " + ex.Message); // Shows an Error Message
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
                txtAddress.Clear();
                txtContactNum.Clear();
                txtEmail.Clear();
                txtID.Clear();
                txtName.Clear();
                txtSalary.Clear();
                txtSurname.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Clear the Form: " + ex.Message); // Shows an error message
            }
        }

        bool accepted;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            bool exit = false;

            getValues();
            try
            {
                var addr = new System.Net.Mail.MailAddress(E_EMAIL);// Validates email address
                accepted = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Invalid email address: " + ex.Message); // Shows an error message
            }
            E_SALARY = txtSalary.Text;

            Employee objEmp = new Employee(E_ID, E_NAME, E_SNAME, E_POS, E_CONTACT, E_EMAIL, E_SALARY);

            exit = check.CheckEmpty(E_NAME, "Employee Name", exit);
            exit = check.CheckEmpty(E_ID, "Employee ID", exit);
            exit = check.CheckEmpty(E_SNAME, "Employee Surname", exit);
            exit = check.CheckEmpty(E_POS, "Employee Position", exit);
            exit = check.CheckEmpty(E_CONTACT, "Employee Contact", exit);
            exit = check.CheckEmpty(E_EMAIL, "Employee Email", exit);
            exit = check.CheckForNumbers(E_NAME, "Employee Name");
            exit = check.CheckForNumbers(E_SNAME, "Employee Surname");
            exit = check.CheckForLetters(E_CONTACT, "Employee Contact Number");
            exit = check.CheckForLetters(E_SALARY, "Employee Salary");
               

            if (accepted == true)
            {
                if (success == true)
                {
                    try
                    {
                        bool executeSQL = check.CheckDB("Employee", "Emp_ID", E_ID);
                        if (executeSQL == false)
                        {
                            DBConnect objDBConnect = new DBConnect();

                            objDBConnect.OpenConnection();

                            objDBConnect.sqlCmd = new SqlCommand("INSERT INTO Employee VALUES (@Emp_ID, @Emp_Name, @Emp_Surname, @Emp_Position,@Emp_Address, @Emp_ContactNo, @Emp_Email, @Emp_MonthlySalary)", objDBConnect.sqlConn);
                            objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ID", E_ID);
                            objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Name", E_NAME);
                            objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Surname", E_SNAME);
                            objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Position", E_POS);
                            objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Address", E_ADDRESS);
                            objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ContactNo", E_CONTACT);
                            objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Email", E_EMAIL);
                            objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_MonthlySalary", E_SALARY);

                            objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                            string message = objEmp.SuccessMessage();
                            MessageBox.Show(message);
                            objDBConnect.sqlDR.Close();
                            objDBConnect.sqlConn.Close();
                        }
                        else
                        {
                            MessageBox.Show("That Employee ID already exists in the database");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Cannot Add Employee Details: " + ex.Message);
                    }
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

                string sql = "DELETE FROM Employee WHERE (Emp_ID ='" + E_ID + "');";

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
                MessageBox.Show("Error Cannot Delete Employee Details: " + ex.Message); // Shows an error message
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getValues();
            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("UPDATE Employee SET Emp_Name=@Emp_Name,Emp_Surname= @Emp_Surname,Emp_Address = @Emp_Address,Emp_Position= @Emp_Position,Emp_ContactNo= @Emp_ContactNo, Emp_Email=@Emp_Email, Emp_MonthlySalary=@Emp_MonthlySalary WHERE Emp_ID = @Emp_ID", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ID", E_ID);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Name", E_NAME);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Surname", E_SNAME);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Address", E_ADDRESS);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Position", E_POS);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ContactNo", E_CONTACT);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Email", E_EMAIL);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_MonthlySalary", E_SALARY);
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
                MessageBox.Show("Error Cannot Update Employee Details: " + ex.Message); // Shows an error message
            }
        }

        public void getValues()
        {
            E_ID = txtID.Text;
            E_NAME = txtName.Text;
            E_SNAME = txtSurname.Text;
            try
            {
                E_POS = this.cboPosition.GetItemText(this.cboPosition.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cobobox error: " + ex.Message);
            }
            E_ADDRESS = txtAddress.Text;
            E_CONTACT = txtContactNum.Text;
            E_EMAIL = txtEmail.Text;
            E_SALARY = txtSalary.Text;

        }       
    }
}
