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
    public partial class frmCustomer : Form
    {
        string C_ID;
        string C_NAME;
        string C_SNAME;
        string C_TYPE;
        string C_CONTACT;
        string C_EMAIL;
        string C_DUE;
        string C_MADE;
        string[] numbers = new string[10];
        bool success = false;
        public frmCustomer()
        {
            InitializeComponent();

            cboCustomer.SelectedItem = "Vehicle Hire"; // Sets the Default value showing in the Drop Down list as Vehicle Hire
            cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList; // Prevents User from inputting Values in the Combo Box, makes the style of the combo box a Drop Down List  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMenu men = new frmMenu(); // Goes back to the Menu Form
                men.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Go back to Previous Form: " + ex.Message); // Shows an error message
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
                txtContact.Clear();
                txtEmail.Clear();
                txtID.Clear();
                txtName.Clear(); // Clears Text Box
                txtPaymentDue.Clear();
                txtPaymentMade.Clear();
                txtSurname.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Clear the Form: " + ex.Message); // Shows an error message 
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            C_ID = txtID.Text;
            C_EMAIL = txtEmail.Text;
            try
            {
                var addr = new System.Net.Mail.MailAddress(C_EMAIL);// validates email address
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Validate Email Address: " + ex.Message);
            }

            Check check = new Check();
            bool exit = false;

            try
            {

                C_TYPE = this.cboCustomer.GetItemText(this.cboCustomer.SelectedItem);
                //C_TYPE = cboCustomer.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cobobox error: " + ex.Message);
            }

            C_CONTACT = txtContact.Text;
            C_DUE = txtPaymentDue.Text;
            C_MADE = txtPaymentMade.Text;
            C_NAME = txtName.Text;
            C_SNAME = txtSurname.Text;

            
                exit = check.CheckEmpty(C_TYPE, "Customer Type");
                exit = check.CheckEmpty(C_CONTACT, "Customer Contact Number");
                exit = check.CheckEmpty(C_DUE, "Payment Due");
                exit = check.CheckEmpty(C_MADE, "Payment Made");
                exit = check.CheckEmpty(C_NAME, "Customer Name");
                exit = check.CheckEmpty(C_SNAME, "Customer Surname");
                exit = check.CheckForNumbers(C_NAME, "Customer Name");
                exit = check.CheckForNumbers(C_SNAME, "Customer Surname");
                exit = check.CheckForLetters(C_CONTACT, "Customer Contact Number");
                exit = check.CheckForLetters(C_DUE, "Payment Due");
                exit = check.CheckForLetters(C_MADE, "Payment Made");

             


            if (exit == false)
            {
                try
                {
                    bool executeSQL = check.CheckDB("Customer", "Cust_ID", C_ID);
                    if (executeSQL == false)
                    {
                        DBConnect objDBConnect = new DBConnect();

                        objDBConnect.OpenConnection();

                        objDBConnect.sqlCmd = new SqlCommand("INSERT INTO Customer VALUES (@Cust_ID, @Cust_Name, @Cust_Surname, @Cust_Type, @Cust_ContactNo,@Cust_Email, @Cust_PayDue, @Cust_PayMade)", objDBConnect.sqlConn);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_ID", C_ID);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_Name", C_NAME);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_Surname", C_SNAME);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_Type", C_TYPE);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_ContactNo", C_CONTACT);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_Email", C_EMAIL);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_PayDue", C_DUE);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_PayMade", C_MADE);

                        objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                        MessageBox.Show("Successfully Inserted");
                        objDBConnect.sqlDR.Close();
                        objDBConnect.sqlConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("That Customer ID already exists in the database");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Cannot Add Customer Details: " + ex.Message + ex.Data + ex.StackTrace);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                string sql = "DELETE FROM Customer WHERE (Cust_ID ='" + C_ID + "');";

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
                MessageBox.Show("Error Cannot Delete Customer Details: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("UPDATE Customer SET Cust_Name= @Cust_Name, Cust_Surname=@Cust_Surname, Cust_Type=@Cust_Type, Cust_ContactNo=@Cust_ContactNo,Cust_Email=@Cust_Email, Cust_PayDue=@Cust_PayDue, Cust_PayMade=@Cust_PayMade WHERE Cust_ID = @Cust_ID", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_ID", C_ID);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_Name", C_NAME);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_Surname", C_SNAME);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_Type", C_TYPE);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_ContactNo", C_CONTACT);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_Email", C_EMAIL);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_PayDue", C_DUE);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_PayMade", C_MADE);

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
                MessageBox.Show("Error Cannot Update Customer Details: " + ex.Message);
            }
        }


    }
}
