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
    public partial class XoaHang : Form
    {
        public XoaHang()
        {
            InitializeComponent();
        }

        private void XoaHang_Load(object sender, EventArgs e)
        {
            lvxoasuathongtin.Enabled = false;
            btnxoahang.Enabled = false;
            btnsuathongtin.Enabled = false;
            cbkieutimkiem.Text = "Mã Hàng Hóa";
            if(QuanLi.TacVuHienTai=="Tìm Kiếm")
            {
                btnsuathongtin.Visible = false;
                btnxoahang.Visible = false;
            }
            else if(QuanLi.TacVuHienTai=="Xóa Hàng")
            {
                this.Text = "Xóa Hàng";
                btnsuathongtin.Visible = false;
            }
            else if(QuanLi.TacVuHienTai=="Sửa Thông Tin HH")
            {
                this.Text = "Sửa Thông Tin HH";
                btnxoahang.Visible = false;
            }
          
        }

        private void btnxoahang_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvxoasuathongtin.SelectedItems[0];
            HeThongBanHang.DSHangHoa.Remove(HeThongBanHang.TimKiemTheoMaHH(int.Parse(item.Name)));
            lvxoasuathongtin.Items.Remove(item);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            try
            {
                while(lvxoasuathongtin.Items.Count!=0)
                {
                    lvxoasuathongtin.Items.RemoveAt(0);
                }
                if (txttimkiem.Text == "")
                {
                    MessageBox.Show("Bạn Cần Nhập Đầy Đủ Thông Tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (cbkieutimkiem.Text == "Mã hàng hóa")
                    {
                        HangHoa hh= HeThongBanHang.TimKiemTheoMaHH(int.Parse(txttimkiem.Text));
                        if (hh==null)
                        {
                            MessageBox.Show("Không Tìm Thấy Hàng Hóa Cần Tìm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            lvxoasuathongtin.Enabled = true;
                            if (QuanLi.TacVuHienTai == "Xóa Hàng")
                            {
                                btnxoahang.Enabled = true;
                            }
                            if (QuanLi.TacVuHienTai == "Sửa Thông Tin HH")
                            {
                                btnsuathongtin.Enabled = true;
                            }
                            ListViewItem item = new ListViewItem(hh.CatChuoi());
                            item.Name = hh.Mahang.ToString();
                            lvxoasuathongtin.Items.Add(item);
                        }
                    }
                    if (cbkieutimkiem.Text == "Tên hàng")
                    {
                        List<HangHoa> danhsach = new List<HangHoa>();
                        danhsach = HeThongBanHang.TimKiemTheoTen(txttimkiem.Text);
                        if (danhsach.Count == 0)
                        {
                            MessageBox.Show("Không Tìm Thấy Hàng Hóa Cần Tìm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            lvxoasuathongtin.Enabled = true;
                            if (QuanLi.TacVuHienTai == "Xóa Hàng")
                            {
                                btnxoahang.Enabled = true;
                            }
                            if (QuanLi.TacVuHienTai == "Sửa Thông Tin HH")
                            {
                                btnsuathongtin.Enabled = true;
                            }
                            for (int i = 0; i < danhsach.Count; i++)
                            {
                                ListViewItem item = new ListViewItem(danhsach[i].CatChuoi());
                                item.Name = danhsach[i].Mahang.ToString();
                                lvxoasuathongtin.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nhập Thông Tin Không Chính Xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txttimkiem.Clear();
            txttimkiem.Focus();
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            XoaHang.ActiveForm.Close();
        }
        public static HangHoa hanghoaduocchon;
        private void btnsuathongtin_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lvxoasuathongtin.SelectedItems[0];
                hanghoaduocchon = HeThongBanHang.TimKiemTheoMaHH(int.Parse(item.Name));
                SuaThongTinHH frmsuathongtinhh = new SuaThongTinHH();
                frmsuathongtinhh.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Bạn Cần Chọn 1 Loại Hàng Hóa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
