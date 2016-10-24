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
        public frmReports()
        {
            InitializeComponent();
        }
         DBConnect db = new DBConnect();
        private void frmReports_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            try // Resizes Columns in the Datagridviews
            {
                dgvDetailedService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvCTDaily.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvCTMonthly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvCTWeekly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvPTDaily.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvPTWeekly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvSADaily.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Resizes the Column
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
                MessageBox.Show("Problem with Resizing Data Grid Views: " + ex); // Shows Error Message if there is a Problem
            }


            db.OpenConnection();
            try // Adds Data to the Data Grid Views
            {
                string selectVehicleStatus = "SELECT * FROM Vehicle ORDER BY Vehicle_Year"; // Sql For Data Grid View         
                db.sqlDA = new SqlDataAdapter(selectVehicleStatus, db.sqlConn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(db.sqlDA);
                DataSet ds = new DataSet();
                db.sqlDA.Fill(ds); // Fills the DataSet
                dgvVehicleStatus.ReadOnly = true;
                dgvVehicleStatus.DataSource = ds.Tables[0];

                string selectServiceAppointDaily = "Select * FROM tblService WHERE Month(Service_Date) = MONTH(GETDATE()) AND YEAR(Service_Date) = YEAR(GETDATE()) AND DAY(Service_Date) = DAY(GETDATE())";                  
                db.sqlDA = new SqlDataAdapter(selectServiceAppointDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder2 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds2 = new DataSet();
                db.sqlDA.Fill(ds2);
                dgvSADaily.ReadOnly = true;
                dgvSADaily.DataSource = ds2.Tables[0];


                string selectServiceAppointWeekly = "SELECT * FROM tblService WHERE Service_Date BETWEEN GETDATE()-1 and GETDATE()+5 ORDER BY Service_Date";
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

                string selectVehicleServicesDaily = "SELECT * FROM tblService WHERE Month(service_date) = MONTH(GETDATE()) AND YEAR(service_date) = YEAR(GETDATE()) AND DAY(service_date) = DAY(GETDATE())"; // Sql For Data Grid View
                db.sqlDA = new SqlDataAdapter(selectVehicleServicesDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder4 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds4 = new DataSet();
                db.sqlDA.Fill(ds4); // Fills the DataSet
                dgvVSDaily.ReadOnly = true;
                dgvVSDaily.DataSource = ds4.Tables[0];

                string selectVehicleServicesWeekly = "SELECT * FROM tblService WHERE service_date BETWEEN getdate()-5 and getdate()";
                db.sqlDA = new SqlDataAdapter(selectVehicleServicesWeekly, db.sqlConn);
                SqlCommandBuilder commandBuilder12 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds12 = new DataSet();
                db.sqlDA.Fill(ds12);
                dgvVSWeekly.ReadOnly = true;
                dgvVSWeekly.DataSource = ds12.Tables[0];

                string selectVehicleServicesMonthly = "SELECT * FROM tblService WHERE Service_Date < getdate() and Month(Service_Date) = Month(GETDATE())";
                db.sqlDA = new SqlDataAdapter(selectVehicleServicesMonthly, db.sqlConn);
                SqlCommandBuilder commandBuilder13 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds13 = new DataSet();
                db.sqlDA.Fill(ds13);
                dgvVSMonthly.ReadOnly = true;
                dgvVSMonthly.DataSource = ds13.Tables[0];

                string selectVehicleServicesYearly = "SELECT * FROM tblService WHERE Service_Date < getdate() AND Year(Service_Date) = YEAR(GETDATE())";
                db.sqlDA = new SqlDataAdapter(selectVehicleServicesYearly, db.sqlConn);
                SqlCommandBuilder commandBuilder14 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds14 = new DataSet();
                db.sqlDA.Fill(ds14);
                dgvVSYearly.ReadOnly = true;
                dgvVSYearly.DataSource = ds14.Tables[0];

                string selectDetailService = "SELECT * FROM tblService WHERE Service_Date < GETDATE() ORDER BY Service_Date"; // Sql For Data Grid View
                db.sqlDA = new SqlDataAdapter(selectDetailService, db.sqlConn);
                SqlCommandBuilder commandBuilder5 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds5 = new DataSet();
                db.sqlDA.Fill(ds5); // Fills the DataSet
                dgvDetailedService.ReadOnly = true;
                dgvDetailedService.DataSource = ds5.Tables[0];

                string selectPlannedTripDaily = "Select * FROM TripUsage WHERE Month(Trip_DateFrom) = MONTH(GETDATE()) AND YEAR(Trip_DateFrom) = YEAR(GETDATE()) AND DAY(Trip_DateFrom) = DAY(GETDATE()) AND Trip_Completed LIKE 'NO'";               
                db.sqlDA = new SqlDataAdapter(selectPlannedTripDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder6 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds6 = new DataSet();
                db.sqlDA.Fill(ds6);
                dgvPTDaily.ReadOnly = true;
                dgvPTDaily.DataSource = ds6.Tables[0];

                string selectPlannedTripWeekly = "SELECT * FROM TripUsage WHERE Trip_DateFrom BETWEEN GETDATE() and GETDATE()+5 AND Trip_Completed LIKE 'NO'";
                db.sqlDA = new SqlDataAdapter(selectPlannedTripWeekly, db.sqlConn);
                SqlCommandBuilder commandBuilder15 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds15 = new DataSet();
                db.sqlDA.Fill(ds15);
                dgvPTWeekly.ReadOnly = true;
                dgvPTWeekly.DataSource = ds15.Tables[0];

                string selectCompletedTripDaily = "Select * FROM TripUsage WHERE Month(Trip_DateFrom) = MONTH(GETDATE()) AND YEAR(Trip_DateFrom) = YEAR(GETDATE()) AND DAY(Trip_DateFrom) = DAY(GETDATE()) AND Trip_Completed LIKE 'YES'";
                db.sqlDA = new SqlDataAdapter(selectCompletedTripDaily, db.sqlConn);
                SqlCommandBuilder commandBuilder7 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds7 = new DataSet();
                db.sqlDA.Fill(ds7);
                dgvCTDaily.ReadOnly = true;
                dgvCTDaily.DataSource = ds7.Tables[0];

                string selectCompletedTripWeekly = "SELECT * FROM TripUsage WHERE Trip_DateFrom BETWEEN GETDATE() and GETDATE()+5 AND Trip_Completed LIKE 'YES' ORDER BY Trip_DateFrom";
                db.sqlDA = new SqlDataAdapter(selectCompletedTripWeekly, db.sqlConn);
                SqlCommandBuilder commandBuilder16 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds16 = new DataSet();
                db.sqlDA.Fill(ds16);
                dgvCTWeekly.ReadOnly = true;
                dgvCTWeekly.DataSource = ds16.Tables[0];

                string selectCompletedTripMonthly = "SELECT * FROM TripUsage WHERE MONTH(Trip_DateFrom) = MONTH(GETDATE()) AND  Trip_Completed LIKE 'YES'";
                db.sqlDA = new SqlDataAdapter(selectCompletedTripMonthly, db.sqlConn);
                SqlCommandBuilder commandBuilder17 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds17 = new DataSet();
                db.sqlDA.Fill(ds17);
                dgvCTMonthly.ReadOnly = true;
                dgvCTMonthly.DataSource = ds17.Tables[0];

                string selectTimeSheetWeek = "SELECT e.Emp_Name, e.Emp_Surname, e.Emp_ID, s.[Total Hours Weekly] FROM Employee  e JOIN (SELECT Emp_ID, SUM(T_HOURS) AS [Total Hours Weekly] FROM Timesheet s WHERE T_DATE BETWEEN GETDATE() and GETDATE()+5 GROUP BY Emp_ID) as s ON e.Emp_ID = s.Emp_ID"; // Sql for Data Grid View
                db.sqlDA = new SqlDataAdapter(selectTimeSheetWeek, db.sqlConn);
                SqlCommandBuilder commandBuilder8 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds8 = new DataSet();
                db.sqlDA.Fill(ds8); // Fills the DataSet
                dgvTSWeekly.ReadOnly = true;
                dgvTSWeekly.DataSource = ds8.Tables[0];

                string selectTimeSheetMonth = "SELECT e.Emp_Name, e.Emp_Surname, e.Emp_ID, s.[Total Hours Monthly] FROM Employee  e JOIN (SELECT Emp_ID, SUM(T_HOURS) AS [Total Hours Monthly] FROM Timesheet s WHERE Month(T_DATE) = Month(GETDATE())GROUP BY Emp_ID) as s ON e.Emp_ID = s.Emp_ID";
                db.sqlDA = new SqlDataAdapter(selectTimeSheetMonth, db.sqlConn);
                SqlCommandBuilder commandBuilder9 = new SqlCommandBuilder(db.sqlDA);
                DataSet ds9 = new DataSet();
                db.sqlDA.Fill(ds9);
                dgvTSMonthly.ReadOnly = true;
                dgvTSMonthly.DataSource = ds9.Tables[0];

                string selectTimeSheetDaily = "SELECT  e.Emp_Name, e.Emp_Surname, e.Emp_ID, t.T_ID  as 'Timesheet ID', SUM(t.T_HOURS) AS 'Total Hours Worked-Daily' FROM Employee e inner join Timesheet t on e.Emp_ID = t.Emp_ID WHERE Day(T_DATE) = day(GETDATE())and Month(T_DATE) = Month(GETDATE()) and year(T_DATE) = year(GETDATE()) GROUP BY e.Emp_Name, e.Emp_Surname, e.Emp_ID,t.T_ID,t.T_HOURS;";
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
        private void btnPrintVehicleStat_Click_1(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.Document = printDoc1;
                printPreviewDialog1.ShowDialog(); // Brings up a Print Preview
                printDoc1.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc1_PrintPage(object sender, PrintPageEventArgs e) // Settings For The Printing
        {
            try
            {
                Bitmap bm = new Bitmap(this.dgvVehicleStatus.Width, this.dgvVehicleStatus.Height);
                dgvVehicleStatus.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvVehicleStatus.Width, this.dgvVehicleStatus.Height));
                e.Graphics.DrawImage(bm, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintSerAppDaily_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog2 = new PrintPreviewDialog();
                printPreviewDialog2.Document = printDoc2;
                printPreviewDialog2.ShowDialog(); // Brings up a Print Preview
                printDoc2.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc2_PrintPage(object sender, PrintPageEventArgs e) // Settings For the Printing
        {
            try
            {
                Bitmap bm2 = new Bitmap(this.dgvSADaily.Width, this.dgvSADaily.Height);
                dgvSADaily.DrawToBitmap(bm2, new Rectangle(0, 0, this.dgvSADaily.Width, this.dgvSADaily.Height));
                e.Graphics.DrawImage(bm2, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintSerAppWeek_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog3 = new PrintPreviewDialog();
                printPreviewDialog3.Document = printDoc3;
                printPreviewDialog3.ShowDialog(); // Brings up a Print Preview 
                printDoc3.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc3_PrintPage(object sender, PrintPageEventArgs e) // Setting for the Printing
        {
            try
            {
                Bitmap bm3 = new Bitmap(this.dgvSAWeekly.Width, this.dgvSAWeekly.Height);
                dgvSAWeekly.DrawToBitmap(bm3, new Rectangle(0, 0, this.dgvSAWeekly.Width, this.dgvSAWeekly.Height));
                e.Graphics.DrawImage(bm3, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintSerReq_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog4 = new PrintPreviewDialog();
                printPreviewDialog4.Document = printDoc4;
                printPreviewDialog4.ShowDialog(); // Brings up a Print Preview 
                printDoc4.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc4_PrintPage(object sender, PrintPageEventArgs e) // Settings for the Printing
        {
            try
            {
                Bitmap bm4 = new Bitmap(this.dgvServiceReq.Width, this.dgvServiceReq.Height);
                dgvServiceReq.DrawToBitmap(bm4, new Rectangle(0, 0, this.dgvServiceReq.Width, this.dgvServiceReq.Height));
                e.Graphics.DrawImage(bm4, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintVehSerComDaily_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog5 = new PrintPreviewDialog();
                printPreviewDialog5.Document = printDoc5;
                printPreviewDialog5.ShowDialog(); // Brings up a Print Preview 
                printDoc5.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc5_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm5 = new Bitmap(this.dgvVSDaily.Width, this.dgvVSDaily.Height);
                dgvVSDaily.DrawToBitmap(bm5, new Rectangle(0, 0, this.dgvVSDaily.Width, this.dgvVSDaily.Height));
                e.Graphics.DrawImage(bm5, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintVehSerComWeek_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog6 = new PrintPreviewDialog();
                printPreviewDialog6.Document = printDoc6;
                printPreviewDialog6.ShowDialog(); // Brings up a Print Preview 
                printDoc6.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc6_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm6 = new Bitmap(this.dgvVSWeekly.Width, this.dgvVSWeekly.Height);
                dgvVSWeekly.DrawToBitmap(bm6, new Rectangle(0, 0, this.dgvVSWeekly.Width, this.dgvVSWeekly.Height));
                e.Graphics.DrawImage(bm6, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintVehSerMonth_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog7 = new PrintPreviewDialog();
                printPreviewDialog7.Document = printDoc7;
                printPreviewDialog7.ShowDialog(); // Brings up a Print Preview 
                printDoc7.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc7_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm7 = new Bitmap(this.dgvVSMonthly.Width, this.dgvVSMonthly.Height);
                dgvVSMonthly.DrawToBitmap(bm7, new Rectangle(0, 0, this.dgvVSMonthly.Width, this.dgvVSMonthly.Height));
                e.Graphics.DrawImage(bm7, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintVehSerYear_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog8 = new PrintPreviewDialog();
                printPreviewDialog8.Document = printDoc8;
                printPreviewDialog8.ShowDialog(); // Brings up a Print Preview 
                printDoc8.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc8_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm8 = new Bitmap(this.dgvVSYearly.Width, this.dgvVSYearly.Height);
                dgvVSYearly.DrawToBitmap(bm8, new Rectangle(0, 0, this.dgvVSYearly.Width, this.dgvVSYearly.Height));
                e.Graphics.DrawImage(bm8, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintDetailSerInfo_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog9 = new PrintPreviewDialog();
                printPreviewDialog9.Document = printDoc9;
                printPreviewDialog9.ShowDialog(); // Brings up a Print Preview 
                printDoc9.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc9_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm9 = new Bitmap(this.dgvDetailedService.Width, this.dgvDetailedService.Height);
                dgvDetailedService.DrawToBitmap(bm9, new Rectangle(0, 0, this.dgvDetailedService.Width, this.dgvDetailedService.Height));
                e.Graphics.DrawImage(bm9, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintPlanTripDaily_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog10 = new PrintPreviewDialog();
                printPreviewDialog10.Document = printDoc10;
                printPreviewDialog10.ShowDialog(); // Brings up a Print Preview 
                printDoc10.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc10_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm10 = new Bitmap(this.dgvPTDaily.Width, this.dgvPTDaily.Height);
                dgvPTDaily.DrawToBitmap(bm10, new Rectangle(0, 0, this.dgvPTDaily.Width, this.dgvPTDaily.Height));
                e.Graphics.DrawImage(bm10, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintPlanTripWeek_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog11 = new PrintPreviewDialog();
                printPreviewDialog11.Document = printDoc11;
                printPreviewDialog11.ShowDialog(); // Brings up a Print Preview 
                printDoc11.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc11_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm11 = new Bitmap(this.dgvPTWeekly.Width, this.dgvPTWeekly.Height);
                dgvPTWeekly.DrawToBitmap(bm11, new Rectangle(0, 0, this.dgvPTWeekly.Width, this.dgvPTWeekly.Height));
                e.Graphics.DrawImage(bm11, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintComTripDaily_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog12 = new PrintPreviewDialog();
                printPreviewDialog12.Document = printDoc12;
                printPreviewDialog12.ShowDialog(); // Brings up a Print Preview 
                printDoc12.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc12_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm12 = new Bitmap(this.dgvCTDaily.Width, this.dgvCTDaily.Height);
                dgvCTDaily.DrawToBitmap(bm12, new Rectangle(0, 0, this.dgvCTDaily.Width, this.dgvCTDaily.Height));
                e.Graphics.DrawImage(bm12, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintComTripWeek_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog13 = new PrintPreviewDialog();
                printPreviewDialog13.Document = printDoc13;
                printPreviewDialog13.ShowDialog(); // Brings up a Print Preview 
                printDoc13.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc13_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm13 = new Bitmap(this.dgvCTWeekly.Width, this.dgvCTWeekly.Height);
                dgvCTWeekly.DrawToBitmap(bm13, new Rectangle(0, 0, this.dgvCTWeekly.Width, this.dgvCTWeekly.Height));
                e.Graphics.DrawImage(bm13, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintComTripMonth_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog14 = new PrintPreviewDialog();
                printPreviewDialog14.Document = printDoc14;
                printPreviewDialog14.ShowDialog(); // Brings up a Print Preview 
                printDoc14.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc14_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm14 = new Bitmap(this.dgvCTMonthly.Width, this.dgvCTMonthly.Height);
                dgvCTMonthly.DrawToBitmap(bm14, new Rectangle(0, 0, this.dgvCTMonthly.Width, this.dgvCTMonthly.Height));
                e.Graphics.DrawImage(bm14, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintTimeDaily_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog15 = new PrintPreviewDialog();
                printPreviewDialog15.Document = printDoc15;
                printPreviewDialog15.ShowDialog(); // Brings up a Print Preview 
                printDoc15.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc15_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm15 = new Bitmap(this.dgvTSDaily.Width, this.dgvTSDaily.Height);
                dgvTSDaily.DrawToBitmap(bm15, new Rectangle(0, 0, this.dgvTSDaily.Width, this.dgvTSDaily.Height));
                e.Graphics.DrawImage(bm15, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintTimeWeekly_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog16 = new PrintPreviewDialog();
                printPreviewDialog16.Document = printDoc16;
                printPreviewDialog16.ShowDialog(); // Brings up a Print Preview 
                printDoc16.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc16_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm16 = new Bitmap(this.dgvTSWeekly.Width, this.dgvTSWeekly.Height);
                dgvTSWeekly.DrawToBitmap(bm16, new Rectangle(0, 0, this.dgvTSWeekly.Width, this.dgvTSWeekly.Height));
                e.Graphics.DrawImage(bm16, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }

        private void btnPrintTimeMonth_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog printPreviewDialog17 = new PrintPreviewDialog();
                printPreviewDialog17.Document = printDoc17;
                printPreviewDialog17.ShowDialog(); // Brings up a Print Preview 
                printDoc17.Print(); // Prints the Data Grid View
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex); // Shows Message Box If Error Occurs
            }
        }

        private void printDoc17_PrintPage(object sender, PrintPageEventArgs e) // Settings For Printing
        {
            try
            {
                Bitmap bm17 = new Bitmap(this.dgvTSMonthly.Width, this.dgvTSMonthly.Height);
                dgvTSMonthly.DrawToBitmap(bm17, new Rectangle(0, 0, this.dgvTSMonthly.Width, this.dgvTSMonthly.Height));
                e.Graphics.DrawImage(bm17, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Print Report: " + ex);
            }
        }      
    }
}
