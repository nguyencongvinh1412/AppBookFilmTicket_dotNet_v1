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
            try
            {
                string strConnection = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=SQL_MyApp_BookTicket;Integrated Security=True";
                con = new SqlConnection(strConnection);
                con.Open();
                cmd = con.CreateCommand();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void closeConnection()
        {
            con.Close();
            con.Dispose();
        }
    }
}
