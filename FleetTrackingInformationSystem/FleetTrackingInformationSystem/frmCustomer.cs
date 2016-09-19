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
        int intTryParseOut;
        double doubleTryParseOut;
        string C_CONTACT;
        string C_EMAIL;
        string C_DUE;
        string C_MADE;
        string[] numbers = new string[10];

        public frmCustomer()
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

        public void CheckForNumbers(string name, string surname)
        {
            for (int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = (x + 1).ToString();
                if(name.Contains(numbers[x]))
                {
                    MessageBox.Show("The 'Customer Name' field cannot contain numbers");
                }
                if(surname.Contains(numbers[x]))
                {
                    MessageBox.Show("The 'Customer Surname' field cannot contain numbers");
                }
            }
        }

        public void CheckForLetters(string contact, string paymentMade, string PaymentDue)
        {
            if(int.TryParse(contact, out intTryParseOut) == false)
            {
                MessageBox.Show("The 'Contact Number' field cannot contain letters or symbols");
            }
            if(double.TryParse(PaymentDue, out doubleTryParseOut) == false)
            {
                MessageBox.Show("The 'Payment Due' field cannot contain letters or symbols");
            }
            if(double.TryParse(paymentMade, out doubleTryParseOut) == false)
            {
                MessageBox.Show("The 'Payment Made' field cannot contain letters or symbols");
            }
        }

        public void CheckEmpty()
        {
            if(txtID.Text == string.Empty)
            {
                MessageBox.Show("The 'Customer ID' field is empty");
            }
            if(txtName.Text == string.Empty)
            {
                MessageBox.Show("The 'Customer Name' field is empty");
            }
            if(txtSurname.Text == string.Empty)
            {
                MessageBox.Show("The 'Customer Surname' field is empty");
            }
            if(cboCustomer.Text == string.Empty)
            {
                MessageBox.Show("Please select a customer type from the drop down list");
            }
            if(txtContact.Text == string.Empty)
            {
                MessageBox.Show("The 'Contact Number' field is empty");
            }
            if(txtEmail.Text == string.Empty)
            {
                MessageBox.Show("The 'Email Address' field is empty");
            }
            if(txtPaymentDue.Text == string.Empty)
            {
                MessageBox.Show("The 'Payment Due' field is empty");
            }
            if(txtPaymentMade.Text == string.Empty)
            {
                MessageBox.Show("The 'Payment Made' field is empty");
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
                MessageBox.Show("Error" + ex.Message);
            }
            C_TYPE = cboCustomer.SelectedItem.ToString();
            C_CONTACT = txtContact.Text;
            C_DUE = txtPaymentDue.Text;
            C_MADE = txtPaymentMade.Text;
            C_NAME = txtName.Text;
            C_SNAME = txtSurname.Text;
            CheckEmpty();
            CheckForNumbers(C_NAME, C_SNAME);
            CheckForLetters(C_CONTACT, C_MADE, C_DUE);

            try
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

                string sql = "DELETE FROM Customer WHERE (Cust_ID ='" + C_ID + "');";

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("UPDATE Customer VALUES (@Cust_ID, @Cust_Name, @Cust_Surname, @Cust_Type, @Cust_ContactNo,@Cust_Email, @Cust_PayDue, @Cust_PayMade)", objDBConnect.sqlConn);
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

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }                        
        }       
    }
}
