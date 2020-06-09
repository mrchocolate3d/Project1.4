using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;
using System.Windows.Forms;

namespace ChapeauLogic
{
    public class EmployeeServices
    {
        EmployeeDAO employee_db = new EmployeeDAO();

        public Employee GetEmployees(login loginCode)
        {
            try
            {
                Employee employee = employee_db.GetUserLoginInfo(loginCode);
                return employee;
            }
            catch
            {
                return null;
            }
        }
    }
}
