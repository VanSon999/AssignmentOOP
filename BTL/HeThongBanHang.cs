using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    public class HeThongBanHang
    {
        public static List<TaiKhoan> DSTaiKhoan=new List<TaiKhoan>();
        public static List<HangHoa> DSHangHoa=new List<HangHoa>();
        public static List<KhachHang> DSKhachHang=new List<KhachHang>();
        public static List<HangHoa> DSDoanhThu = new List<HangHoa>();
        public static List<HangHoa> TimKiemTheoTen(string tenhanghoa)
        {
            List<HangHoa> danhsach = new List<HangHoa>();
            foreach(HangHoa hh in HeThongBanHang.DSHangHoa)
            {
                if(hh.Tenhang.Contains(tenhanghoa))
                {
                    danhsach.Add(hh);
                }
            }
            return danhsach;
        }   
        public static HangHoa TimKiemTheoMaHH(int mahanghoa)
        {
            foreach (HangHoa hh in HeThongBanHang.DSHangHoa)
            {
                if (hh.Mahang == mahanghoa)
                {
                    return hh;
                }
            }
            return null;
        }
        public static void ThemHangVaoGio(TaiKhoan tkhientai,HangHoa hanghoamuonthem,int soluong)
        {
            foreach(HangHoa hanghoa in HeThongBanHang.DSHangHoa)
            {
                if(hanghoa.Mahang==hanghoamuonthem.Mahang)
                {
                    hanghoa.Soluong -= soluong;
                    if (hanghoa.Soluong == 0)
                    {
                        HeThongBanHang.DSHangHoa.Remove(hanghoa);
                     }
                    break;
                }
            }
            bool Kiemtra = false;
            foreach(KhachHang kh in HeThongBanHang.DSKhachHang)
            {
                if(kh.Tentaikhoan==tkhientai.Tentaikhoan)
                {
                    foreach(HangHoa hh in kh.Giohang)
                    {
                        if(hh.Mahang==hanghoamuonthem.Mahang)
                        {
                            hh.Soluong += soluong;
                            Kiemtra = true;
                        }
                    }
                    if(Kiemtra==false)
                    {
                        HangHoa temp = new HangHoa(hanghoamuonthem);
                        temp.Soluong = soluong;
                        kh.Giohang.Add(temp);
                    }
                    break;
                }
            }
        }
        public static void TraHang(TaiKhoan tkhientai, HangHoa hanghoamuontra)
        {
            foreach(KhachHang kh in HeThongBanHang.DSKhachHang)
            {
                if(kh.Tentaikhoan==tkhientai.Tentaikhoan)
                {
                    foreach (HangHoa hh in kh.Giohang)
                    {
                        if (hanghoamuontra.Mahang == hh.Mahang)
                        {
                            hh.Soluong += hanghoamuontra.Soluong;
                            kh.Giohang.Remove(hh);
                            return;
                        }
                    }
                }
            }
        }
        public static void XuatFile()
        {
            //Đọc danh sách tài khoản
            StreamReader stRead = new StreamReader("dstaikhoan.txt", Encoding.Unicode);
            string line = stRead.ReadLine();
            while (line != null)
            {
                string[] s = line.Split('|');
                if(s[2]=="True")
                {
                    s[2] = "true";
                }
                if(s[2]=="False")
                {
                    s[2] = "false";
                }
                TaiKhoan tk = new TaiKhoan(s[0], s[1], bool.Parse(s[2]), s[3]);
                HeThongBanHang.DSTaiKhoan.Add(tk);
                line = stRead.ReadLine();
            }
            stRead.Close();
            //Đọc danh sách hàng hóa
            stRead = new StreamReader("dsHangHoa.txt", Encoding.Unicode);
            line = stRead.ReadLine();
            while (line != null)
            {
                string[] s = line.Split('|');
                string[] NgaySx = s[4].Split('/');
                DateTime ngaysx = new DateTime(int.Parse(NgaySx[2]), int.Parse(NgaySx[1]), int.Parse(NgaySx[0]));
                string[] HanSD = s[5].Split('/');
                DateTime hansd = new DateTime(int.Parse(HanSD[2]), int.Parse(HanSD[1]), int.Parse(HanSD[0]));
                HangHoa hh = new HangHoa(int.Parse(s[0]), s[1], int.Parse(s[2]), decimal.Parse(s[3]),ngaysx,hansd,s[6]);
                HeThongBanHang.DSHangHoa.Add(hh);
                line = stRead.ReadLine();
            }
            stRead.Close();
            //Đọc danh sách doanh thu
            stRead = new StreamReader("dsdoanhthu.txt", Encoding.Unicode);
            line = stRead.ReadLine();
            while (line != null)
            {
                string[] s = line.Split('|');
                string[] NgaySx = s[4].Split('/');
                DateTime ngaysx = new DateTime(int.Parse(NgaySx[2]), int.Parse(NgaySx[1]), int.Parse(NgaySx[0]));
                string[] HanSD = s[5].Split('/');
                DateTime hansd = new DateTime(int.Parse(HanSD[2]), int.Parse(HanSD[1]), int.Parse(HanSD[0]));
                HangHoa hh = new HangHoa(int.Parse(s[0]), s[1], int.Parse(s[2]), decimal.Parse(s[3]), ngaysx, hansd, s[6]);
                HeThongBanHang.DSDoanhThu.Add(hh);
                line = stRead.ReadLine();
            }
            stRead.Close();
            //Đọc danh sách khách hàng
            stRead = new StreamReader("dskhachhang.txt", Encoding.Unicode);
            line = stRead.ReadLine();
            while (line != null)
            {
                List<HangHoa> lsthh = new List<HangHoa>();
                string[] s = line.Split('|');
                for(int i=1;i<s.Count()-1;i=i+7)
                {
                    string[] NgaySx = s[i+4].Split('/');
                    DateTime ngaysx = new DateTime(int.Parse(NgaySx[2]), int.Parse(NgaySx[1]), int.Parse(NgaySx[0]));
                    string[] HanSD = s[i+5].Split('/');
                    DateTime hansd = new DateTime(int.Parse(HanSD[2]), int.Parse(HanSD[1]), int.Parse(HanSD[0]));
                    HangHoa hh = new HangHoa(int.Parse(s[i]), s[i+1], int.Parse(s[i+2]), decimal.Parse(s[i+3]), ngaysx, hansd, s[i+6]);
                    lsthh.Add(hh);
                }
                KhachHang kh = new KhachHang(s[0], lsthh);
                HeThongBanHang.DSKhachHang.Add(kh);
                line = stRead.ReadLine();
            }
            stRead.Close();
        }
        public static void NhapFile()
        {
            //Ghi danh sách tài khoản
            FileStream fs = new FileStream("dstaikhoan.txt", FileMode.Truncate, FileAccess.Write);
            StreamWriter stwritetaikhoan = new StreamWriter(fs,Encoding.Unicode);
            foreach (TaiKhoan tk in HeThongBanHang.DSTaiKhoan)
            {
                string[] s= { tk.Tentaikhoan,tk.Matkhau,tk.Trangthai.ToString(),tk.Vaitro}; 
                string str = s[0] + "|" + s[1] + "|" + s[2] + "|" + s[3];
                stwritetaikhoan.WriteLine(str);
            }
            stwritetaikhoan.Close();
            fs.Close();
            //Ghi danh sách hàng hóa
            fs = new FileStream("dshanghoa.txt", FileMode.Truncate, FileAccess.Write);
            StreamWriter stwritehanghoa = new StreamWriter(fs, Encoding.Unicode);
            foreach (HangHoa tk in HeThongBanHang.DSHangHoa)
            {
                string[] s = {tk.Mahang.ToString(),tk.Tenhang,tk.Soluong.ToString(),tk.Gia.ToString(),tk.Ngaysanxuat.Day+"/"+tk.Ngaysanxuat.Month+"/"+tk.Ngaysanxuat.Year, tk.Hansudung.Day + "/" + tk.Hansudung.Month + "/" + tk.Hansudung.Year,tk.Loai };
                string str = s[0] + "|" + s[1] + "|" + s[2] + "|" + s[3] + "|" + s[4] + "|" + s[5]+ "|" + s[6];
                stwritehanghoa.WriteLine(str);
            }
            stwritehanghoa.Close();
            fs.Close();
            //Ghi danh sách doanh thu
            fs = new FileStream("dsdoanhthu.txt", FileMode.Truncate, FileAccess.Write);
            StreamWriter stwritedoanhthu = new StreamWriter(fs, Encoding.Unicode);
            foreach (HangHoa tk in HeThongBanHang.DSDoanhThu)
            {
                string[] s = { tk.Mahang.ToString(), tk.Tenhang, tk.Soluong.ToString(), tk.Gia.ToString(), tk.Ngaysanxuat.Day + "/" + tk.Ngaysanxuat.Month + "/" + tk.Ngaysanxuat.Year, tk.Hansudung.Day + "/" + tk.Hansudung.Month + "/" + tk.Hansudung.Year, tk.Loai };
                string str = s[0] + "|" + s[1] + "|" + s[2] + "|" + s[3] + "|" + s[4] + "|" + s[5] +"|"+ s[6];
                stwritedoanhthu.WriteLine(str);
            }
            stwritedoanhthu.Close();
            fs.Close();
            //Ghi danh sách khách hàng
            fs = new FileStream("dskhachhang.txt", FileMode.Truncate, FileAccess.Write);
            StreamWriter stwritekhachhang = new StreamWriter(fs, Encoding.Unicode);
            foreach (KhachHang tk in HeThongBanHang.DSKhachHang)
            {
                string str = tk.Tentaikhoan+"|";
                foreach (HangHoa hh in tk.Giohang)
                {
                    string[] s = { hh.Mahang.ToString(), hh.Tenhang, hh.Soluong.ToString(), hh.Gia.ToString(), hh.Ngaysanxuat.Day + "/" + hh.Ngaysanxuat.Month + "/" + hh.Ngaysanxuat.Year, hh.Hansudung.Day + "/" + hh.Hansudung.Month + "/" + hh.Hansudung.Year, hh.Loai };
                    str += s[0] + "|" + s[1] + "|" + s[2] + "|" + s[3] + "|" + s[4] + "|" + s[5] + "|"+s[6]+"|";
                }
                stwritekhachhang.WriteLine(str);
            }
            stwritekhachhang.Close();
            fs.Close();

        }
    }
}
