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
    public partial class ThongTinDatVe : Form
    {
        public ThongTinDatVe()
        {
            InitializeComponent();
        }

        private void ThongTinDatVe_Load(object sender, EventArgs e)
        {
            txtUserName.Text = ClassLogin.Ten;
            txtThanhTien.Text = (ClassLogin.dsghe.Count * 100000).ToString();
            foreach(string item in ClassLogin.dsghe)
            {
                cobDSGhe.Items.Add(item);
            }
            cobDSGhe.Text = cobDSGhe.Items[0].ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtSDT.Text.Trim() != "" && cobPTThanhToan.SelectedIndex != -1)
            {
                DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn đặt vé không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(ret == DialogResult.Yes)
                {
                    ClassLogin.DatGhe(txtSDT.Text , cobPTThanhToan.SelectedItem.ToString());
                    ClassLogin.CheckDatGhe = true;
                    ClassLogin.SDT = txtSDT.Text;
                    ClassLogin.PTTT = cobPTThanhToan.SelectedItem.ToString();
                    ClassLogin.ThanhTien = txtThanhTien.Text;
                    ClassLogin.Ten = txtUserName.Text;
                    this.Close();
                }
                else
                {
                    ClassLogin.CheckDatGhe = false;
                    this.Close();
                }    
            }   
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClassLogin.CheckDatGhe = false;
            this.Close();
        }
    }
}
