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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            txtTen.Text = ClassLogin.Ten;
            txtSDT.Text = ClassLogin.SDT;
            txtPTTT.Text = ClassLogin.PTTT;
            txtThanhTien.Text = ClassLogin.ThanhTien;
            foreach (string item in ClassLogin.dsghe)
            {
                txtDSGhe.Text += item + "  ";
            }
            DateTime dt = DateTime.Now;
            string.Format("dd/MM/yyyy HH:mm:ss", dt);
            txtTG.Text = dt.ToString();
            try
            {
                SQL.getConnection();
                string sql = "select TenFiml from Fiml where MaFiml = @mafiml";
                SQL.cmd.CommandText = sql;
                SQL.cmd.Parameters.Add(new SqlParameter("@mafiml", ClassLogin.MaFiml));
                string tenfiml = (string)SQL.cmd.ExecuteScalar();
                txtTenFiml.Text = tenfiml;
                SQL.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // QRcode
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder { };
            encode.QRCodeScale = 5;
            Random rd = new Random();
            string strcode = ClassLogin.Ten + ClassLogin.MaFiml + rd.Next(100).ToString();
            Bitmap bmp = encode.Encode(strcode);
            pcQRCode.Image = bmp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
