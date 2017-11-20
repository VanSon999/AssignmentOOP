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
    public partial class ThanhToan_TraHang : Form
    {
        public ThanhToan_TraHang()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThanhToan frmthanhtoan = new ThanhToan();
            frmthanhtoan.ShowDialog();
        }

        private void ThanhToan_TraHang_Load(object sender, EventArgs e)
        {
            if(Customer.DoiTuongDangChon=="Thanh Toán")
            {
                this.Text = "Thanh Toán";
                btntrahang.Enabled = false;
                btntrahang.Visible = false;
            }
            else
            {
                this.Text = "Trả Hàng";
                btnthanhtoan.Enabled = false;
                btnthanhtoan.Visible = false;
            }
            decimal Tongtienthanhtoan = 0;
            foreach (KhachHang kh in HeThongBanHang.DSKhachHang)
            {
                if (kh.Tentaikhoan == DangNhap.taikhoanhientai.Tentaikhoan)
                {
                    for (int i = 0; i < kh.Giohang.Count; i++)
                    {
                        Tongtienthanhtoan += kh.Giohang[i].Gia * kh.Giohang[i].Soluong;
                        ListViewItem item = new ListViewItem(kh.Giohang[i].CatChuoi());
                        item.Name = kh.Giohang[i].Mahang.ToString();
                        lvthanhtoantrahang.Items.Add(item);
                    }
                }
            }
            txttonggiati.Text = Tongtienthanhtoan.ToString();
        }

        private void ThanhToan_TraHang_Paint(object sender, PaintEventArgs e)
        {
            if(ThanhToan.Dathanhtoan==true)
            {
                while(lvthanhtoantrahang.Items.Count!=0)
                {
                    lvthanhtoantrahang.Items.RemoveAt(0);
                }
                decimal Tongtienthanhtoan = 0;
                foreach (KhachHang kh in HeThongBanHang.DSKhachHang)
                {
                    if (kh.Tentaikhoan == DangNhap.taikhoanhientai.Tentaikhoan)
                    {
                        for (int i = 0; i < kh.Giohang.Count; i++)
                        {
                            Tongtienthanhtoan += kh.Giohang[i].Gia * kh.Giohang[i].Soluong;
                            ListViewItem item = new ListViewItem(kh.Giohang[i].CatChuoi());
                            item.Name = kh.Giohang[i].Mahang.ToString();
                            lvthanhtoantrahang.Items.Add(item);
                        }
                    }
                }
                txttonggiati.Text = Tongtienthanhtoan.ToString();
            }
            ThanhToan.Dathanhtoan = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThanhToan_TraHang.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lvthanhtoantrahang.SelectedItems[0];
                foreach (KhachHang kh in HeThongBanHang.DSKhachHang)
                {
                    if (kh.Tentaikhoan == DangNhap.taikhoanhientai.Tentaikhoan)
                    {
                        HangHoa hh = kh.Giohang.Find(m => m.Mahang == int.Parse(item.Name));
                        txttonggiati.Text = (decimal.Parse(txttonggiati.Text) - hh.Gia * hh.Soluong).ToString();
                        HeThongBanHang.TraHang(DangNhap.taikhoanhientai, hh);
                        lvthanhtoantrahang.Items.Remove(item);
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chưa Chọn Hàng Cần Trả", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
