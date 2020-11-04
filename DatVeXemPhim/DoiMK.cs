using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatVeXemPhim
{
    public partial class DoiMK : Form
    {
        public DoiMK()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPassOld.Text != "" && txtPassNew.Text != "")
            {
                try
                {
                    if (txtName.Text == ClassLogin.Ten && txtPassOld.Text == ClassLogin.MK)
                    {
                        SqlParameter mk = new SqlParameter("@newpass", SqlDbType.NVarChar);
                        SqlParameter ten = new SqlParameter("@name", SqlDbType.NVarChar);
                        SQL.getConnection();

                        string sql = "resetPassDangNhap";
                        SQL.cmd.CommandText = sql;
                        SQL.cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        ten.Value = txtName.Text;
                        mk.Value = txtPassNew.Text;

                        SQL.cmd.Parameters.Add(ten);
                        SQL.cmd.Parameters.Add(mk);
                        SQL.cmd.ExecuteNonQuery();

                        ClassLogin.MK = txtPassNew.Text;
                        if (ClassLogin.Ten == "admin")
                        {
                            this.Visible = false;
                            ThongTinKH ttkh = new ThongTinKH();
                            ttkh.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            this.Close();
                        }

                        SQL.closeConnection();
                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu Chưa Chính Xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassOld.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn Vui Lòng Nhập Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoiMK_Load(object sender, EventArgs e)
        {
            txtName.Text = ClassLogin.Ten;
            txtPassOld.Focus();
        }
    }
}
