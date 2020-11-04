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
using System.Data.Common;

namespace DatVeXemPhim
{
    public partial class DatVe : Form
    {
        public DatVe()
        {
            InitializeComponent();
        }

        private void DatVe_Load(object sender, EventArgs e)
        {
            int colTrai = 3 , colPhai = 7, rowTrai = 10 , rowPhai = 10;
            Button[,] gheTrai = new Button[rowTrai, colTrai];
            Button[,] ghePhai = new Button[rowPhai, colPhai];

            int dem = 1;
            for(int i = 0; i < gheTrai.GetLength(0); i++)
            {
                for(int j = 0;j<gheTrai.GetLength(1);j++)
                {
                    Button btnTrai = new Button();
                    btnTrai.Text = dem.ToString();
                    btnTrai.Width = btnTrai.Height = 50;
                    btnTrai.BackColor = Color.White;
                    btnTrai.Location = new Point(j * btnTrai.Width, i * btnTrai.Height);
                    pnGheTrai.Controls.Add(btnTrai);
                    gheTrai[i, j] = btnTrai;
                    dem++;
                    btnTrai.Click += BtnTrai_Click;
                }    
            }
            
            for(int i = 0;i<ghePhai.GetLength(0);i++)
            {
                for(int j = 0; j< ghePhai.GetLength(1);j++)
                {
                    Button btnPhai = new Button();
                    btnPhai.Text = dem.ToString();
                    btnPhai.BackColor = Color.White;
                    btnPhai.Width = btnPhai.Height = 50;
                    btnPhai.Location = new Point(j * btnPhai.Width, i * btnPhai.Height);
                    pnGhePhai.Controls.Add(btnPhai);
                    ghePhai[i, j] = btnPhai;
                    dem++;
                    btnPhai.Click += BtnPhai_Click;
                }    
            }
            
            // gọi hàm update màu ghế trong sql ( su 3 ngày sẽ tự động reload lại tất cả các ghế trong fiml đó)
            try
            {
                SQL.getConnection();
                SQL.cmd.CommandText = "resetData";
                SQL.cmd.CommandType = CommandType.StoredProcedure;
                //SqlParameter sqlmafim = new SqlParameter("@mafim", SqlDbType.Int);
                //sqlmafim.Value = ClassLogin.MaFiml;
                //SQL.cmd.Parameters.Add(sqlmafim);
 
                SQL.cmd.ExecuteNonQuery();
                SQL.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // load màu của các ghế
            try
            {
                int Maghe;
                int mafiml;
                SQL.getConnection();
                string sql = "select MaGhe from Ghe where MaFiml = @mafiml";
                SQL.cmd.CommandText = sql;
                SQL.cmd.Parameters.Add(new SqlParameter("@mafiml", ClassLogin.MaFiml));
                using(DbDataReader reader = SQL.cmd.ExecuteReader())
                { 
                    if(reader.HasRows)
                        while(reader.Read())
                        {
                            Maghe = Convert.ToInt32(reader.GetValue(0));    
                            
                            if (Maghe <= 30) pnGheTrai.Controls[Maghe - 1].BackColor = Color.Red;
                            else if ( Maghe > 30) pnGhePhai.Controls[Maghe-31].BackColor = Color.Red;
                        }
                }    

                SQL.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPhai_Click(object sender, EventArgs e)
        {
            Button btnPhai = sender as Button;
            if (btnPhai.BackColor == Color.White)
            {
                btnPhai.BackColor = Color.Green;
            }
            else if (btnPhai.BackColor == Color.Green)
            {
                btnPhai.BackColor = Color.White;
            }
            else if (btnPhai.BackColor == Color.Yellow)
            {
                try
                {
                    SQL.getConnection();
                    string sql = "select Ten from Ghe where MaGhe = @maghe";
                    SQL.cmd.Parameters.Add(new SqlParameter("@maghe", btnPhai.Text));
                    SQL.cmd.CommandText = sql;
                    string ten = (string)SQL.cmd.ExecuteScalar();
                    if (ten == ClassLogin.Ten)
                    {
                        if (btnPhai.ForeColor == Color.Red) btnPhai.ForeColor = Color.Black;
                        else btnPhai.ForeColor = Color.Red;
                    }
                    else
                    {
                        MessageBox.Show("Ghế số [ " + btnPhai.Text + " ] đã được đặt", "Thông báo");
                    }

                    SQL.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ghế số [ " + btnPhai.Text + " ] đã được đặt", "Thông báo");
            }
        }

        private void BtnTrai_Click(object sender, EventArgs e)
        {
            Button btnTrai = sender as Button;
            if(btnTrai.BackColor == Color.White)
            {
                btnTrai.BackColor = Color.Green;
            }
            else if(btnTrai.BackColor == Color.Green)
            {
                btnTrai.BackColor = Color.White;
            }    
            else if(btnTrai.BackColor == Color.Yellow)
            {
                try
                {
                    SQL.getConnection();
                    string sql = "select Ten from Ghe where MaGhe = @maghe";
                    SQL.cmd.Parameters.Add(new SqlParameter("@maghe", btnTrai.Text));
                    SQL.cmd.CommandText = sql;
                    string ten = (string)SQL.cmd.ExecuteScalar();
                    if(ten == ClassLogin.Ten)
                    {
                        if (btnTrai.ForeColor == Color.Red) btnTrai.ForeColor = Color.Black;
                        else btnTrai.ForeColor = Color.Red;
                    }   
                    else
                    {
                        MessageBox.Show("Ghế số [ " + btnTrai.Text + " ] đã được đặt", "Thông báo");
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
                MessageBox.Show("Ghế số [ " + btnTrai.Text + " ] đã được đặt", "Thông báo");
            }    
        }

        private void BtnDatVe_Click(object sender, EventArgs e)
        {
            int vitri = 0;
            for(int i = 0;i<10; i++)
            {
                for(int j  =0;j<3;j++)
                {
                    if( pnGheTrai.Controls[vitri].BackColor == Color.Green)
                    {
                        ClassLogin.dsghe.Add(pnGheTrai.Controls[vitri].Text);
                    }
                    vitri++;
                }    
            }
            vitri = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (pnGhePhai.Controls[vitri].BackColor == Color.Green)
                    {
                        ClassLogin.dsghe.Add(pnGhePhai.Controls[vitri].Text);
                    }
                    vitri++;
                }
            }

            if(ClassLogin.dsghe.Count() > 0)
            {
                ThongTinDatVe ttdatve = new ThongTinDatVe();
                ttdatve.ShowDialog();
                if(ClassLogin.CheckDatGhe == true)
                {
                    foreach (string item in ClassLogin.dsghe)
                    {
                        if (Convert.ToInt32(item) <= 30) pnGheTrai.Controls[Convert.ToInt32(item) - 1].BackColor = Color.Red;
                        else pnGhePhai.Controls[Convert.ToInt32(item) - 31].BackColor = Color.Red;
                    }

                    // xuất màn hình hiện hóa đơn
                    HoaDon hoadon = new HoaDon();
                    hoadon.ShowDialog();
                }

                ClassLogin.dsghe.Clear();
                ClassLogin.CheckDatGhe = false;
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(ret == DialogResult.Yes)
            {
                ClassLogin.dsghe.Clear();
                ClassLogin.CheckDatGhe = false;
                this.Close();
            }    
        }
    }
}
