using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatVeXemPhim
{
    public partial class ThongTinAcc : Form
    {
        public ThongTinAcc()
        {
            InitializeComponent();
        }

        private void ThongTinAcc_Load(object sender, EventArgs e)
        {
            txtTenAcc.Text = ClassLogin.Ten;
            txtLichSuTruyCap.Text = "Lịch Sử Truy Cập";
            DataSet data = new DataSet();
            try
            {
                SQL.getConnection();
                string sql = "select (select TenFiml from Fiml where Fiml.MaFiml = Ghe.MaFiml) as N'Tên Fiml' , MaGhe, TG,PTTT,SDT from Ghe where Ten = @ten";
                SQL.cmd.CommandText = sql;
                SQL.cmd.CommandType = CommandType.Text;
                SQL.cmd.Parameters.Add(new SqlParameter("@ten", ClassLogin.Ten));
                SqlDataAdapter adapter = new SqlDataAdapter(SQL.cmd);
                adapter.Fill(data);

                SQL.closeConnection();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgvTTA.DataSource = data.Tables[0];
            dgvTTA.AutoSize = true;
            dgvTTA.ReadOnly = true;
            dgvTTA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc muốn đăng xuất","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(ret == DialogResult.Yes)
            {
                this.Close();
                ClassLogin.Ten = "";
                ClassLogin.MK = "";
            }    
        }

        private void dgvTTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DoiMK doiMK = new DoiMK();
            doiMK.ShowDialog();
            this.Visible = true;
        }
    }
}
