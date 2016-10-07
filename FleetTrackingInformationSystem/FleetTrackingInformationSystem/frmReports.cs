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
            // TODO: This line of code loads data into the 'FleetTrackingDBDataSet.Vehicle' table. You can move, or remove it, as needed.

            DBConnect db = new DBConnect();
            db.OpenConnection();

            try
            {
                string selectVehicleStatus = "SELECT * FROM Vehicle"; // Sql For Data Grid View         
                db.sqlDA = new SqlDataAdapter(selectVehicleStatus, db.sqlConn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(db.sqlDA);
                DataSet ds = new DataSet();
                db.sqlDA.Fill(ds); // Fills the DataSet
                dgvVehicleStatus.ReadOnly = true;
                dgvVehicleStatus.DataSource = ds.Tables[0];

                string selectServiceAppointDaily = "SELECT * FROM tblService";
                db.sqlDA = new SqlDataAdapter(selectServiceAppointDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder2 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds2 = new DataSet();
                db.sqlDA.Fill(ds2);
                dgvSADaily.ReadOnly = true;
                dgvSADaily.DataSource = ds.Tables[0];

                string selectServiceAppointWeekly = "SELECT * FROM tblService WHERE Service_Date BETWEEN GETDATE() and GETDATE()+5";
                db.sqlDA = new SqlDataAdapter(selectServiceAppointWeekly, db.sqlConn);
                SqlCommandBuilder commandBuilder11 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds11 = new DataSet();
                db.sqlDA.Fill(ds11);
                dgvSAWeekly.ReadOnly = true;
                dgvSAWeekly.DataSource = ds.Tables[0];

                string selectServiceReq = "SELECT Vehicle_RegNumber, Service_Description, Service_Date, Service_Time FROM tblService";
                db.sqlDA = new SqlDataAdapter(selectServiceReq, db.sqlConn);
                SqlCommandBuilder commandBuilder3 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds3 = new DataSet();
                db.sqlDA.Fill(ds3);
                dgvServiceReq.ReadOnly = true;
                dgvServiceReq.DataSource = ds.Tables[0];

                string selectVehicleServicesDaily = "SELECT * FROM tblService ORDER BY Service_Date";
                db.sqlDA = new SqlDataAdapter(selectVehicleServicesDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder4 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds4 = new DataSet();
                db.sqlDA.Fill(ds4);
                dgvVSDaily.ReadOnly = true;
                dgvVSDaily.DataSource = ds.Tables[0];

                string selectVehicleServicesWeekly = "SELECT * FROM tblService WHERE Service_Date BETWEEN GETDATE() and GETDATE()+5";
                db.sqlDA = new SqlDataAdapter(selectVehicleServicesWeekly, db.sqlConn);
                SqlCommandBuilder commandBuilder12 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds12 = new DataSet();
                db.sqlDA.Fill(ds12);
                dgvVSWeekly.ReadOnly = true;
                dgvVSWeekly.DataSource = ds.Tables[0];

                string selectVehicleServicesMonthly = "SELECT * FROM tblService WHERE MONTH(Service_Date) = MONTH(dateadd(dd, -1, GetDate()));";
                db.sqlDA = new SqlDataAdapter(selectVehicleServicesMonthly, db.sqlConn);
                SqlCommandBuilder commandBuilder13 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds13 = new DataSet();
                db.sqlDA.Fill(ds13);
                dgvVSMonthly.ReadOnly = true;
                dgvVSMonthly.DataSource = ds.Tables[0];

                string selectVehicleServicesYearly = "SELECT * FROM tblService WHERE YEAR(Service_Date) = YEAR(dateadd(dd, -1, GetDate())) ORDER BY Service_Date ASC;";
                db.sqlDA = new SqlDataAdapter(selectVehicleServicesYearly, db.sqlConn);
                SqlCommandBuilder commandBuilder14 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds14 = new DataSet();
                db.sqlDA.Fill(ds14);
                dgvVSYearly.ReadOnly = true;
                dgvVSYearly.DataSource = ds.Tables[0];

                string selectDetailService = "SELECT * FROM tblService ORDER BY Service_Date";
                db.sqlDA = new SqlDataAdapter(selectDetailService, db.sqlConn);
                SqlCommandBuilder commandBuilder5 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds5 = new DataSet();
                db.sqlDA.Fill(ds5);
                dgvDetailedService.ReadOnly = true;
                dgvDetailedService.DataSource = ds.Tables[0];

                string selectPlannedTripDaily = "SELECT * FROM TripUsage ORDER BY Trip_DateFrom";
                db.sqlDA = new SqlDataAdapter(selectPlannedTripDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder6 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds6 = new DataSet();
                db.sqlDA.Fill(ds6);
                dgvPTDaily.ReadOnly = true;
                dgvPTDaily.DataSource = ds.Tables[0];

                string selectPlannedTripWeekly = "SELECT * FROM TripUsage WHERE Trip_DateFrom BETWEEN GETDATE() and GETDATE()+5";
                db.sqlDA = new SqlDataAdapter(selectPlannedTripWeekly, db.sqlConn);
                SqlCommandBuilder commandBuilder15 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds15 = new DataSet();
                db.sqlDA.Fill(ds15);
                dgvPTWeekly.ReadOnly = true;
                dgvPTWeekly.DataSource = ds.Tables[0];

                string selectCompletedTripDaily = "SELECT * FROM TripUsage ORDER BY Trip_DateFrom";
                db.sqlDA = new SqlDataAdapter(selectCompletedTripDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder7 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds7 = new DataSet();
                db.sqlDA.Fill(ds7);
                dgvCTDaily.ReadOnly = true;
                dgvCTDaily.DataSource = ds.Tables[0];

                string selectCompletedTripWeekly = "SELECT * FROM TripUsage WHERE Trip_DateFrom BETWEEN GETDATE() and GETDATE()+5";
                db.sqlDA = new SqlDataAdapter(selectCompletedTripWeekly, db.sqlConn);
                SqlCommandBuilder commandBuilder16 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds16 = new DataSet();
                db.sqlDA.Fill(ds16);
                dgvCTWeekly.ReadOnly = true;
                dgvCTWeekly.DataSource = ds.Tables[0];

                string selectCompletedTripMonthly = "SELECT * FROM TripUsage WHERE MONTH(Trip_DateFrom) = MONTH(dateadd(dd, -1, GetDate()));";
                db.sqlDA = new SqlDataAdapter(selectCompletedTripMonthly, db.sqlConn);
                SqlCommandBuilder commandBuilder17 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds17 = new DataSet();
                db.sqlDA.Fill(ds17);
                dgvCTMonthly.ReadOnly = true;
                dgvCTMonthly.DataSource = ds.Tables[0];

                string selectTimeSheetWeek = "SELECT * FROM Timesheet WHERE T_Date BETWEEN GETDATE() and GETDATE()+5";
                db.sqlDA = new SqlDataAdapter(selectTimeSheetWeek, db.sqlConn);
                SqlCommandBuilder commandBuilder8 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds8 = new DataSet();
                db.sqlDA.Fill(ds8);
                dgvTSWeekly.ReadOnly = true;
                dgvTSWeekly.DataSource = ds.Tables[0];

                string selectTimeSheetMonth = "SELECT * FROM Timesheet WHERE MONTH(T_Date) = MONTH(dateadd(dd, -1, GetDate()));";
                db.sqlDA = new SqlDataAdapter(selectTimeSheetMonth, db.sqlConn);
                SqlCommandBuilder commandBuilder9 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds9 = new DataSet();
                db.sqlDA.Fill(ds9);
                dgvTSMonthly.ReadOnly = true;
                dgvTSMonthly.DataSource = ds.Tables[0];

                string selectTimeSheetDaily = "SELECT * FROM Timesheet ORDER BY T_Date";
                db.sqlDA = new SqlDataAdapter(selectTimeSheetDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder10 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds10 = new DataSet();
                db.sqlDA.Fill(ds10);
                dgvTSDaily.ReadOnly = true;
                dgvTSDaily.DataSource = ds.Tables[0];
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

        private void dgvVehicleStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
