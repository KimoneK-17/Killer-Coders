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
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Microsoft.VisualBasic;

namespace FleetTrackingInformationSystem
{
    public partial class frmTripPlan : Form
    {
        string T_ID;
        string V_RN;
        string T_FROM;
        string T_TO;
        string T_Complete;
        string L_ID;
        string trip_plan;
        DBConnect objDBConnect = new DBConnect();
        public frmTripPlan()
        {
            InitializeComponent();

            cboV_RN.DropDownStyle = ComboBoxStyle.DropDownList; // Prevents User from inputting Values in the Combo Box, makes the style of the combo box a Drop Down List  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMenu men = new frmMenu(); // Goes back to the Menu Form
                men.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Go Back To Previous Form: " + ex.Message);
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
                MessageBox.Show("Error Cannot Exit The Application: " + ex.Message); // Shows an error message
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtTripID.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Clear The Form: " + ex.Message); // Shows an error message 
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            bool exit = false;
            getValues();


            exit = check.CheckEmpty(T_ID, "Trip ID", exit);

            exit = check.CheckEmpty(V_RN, "Vehicle Reg Number", exit);


            if (exit == false)
            {
                if (!T_ID.Equals(""))
                {
                    try
                    {
                        objDBConnect.OpenConnection();

                        objDBConnect.sqlCmd = new SqlCommand("INSERT INTO TripUsage VALUES(@Trip_ID, @Vehicle_RegNumber,@Location_ID, @Trip_DateFrom, @Trip_DateTo,NULL,NULL,NULL,'NO')", objDBConnect.sqlConn);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_ID", T_ID);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_ID", L_ID);

                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value.Date;
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_DateTo", SqlDbType.Date).Value = dtpDateTo.Value.Date;


                        objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                        MessageBox.Show("Succesfully inserted");
                        CloseConnections();


                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("ERROR!!!" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Cannot Submit Details: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Trip ID");
                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            T_ID = Interaction.InputBox("Please enter Trip ID: ", "Trip ID", "Default Text");
            try
            {

                objDBConnect.OpenConnection();

                string sql = "DELETE FROM TripUsage WHERE (Trip_ID ='" + T_ID + "');";

                objDBConnect.sqlCmd = new SqlCommand();
                objDBConnect.sqlCmd.CommandText = sql;
                objDBConnect.sqlCmd.Connection = objDBConnect.sqlConn;

                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                MessageBox.Show("SUCCESS");
                CloseConnections();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Delete Records: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getValues();

            if (!(T_ID.Equals("")))
            {
                try
                {

                    objDBConnect.OpenConnection();

                    objDBConnect.sqlCmd = new SqlCommand("UPDATE TripUsage SET Vehicle_RegNumber=@Vehicle_RegNumber,Trip_DateFrom= @Trip_DateFrom,Trip_DateTo= @Trip_DateTo WHERE Trip_ID = @Trip_ID", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_ID", T_ID);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_DateFrom", SqlDbType.Date).Value = dtpDateFrom.Value.Date;
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_DateTo", SqlDbType.Date).Value = dtpDateTo.Value.Date;

                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                    MessageBox.Show("SUCCESSFULLY UPDATED");
                    CloseConnections();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Cannot Update Records: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter Trip ID");

            }

        }

        public void getValues()
        {

            T_ID = txtTripID.Text;
            T_TO = dtpDateTo.Text;
            T_FROM = dtpDateFrom.Text;
            try
            {
                V_RN = this.cboV_RN.GetItemText(this.cboV_RN.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Combobox error: " + ex.Message);
            }

            L_ID = this.cboL_ID.GetItemText(this.cboL_ID.SelectedItem);

        }

        private void frmTripUsage_Load(object sender, EventArgs e)
        {

            try
            {

                string query = "SELECT Vehicle_RegNumber from Vehicle;";
                objDBConnect.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, objDBConnect.sqlConn);

                DataSet ds = new DataSet();
                da.Fill(ds, "Vehicle");
                cboV_RN.ValueMember = "Vehicle_RegNumber";
                cboV_RN.DisplayMember = "Vehicle_RegNumber";
                cboV_RN.DataSource = ds.Tables["Vehicle"];
                objDBConnect.sqlConn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Shows an error message
            }

            try
            {

                string query = "SELECT Location_ID from Location;";
                objDBConnect.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, objDBConnect.sqlConn);

                DataSet ds = new DataSet();
                da.Fill(ds, "Location");
                cboL_ID.ValueMember = "Location_ID";
                cboL_ID.DisplayMember = "Location_ID";
                cboL_ID.DataSource = ds.Tables["Location"];
                objDBConnect.sqlConn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Shows an error message
            }

        }

        private void btnGenQR_Click(object sender, EventArgs e)
        {
            try
            {
                getValues();
                trip_plans();
                QRCodeEncoder encodeQR = new QRCodeEncoder();
                Bitmap qr = encodeQR.Encode(trip_plan);
                pbxQR.Image = qr as Image;
                pbxQR.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Display QR Code.\n Error: " + ex.Message);
            }
        }

        public void trip_plans()
        {
            trip_plan = "Trip ID: " + T_ID + "\nVehicle Registration Number: " + V_RN + "\nTrip Location: "+L_ID+"\nTrip Start Date: " + T_FROM + "\nTrip End Date: " + T_TO;

        }

        public void saveQR()
        {
            try
            {
                DialogResult saveqrcode = MessageBox.Show("Do you want to save the generate QR Code?", "Save QR Code", MessageBoxButtons.YesNoCancel);
                if (saveqrcode == DialogResult.Yes)
                {
                    SaveFileDialog saveQr = new SaveFileDialog();
                    saveQr.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
                    if (saveQr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        pbxQR.Image.Save(saveQr.FileName);
                        MessageBox.Show("QR Code Saved Successfully.\n Image Saved As: " + saveQr.FileName);
                    }
                }
                else
                {
                    if (saveqrcode == DialogResult.No)
                    {
                        MessageBox.Show("QR Code Not Saved.");
                    }
                    else
                    {
                        MessageBox.Show("Saving Cancelled");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save unsuccessful.\n" + ex.Message);
            }


        }

        public void CloseConnections()
        {
            objDBConnect.sqlDR.Close();
            objDBConnect.sqlConn.Close();
        }

        public void checkPicture()
        {
            if (pbxQR.Image == null)
            {
                MessageBox.Show("Please Generate QR Code First");
            }
            else
            {
                saveQR();
            }
        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            checkPicture();
        }

        private void lblCompleted_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCompletedTripDetails com = new frmCompletedTripDetails();
            this.Hide();
            com.Show();
        }
    }
}