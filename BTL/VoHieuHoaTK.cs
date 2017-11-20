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
    public partial class VoHieuHoaTK : Form
    {
        public VoHieuHoaTK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Kiemtra = false;
            foreach (TaiKhoan tk in HeThongBanHang.DSTaiKhoan)
            {
                if (tk.Tentaikhoan == txttaikhoan.Text)
                {
                    Kiemtra = true;
                    if (tk.Trangthai == false)
                    {
                        MessageBox.Show("Tài Khoản Đã Bị Vô Hiệu Hóa Trước Đó!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else
                    {
                        tk.Trangthai = false;
                        MessageBox.Show("Vô Hiệu Hóa Tài Khoản Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        break;
                    }
                }
            }
            if (Kiemtra == false)
            {
                MessageBox.Show("Không Tìm Thấy Tài Khoản", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txttaikhoan.Clear();
            txttaikhoan.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VoHieuHoaTK.ActiveForm.Close();
        }
    }
}
