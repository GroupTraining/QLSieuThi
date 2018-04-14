using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Globalization;
namespace BUS
{
    public class Bus
    {
        DataDiagramDataContext data = new DataDiagramDataContext();
        public int check_login(string user, string pass)
        {
            int login = (from tks in data.TaiKhoans
                         where tks.username == user && tks.password == pass
                         select tks).Count();
            if (login == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //chỉnh sửa khách hàng 
         public object get_KhachHang()
        {
            var kh = from p in data.Khach_Hangs
                     select new
                     {
                         MaKH = p.MaKH,
                         TenKH = p.TenKH,
                         DiaChi = p.DiaChi,
                         SDT = p.SDT

                     };
            return kh;
            
        }

        public object AddKhachHang(string makh,string tenkh,string diachi,string sdt)
        {
            Khach_Hang a = new Khach_Hang();
            a.MaKH = makh;
            a.TenKH = tenkh;
            a.DiaChi = diachi;
            a.SDT = sdt;
            return 1;
        }

        public object EditKhachHang(string makh,string tenkh,string diachi,string sdt)
        {
            var p= data.Khach_Hangs.Single(a => a.MaKH == makh);
            p.TenKH = tenkh;
            p.DiaChi = diachi;
            p.SDT = sdt;
            data.SubmitChanges();
            return 1;

        }

        public object DelKhachHang(string makh,string tenkh,string diachi,string  sdt)
        {
            var kh = data.Khach_Hangs.Single(a => a.MaKH == makh);
            var hdbh = data.HoaDon_BanHangs.Single(a => a.MaKH == makh);
            data.Khach_Hangs.DeleteOnSubmit(kh);
            data.HoaDon_BanHangs.DeleteOnSubmit(hdbh);
            data.SubmitChanges();
            return 1; ;

        }
    }
}
