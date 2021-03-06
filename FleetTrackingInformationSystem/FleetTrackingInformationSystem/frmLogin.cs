﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace FleetTrackingInformationSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            toolTip();
        }
        string userName;
        string password;
      
        bool found;
        bool checkValid;
        
        //declarations

        DBConnect objDBConnect = new DBConnect();
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
                reg.Show(); // Shows the Registration Form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Go To Registration Form: " + ex.Message + "\n" + ex.StackTrace); // Shows an error message
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

            try
            {
                userName = txtUser.Text; // Gets the Username from Text Box
                password = txtPass.Text; // Gets Password from Text box
                    
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
                            CheckExisting();
                            
                            if (found == false)
                            {
                                MessageBox.Show("Cannot find user is system, please check username or register account");
                            }
                            else
                            {
                                if(found == true)
                                {
                                    CheckValid();

                                    if(checkValid == true)
                                    {
                                        frmMenu mnu = new frmMenu();

                                        this.Hide();
                                        mnu.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid password entered. Please Try Again");
                                    }
                                }
                            }

                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                        }
                        
                        catch (ArgumentOutOfRangeException ex)
                        {
                            MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                        }
                    }
                }
            }                
            
            catch(Exception ex)
            { 
                MessageBox.Show("Error Cannot Login: " + ex.Message); // Shows an error message
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
                MessageBox.Show("Error Cannot Exit The Application: " + ex.Message + "\n" + ex.StackTrace); ; // Shows an error message                             
            }
        }
        
        private void btnPassReset_Click(object sender, EventArgs e)
        {
            //Code adapted from: http://www.codeproject.com/Tips/520998/Send-Email-from-Yahoo-Gmail-Hotmail-Csharp
            Check check = new Check();
            GeneratePassword newPass = new GeneratePassword();
            bool exit = false;
            string tempPass = newPass.GeneratePass(10);
            userName = txtUser.Text;
            exit = check.CheckEmpty(userName, "Username", exit);
            if (exit == false)
            {
                try
                {
                    DBConnect objDBConnect = new DBConnect();

                    objDBConnect.OpenConnection();
                    objDBConnect.sqlCmd = new SqlCommand("UPDATE Register SET R_PWORD = @R_PWORD WHERE R_UNAME = @R_UNAME", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@R_PWORD", tempPass);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@R_UNAME", userName);
                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                    objDBConnect.sqlDR.Close();

                    MessageBox.Show("Successfully updated password");

                    objDBConnect.sqlCmd = new SqlCommand("SELECT R_EMAIL FROM Register WHERE R_UNAME = @R_UNAME", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@R_UNAME", userName);
                    string email = ((string)objDBConnect.sqlCmd.ExecuteScalar());
                    objDBConnect.sqlConn.Close();

                    string smtpAddress = "smtp.gmail.com";
                    int portNumber = 587;
                    bool enableSSL = true;

                    string emailFrom = "cargofleetdonotreply@gmail.com";
                    string password = "Pass123456";
                    string emailTo = email;
                    string subject = "Password Reset";
                    string body = "You have requested a password reset, your new temporary password/Security Code is: " + tempPass + ". Please change your password as soon as possible.";
                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress(emailFrom);
                        mail.To.Add(emailTo);
                        mail.Subject = subject;
                        mail.Body = body;
                        mail.IsBodyHtml = false;

                        using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                        {
                            smtp.Credentials = new NetworkCredential(emailFrom, password);
                            smtp.EnableSsl = enableSSL;
                            smtp.Send(mail);
                            MessageBox.Show("An email has been sent. If you do not receive the email within 5 minutes check that the username you entered is correct");
                        }
                    }
                    this.Hide();
                    frmPasswordReset passReset = new frmPasswordReset();
                    passReset.Show();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (SmtpFailedRecipientException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (SmtpException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CheckExisting()
        {
            try
            {
                string existName;
                //checks to see if patient already exists in database
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("SELECT COUNT(*) FROM Register WHERE R_UNAME LIKE @R_UNAME;", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_UNAME", userName);
                //parameter
                existName = objDBConnect.sqlCmd.ExecuteScalar().ToString();
                //assigning query to variable
                if (int.Parse(existName) > 0)
                {
                    found = true;
                    //in database
                }
                else
                {
                    found = false;
                    //not in database
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Check If User  Exists In Database: " + ex.Message); // Shows an error message
            }
        }

        private void CheckValid()
        {
            try
            {
                string checkVal;
                //checks to see if patient already exists in database
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("SELECT COUNT(*) FROM Register WHERE R_UNAME LIKE @R_UNAME AND R_PWORD LIKE @R_PWORD;", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_UNAME", userName);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_PWORD", password);

                //parameter
                checkVal = objDBConnect.sqlCmd.ExecuteScalar().ToString();
                //assigning query to variable
                if (int.Parse(checkVal) > 0)
                {
                    checkValid = true;
                    //in database
                }
                else
                {
                    checkValid = false;
                    //not in database
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Check Validation of Users In Database: " + ex.Message); // Shows an error message
            }
        }

        public void toolTip()
        {
            try
            {
                // tooltip properties
                int ttAutoDelay = 5000;
                int ttInitDelay = 1000;
                int ttRshwDelay = 500;

                //tooltips
                ToolTip objTooltipBtnLogin = new ToolTip();
                objTooltipBtnLogin.AutoPopDelay = ttAutoDelay;
                objTooltipBtnLogin.InitialDelay = ttInitDelay;
                objTooltipBtnLogin.ReshowDelay = ttRshwDelay;
                objTooltipBtnLogin.SetToolTip(this.btnLog, "Login to the Fleet Tracking system");

                ToolTip objTooltipBtnClear = new ToolTip();
                objTooltipBtnClear.AutoPopDelay = ttAutoDelay;
                objTooltipBtnClear.InitialDelay = ttInitDelay;
                objTooltipBtnClear.ReshowDelay = ttRshwDelay;
                objTooltipBtnClear.SetToolTip(this.btnClear, "Clear login details");

                ToolTip objTooltipBtnPassReset = new ToolTip();
                objTooltipBtnPassReset.AutoPopDelay = ttAutoDelay;
                objTooltipBtnPassReset.InitialDelay = ttInitDelay;
                objTooltipBtnPassReset.ReshowDelay = ttRshwDelay;
                objTooltipBtnPassReset.SetToolTip(this.btnPassReset, "Takes you to the password reset form");

                ToolTip objTooltipBtnReg = new ToolTip();
                objTooltipBtnReg.AutoPopDelay = ttAutoDelay;
                objTooltipBtnReg.InitialDelay = ttInitDelay;
                objTooltipBtnReg.ReshowDelay = ttRshwDelay;
                objTooltipBtnReg.SetToolTip(this.btnReg, "Register to the Fleet Tracking System");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void chbShow_CheckedChanged(object sender, EventArgs e)
        {
            password = txtPass.Text;
            txtPass.PasswordChar = '\0';//plain text
            if(chbShow.Checked==true)
            {
                txtPass.Text = password;//sets textbox to plain text password
            }
            else
            {
                txtPass.PasswordChar = '*';//password hidden

            }
        }//shows password

        

    }
}
