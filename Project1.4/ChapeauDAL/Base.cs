using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Diagnostics;

namespace ChapeauDAL
{
    public abstract class Base
    {
        private SqlDataAdapter adapter;
        private SqlConnection conn;

        /*Connect to the databse where the connectionstring name is CharpeauDatabase*/
        protected SqlConnection OpenConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString);
            adapter = new SqlDataAdapter();

            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        /*Close the connection to the database*/
        private void CloseConnection()
        {
            conn.Close();
        }

        /*Insert/Update and Delete queries*/
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand com = new SqlCommand();
            StringBuilder errorMessages = new StringBuilder();
            try
            {
                com.Connection = OpenConnection();
                com.CommandText = query;
                com.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = com;
                com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Error " + i + "\n" +
                         "Message: " + ex.Errors[i].Message + "\n" +
                         "Error Number: " + ex.Errors[i].Number + "\n" +
                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                         "Source: " + ex.Errors[i].Source + "\n" +
                         "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Debug.WriteLine(errorMessages);
            }
            finally
            {
                CloseConnection();
            }
        }

        /*Select querys*/
        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
        {
            StringBuilder errorMessages = new StringBuilder();
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Error " + i + "\n" +
                         "Message: " + ex.Errors[i].Message + "\n" +
                         "Error Number: " + ex.Errors[i].Number + "\n" +
                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                         "Source: " + ex.Errors[i].Source + "\n" +
                         "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Debug.WriteLine(errorMessages);
                return null;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }
    }
}
