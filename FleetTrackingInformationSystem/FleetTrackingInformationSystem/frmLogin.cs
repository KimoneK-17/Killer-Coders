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
        string userName;
        string password;
        string line;
        string name;
        string pass;
        System.IO.StreamReader file;
        string[] arrUserCred;
        int count = 0;
        bool found = false;
        //declarations
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Clear(); // Clears the Text Box
            txtPass.Clear();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try // Tries the Code
            {
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
                userName = txtUser.Text; // Gets the Username from Text Box
                password = txtPass.Text; // Gets Password from Text box
                    //this.Hide();
                    //MessageBox.Show("Login Successful");
                    //frmMenu m = new frmMenu();
                    //m.ShowDialog(); //Shows Menu Form  
                if (userName.Equals(""))
                {
                    MessageBox.Show("Please enter Username");

                }
                else
                {
                    if (password.Equals(""))
                    {
                        MessageBox.Show("Please enter Password");
                    }
                    else
                    {


                        try// runs through the code unless exception is thrown
                        {
                            found = false;
                            using (file = new System.IO.StreamReader("UserCred.txt"))// Read the file and display it line by line. 
                            {

                                while ((line = file.ReadLine()) != null && found == false)
                                {

                                    arrUserCred = line.Split(',');
                                    name = arrUserCred[3];
                                    pass = arrUserCred[4];// populates array from file

                                    if (userName.ToLower().Equals(name.ToLower()))
                                    {
                                        found = true;
                                        //compares username to ones in file
                                        if (password.Equals(pass))
                                        {
                                            //if username and password match menu screen is shown
                                            frmMenu menu = new frmMenu();
                                            this.Hide();
                                            menu.Show();


                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed Attempt, Incorrect Password");
                                            count++;
                                            //login unsuccessful
                                        }

                                    }

                                    if (((line = file.ReadLine()) == null) && (!(name.ToLower().Equals(userName))))
                                    {
                                        //MessageBox.Show("Failed Attempt, Incorrect Username");
                                        count++;
                                        //cannot find username in file
                                    }
                                    try
                                    {
                                        if (!(name.ToLower().Contains(userName.ToLower())))
                                        {

                                        }
                                    }
                                    catch
                                    {

                                    }

                                }


                            }
                            if (found == false)
                            {
                                MessageBox.Show("Cannot find user is system, please check username or register account");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\n" + ex.StackTrace);

                        }
                    }

                }

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
