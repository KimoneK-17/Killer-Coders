using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FleetTrackingInformationSystem
{
    class Check
    {
        double doubleTryParseOut;
        public bool CheckEmpty(string text, string fieldName, bool exit)
        {
            if (text == string.Empty)
            {
                MessageBox.Show("The " + fieldName + " field is empty");
                exit = true;
            }
            return exit;
        }

        public bool CheckForNumbers(string text, string fieldName)
        {
            bool exit = false;
            string[] numbers = new string[10];
            try
            {
                for (int x = 0; x < numbers.Length; x++)
                {
                    numbers[x] = (x + 1).ToString();
                    if (text.Contains(numbers[x]))
                    {
                        MessageBox.Show("The " + fieldName + " field cannot contain numbers");
                        exit = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Check For Numbers: " + ex); // Shows an error message 
            }
            return exit;
        }

        public bool CheckForLetters(string text, string fieldName)
        {
            bool exit = false;
            if (double.TryParse(text, out doubleTryParseOut) == false)
            {
                MessageBox.Show("The " + fieldName + " field cannot contain letters");
                exit = true;
            }
            return exit;
        }
        public bool CheckDB(string tableName, string fieldName, string field)
        {
            bool checkID;
            string exist_id;
            DBConnect objDBConnect = new DBConnect();
            objDBConnect.OpenConnection();

            objDBConnect.sqlCmd = new SqlCommand("SELECT COUNT(*) FROM " + tableName + " WHERE " + fieldName + " LIKE @" + fieldName + ";", objDBConnect.sqlConn);
            objDBConnect.sqlCmd.Parameters.AddWithValue("@" + fieldName, field);
            exist_id = objDBConnect.sqlCmd.ExecuteScalar().ToString();

            if (int.Parse(exist_id) > 0)
            {
                checkID = true;
            }
            else
            {
                checkID = false;
            }

            objDBConnect.sqlConn.Close();
            return checkID;
        }
    }
}
