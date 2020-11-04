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
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtEmail.Focus();
        }

        private void btnLayMaDN_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Trim() != "UserName/SDT.............." && txtEmail.Text.Trim() != "")
            {
                SqlParameter ten = new SqlParameter("@ten", SqlDbType.NVarChar);
                SqlParameter mk = new SqlParameter("@mk", SqlDbType.NVarChar);
                try
                {
                    SQL.getConnection();

                    string sql = "select count(*) from DangNhap where Ten = @ten";
                    SQL.cmd.CommandText = sql;
                    ten.Value = txtEmail.Text;
                    SQL.cmd.Parameters.Add(ten);
                    int x = (int)SQL.cmd.ExecuteScalar();
                    if(x < 1)
                    {
                        MessageBox.Show("Tên đăng nhập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                    else
                    {
                        Random rd = new Random();
                        string madn = rd.Next(10000).ToString();
                        DialogResult ret = MessageBox.Show(madn, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (ret == DialogResult.Yes)
                        {
                            txtMaDN.Text = madn;
                        }
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
                MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc sô điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnOKQuenMK_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Trim() != "" && txtEmail.Text.Trim() != "UserName/SDT.............." 
                && txtMaDN.Text.Trim() != "" && txtMaDN.Text.Trim() != "Mã đăng nhập........." 
                && txtNhapCodeQuenMK.Text.Trim() != "")
            {
                errorProvider1.SetError(txtNhapCodeQuenMK, "");
                if(txtNhapCodeQuenMK.Text.Trim() != txtCodeQuenMK.Text.Trim())
                {
                    errorProvider1.SetError(txtNhapCodeQuenMK, "Nhập sai mã CaptChar");
                    return;
                }    
                try
                {
                    SqlParameter mk = new SqlParameter("@mk", SqlDbType.NVarChar);
                    SqlParameter ten = new SqlParameter("@ten", SqlDbType.NVarChar);
                    SQL.getConnection();

                    Random rd = new Random();
                    string MK = rd.Next(10000).ToString();
                    string mes = "Mật khẩu mới của bạn là : " + MK;
                    DialogResult ret = MessageBox.Show(mes, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(ret == DialogResult.Yes)
                    {
                        string sql = "update DangNhap set MK = @mk where Ten = @ten";
                        SQL.cmd.CommandText = sql;
                        ten.Value = txtEmail.Text;
                        mk.Value = MK;
                        SQL.cmd.Parameters.Add(ten);
                        SQL.cmd.Parameters.Add(mk);
                        SQL.cmd.ExecuteNonQuery();
                        ClassLogin.Ten = txtEmail.Text;
                        ClassLogin.MK = MK;
                        if(ClassLogin.Ten == "admin")
                        {
                            this.Visible = false;
                            ThongTinKH ttkh = new ThongTinKH();
                            ttkh.ShowDialog();
                            this.Close();
                        }    
                        else
                        {
                            this.Visible = false;
                            DatVe datve = new DatVe();
                            datve.ShowDialog();
                            this.Close();
                        }       
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
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void picReLoad_Click(object sender, EventArgs e)
        {

            Random rd = new Random();
            txtCodeQuenMK.Text = rd.Next(10) + "wG" + rd.Next(10) + "tHC";
        }

        private void QuenMK_Load(object sender, EventArgs e)
        {

            Random rd = new Random();
            txtCodeQuenMK.Text = rd.Next(10) + "wG" + rd.Next(10) + "tHC";
        }

        private void btnCancelQuenMK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
