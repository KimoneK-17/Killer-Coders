using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetTrackingInformationSystem
{
    class Check
    {
        double doubleTryParseOut;
        public void CheckEmpty(string text, string fieldName)
        {
            if (text == string.Empty)
            {
                MessageBox.Show("The {0} field is empty", fieldName);
            }
        }

        public void CheckForNumbers(string text, string fieldName)
        {
            string[] numbers = new string[10];
            try
            {
                for (int x = 0; x < numbers.Length; x++)
                {
                    numbers[x] = (x + 1).ToString();
                    if (text.Contains(numbers[x]))
                    {
                        MessageBox.Show("The {0} field cannot contain numbers", fieldName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Check For Numbers: " + ex); // Shows an error message 
            }
        }

        public void CheckForLetters(string text, string fieldName)
        {
            if (double.TryParse(text, out doubleTryParseOut) == false)
            {
                MessageBox.Show("The {0} field cannot contain letters", fieldName);
            }

        }
    }
}
