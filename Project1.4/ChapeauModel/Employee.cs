using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int roleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string emailaddress { get; set; }
        public int phonenumber { get; set; }

        //public Employee(int EmployeeId,string firstname,string lastname,string emailaddress,int phonenumber)
        //{
        //    this.EmployeeId = EmployeeId;
        //    this.FirstName = firstname;
        //    this.LastName = lastname;
        //    this.emailaddress = emailaddress;
        //    this.phonenumber = phonenumber;
        //}
    }
}
