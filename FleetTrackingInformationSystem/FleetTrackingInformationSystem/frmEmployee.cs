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
        int intTryParseOut;
        double doubleTryParseOut;
        string[] numbers = new string[10];
        
        public frmEmployee()
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
            catch(Exception ex)
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
            catch(Exception ex)
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
                updHours.Value = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Clear the Form: " + ex.Message); // Shows an error message
            }
        }

        public void CheckForNumbers(string name, string surname)
        {
            try
            {
                for (int x = 0; x < numbers.Length; x++)
                {
                    numbers[x] = (x + 1).ToString();
                    if (name.Contains(numbers[x]))
                    {
                        MessageBox.Show("The 'Customer Name' field cannot contain numbers");
                    }
                    if (surname.Contains(numbers[x]))
                    {
                        MessageBox.Show("The 'Customer Surname' field cannot contain numbers");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Check For Numbers: " + ex.Message); // Shows an error message
            }
        }

        public void CheckForLetters(string contact, string salary)
        {
            try
            {
                if (int.TryParse(contact, out intTryParseOut) == false)
                {
                    MessageBox.Show("The 'Contact Number' field cannot contain letters");
                }
                if (double.TryParse(salary, out doubleTryParseOut) == false)
                {
                    MessageBox.Show("The 'Monthly Salary' field cannot contain letters");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Check For Letters: " + ex.Message); // Shows an error message
            }
        }

        public void CheckEmpty()
        {
            try
            {
                if (txtName.Text == string.Empty)
                {
                    MessageBox.Show("The 'Employee Name' field is empty");
                }
                if (txtSurname.Text == string.Empty)
                {
                    MessageBox.Show("The 'Employee Surname' field is empty");
                }
                if (txtID.Text == string.Empty)
                {
                    MessageBox.Show("The 'Employee ID' field is empty");
                }
                if (cboPosition.Text == string.Empty)
                {
                    MessageBox.Show("Select the employee position from the drop down list");
                }
                if (txtAddress.Text == string.Empty)
                {
                    MessageBox.Show("The 'Employee Address' field is empty");
                }
                if (txtContactNum.Text == string.Empty)
                {
                    MessageBox.Show("The 'Contact Number' field is empty");
                }
                if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("The 'Email Address' field is empty");
                }
                if (txtSalary.Text == string.Empty)
                {
                    MessageBox.Show("The 'Monthly Salary' field is empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Check if Fields are Empty: " + ex.Message); // Shows an error message
            }
        }

        bool accepted;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            E_ID = txtID.Text;
            E_NAME = txtName.Text;
            E_SNAME = txtSurname.Text;
            E_POS = cboPosition.SelectedItem.ToString();
            E_CONTACT = txtContactNum.Text;
            E_EMAIL = txtEmail.Text;
            try
            {
                var addr = new System.Net.Mail.MailAddress(E_EMAIL);// validates email address
                accepted = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Invalid email address: " + ex.Message); // Shows an error message
            }
            E_SALARY = txtSalary.Text;

            Employee objEmp = new Employee(E_ID,E_NAME,E_SNAME,E_POS,E_CONTACT,E_EMAIL,E_SALARY);
            CheckEmpty();
            CheckForNumbers(E_NAME, E_SNAME);
            CheckForLetters(E_CONTACT, E_SALARY);
            if (accepted == true)
            {
                try
                {
                    DBConnect objDBConnect = new DBConnect();

                    objDBConnect.OpenConnection();

                    objDBConnect.sqlCmd = new SqlCommand("INSERT INTO Employee VALUES (@Emp_ID, @Emp_Name, @Emp_Surname, @Emp_Position, @Emp_ContactNo, @Emp_Email, @Emp_MonthlySalary)", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ID", E_ID);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Name", E_NAME);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Surname", E_SNAME);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Position", E_POS);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ContactNo", E_CONTACT);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Email", E_EMAIL);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_MonthlySalary", E_SALARY);

                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                    string message = objEmp.SuccessMessage();
                    MessageBox.Show(message);
                    objDBConnect.sqlDR.Close();
                    objDBConnect.sqlConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Cannot Add Employee Details: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
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
            catch (Exception ex)
            {

                MessageBox.Show("Error Cannot Delete Employee Details: " + ex.Message); // Shows an error message
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
               DBConnect objDBConnect = new DBConnect();

               objDBConnect.OpenConnection();

		       objDBConnect.sqlCmd = new SqlCommand("UPDATE Employee VALUES (@Emp_ID, @Emp_Name, @Emp_Surname, @Emp_Position, @Emp_ContactNo, @Emp_Email, @Emp_MonthlySalary)",objDBConnect.sqlConn);
		       objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ID", E_ID);
		       objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Name", E_NAME);
		       objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Surname", E_SNAME);
		       objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Position", E_POS);
		       objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ContactNo", E_CONTACT);
		       objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_Email", E_EMAIL);
		       objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_MonthlySalary", E_SALARY);
		       objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

               MessageBox.Show("SUCCESSFULLY UPDATED");
               objDBConnect.sqlDR.Close();
               objDBConnect.sqlConn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Update Employee Details: " + ex.Message); // Shows an error message
            }
        }
    }
}
