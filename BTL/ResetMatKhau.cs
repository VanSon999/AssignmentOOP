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
    public partial class ResetMatKhau : Form
    {
        public ResetMatKhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Kiemtra = false;
            foreach(TaiKhoan tk in HeThongBanHang.DSTaiKhoan)
            {
                if(tk.Tentaikhoan==txttaikhoan.Text)
                {
                    tk.Matkhau = Hash_PassWord.GetMD5("1234");
                    MessageBox.Show("Reset Mật Khẩu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Kiemtra = true;              
                    break;
                }
            }
            if(Kiemtra==false)
            {
                MessageBox.Show("Không Tìm Thấy Tài Khoản", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txttaikhoan.Clear();
            txttaikhoan.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetMatKhau.ActiveForm.Close();
        }
    }
}
