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
    public partial class KichhoatTK : Form
    {
        public KichhoatTK()
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
                    if (tk.Trangthai == true)
                    {
                        MessageBox.Show("Tài Khoản Chưa Bị Vô Hiệu Hóa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Kiemtra = true;
                    }
                    else
                    {
                        tk.Trangthai = true;
                        MessageBox.Show("Kích Hoạt Tài Khoản Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Kiemtra = true;
                    }
                    break;
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
            KichhoatTK.ActiveForm.Close();
        }
    }
}
