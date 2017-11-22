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
    public partial class ThemTaiKhoan : Form
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(txttaikhoan.Text, Hash_PassWord.GetMD5(txtmatkhau.Text), true, cbloaitk.Text);
            if (!tk.KiemTraTrung())
            {
                if (tk.KiemTraTK())
                {
                    HeThongBanHang.DSTaiKhoan.Add(tk);
                    if(tk.Vaitro=="Khách Hàng")
                    {
                        HeThongBanHang.DSKhachHang.Add(new KhachHang(tk.Tentaikhoan, new List<HangHoa>()));
                    }
                    MessageBox.Show("Cấp Tài Khoản Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Cấp Tài Khoản Không Thành Công", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài Khoản Đã Tồn Tại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txttaikhoan.Clear();
            txtmatkhau.Clear();
            txttaikhoan.Focus();
        }

        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            cbloaitk.Text = "Quản Lí";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan.ActiveForm.Close();
        }
    }
}
