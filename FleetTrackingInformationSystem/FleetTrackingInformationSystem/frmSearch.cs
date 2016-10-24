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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            toolTip();

            cboC_ID.DropDownStyle = ComboBoxStyle.DropDownList; // Prevents User from inputting Values in the Combo Box, makes the style of the combo box a Drop Down List  
            cboT_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            cboE_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            cboL_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            cboV_RN.DropDownStyle = ComboBoxStyle.DropDownList;
            cboS_ID.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMenu men = new frmMenu(); // Goes back to the Menu Form
                men.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Go Back to Previous Form: " + ex.Message); // Shows an Error Message
            }
        }

        DBConnect objDBConnect = new DBConnect();


        private void mnuExit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0); // Exits the Entire Application
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Exit the Application: " + ex.Message); // Shows an error message
            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            //cboE_ID = E_ID;

            try
            {
                string query = "SELECT Emp_ID from Employee;";
                objDBConnect.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, objDBConnect.sqlConn);

                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");
                cboE_ID.ValueMember = "Emp_ID";
                cboE_ID.DisplayMember = "Emp_ID";
                cboE_ID.DataSource = ds.Tables["Employee"];
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

                string query = "SELECT Cust_ID from Customer;";
                objDBConnect.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, objDBConnect.sqlConn);

                DataSet ds = new DataSet();
                da.Fill(ds, "Customer");
                cboC_ID.ValueMember = "Cust_ID";
                cboC_ID.DisplayMember = "Cust_ID";
                cboC_ID.DataSource = ds.Tables["Customer"];
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
            try
            {

                string query = "SELECT Trip_ID from TripUsage;";
                objDBConnect.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, objDBConnect.sqlConn);

                DataSet ds = new DataSet();
                da.Fill(ds, "TripUsage");
                cboT_ID.ValueMember = "Trip_ID";
                cboT_ID.DisplayMember = "Trip_ID";
                cboT_ID.DataSource = ds.Tables["TripUsage"];
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

                string query = "SELECT Service_ID from tblService;";
                objDBConnect.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, objDBConnect.sqlConn);

                DataSet ds = new DataSet();
                da.Fill(ds, "tblService");
                cboS_ID.ValueMember = "Service_ID";
                cboS_ID.DisplayMember = "Service_ID";
                cboS_ID.DataSource = ds.Tables["tblService"];
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

        private void btnTrip_Click(object sender, EventArgs e)
        {
            string T_ID = cboT_ID.SelectedValue.ToString();
            try
            {	//creates object of DBConnect class


                objDBConnect.GiveCommand("SELECT * from TripUsage WHERE Trip_ID LIKE @Trip_ID ");
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Trip_ID", T_ID);
                objDBConnect.sqlDA = new SqlDataAdapter(objDBConnect.sqlCmd);
                DataTable dtSearch = new DataTable();
                objDBConnect.sqlDA.Fill(dtSearch);
                dgvTripUsage.DataSource = dtSearch;
                dgvTripUsage.AutoResizeColumns();

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

        private void btnEmp_Click(object sender, EventArgs e)
        {
            string E_ID = cboE_ID.SelectedValue.ToString();
            try
            {	//creates object of DBConnect class


                objDBConnect.GiveCommand("SELECT * from Employee WHERE Emp_ID LIKE @Emp_ID ");
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Emp_ID", E_ID);
                objDBConnect.sqlDA = new SqlDataAdapter(objDBConnect.sqlCmd);
                DataTable dtSearch = new DataTable();
                objDBConnect.sqlDA.Fill(dtSearch);
                dgvEmployee.DataSource = dtSearch;
                dgvEmployee.AutoResizeColumns();
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

        private void btnLocation_Click(object sender, EventArgs e)
        {
            string L_ID = cboL_ID.SelectedValue.ToString();
            try
            {	//creates object of DBConnect class

                objDBConnect.GiveCommand("SELECT * from Location WHERE Location_ID LIKE @Location_ID ");
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Location_ID", L_ID);
                objDBConnect.sqlDA = new SqlDataAdapter(objDBConnect.sqlCmd);
                DataTable dtSearch = new DataTable();
                objDBConnect.sqlDA.Fill(dtSearch);
                dgvLocation.DataSource = dtSearch;
                dgvLocation.AutoResizeColumns();

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

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            string V_RN = cboV_RN.SelectedValue.ToString();
            try
            {	//creates object of DBConnect class
                objDBConnect.GiveCommand("SELECT * from Vehicle WHERE Vehicle_RegNumber LIKE @Vehicle_RegNumber ");
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Vehicle_RegNumber", V_RN);
                objDBConnect.sqlDA = new SqlDataAdapter(objDBConnect.sqlCmd);
                DataTable dtSearch = new DataTable();
                objDBConnect.sqlDA.Fill(dtSearch);
                dgvVehicle.DataSource = dtSearch;
                dgvVehicle.AutoResizeColumns();
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

        private void btnService_Click(object sender, EventArgs e)
        {
            string S_ID = cboS_ID.SelectedValue.ToString();
            try
            {	//creates object of DBConnect class

                objDBConnect.GiveCommand("SELECT * from tblService WHERE Service_ID LIKE @Service_ID ");
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Service_ID", S_ID);
                objDBConnect.sqlDA = new SqlDataAdapter(objDBConnect.sqlCmd);
                DataTable dtSearch = new DataTable();
                objDBConnect.sqlDA.Fill(dtSearch);
                dgvService.DataSource = dtSearch;
                dgvService.AutoResizeColumns();
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

        private void btnCust_Click(object sender, EventArgs e)
        {
            string C_ID = cboC_ID.SelectedValue.ToString();
            try
            {	//creates object of DBConnect class


                objDBConnect.GiveCommand("SELECT * from Customer WHERE Cust_ID LIKE @Cust_ID ");
                objDBConnect.sqlCmd.Parameters.AddWithValue("@Cust_ID", C_ID);
                objDBConnect.sqlDA = new SqlDataAdapter(objDBConnect.sqlCmd);
                DataTable dtSearch = new DataTable();
                objDBConnect.sqlDA.Fill(dtSearch);
                dgvCustomer.DataSource = dtSearch;
                dgvCustomer.AutoResizeColumns();
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

        public void toolTip()
        {
            try
            {
                // tooltip properties
                int ttAutoDelay = 5000;
                int ttInitDelay = 1000;
                int ttRshwDelay = 500;

                ToolTip objTooltipbtnTrip = new ToolTip();
                objTooltipbtnTrip.AutoPopDelay = ttAutoDelay;
                objTooltipbtnTrip.InitialDelay = ttInitDelay;
                objTooltipbtnTrip.ReshowDelay = ttRshwDelay;
                objTooltipbtnTrip.SetToolTip(this.btnTrip, "Search for all entries containting the specified Trip ID");

                ToolTip objTooltipbtnCust = new ToolTip();
                objTooltipbtnCust.AutoPopDelay = ttAutoDelay;
                objTooltipbtnCust.InitialDelay = ttInitDelay;
                objTooltipbtnCust.ReshowDelay = ttRshwDelay;
                objTooltipbtnCust.SetToolTip(this.btnCust, "Search for all entries containting the specified Customer ID");

                ToolTip objTooltipbtnEmp = new ToolTip();
                objTooltipbtnEmp.AutoPopDelay = ttAutoDelay;
                objTooltipbtnEmp.InitialDelay = ttInitDelay;
                objTooltipbtnEmp.ReshowDelay = ttRshwDelay;
                objTooltipbtnEmp.SetToolTip(this.btnEmp, "Search for all entries containting the specified Employee ID");

                ToolTip objTooltipbtnService = new ToolTip();
                objTooltipbtnService.AutoPopDelay = ttAutoDelay;
                objTooltipbtnService.InitialDelay = ttInitDelay;
                objTooltipbtnService.ReshowDelay = ttRshwDelay;
                objTooltipbtnService.SetToolTip(this.btnService, "Search for all entries containting the specified Service ID");

                ToolTip objTooltipbtnVehicle = new ToolTip();
                objTooltipbtnVehicle.AutoPopDelay = ttAutoDelay;
                objTooltipbtnVehicle.InitialDelay = ttInitDelay;
                objTooltipbtnVehicle.ReshowDelay = ttRshwDelay;
                objTooltipbtnVehicle.SetToolTip(this.btnVehicle, "Search for all entries containting the specified Vehicle ID");

                ToolTip objTooltipbtnLocation = new ToolTip();
                objTooltipbtnLocation.AutoPopDelay = ttAutoDelay;
                objTooltipbtnLocation.InitialDelay = ttInitDelay;
                objTooltipbtnLocation.ReshowDelay = ttRshwDelay;
                objTooltipbtnLocation.SetToolTip(this.btnLocation, "Search for all entries containting the specified Location ID");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}