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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            cbthongke.Text = "Hàng hóa còn lại trong kho";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbthongke.Text== "Hàng hóa còn lại trong kho")
            {
                thongke(HeThongBanHang.DSHangHoa);
            }
            else if(cbthongke.Text== "Hàng hóa đã hết hạn")
            {
                List<HangHoa> hethan = new List<HangHoa>();
                for(int i=0;i<HeThongBanHang.DSHangHoa.Count;i++)
                {
                    if(HeThongBanHang.DSHangHoa[i].KiemTraHetHan())
                    {
                        hethan.Add(HeThongBanHang.DSHangHoa[i]);
                    }
                }
                thongke(hethan);
            }
            else if(cbthongke.Text== "Hàng đã bán")
            {
                thongke(HeThongBanHang.DSDoanhThu);
            }
        }
        public void thongke(List<HangHoa> lsthanghoa)
        {
            decimal Tongdoanhthu = 0;
            while(lvthongke.Items.Count!=0)
            {
                lvthongke.Items.RemoveAt(0);
            }
            if(lsthanghoa.Count==0)
            {
                MessageBox.Show("Danh Sách Trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (HangHoa hh in lsthanghoa)
            {
                Tongdoanhthu += hh.Gia * hh.Soluong;
                ListViewItem item = new ListViewItem(hh.CatChuoi());
                item.Name = hh.Mahang.ToString();
                lvthongke.Items.Add(item);
            }
            txttonggiatri.Text = Tongdoanhthu.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongKe.ActiveForm.Close();
        }

    }
}
