using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace FleetTrackingInformationSystem
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }
        string R_DOB;
        string R_NAME;
        string R_SNAME;
        string R_UNAME;
        string R_PWORD;
        string R_EMAIL = "myvcemail@gmail.com";
        string R_EPWORD = "ice-cream2";
        string R_CURRDATE;
        string R_EMPPOS;
        string S_ID;
        string V_RN;
        string E_ID;
        string S_DATE;
        string S_DES;

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmLogin log = new frmLogin(); // Goes back to Login Form
                log.ShowDialog();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtName.Clear(); // Clears Text Box
                txtSurname.Clear();
                txtUserName.Clear();
                txtPass.Clear();
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

        private string CurrDate(string date)
        {
            DateTime localDate = DateTime.Now;

            var culture = new CultureInfo("en-GB");
         date = localDate.ToString(culture);

          return date;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            R_DOB = dtpDateOfBirth.Value.ToShortDateString();
            R_NAME = txtName.Text;
            R_SNAME = txtSurname.Text;
            R_UNAME = txtUserName.Text;
            R_PWORD = txtPass.Text;
            R_CURRDATE = CurrDate(R_CURRDATE);
            R_EMPPOS = cboEmpPosition.SelectedItem.ToString();

            Cursor.Current = Cursors.WaitCursor;//this is used to show the user that a process is occuring
            try
            {
              string s = R_DOB + "," + R_NAME + "," + R_SNAME + "," + R_UNAME + "," + R_PWORD;

              using (StreamWriter writer = File.AppendText("UserCred.txt"))
              {
                  writer.WriteLine(s);
              }

                //try
                //{

                //    SmtpClient client = new SmtpClient("smtp.gmail.com");
                //    client.Port = 587;
                //    client.EnableSsl = true;
                //    client.Timeout = 100000;
                //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //    client.UseDefaultCredentials = false;

                //    client.Credentials = new NetworkCredential(
                //      emailAddress, emailPass);//logins into your email account

                //    //gets values from the textboxes
                //    MailMessage msg = new MailMessage();
                //    msg.To.Add(txtEmail.Text);
                //    msg.From = new MailAddress(emailAddress);//checks that email address exists
                //    msg.Subject = "Successful Registration - Fleet Tracking Application";
                //    msg.Body = "Hello " + regName.ToUpper() + " " + regSname.ToUpper() + "\n\nThis is confirmation indicating that you have successfully registered to use the Fleet Tracking Application. \n\nDate: " + currDate + "\nUser Name: " + userName + "\n(Use this to log into the application, along with your password)\n\nKind Regards,\nFleet Tracking Team\n(0312521212)";

                //    client.Send(msg);

                //    Cursor.Current = Cursors.Default;// when processing is done default curser will appear
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Email Confirmation Not Sent:\n" + ex.Message);
                //}


                MessageBox.Show("Registration Successful\nConfirmation Email Sent to: " + R_EMAIL);

                this.Hide();
                frmLogin log = new frmLogin();
                log.ShowDialog(); // Goes back to Login Form
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
            DBConnect objDBConnect = new DBConnect();

            objDBConnect.OpenConnection();

              objDBConnect.sqlCmd = new SqlCommand("UPDATE Service VALUES (@Service_ID, @Vehicle_RegNumber, @Emp_ID, @Service_Date, @Service_Description)",objDBConnect.sqlConn);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Service_ID", S_ID);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ID", E_ID);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Service_Date", S_DATE);
		      objDBConnect.sqlCmd.Parameters.AddWithValue("@Service_Description", S_DES);

                MessageBox.Show("SUCCESSFULLY INSERTED");
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
