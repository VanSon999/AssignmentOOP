﻿using System;
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
    public partial class MuaHang : Form
    {
        public MuaHang()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                while(lvmuahang.Items.Count!=0)
                {
                    lvmuahang.Items.RemoveAt(0);
                }
                if (txttimkiem.Text == "")
                {
                    MessageBox.Show("Bạn Cần Nhập Đầy Đủ Thông Tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (cbkieutimkiem.Text == "Mã hàng hóa")
                    {
                        HangHoa hh = HeThongBanHang.TimKiemTheoMaHH(int.Parse(txttimkiem.Text));
                        if (hh == null)
                        {
                            MessageBox.Show("Không Tìm Thấy Hàng Hóa Cần Tìm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            lvmuahang.Enabled = true;
                            
                            ListViewItem item = new ListViewItem(hh.CatChuoi());
                            item.Name = hh.Mahang.ToString();
                            lvmuahang.Items.Add(item);
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
                            lvmuahang.Enabled = true;
                            for (int i = 0; i < danhsach.Count; i++)
                            {
                                ListViewItem item = new ListViewItem(danhsach[i].CatChuoi());
                                item.Name = danhsach[i].Mahang.ToString();
                                lvmuahang.Items.Add(item);
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
        private void MuaHang_Load(object sender, EventArgs e)
        {
            lvmuahang.Enabled = false;
            btnmuahang.Enabled = false;
            cbkieutimkiem.Text = "Mã Hàng Hóa";
            ////////////////////////////////////////////////Sửa lại
            btnmuahang.Visible = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MuaHang.ActiveForm.Close();
        }
        public static HangHoa hanghoaduocchonmua;
        private void lvmuahang_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lvmuahang.SelectedItems[0];
                hanghoaduocchonmua = HeThongBanHang.TimKiemTheoMaHH(int.Parse(item.Name));
                SoLuongMua frmsoluongcanmua = new SoLuongMua();
                frmsoluongcanmua.ShowDialog();
                ListViewItem item1 = new ListViewItem(hanghoaduocchonmua.CatChuoi());
                item1.Name = hanghoaduocchonmua.Mahang.ToString();
                lvmuahang.Items.Remove(item);
                lvmuahang.Items.Add(item1);
            }
            catch
            {
                MessageBox.Show("Bạn Cần Chọn 1 Loại Hàng Hóa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }
    }
}