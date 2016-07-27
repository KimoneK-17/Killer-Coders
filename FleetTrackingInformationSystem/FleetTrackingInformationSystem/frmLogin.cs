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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Clear(); // Clears the Text Box
            txtPass.Clear();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try // Tries the Code
            {
                string userName = txtUser.Text; // Gets the Username from Text Box
                string password = txtPass.Text; // Gets Password from Text box
                this.Hide(); // Will Hide this Form
                frmRegistration reg = new frmRegistration(); // Creates an Object 
                reg.ShowDialog(); // Shows the Registration Form
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

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {        
                    this.Hide();
                    MessageBox.Show("Login Successful");
                    frmMenu m = new frmMenu();
                    m.ShowDialog(); //Shows Menu Form  
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
    }
}
