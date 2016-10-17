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
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace FleetTrackingInformationSystem
{
    public partial class frmReports : Form
    {
        DataGridView DataSource;
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDetailedService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Resizes Columns in the Datagridview
                dgvCTDaily.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvCTMonthly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvCTWeekly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvPTDaily.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvPTWeekly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvSADaily.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvSAWeekly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvServiceReq.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvTSDaily.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvTSMonthly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvTSWeekly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvVehicleStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvVSDaily.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvVSMonthly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvVSWeekly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvVSYearly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with Resizing Data Grid Views: " + ex);
            }

            DBConnect db = new DBConnect();
            db.OpenConnection();

            try
            {
                string selectVehicleStatus = "SELECT * FROM Vehicle ORDER BY Vehicle_Year"; // Sql For Data Grid View         
                db.sqlDA = new SqlDataAdapter(selectVehicleStatus, db.sqlConn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(db.sqlDA);
                DataSet ds = new DataSet();
                db.sqlDA.Fill(ds); // Fills the DataSet
                dgvVehicleStatus.ReadOnly = true;
                dgvVehicleStatus.DataSource = ds.Tables[0];

                string selectServiceAppointDaily = "SELECT * FROM tblService WHERE Service_Date = GETDATE() ORDER BY Service_Date";
                db.sqlDA = new SqlDataAdapter(selectServiceAppointDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder2 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds2 = new DataSet();
                db.sqlDA.Fill(ds2);
                dgvSADaily.ReadOnly = true;
                dgvSADaily.DataSource = ds2.Tables[0];


                string selectServiceAppointWeekly = "SELECT * FROM tblService WHERE Service_Date BETWEEN GETDATE() and GETDATE()+5 ORDER BY Service_Date";
                db.sqlDA = new SqlDataAdapter(selectServiceAppointWeekly, db.sqlConn);
                SqlCommandBuilder commandBuilder11 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds11 = new DataSet();
                db.sqlDA.Fill(ds11);
                dgvSAWeekly.ReadOnly = true;
                dgvSAWeekly.DataSource = ds11.Tables[0];

                string selectServiceReq = "SELECT Vehicle_RegNumber, Service_Description, Service_Date, Service_Time FROM tblService WHERE Service_Date >= GETDATE() ORDER BY Service_Date";
                db.sqlDA = new SqlDataAdapter(selectServiceReq, db.sqlConn);
                SqlCommandBuilder commandBuilder3 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds3 = new DataSet();
                db.sqlDA.Fill(ds3);
                dgvServiceReq.ReadOnly = true;
                dgvServiceReq.DataSource = ds3.Tables[0];

                string selectVehicleServicesDaily = "SELECT * FROM tblService WHERE Service_Date = GETDATE() ORDER BY Service_Date";
                db.sqlDA = new SqlDataAdapter(selectVehicleServicesDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder4 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds4 = new DataSet();
                db.sqlDA.Fill(ds4);
                dgvVSDaily.ReadOnly = true;
                dgvVSDaily.DataSource = ds4.Tables[0];

                string selectVehicleServicesWeekly = "SELECT * FROM tblService WHERE Service_Date BETWEEN GETDATE() and GETDATE()+5 ORDER BY Service_Date";
                db.sqlDA = new SqlDataAdapter(selectVehicleServicesWeekly, db.sqlConn);
                SqlCommandBuilder commandBuilder12 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds12 = new DataSet();
                db.sqlDA.Fill(ds12);
                dgvVSWeekly.ReadOnly = true;
                dgvVSWeekly.DataSource = ds12.Tables[0];

                string selectVehicleServicesMonthly = "SELECT * FROM tblService WHERE MONTH(Service_Date) = MONTH(dateadd(dd, -1, GetDate())) ORDER BY Service_Date";
                db.sqlDA = new SqlDataAdapter(selectVehicleServicesMonthly, db.sqlConn);
                SqlCommandBuilder commandBuilder13 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds13 = new DataSet();
                db.sqlDA.Fill(ds13);
                dgvVSMonthly.ReadOnly = true;
                dgvVSMonthly.DataSource = ds13.Tables[0];

                string selectVehicleServicesYearly = "SELECT * FROM tblService WHERE YEAR(Service_Date) = YEAR(dateadd(dd, -1, GetDate())) ORDER BY Service_Date";
                db.sqlDA = new SqlDataAdapter(selectVehicleServicesYearly, db.sqlConn);
                SqlCommandBuilder commandBuilder14 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds14 = new DataSet();
                db.sqlDA.Fill(ds14);
                dgvVSYearly.ReadOnly = true;
                dgvVSYearly.DataSource = ds14.Tables[0];

                string selectDetailService = "SELECT * FROM tblService WHERE Service_Date = GETDATE() ORDER BY Service_Date";
                db.sqlDA = new SqlDataAdapter(selectDetailService, db.sqlConn);
                SqlCommandBuilder commandBuilder5 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds5 = new DataSet();
                db.sqlDA.Fill(ds5);
                dgvDetailedService.ReadOnly = true;
                dgvDetailedService.DataSource = ds5.Tables[0];

                string selectPlannedTripDaily = "SELECT * FROM TripUsage WHERE Trip_DateFrom >= GETDATE() ORDER BY Trip_DateFrom";
                db.sqlDA = new SqlDataAdapter(selectPlannedTripDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder6 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds6 = new DataSet();
                db.sqlDA.Fill(ds6);
                dgvPTDaily.ReadOnly = true;
                dgvPTDaily.DataSource = ds6.Tables[0];

                string selectPlannedTripWeekly = "SELECT * FROM TripUsage WHERE Trip_DateFrom BETWEEN GETDATE() and GETDATE()+5";
                db.sqlDA = new SqlDataAdapter(selectPlannedTripWeekly, db.sqlConn);
                SqlCommandBuilder commandBuilder15 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds15 = new DataSet();
                db.sqlDA.Fill(ds15);
                dgvPTWeekly.ReadOnly = true;
                dgvPTWeekly.DataSource = ds15.Tables[0];

                string selectCompletedTripDaily = "SELECT * FROM TripUsage ORDER BY Trip_DateFrom";
                db.sqlDA = new SqlDataAdapter(selectCompletedTripDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder7 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds7 = new DataSet();
                db.sqlDA.Fill(ds7);
                dgvCTDaily.ReadOnly = true;
                dgvCTDaily.DataSource = ds7.Tables[0];

                string selectCompletedTripWeekly = "SELECT * FROM TripUsage WHERE Trip_DateFrom BETWEEN GETDATE() and GETDATE()+5";
                db.sqlDA = new SqlDataAdapter(selectCompletedTripWeekly, db.sqlConn);
                SqlCommandBuilder commandBuilder16 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds16 = new DataSet();
                db.sqlDA.Fill(ds16);
                dgvCTWeekly.ReadOnly = true;
                dgvCTWeekly.DataSource = ds16.Tables[0];

                string selectCompletedTripMonthly = "SELECT * FROM TripUsage WHERE MONTH(Trip_DateFrom) = MONTH(dateadd(dd, -1, GetDate()));";
                db.sqlDA = new SqlDataAdapter(selectCompletedTripMonthly, db.sqlConn);
                SqlCommandBuilder commandBuilder17 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds17 = new DataSet();
                db.sqlDA.Fill(ds17);
                dgvCTMonthly.ReadOnly = true;
                dgvCTMonthly.DataSource = ds17.Tables[0];

                string selectTimeSheetWeek = "SELECT * FROM Timesheet WHERE T_Date BETWEEN GETDATE() and GETDATE()+5";
                db.sqlDA = new SqlDataAdapter(selectTimeSheetWeek, db.sqlConn);
                SqlCommandBuilder commandBuilder8 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds8 = new DataSet();
                db.sqlDA.Fill(ds8);
                dgvTSWeekly.ReadOnly = true;
                dgvTSWeekly.DataSource = ds8.Tables[0];

                string selectTimeSheetMonth = "SELECT * FROM Timesheet WHERE MONTH(T_Date) = MONTH(dateadd(dd, -1, GetDate()));";
                db.sqlDA = new SqlDataAdapter(selectTimeSheetMonth, db.sqlConn);
                SqlCommandBuilder commandBuilder9 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds9 = new DataSet();
                db.sqlDA.Fill(ds9);
                dgvTSMonthly.ReadOnly = true;
                dgvTSMonthly.DataSource = ds9.Tables[0];

                string selectTimeSheetDaily = "SELECT * FROM Timesheet ORDER BY T_Date";
                db.sqlDA = new SqlDataAdapter(selectTimeSheetDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder10 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds10 = new DataSet();
                db.sqlDA.Fill(ds10);
                dgvTSDaily.ReadOnly = true;
                dgvTSDaily.DataSource = ds10.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Load Sql Commands to The Data Grid Views: " + ex.Message); // Shows an error message
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMenu men = new frmMenu(); // Goes back to the Menu Form
                men.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Cannot Go Back to the Previous Form: " + ex.Message); // Shows an error message 
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0); // Exits the Entire Application
            }
            catch(Exception ex)
            {        
                MessageBox.Show("Cannot Exit the Application: " + ex.Message); // Shows an error message 
            }
        }

        private void btnPrintVehicleStat_Click(object sender, EventArgs e)
        {

        }
    }
}
