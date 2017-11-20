using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    public class TaiKhoan
    {
        private string tentaikhoan;
        private string matkhau;
        private bool trangthai;
        private string vaitro;
        public TaiKhoan(string tentaikhoan,string matkhau,bool trangthai,string vaitro)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.trangthai = trangthai;
            this.vaitro = vaitro;
        }

        public string Tentaikhoan
        {
            get
            {
                return tentaikhoan;
            }

            set
            {
                tentaikhoan = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }

        public bool Trangthai
        {
            get
            {
                return trangthai;
            }

            set
            {
                trangthai = value;
            }
        }

        public string Vaitro
        {
            get
            {
                return vaitro;
            }

            set
            {
                vaitro = value;
            }
        }
        //Kiểm tra các chuỗi nhập vào
        public bool KiemTraTK()
        {
            if(tentaikhoan!=""&&matkhau!=""&&(trangthai==true||trangthai==false)&&(vaitro=="Admin"||vaitro=="Quản Lí"||vaitro=="Khách Hàng"))
            {
                return true;
            }
            return false;
        }
        //Kiểm tra trùng
        public bool KiemTraTrung()
        {
            foreach(TaiKhoan tk in HeThongBanHang.DSTaiKhoan)
            {
                if(tk.tentaikhoan==tentaikhoan)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
