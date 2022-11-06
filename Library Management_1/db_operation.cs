using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_Management_1
{
    class db_operation
    {
        
        
            SqlConnection con;
            public db_operation(string connectionstring)
            {
                this.con = new SqlConnection(connectionstring);
            }
            public DataTable display()
            {
                SqlCommand cmd = new SqlCommand("Select * from b_details ", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            public DataTable GetData(string query)
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                adapter.Fill(dt);
                con.Close();
                return dt;


            }
        
    }
}
