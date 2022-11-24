using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Insuranceissuing
{
    internal class Person
    {

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Person(string connStr)
        {
            conn.ConnectionString = connStr;
        }
        ~Person() { }

        public DataTable ReturnData(string word)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string queary = "select [First Name],[Last Name],[Legal]" +
                                            ",[National Id],[Insurer]" +
                                            ",[Insured],[Beneficiary]" +
                                            ",[MARKETER],[USER]" +
                                            ",[MANAGER],[UNIT]" +
                                            ",[USERNAME],[PASSWORD]" +
                            " from Person " +
                            " where [First Name] like '%" + word+ "%'";
            
            cmd.CommandText = queary;
            cmd.Connection = conn;

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            return dt;

        }

    }
}
