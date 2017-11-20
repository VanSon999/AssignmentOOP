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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            decimal TongTien = 0;
            foreach(KhachHang kh in HeThongBanHang.DSKhachHang)
            {
                if(kh.Tentaikhoan==DangNhap.taikhoanhientai.Tentaikhoan)
                {
                    foreach(HangHoa hh in kh.Giohang)
                    {
                        TongTien += hh.Gia * hh.Soluong;
                    }
                    break;
                }
            }
            txtthanhtoan.Text = TongTien.ToString();
        }
        public static bool Dathanhtoan=false;
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtthanhtoan.Text=="0")
            {
                MessageBox.Show("Không Thể Thanh Toán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (KhachHang kh in HeThongBanHang.DSKhachHang)
            {
                if (kh.Tentaikhoan == DangNhap.taikhoanhientai.Tentaikhoan)
                {
                    try
                    {

                        foreach (HangHoa hhgiohang in kh.Giohang)
                        {
                            if (HeThongBanHang.DSDoanhThu.Count == 0)
                            {
                                HeThongBanHang.DSDoanhThu.Add(hhgiohang);
                            }
                            else
                            {
                                for (int i = 0; i < HeThongBanHang.DSDoanhThu.Count; i++)
                                {
                                    if (HeThongBanHang.DSDoanhThu[i].Mahang == hhgiohang.Mahang)
                                    {
                                        HeThongBanHang.DSDoanhThu[i].Soluong += hhgiohang.Soluong;
                                        break;
                                    }
                                    else
                                    {
                                        if (i == HeThongBanHang.DSDoanhThu.Count - 1)
                                        {
                                            HeThongBanHang.DSDoanhThu.Add(hhgiohang);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        kh.Giohang.RemoveRange(0, kh.Giohang.Count);
                        MessageBox.Show("Thanh Toán Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ThanhToan.ActiveForm.Close();
                        Dathanhtoan = true;
                    }
                    catch
                    {
                        MessageBox.Show("Không Thể Thanh Toán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThanhToan.ActiveForm.Close();
        }

    }
}
