using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVeXemPhim
{
    public class SQL
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static void  getConnection()
        {
            string strConnection = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=SQL_MyApp_BookTicket;Integrated Security=True";
            con = new SqlConnection(strConnection);
            con.Open();
            cmd = con.CreateCommand();
        }
        public static void closeConnection()
        {
            con.Close();
            con.Dispose();
        }
    }
}
