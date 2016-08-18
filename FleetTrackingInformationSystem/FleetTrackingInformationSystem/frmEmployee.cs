using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetTrackingInformationSystem
{
    public partial class frmEmployee : Form
    {
        string name;
        string surname;
        string contact;
        string salary;
        int intTryParseOut;
        double doubleTryParseOut;
        string[] numbers = new string[10];
        public frmEmployee()
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
            catch
            {
                int stopper = 1;
                while (stopper == 1)
                {
                    MessageBox.Show("Application Error");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtAddress.Clear();
                txtContactNum.Clear();
                txtEmail.Clear();
                txtID.Clear();
                txtName.Clear();
                txtSalary.Clear();
                txtSurname.Clear();
                updHours.Value = 0;
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

        public void CheckForNumbers(string name, string surname)
        {
            for (int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = (x + 1).ToString();
                if (name.Contains(numbers[x]))
                {
                    MessageBox.Show("The 'Customer Name' field cannot contain numbers");
                }
                if (surname.Contains(numbers[x]))
                {
                    MessageBox.Show("The 'Customer Surname' field cannot contain numbers");
                }
            }
        }

        public void CheckForLetters(string contact, string salary)
        {
            if (int.TryParse(contact, out intTryParseOut) == false)
            {
                MessageBox.Show("The 'Contact Number' field cannot contain letters");
            }
            if (double.TryParse(salary, out doubleTryParseOut) == false)
            {
                MessageBox.Show("The 'Monthly Salary' field cannot contain letters");
            }
        }

        public void CheckEmpty()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("The 'Employee Name' field is empty");
            }
            if (txtSurname.Text == string.Empty)
            {
                MessageBox.Show("The 'Employee Surname' field is empty");
            }
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("The 'Employee ID' field is empty");
            }
            if (cboPosition.Text == string.Empty)
            {
                MessageBox.Show("Select the employee position from the drop down list");
            }
            if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("The 'Employee Address' field is empty");
            }
            if (txtContactNum.Text == string.Empty)
            {
                MessageBox.Show("The 'Contact Number' field is empty");
            }
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("The 'Email Address' field is empty");
            }
            if (txtSalary.Text == string.Empty)
            {
                MessageBox.Show("The 'Monthly Salary' field is empty");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            surname = txtSurname.Text;
            contact = txtContactNum.Text;
            salary = txtSalary.Text;
            CheckEmpty();
            CheckForNumbers(name, surname);
            CheckForLetters(contact, salary);
        }
    }
}
