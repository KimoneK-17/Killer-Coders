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

        public void CheckForNumbers()
        {

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
