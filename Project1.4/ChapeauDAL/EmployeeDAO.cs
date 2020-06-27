using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class EmployeeDAO : Base
    {
        public Employee GetEmployeeInfo(login loginCode)
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
            
            if (loginTable.Rows.Count == 0)
            {
                return null;
            }
            else
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

        //public Employee GetOne(int id)
        //{
        //    string query = "";
        //    SqlParameter[] sqlParameters = new SqlParameter[1];
        //    sqlParameters[0] = new SqlParameter("@id", id);
        //    DataTable dt = ExecuteSelectQuery(query, sqlParameters);

        //    Employee emp = null;
        //    if (dt.Rows.Count > 0)
        //    {
        //        DataRow dr = dt.Rows[0];

        //        emp = new Employee()
        //        {
        //            password = new login((int)dr["loginCode"]),
        //            EmployeeId = (int)dr["employeeID"],
        //            FirstName = (string)(dr["firstName"]),
        //            LastName = (string)(dr["lastName"]),
        //            role = (string)(dr["roleDescription"])
        //        };
        //    }
        //    return emp;
        //}
    }
}

