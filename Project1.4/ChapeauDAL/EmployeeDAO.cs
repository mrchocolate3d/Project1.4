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
        public Employee GetUserLoginInfo(login loginCode)
        {
            string query = $"SELECT [login].loginCode,firstName,lastName,roles.roleDescription " +
                $"FROM (([login] inner join employees ON [login].employeeID = employees.employeeID) " +
                $"INNER JOIN [roles] ON roles.roleID = employees.roleID) WHERE [login].loginCode = {loginCode.loginCode}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetEmployee(ExecuteSelectQuery(query, sqlParameters));
        }


        private Employee GetEmployee(DataTable loginTable)
        {
            DataRow dr = loginTable.Rows[0];
                Employee employee = new Employee()
                {
                    password = new login((int)dr["loginCode"]),
                    FirstName = (string)(dr["firstName"]),
                    LastName = (string)(dr["lastName"]),
                    role = (string)(dr["roleDescription"])
                };
            return employee;
        }
    }
}

