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
    public partial class SuaThongTinHH : Form
    {
        public SuaThongTinHH()
        {
            InitializeComponent();
        }
        int mahangcu;
        private void SuaThongTinHH_Load(object sender, EventArgs e)
        {
            txtmahang.Text = XoaHang.hanghoaduocchon.Mahang.ToString();
            mahangcu =XoaHang.hanghoaduocchon.Mahang;
            txttenhang.Text = XoaHang.hanghoaduocchon.Tenhang;
            nudsoluong.Value = XoaHang.hanghoaduocchon.Soluong;
            nudgia.Value = XoaHang.hanghoaduocchon.Gia;
            dtpngaysanxuat.Value = XoaHang.hanghoaduocchon.Ngaysanxuat;
            dtphansudung.Value = XoaHang.hanghoaduocchon.Hansudung;
            cbloai.Text = XoaHang.hanghoaduocchon.Loai;
        }

        private void btnsuathongtinhh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmahang.Text == "" || txttenhang.Text == "")
                {
                    MessageBox.Show("Bạn Cần Nhập Đầy Đủ Thông Tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmahang.Focus();
                }
                else
                {
                    HangHoa hanghoa = new HangHoa(int.Parse(txtmahang.Text), txttenhang.Text, (int)nudsoluong.Value, nudgia.Value, dtpngaysanxuat.Value, dtphansudung.Value, cbloai.Text);
                    if (hanghoa.Mahang != mahangcu)
                    {
                        if (hanghoa.KiemTraMaHangTrung())
                        {
                            MessageBox.Show("Mã Hàng Hóa Đã Tồn Tại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        XoaHang.hanghoaduocchon.SuaThongTinHH(hanghoa);
                        MessageBox.Show("Sửa Thông Tin Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SuaThongTinHH.ActiveForm.Close();
                    }
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
