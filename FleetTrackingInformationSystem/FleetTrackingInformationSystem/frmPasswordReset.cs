using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FleetTrackingInformationSystem
{
    public partial class frmPasswordReset : Form
    {
        string username;
        string oldPass;
        string newPass1;
        string newPass2;

        public frmPasswordReset()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool exit = false;
            Check check = new Check();
            username = txtUsername.Text;
            oldPass = txtOldPass.Text;
            newPass1 = txtNewPass.Text;
            newPass2 = txtNewPass.Text;

            exit = check.CheckEmpty(username, "Username", exit);
            exit = check.CheckEmpty(oldPass, "Old Password", exit);
            exit = check.CheckEmpty(newPass1, "New Password", exit);
            exit = check.CheckEmpty(newPass2, "Confirm New Password", exit);

            if (exit == false)
            {
                if (newPass1 == newPass2)
                {
                    DBConnect objDBConnect = new DBConnect();

                    objDBConnect.OpenConnection();
                    objDBConnect.sqlCmd = new SqlCommand("UPDATE Register SET R_PWORD = @R_PWORD WHERE R_UNAME = @R_UNAME", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@R_PWORD", newPass1);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@R_UNAME", username);
                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                    objDBConnect.sqlDR.Close();
                    MessageBox.Show("Susccessfully Updated");
                }
                else
                {
                    MessageBox.Show("The password fields do not match");
                }
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmLogin log = new frmLogin();
                log.Show(); // Goes back to Login Form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Logout of System: " + ex.Message); // Shows an error message
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
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
    }
}
