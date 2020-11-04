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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                SqlParameter ten = new SqlParameter("@name",SqlDbType.NVarChar);
                SqlParameter mk = new SqlParameter("@pass",SqlDbType.NVarChar);
                try
                {
                    SQL.getConnection();
                    string sql = "select count(*) from DangNhap where Ten = @name";
                    SQL.cmd.CommandText = sql;
                    ten.Value = txtUserName.Text;
                    SQL.cmd.Parameters.Add(ten);
                    int x = (int)SQL.cmd.ExecuteScalar();
                    if(x >= 1)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }    
                    else
                    {
                        sql = "addDangNhap";
                        SQL.cmd.CommandText = sql;
                        SQL.cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        ten.Value = txtUserName.Text;
                        mk.Value = txtPassword.Text;
                        SQL.cmd.Parameters.Add(mk);
                        SQL.cmd.ExecuteNonQuery();
                        ClassLogin.Ten = txtUserName.Text;
                        ClassLogin.MK = txtPassword.Text;

                        this.Close();
                    }
                    SQL.closeConnection();
                }
                catch ( Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   
            else
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(ret == DialogResult.Yes)
            {
                this.Close();
            }    
        }
    }
}
