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
    public partial class SoLuongMua : Form
    {
        public SoLuongMua()
        {
            InitializeComponent();
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            if(nudsoluongcanmua.Value>MuaHang.hanghoaduocchonmua.Soluong)
            {
                MessageBox.Show("Số Lượng còn lại :" + MuaHang.hanghoaduocchonmua.Soluong.ToString(), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                HeThongBanHang.ThemHangVaoGio(DangNhap.taikhoanhientai, MuaHang.hanghoaduocchonmua, (int)nudsoluongcanmua.Value);
                MessageBox.Show("Mua Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SoLuongMua.ActiveForm.Close();
            }          
        }


    }
}
