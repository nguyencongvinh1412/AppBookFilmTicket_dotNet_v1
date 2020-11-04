using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatVeXemPhim
{
    public partial class ThongTinKH : Form
    {
        public ThongTinKH()
        {
            InitializeComponent();
        }

        private void ThongTinKH_Load(object sender, EventArgs e)
        {
            // đọc dữ liệu từ table DangNhap để đổ dữ liệu vào listbox
            try
            {
                SQL.getConnection();

                string sql = "select Ten from Ghe group by Ten";
                SQL.cmd.CommandText = sql;
                DbDataReader reader = SQL.cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        string ten = reader.GetString(0).ToString();
                        lstDanhSachDatVe.Items.Add(ten);
                    }    
                }
                SQL.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // lấy được số lượng row trong bảng Ghế để tính tổng doanh thu
            try
            {
                SQL.getConnection();
                string sql = "select count(*) from Ghe";
                SQL.cmd.CommandText = sql;
                int x = (int)SQL.cmd.ExecuteScalar();
                txtDoanhThu.Text = (x * 100000).ToString();

                SQL.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstDanhSachDatVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ten = lstDanhSachDatVe.SelectedItem.ToString();
            dgvGhe.AutoSize = true;
            dgvGhe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGhe.ReadOnly = true;
            dgvGhe.DataSource = GetDataGhe(ten).Tables[0];
        }
        DataSet GetDataGhe(string ten)
        {        
            DataSet data = new DataSet();

            try
            {
                SQL.getConnection();
                string sql = "select (select TenFiml from Fiml where Fiml.MaFiml = Ghe.MaFiml) as N'Tên Fiml' , MaGhe, TG,PTTT,SDT from Ghe where Ten = @ten";
                SQL.cmd.CommandText = sql;
                SQL.cmd.CommandType = CommandType.Text;
                SQL.cmd.Parameters.Add(new SqlParameter("@ten", ten));
                SqlDataAdapter adapter = new SqlDataAdapter(SQL.cmd);
                adapter.Fill(data);

                SQL.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return data;
        }

        
    }
}
