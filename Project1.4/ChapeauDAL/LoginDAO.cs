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
    public class LoginDAO  : Base
    {
        public List<login> GetAllLoginInfo(int loginCode)
        {
            string query = $"SELECT [login].loginCode,[login].employeeID,firstName,lastName,roles.roleDescription " +
                $"FROM (([login] inner join employees ON [login].employeeID = employees.employeeID) " +
                $"INNER JOIN [roles] ON roles.roleID = employees.roleID) where [login].loginCode = {loginCode}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadLoginTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<login> ReadLoginTables(DataTable loginTable)
        {
            List<login> logins = new List<login>();

            foreach(DataRow dr in loginTable.Rows)
            {
                login login = new login()
                {
                    loginCode = (int)dr["loginCode"],
                    employeeID = (int)dr["employeeID"],
                    firstname = (string)(dr["firstName"]),
                    lastname = (string)(dr["lastName"]),
                    role = (string)(dr["roleDescription"])

                };
                logins.Add(login);
            }
            return logins;
        }
           
    }
}
