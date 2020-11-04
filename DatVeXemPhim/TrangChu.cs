using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatVeXemPhim
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        int FimlLeft, FimlRight, KMLeft, KMRight;

        private void lblDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
            if (ClassLogin.Ten.Length > 0)
            {
                lblDangNhap.Visible = false;
                lblDangKy.Visible = false;
                pcAcc.Visible = true;
                lblTen.Text = ClassLogin.Ten;
                lblTen.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
            if(ClassLogin.Ten.Length >0)
            {
                lblDangNhap.Visible = false;
                lblDangKy.Visible = false;
                pcAcc.Visible = true;
                lblTen.Text = ClassLogin.Ten;
                lblTen.Visible = true;
            }    
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            pcFiml1.Image = imageListFiml.Images[0];
            pcFiml2.Image = imageListFiml.Images[1];
            pcFiml3.Image = imageListFiml.Images[2];
            pcFiml4.Image = imageListFiml.Images[3];
            FimlLeft = 0; FimlRight = 3;
                
            pcKM1.Image = imageListKM.Images[0];
            pcKM2.Image = imageListKM.Images[1];
            pcKM3.Image = imageListKM.Images[2];
            pcKM4.Image = imageListKM.Images[3];
            KMLeft = 0; KMRight = 3;

            pcAcc.Visible = false;
            if(ClassLogin.Ten != "")
            {
                lblDangNhap.Visible = false;
                lblDangKy.Visible = false;
                pcAcc.Visible = true;
                lblTen.Text = ClassLogin.Ten;
                lblTen.Visible = true;
            }    
            else
            {
                lblDangNhap.Visible = true;
                lblDangKy.Visible = true;
                pcAcc.Visible = false;
                lblTen.Visible = false;
            }    
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pcNextFiml_Click(object sender, EventArgs e)
        {
            if(FimlRight < 12)
            {
                FimlRight++;
                FimlLeft++;
                pcFiml4.Image = imageListFiml.Images[FimlRight];
                pcFiml3.Image = imageListFiml.Images[FimlRight-1];
                pcFiml2.Image = imageListFiml.Images[FimlRight - 2];
                pcFiml1.Image = imageListFiml.Images[FimlRight - 3];
            }    
        }

        private void pcBackFiml_Click(object sender, EventArgs e)
        {
            if(FimlLeft > 0 )
            {
                FimlLeft--;
                FimlRight--;
                pcFiml1.Image = imageListFiml.Images[FimlLeft];
                pcFiml2.Image = imageListFiml.Images[FimlLeft+1];
                pcFiml3.Image = imageListFiml.Images[FimlLeft+2];
                pcFiml4.Image = imageListFiml.Images[FimlLeft+3];
            }    
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (KMLeft > 0)
            {
                KMLeft--;
                KMRight--;
                pcKM1.Image = imageListKM.Images[KMLeft];
                pcKM2.Image = imageListKM.Images[KMLeft + 1];
                pcKM3.Image = imageListKM.Images[KMLeft + 2];
                pcKM4.Image = imageListKM.Images[KMLeft + 3];
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (KMRight < 6)
            {
                KMLeft++;
                KMRight++;
                pcKM4.Image = imageListKM.Images[KMRight];
                pcKM3.Image = imageListKM.Images[KMRight - 1];
                pcKM2.Image = imageListKM.Images[KMRight - 2];
                pcKM1.Image = imageListKM.Images[KMRight - 3];
            }
        }

        private void pcAcc_Click(object sender, EventArgs e)
        {
            ThongTinAcc ttacc = new ThongTinAcc();
            ttacc.ShowDialog();

            if (ClassLogin.Ten != "")
            {
                lblDangNhap.Visible = false;
                lblDangKy.Visible = false;
                pcAcc.Visible = true;
                lblTen.Text = ClassLogin.Ten;
                lblTen.Visible = true;
            }
            else
            {
                lblDangNhap.Visible = true;
                lblDangKy.Visible = true;
                pcAcc.Visible = false;
                lblTen.Visible = false;
            }
        }

        private void btnMua1_Click(object sender, EventArgs e)
        {
            if(ClassLogin.Ten == "admin")
            {
                return;
            }    
            if(btnMua1.Visible == true)
                if (ClassLogin.Ten != "")
                {
                    // lấy mã fiml 
                    ClassLogin.MaFiml = FimlLeft;

                    this.Visible = false;
                    DatVe datve = new DatVe();
                    datve.ShowDialog();
                    this.Visible = true;
                }
        }

        private void btnMua2_Click(object sender, EventArgs e)
        {
            if (ClassLogin.Ten == "admin")
            {
                return;
            }
            if (btnMua2.Visible == true)
                if (ClassLogin.Ten != "")
                {
                    // lấy mã fiml 
                    ClassLogin.MaFiml = FimlLeft+1;

                    this.Visible = false;
                    DatVe datve = new DatVe();
                    datve.ShowDialog();
                    this.Visible = true;
                }
        }

        private void btnMua3_Click(object sender, EventArgs e)
        {
            if (ClassLogin.Ten == "admin")
            {
                return;
            }
            if (btnMua3.Visible == true)
                if (ClassLogin.Ten != "")
                {
                    // lấy mã fiml 
                    ClassLogin.MaFiml = FimlLeft+2;

                    this.Visible = false;
                    DatVe datve = new DatVe();
                    datve.ShowDialog();
                    this.Visible = true;
                }
        }

        private void btnMua4_Click(object sender, EventArgs e)
        {
            if (ClassLogin.Ten == "admin")
            {
                return;
            }
            if (btnMua4.Visible == true)
                if (ClassLogin.Ten != "")
                {
                    // lấy mã fiml 
                    ClassLogin.MaFiml = FimlLeft+3;

                    this.Visible = false;
                    DatVe datve = new DatVe();
                    datve.ShowDialog();
                    this.Visible = true;
                }
        }

        private void indonesiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pcFiml3_MouseMove(object sender, MouseEventArgs e)
        {
            btnMua3.Visible = true;
            btnXem3.Visible = true;
        }

        private void pcFiml4_MouseLeave(object sender, EventArgs e)
        {
            btnMua4.Visible = false;
            btnXem4.Visible = false;
        }

        private void pcFiml4_MouseMove(object sender, MouseEventArgs e)
        {
            btnMua4.Visible = true;
            btnXem4.Visible = true;
        }
    }
}
