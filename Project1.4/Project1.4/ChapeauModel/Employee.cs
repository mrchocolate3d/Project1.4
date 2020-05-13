using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    class Employee
    {
        private int EmployeeId;
        private string FirstName;
        private string LastName;
        private string emailaddress;
        private int phonenumber;

        public Employee(int EmployeeId,string firstname,string lastname,string emailaddress,int phonenumber)
        {
            this.EmployeeId = EmployeeId;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.emailaddress = emailaddress;
            this.phonenumber = phonenumber;
        }
    }
}
