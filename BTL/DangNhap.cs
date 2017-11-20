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
    public partial class DangNhap : Form
    {
        public static TaiKhoan taikhoanhientai;
        public DangNhap()
        {
            InitializeComponent();
        }        
        //click vào đăng nhập
        private void button1_Click(object sender, EventArgs e)
        {
            bool KiemTra = false;
            string tentakhoan = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;
            foreach(TaiKhoan tk in HeThongBanHang.DSTaiKhoan)
            {
                if(tk.Tentaikhoan==tentakhoan&&tk.Matkhau==matkhau)
                {
                    if(tk.Trangthai==true)
                    {
                        taikhoanhientai = tk;
                        if (tk.Vaitro=="Admin")
                        {    
                            Admin frmadmin = new Admin();
                            frmadmin.ShowDialog();
                          
                            return;
                        }
                        else if(tk.Vaitro=="Quản Lí")
                        {
                            QuanLi frmquanli = new QuanLi();
                            frmquanli.ShowDialog();
                            
                            return;
                        }
                        else if(tk.Vaitro=="Khách Hàng")
                        {
                            Customer frmcustomer = new Customer();
                            frmcustomer.ShowDialog();
                            
                            return;
                        }
                        KiemTra = true;
                    }
                }
            }
            if(KiemTra==false)
            {
                MessageBox.Show("Đăng Nhập Thất Bại.Vui Lòng Đăng Nhập Lại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttaikhoan.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HeThongBanHang.NhapFile();
            Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            HeThongBanHang.XuatFile();
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            HeThongBanHang.NhapFile();
        }
    }
}
