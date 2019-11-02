using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace HMS
{
    class LoginAccessManager
    {
        SqlConnection scon = new SqlConnection(connection.connmethod());
        SqlCommand scom;
        string result = "";

        public string login(login_access la)
        {
            try
            {
                scon.Open();
                la.sql = "SELECT COUNT(*) FROM Users where username='" + la.user + "' and password='" + la.pass + "'";
                scom = new SqlCommand(la.sql, scon);
                la.c = (int)scom.ExecuteScalar();

                if ((la.c > 0))
                {
                    string sql2 = "INSERT INTO login_details (username,datetime) VALUES ('" + la.user + "','" + DateTime.Now.ToString() + "')";
                    scom = new SqlCommand(sql2, scon);
                    scom.ExecuteNonQuery();
                    scon.Close();
                    if (la.c > 0)
                    {
                        result = "Login Successfully !";
                    }
                }
                else
                {
                    result = "Invalid Login !";
                    scon.Close();
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}