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

namespace FleetTrackingInformationSystem
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writetext = new StreamWriter("RegistrationDetails.txt")) // Creates Text File
                {
                    string dateOfBirth = dtpDateOfBirth.Value.ToShortDateString();
                    string name = txtName.Text;
                    string surname = txtSurname.Text;
                    string userName = txtUserName.Text;
                    string password = txtPass.Text;
                    writetext.WriteLine("Registration Details:"); // Writes to the Text File
                    writetext.WriteLine("Name is: " + name);
                    writetext.WriteLine("Surname is: " + surname);
                    writetext.WriteLine("Date of Birth is: " + dateOfBirth);
                    writetext.WriteLine("User Name is: " + userName);
                    writetext.WriteLine("Password is: " + password);
                }
                MessageBox.Show("Registration Successful");
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
    }
}
