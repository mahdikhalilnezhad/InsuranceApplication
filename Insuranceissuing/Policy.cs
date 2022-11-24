using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Insuranceissuing
{
    internal class Policy
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Policy(string connStr)
        {
            conn.ConnectionString = connStr;
        }
        ~Policy() { }

        public DataTable ReturnData(string word)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string queary = "select [Insurer],[User],[Item]" +
                                            ",[Premium],[From Date]" +
                                            ",[To date],[period]" +
                                            ",[MARKETER]" +
                            " from Policy ";
            // + " where [First Name] like '%" + word + "%'";

            cmd.CommandText = queary;
            cmd.Connection = conn;

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            return dt;

        }
    }
}
