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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        public static string DoiTuongDangChon;
        private void Customer_Load(object sender, EventArgs e)
        {
            lbtaikhoan.Text = DangNhap.taikhoanhientai.Tentaikhoan;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MuaHang frmmuahang = new MuaHang();
            frmmuahang.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ThanhToan_TraHang frmthanhtoanvatrahang = new ThanhToan_TraHang();
            DoiTuongDangChon = "Thanh Toán";
            frmthanhtoanvatrahang.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ThanhToan_TraHang frmthanhtoanvatrahang = new ThanhToan_TraHang();
            DoiTuongDangChon = "Trả Hàng";
            frmthanhtoanvatrahang.ShowDialog();
        }

        private void Customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
