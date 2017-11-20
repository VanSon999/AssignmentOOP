using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    public class KhachHang
    {
        private string tentaikhoan;
        private List<HangHoa> giohang;
        public KhachHang(string tentaikhoan,List<HangHoa> giohang)
        {
            this.tentaikhoan = tentaikhoan;
            this.giohang = giohang;
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

        public List<HangHoa> Giohang
        {
            get
            {
                return giohang;
            }

            set
            {
                giohang = value;
            }
        }

    }
}
