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
    public class TableDAO : Base
    {
        public List<Table> getAllTables()
        {
            string query = "Select * FROM [tables]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTableTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> ReadTableTables(DataTable resturantTables)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in resturantTables.Rows)
            {
                Table table = new Table()
                {
                    TableID = (int)dr["tableID"],
                    status = (string)(dr["status"])
                };
                tables.Add(table);
            }
            return tables;
        }
    }
}
