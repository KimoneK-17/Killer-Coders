using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetTrackingInformationSystem
{
    class Register
    {
       private string dateOfBirth;
       private string regName;
       private string regSname;
       private string userName;
       private string password;
       private string empPosition;

        public Register()
       {

       }

        public Register(string dob, string name, string sname,string uname, string password, string pos)
        {

        }

        public string DOB
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }
        public string Name
        {
            get
            {
                return regName;
            }
            set
            {
                regName = value;
            }
        }

        public string SName
        {
            get
            {
                return regSname;
            }
            set
            {
                regSname = value;
            }
        }

        public string UName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string Position
        {
            get
            {
                return empPosition;
            }
            set
            {
                empPosition = value;
            }
        }


        public string SuccessMessage()
        {
            return "Successfully Registered";
        }
    }
}
