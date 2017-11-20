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
    public partial class QuanLi : Form
    {
        public static String TacVuHienTai;
        public QuanLi()
        {
            InitializeComponent();
        }

        private void QuanLi_Load(object sender, EventArgs e)
        {
            lbtaikhoan.Text = DangNhap.taikhoanhientai.Tentaikhoan;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ThemHang frmthemhang = new ThemHang();
            frmthemhang.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            XoaHang frmxoahang = new XoaHang();
            QuanLi.TacVuHienTai = "Xóa Hàng";
            frmxoahang.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            XoaHang frmxoahang = new XoaHang();
            QuanLi.TacVuHienTai = "Sửa Thông Tin HH";
            frmxoahang.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            XoaHang frmtimkiem = new XoaHang();
            QuanLi.TacVuHienTai = "Tìm Kiếm";
            frmtimkiem.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ThongKe frmthongke = new ThongKe();
            frmthongke.ShowDialog();
        }

        private void QuanLi_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
