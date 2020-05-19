using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using ChapeauModel;

namespace ChapeauDAL
{
    public class EmployeeDAO : Base
    {
        public List<Employee> GetUserLoginInfo(int EmployeeID)
        {
            string query = "Select firstName,lastName,roleID FROM employees WHERE employeeID = " + EmployeeID + "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadEmployeeTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Employee> ReadEmployeeTables(DataTable loginTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in loginTable.Rows)
            {
                Employee employee = new Employee()
                {
                    FirstName = (string)(dr["firstName"]),
                    LastName = (string)(dr["lastName"]),
                    roleID = (int)dr["roleID"]

                };
                employees.Add(employee);
            }
            return employees;
        }
    }
}
