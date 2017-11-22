using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan frmthemtk = new ThemTaiKhoan();
            frmthemtk.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lbtaikhoan.Text = DangNhap.taikhoanhientai.Tentaikhoan;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ResetMatKhau frmresetmk = new ResetMatKhau();
            frmresetmk.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            VoHieuHoaTK frmvohieuhoatk = new VoHieuHoaTK();
            frmvohieuhoatk.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            KichhoatTK frmkichhoattk = new KichhoatTK();
            frmkichhoattk.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ThongKe frmthongke = new ThongKe();
            frmthongke.ShowDialog();
        }

        private void Admin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
