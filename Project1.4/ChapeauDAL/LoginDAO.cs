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
        public List<login> GetAllLoginInfo()
        {
            string query = "Select (loginCode) FROM [login]";
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
                    loginCode = (int)dr["loginCode"]
                };
                logins.Add(login);
            }
            return logins;
        }
           
    }
}
