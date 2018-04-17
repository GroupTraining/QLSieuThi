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
            data.Khach_Hangs.InsertOnSubmit(a);
            data.SubmitChanges();    
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
            data.Khach_Hangs.DeleteOnSubmit(kh);
            data.SubmitChanges();
            return 1;

        }
        // QL Hóa Đơn
        public object getall_hd()
        {
            var hd = from p in data.HoaDon_Nhaps
                     select new
                     {
                         MaHD = p.MaHoaDonNhap,
                         NgayNhap = p.NgayNhapHang,
                         DonViTinh = p.DonViTinh,
                         TongTien = p.TongTien,
                         MaNV = p.MaNV
                     };
            return hd;
        }
        public bool QLHDNhap(string mahd,string mancc,string mahh,int sl)
        {
            HoaDon_Nhap hd = data.HoaDon_Nhaps.Single(p => p.MaHoaDonNhap == mahd);
            var cts = from ct in data.ChiTiet_HoaDon_NhapHangs
                     where ct.MaHoaDonNhap == mahd
                     select ct;
            Hang_Hoa hh = data.Hang_Hoas.Single(p => p.MaHang == mahh);
            DateTime time = DateTime.Now;
            if(hd != null)
            {
                foreach (ChiTiet_HoaDon_NhapHang ct in cts)
                {
                    if (ct.MaHang == mahh)
                    {
                        ct.SoLuongHang += sl;
                        ct.TongTien += hh.Gia * sl;
                        hd.NgayNhapHang = time;
                        hd.TongTien += hh.Gia * sl;
                    }
                    else
                    {
                        ChiTiet_HoaDon_NhapHang new_ct = new ChiTiet_HoaDon_NhapHang();
                        new_ct.MaHoaDonNhap = mahd;
                        new_ct.MaHang = mahh;
                        new_ct.MaNhaCungCap = mancc;
                        new_ct.SoLuongHang = sl;
                        new_ct.TongTien = hh.Gia * sl;
                        data.ChiTiet_HoaDon_NhapHangs.InsertOnSubmit(new_ct);
                    }
                }
            }else
            {
                HoaDon_Nhap hdn = new HoaDon_Nhap();
                hdn.MaHoaDonNhap = mahd;
                hdn.NgayNhapHang = time;
                hdn.DonViTinh = "vnd";
                hdn.TongTien = hh.Gia * sl;
                hdn.MaNV = "NV1";
                data.HoaDon_Nhaps.InsertOnSubmit(hdn);
                ChiTiet_HoaDon_NhapHang new_ct = new ChiTiet_HoaDon_NhapHang();
                new_ct.MaHoaDonNhap = mahd;
                new_ct.MaHang = mahh;
                new_ct.MaNhaCungCap = mancc;
                new_ct.SoLuongHang = sl;
                new_ct.TongTien = hh.Gia * sl;
                data.ChiTiet_HoaDon_NhapHangs.InsertOnSubmit(new_ct);
            }
            data.SubmitChanges();
            return true;
        }
    }
}
