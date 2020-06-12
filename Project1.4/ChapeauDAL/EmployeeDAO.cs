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
            string query = $"SELECT [login].loginCode,firstName,lastName,roles.roleDescription,[login].employeeID " +
                $"FROM (([login] inner join employees ON [login].employeeID = employees.employeeID) " +
                $"INNER JOIN [roles] ON roles.roleID = employees.roleID) WHERE [login].loginCode = @loginCode";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@loginCode", loginCode.loginCode);
            return GetEmployee(ExecuteSelectQuery(query, sqlParameters));
        }


        private Employee GetEmployee(DataTable loginTable)
        {
            DataRow dr = loginTable.Rows[0];
                Employee employee = new Employee()
                {
                    password = new login((int)dr["loginCode"]),
                    EmployeeId = (int)dr["employeeID"],
                    FirstName = (string)(dr["firstName"]),
                    LastName = (string)(dr["lastName"]),
                    role = (string)(dr["roleDescription"])
                };
            return employee;
        }
    }
}

