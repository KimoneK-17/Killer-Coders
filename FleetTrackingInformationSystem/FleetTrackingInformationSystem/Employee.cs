using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetTrackingInformationSystem
{
    class Employee
    {
        private string E_ID;
        private string E_NAME;
        private string E_SNAME;
        private string E_POS;
        private string E_CONTACT;
        private string E_EMAIL;
        private string E_SALARY;

       public Employee()
        {

        }

        public Employee(string id, string name, string sname, string pos, string contact, string email, string salary)
       {

       }

        public string ID
        {
            get
            {
                return E_ID;
            }
            set
            {
                E_ID = value;
            }
        }

        public string Name
        {
            get
            {
                return E_NAME;
            }
            set
            {
                E_NAME = value;
            }
        }

        public string SName
        {
            get
            {
                return E_SNAME;
            }
            set
            {
                E_SNAME = value;
            }
        }

        public string Position
        {
            get
            {
                return E_POS;
            }
            set
            {
                E_POS = value;
            }
        }

        public string Contact
        {
            get
            {
                return E_CONTACT;
            }
            set
            {
                E_CONTACT = value;
            }
        }

        public string Email
        {
            get
            {
                return E_EMAIL;
            }
            set
            {
                E_EMAIL = value;
            }
        }

        public string Salary
        {
            get
            {
                return E_SNAME;
            }
            set
            {
                E_SALARY = value;
            }
        }

        public string SuccessMessage()
        {
            return "Details Added Successfully";
        }

    }
}
