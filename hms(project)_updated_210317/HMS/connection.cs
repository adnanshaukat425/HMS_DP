using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace HMS
{
    class connection
    {
        public static string connmethod()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PROGRAMMINGART;Initial Catalog=HMS_OOP;Integrated Security=True;");
            //SqlConnection conn = new SqlConnection(@"Data Source=MUHAMMEDREZA;Initial Catalog=HMS_OOP;User ID=sa;Password=sa9");
            string connstring = conn.ConnectionString;
            return connstring;
        }
    }
}
