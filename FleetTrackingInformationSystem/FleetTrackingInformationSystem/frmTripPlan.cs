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

namespace FleetTrackingInformationSystem
{
    public partial class frmTripPlan : Form
    {
        string T_ID;
        string V_RN;
        string T_FROM;
        string T_TO;

        string trip_plan;

        public frmTripPlan()
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


            exit = check.CheckEmpty(T_ID, "Trip ID");

            exit = check.CheckEmpty(V_RN, "Vehicle Reg Number");


            if (exit == false)
            {
                try
                {
                    DBConnect objDBConnect = new DBConnect();
                    objDBConnect.OpenConnection();

                    objDBConnect.sqlCmd = new SqlCommand("IF NOT EXISTS(SELECT * FROM TripUsage WHERE T_ID = @Trip_ID) BEGIN INSERT INTO TripUsage VALUES(@Trip_ID, @Vehicle_RegNumber, @Trip_DateFrom, @Trip_DateTo)", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_ID", T_ID);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_DateFrom", T_FROM);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_DateTo", T_TO);

                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                    MessageBox.Show("Succesfully inserted");
                    objDBConnect.sqlDR.Close();
                    objDBConnect.sqlConn.Close();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Cannot Submit Details: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            getValues();
            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                string sql = "DELETE FROM TripUsage WHERE (Trip_ID ='" + T_ID + "');";

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
                MessageBox.Show("Error Cannot Delete Records: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getValues();
            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("UPDATE TripUsage SET(Vehicle_RegNumber=@Vehicle_RegNumber,Trip_DateFrom= @Trip_DateFrom,Trip_DateTo= @Trip_DateTo)", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_ID", T_ID);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_DateFrom", T_FROM);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_DateTo", T_TO);

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
                MessageBox.Show("Error Cannot Update Records: " + ex.Message);
            }
        }

        public void getValues()
        {

            T_ID = txtTripID.Text;
            T_TO = dtpDateTo.Text;
            T_FROM = dtpDateFrom.Text;
            V_RN = cboV_RN.SelectedValue.ToString();


        }

        private void frmTripUsage_Load(object sender, EventArgs e)
        {
            DBConnect objDBConnect = new DBConnect();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Display QR Code.\n Error: " + ex.Message);
            }
        }

        public void trip_plans()
        {
            trip_plan = "Trip ID: " + T_ID + "\nVehicle Registration Number: " + V_RN + "\nTrip Start Date: " + T_FROM + "\nTrip End Date: " + T_TO;

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
    }
}