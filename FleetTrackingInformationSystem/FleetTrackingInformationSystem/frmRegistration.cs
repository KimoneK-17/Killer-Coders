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
        string R_EMAIL;
        string R_MEMAIL = "myvcemail@gmail.com";
        string R_EPWORD = "ice-cream2";
        string R_CURRDATE;
        string R_EMPPOS;


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

        private void btnClear_Click(object sender, EventArgs e)
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
            Cursor.Current = Cursors.WaitCursor;//this is used to show the user that a process is occuring

            R_DOB = dtpDateOfBirth.Value.ToShortDateString();
            R_NAME = txtName.Text;
            R_SNAME = txtSurname.Text;
            R_UNAME = txtUserName.Text;
            R_PWORD = txtPass.Text;
            R_EMAIL = txtEmail.Text;
            R_CURRDATE = CurrDate(R_CURRDATE);
            R_EMPPOS = cboEmpPosition.SelectedItem.ToString();
            bool email = false;

            if (!R_NAME.Equals(""))
            {
                if (!R_SNAME.Equals(""))
                {
                    if (!(cboEmpPosition.SelectedIndex < 0))
                    {
                        if (!R_EMAIL.Equals(""))
                        {
                            try
                            {
                                var addr = new System.Net.Mail.MailAddress(R_EMAIL);// validates email address
                                email = true;
                            }
                            catch
                            {

                            }
                            if (email == true)
                            {
                                if (!R_UNAME.Equals(""))
                                {
                                    if(!R_PWORD.Equals(""))
                                    {
                                        try
                                        {
                                            DBConnect objDBConnect = new DBConnect();
                                            objDBConnect.OpenConnection();

                                            objDBConnect.sqlCmd = new SqlCommand("INSERT INTO Register VALUES (@R_DOB, @R_NAME, @R_SNAME,@R_EMPPOS,@R_UNAME, @R_PWORD)", objDBConnect.sqlConn);
                                            objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DOB", R_DOB);
                                            objDBConnect.sqlCmd.Parameters.AddWithValue("@R_NAME", R_NAME);
                                            objDBConnect.sqlCmd.Parameters.AddWithValue("@R_SNAME", R_SNAME);
                                            objDBConnect.sqlCmd.Parameters.AddWithValue("@R_EMPPOS", R_EMPPOS);
                                            objDBConnect.sqlCmd.Parameters.AddWithValue("@R_UNAME", R_UNAME);
                                            objDBConnect.sqlCmd.Parameters.AddWithValue("@R_PWORD", R_PWORD);


                                            objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                                            objDBConnect.sqlDR.Close();
                                            objDBConnect.sqlConn.Close();

                                            try
                                            {


                                                string s = R_DOB + "," + R_NAME + "," + R_SNAME + "," + R_EMPPOS + "," + R_UNAME + "," + R_PWORD;

                                                try
                                                {

                                                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                                                    client.Port = 587;
                                                    client.EnableSsl = true;
                                                    client.Timeout = 100000;
                                                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                                                    client.UseDefaultCredentials = false;

                                                    client.Credentials = new NetworkCredential(
                                                      R_MEMAIL, R_EPWORD);//logins into your email account

                                                    //gets values from the textboxes
                                                    MailMessage msg = new MailMessage();
                                                    msg.To.Add(txtEmail.Text);
                                                    msg.From = new MailAddress(R_MEMAIL);//checks that email address exists
                                                    msg.Subject = "Successful Registration - Fleet Tracking Application";
                                                    msg.Body = "Hello " + R_NAME.ToUpper() + " " + R_SNAME.ToUpper() + "\n\nThis is confirmation indicating that you have successfully registered to use the Fleet Tracking Application. \n\nDate: " + R_CURRDATE + "\nUser Name: " + R_UNAME + "\n(Use this to log into the application, along with your password)\n\nKind Regards,\nFleet Tracking Team\n(0312521212)";

                                                    client.Send(msg);

                                                    Cursor.Current = Cursors.Default;// when processing is done default curser will appear
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show("Email Confirmation Not Sent:\n" + ex.Message);
                                                }


                                                MessageBox.Show("Registration Successful\nConfirmation Email Sent to: " + R_MEMAIL);

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
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Error" + ex.Message);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Enter A Password");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please Enter a Username");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Email Address: "+R_EMAIL);
                            }


                        }
                        else
                        {
                            MessageBox.Show("Please Enter Your Email Address");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select The Employees Position");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Your Surname");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Name");
            }
            
        }

    }
}
