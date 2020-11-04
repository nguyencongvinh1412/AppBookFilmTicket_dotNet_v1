using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatVeXemPhim
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void txtUserName_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Trim() == "" || txtUserName.Text == "User Name.............") txtUserName.Text = "";
            if (txtPassword.Text.Trim() == "") txtPassword.Text = "Password...............";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "" || txtPassword.Text == "Password...............") txtPassword.Text = "";
            if (txtUserName.Text.Trim() == "") txtUserName.Text = "User Name.............";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() != "" && txtPassword.Text != "Password...............")
                txtPassword.PasswordChar = '*';
            else txtPassword.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Trim() != "" && txtUserName.Text.Trim() != "User Name............." 
                && txtPassword.Text.Trim() != "" && txtPassword.Text.Trim() != "Password...............")
            {
                try
                {
                    SQL.getConnection();
                    string sql = "select count(*) from DangNhap where Ten = @user and MK = @mk";
                    SQL.cmd.CommandText = sql;
                    SQL.cmd.Parameters.Add(new SqlParameter("@user", txtUserName.Text));
                    SQL.cmd.Parameters.Add(new SqlParameter("@mk", txtPassword.Text));
                    int x = (int)SQL.cmd.ExecuteScalar();
                    if(x == 1 )
                    {
                        ClassLogin.Ten = txtUserName.Text;
                        ClassLogin.MK = txtPassword.Text;
                        if(ClassLogin.Ten == "admin")
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
                    }    
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu bị sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    SQL.closeConnection();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin đăng nhập", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtUserName.Focus();
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblQuenMK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            QuenMK quenmk = new QuenMK();
            quenmk.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
