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
    public partial class ThemHang : Form
    {
        public ThemHang()
        {
            InitializeComponent();
        }

        private void ThemHang_Load(object sender, EventArgs e)
        {
            cbloai.Text = "Điện Thoại";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemHang.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtmahang.Text==""||txttenhang.Text=="")
                {
                    MessageBox.Show("Bạn Cần Nhập Đầy Đủ Thông Tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmahang.Focus();
                }
                else
                {
                    HangHoa hanghoa = new HangHoa(int.Parse(txtmahang.Text),txttenhang.Text,(int)nudsoluong.Value,nudgia.Value,dtpngaysanxuat.Value,dtphansudung.Value,cbloai.Text);
                    if(hanghoa.KiemTraMaHangTrung())
                    {
                        if (!hanghoa.KiemTraTenHangTrung())
                        {
                            MessageBox.Show("Mã Hàng Hóa Và Tên Hàng Không Khớp", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            hanghoa.ThemSoLuongHang();
                            MessageBox.Show("Thêm Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    HeThongBanHang.DSHangHoa.Add(hanghoa);
                }
            }
            catch
            {
                MessageBox.Show("Nhập Thông Tin Không Chính Xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            }
            txtmahang.Focus();
        }
    }
}
