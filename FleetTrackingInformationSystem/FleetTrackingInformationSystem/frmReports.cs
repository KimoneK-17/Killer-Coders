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
        SqlConnection Connection;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        DataGridView DataSource;
        public frmReports()
        {
            InitializeComponent();
        }
        private void frmReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FleetTrackingDBDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.VehicleTableAdapter.Fill(this.FleetTrackingDBDataSet.Vehicle);

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

                string selectServiceAppoint = "SELECT * FROM Service";
                db.sqlDA = new SqlDataAdapter(selectServiceAppoint, db.sqlConn);
                SqlCommandBuilder commandBuilder2 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds2 = new DataSet();
                db.sqlDA.Fill(ds2);
                dgvServiceAppointment.ReadOnly = true;

                string selectServiceReq = "SELECT * FROM Service";
                db.sqlDA = new SqlDataAdapter(selectServiceReq, db.sqlConn);
                SqlCommandBuilder commandBuilder3 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds3 = new DataSet();
                db.sqlDA.Fill(ds3);
                dgvServiceReq.ReadOnly = true;

                string selectVehicleServices = "SELECT * FROM Service";
                db.sqlDA = new SqlDataAdapter(selectVehicleServices, db.sqlConn);
                SqlCommandBuilder commandBuilder4 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds4 = new DataSet();
                db.sqlDA.Fill(ds4);
                dgvVehicleServices.ReadOnly = true;

                string selectDetailService = "SELECT * FROM Service";
                db.sqlDA = new SqlDataAdapter(selectDetailService, db.sqlConn);
                SqlCommandBuilder commandBuilder5 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds5 = new DataSet();
                db.sqlDA.Fill(ds5);
                dgvDetailedService.ReadOnly = true;

                string selectPlannedTrip = "SELECT * FROM Service";
                db.sqlDA = new SqlDataAdapter(selectPlannedTrip, db.sqlConn);
                SqlCommandBuilder commandBuilder6 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds6 = new DataSet();
                db.sqlDA.Fill(ds6);
                dgvPlannedTrip.ReadOnly = true;

                string selectCompletedTrip = "SELECT * FROM Service";
                db.sqlDA = new SqlDataAdapter(selectCompletedTrip, db.sqlConn);
                SqlCommandBuilder commandBuilder7 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds7 = new DataSet();
                db.sqlDA.Fill(ds7);
                dgvCompletedTrip.ReadOnly = true;

                string selectTimeSheet = "SELECT * FROM Service";
                db.sqlDA = new SqlDataAdapter(selectTimeSheet, db.sqlConn);
                SqlCommandBuilder commandBuilder8 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds8 = new DataSet();
                db.sqlDA.Fill(ds8);
                dgvTimeSheet.ReadOnly = true;
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
    }
}
