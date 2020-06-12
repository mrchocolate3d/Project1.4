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
        public string role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public login password;

        public Employee()
        {
        }
        public Employee(int EmployeeId)
        {
            this.EmployeeId = EmployeeId;
        }
    }
}
