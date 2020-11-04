using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatVeXemPhim
{
    public class ClassLogin
    {
        public static string Ten = "";
        public static string MK  = "";
        public static string SDT = "";
        public static string PTTT = "";
        public static string tenFiml = "";
        public static string ThanhTien = "";
        public static List<string> dsghe = new List<string>();
        public static bool CheckDatGhe = false;
        public static int MaFiml;
        

        
        public static void DatGhe(string sdt, string pttt)
        {
            try
            {
                SQL.getConnection();

                SQL.cmd.CommandText = "SQLDatGhe";
                SQL.cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter maghe = new SqlParameter("@maghe", System.Data.SqlDbType.Int);
                SqlParameter ten = new SqlParameter("@ten", System.Data.SqlDbType.NVarChar);
                SqlParameter sqlsdt = new SqlParameter("@sdt", System.Data.SqlDbType.NVarChar);
                SqlParameter sqlpttt = new SqlParameter("@pttt", System.Data.SqlDbType.NVarChar);
                SqlParameter sqlmafiml = new SqlParameter("@mafiml", System.Data.SqlDbType.Int);

                ten.Value = ClassLogin.Ten;
                SQL.cmd.Parameters.Add(ten);

                sqlsdt.Value = sdt;
                SQL.cmd.Parameters.Add(sqlsdt);

                sqlpttt.Value = pttt;
                SQL.cmd.Parameters.Add(sqlpttt);

                sqlmafiml.Value = ClassLogin.MaFiml;
                SQL.cmd.Parameters.Add(sqlmafiml);

                SQL.cmd.Parameters.Add(maghe);

                foreach (string item in ClassLogin.dsghe)
                {
                    maghe.Value = item;
                    SQL.cmd.ExecuteNonQuery();
                }

                SQL.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
