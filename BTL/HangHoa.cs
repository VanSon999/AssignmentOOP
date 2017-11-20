using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    public class HangHoa
    {
        private int mahang;
        private string tenhang;
        private int soluong;
        private decimal gia;
        private DateTime ngaysanxuat;
        private DateTime hansudung;
        private string loai;
        public int Mahang
        {
            get
            {
                return mahang;
            }

            set
            {
                mahang = value;
            }
        }

        public string Tenhang
        {
            get
            {
                return tenhang;
            }

            set
            {
                tenhang = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public decimal Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }

        public DateTime Ngaysanxuat
        {
            get
            {
                return ngaysanxuat;
            }

            set
            {
                ngaysanxuat = value;
            }
        }

        public DateTime Hansudung
        {
            get
            {
                return hansudung;
            }

            set
            {
                hansudung = value;
            }
        }

        public string Loai
        {
            get
            {
                return loai;
            }

            set
            {
                loai = value;
            }
        }

        public HangHoa(int mahang, string tenhang, int soluong, decimal gia, DateTime ngaysanxuat, DateTime hansudung, string loai)
        {
            this.Mahang = mahang;
            this.Tenhang = tenhang;
            this.Soluong = soluong;
            this.Gia = gia;
            this.Ngaysanxuat = ngaysanxuat;
            this.Hansudung = hansudung;
            this.Loai = loai;
        }
        public HangHoa(HangHoa hh)
        {
            this.Mahang = hh.mahang;
            this.Tenhang = hh.tenhang;
            this.Soluong = hh.soluong;
            this.Gia = hh.gia;
            this.Ngaysanxuat = hh.ngaysanxuat;
            this.Hansudung = hh.hansudung;
            this.Loai = hh.loai;
        }
        public void SuaThongTinHH(HangHoa hh)
        {
            this.Mahang = hh.mahang;
            this.Tenhang = hh.tenhang;
            this.Soluong = hh.soluong;
            this.Gia = hh.gia;
            this.Ngaysanxuat = hh.ngaysanxuat;
            this.Hansudung = hh.hansudung;
            this.Loai = hh.loai;
        }
        public bool KiemTraHetHan()
        {
            if(DateTime.Compare(DateTime.Now,this.Hansudung)!=-1)
            {
                return true;
            }
            return false;
        }
        public bool KiemTraMaHangTrung()
        {
            foreach (HangHoa hh in HeThongBanHang.DSHangHoa)
            {
                if (hh.Mahang == Mahang)
                {
                    return true;
                }
            }
            return false;
        }
        public bool KiemTraTenHangTrung()
        {
            foreach (HangHoa hh in HeThongBanHang.DSHangHoa)
            {
                if (hh.Tenhang == Tenhang)
                {
                    return true;
                }
            }
            return false;
        }
        public void ThemSoLuongHang()
        {
            foreach (HangHoa hh in HeThongBanHang.DSHangHoa)
            {
                if (hh.Tenhang == Tenhang)
                {
                    hh.Soluong += this.Soluong;
                }
            }
        }
        public string[] CatChuoi()
        {
            string[] s = { Mahang.ToString(),Tenhang,Soluong.ToString(),Gia.ToString(),Ngaysanxuat.Day + "/" +Ngaysanxuat.Month + "/" + Ngaysanxuat.Year, Hansudung.Day + "/" + Hansudung.Month + "/" + Hansudung.Year,Loai };
            return s;
        }
    }
}
