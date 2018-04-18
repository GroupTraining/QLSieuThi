using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Globalization;
using System.Windows.Forms;

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
            return 1; ;

        }

        //Nhà cung cấp
        public object getNhacungcap()
        {
            var kh = from p in data.NhaCungCaps
                     select new
                     {
                         MaNhaCungCap = p.MaNhaCungCap,
                         TenNhaCungCap = p.TenNhaCungCap,
                         DiaChi = p.DiaChi,
                         SDT = p.SDT

                     };
            return kh;

        }

        public object AddNhaCungCap(string manhacungcap, string tennhacungcap, string diachi, string sdt)
        {
            NhaCungCap a = new NhaCungCap();
            a.MaNhaCungCap = manhacungcap;
            a.TenNhaCungCap = tennhacungcap;
            a.DiaChi = diachi;
            a.SDT = sdt;
            data.NhaCungCaps.InsertOnSubmit(a);
            data.SubmitChanges();
            return 1;
        }

        public object EditNhaCungCap(string manhacungcap, string tennhacungcap, string diachi, string sdt)
        {
            var p = data.NhaCungCaps.Single(a => a.MaNhaCungCap == manhacungcap);
            p.TenNhaCungCap = tennhacungcap;
            p.DiaChi = diachi;
            p.SDT = sdt;

            data.SubmitChanges();
            return 1;

        }
        public object DelNhaCungCap(string manhacungcap)
        {
            var cc = data.NhaCungCaps.Single(a => a.MaNhaCungCap == manhacungcap);
            data.NhaCungCaps.DeleteOnSubmit(cc);
            data.SubmitChanges();
            return 1; ;

        }
        //QL Hàng Hóa
        public object getHangHoa()
        {
            var hh = from p in data.Hang_Hoas
                     select new {
                          MaHang = p.MaHang,
                          TenHang = p.TenHang,
                          NhaCungCap = p.MaNhaCungCap,
                          Gia = p.Gia,
                          SoLuong = p.SoLuong
                     };
            return hh;
        }
        public object AddHangHoa(string mahh, string tenhh, string nhacc, string gia, string soluong)
        {
            Hang_Hoa p = new Hang_Hoa();
            p.MaHang = mahh;
            p.TenHang = tenhh;
            p.Gia = Convert.ToInt32(gia);
            p.SoLuong = Convert.ToInt32(soluong);
            string macc = "";
            if (nhacc == "Hồng Hà")
            {
                macc = "CC1       ";
            }
            else if (nhacc == "Thiên Long")
            {
                macc = "CC2       ";
            }
            else if (nhacc == "Vinamilk")
            {
                macc = "CC3       ";
            }
            else if (nhacc == "Orion")
            {
                macc = "CC4       ";
            }
            else if (nhacc == "Hải Hà")
            {
                macc = "CC5       ";
            }
            p.MaNhaCungCap = macc;

            data.Hang_Hoas.InsertOnSubmit(p);
            data.SubmitChanges();
            return 1;
        }
        public object EditHangHoa(string mahh,string tenhh, string nhacc, string gia, string soluong)
        {
            var p = data.Hang_Hoas.Single(a => a.MaHang == mahh);
            p.TenHang = tenhh;
            p.Gia = Convert.ToInt32(gia);
            p.SoLuong = Convert.ToInt32(soluong);
            string macc = "";
            if(nhacc == "Hồng Hà")
            {
                macc = "CC1       ";
            }else if (nhacc == "Thiên Long")
            {
                macc = "CC2       ";
            }
            else if (nhacc == "Vinamilk")
            {
                macc = "CC3       ";
            }
            else if (nhacc == "Orion")
            {
                macc = "CC4       ";
            }
            else if (nhacc == "Hải Hà")
            {
                macc = "CC5       ";
            }
            p.MaNhaCungCap = macc;
            data.SubmitChanges();
            return 1;

        }
        public object DelHangHoa(string mahh)
        {
            var p = data.Hang_Hoas.Single(a => a.MaHang == mahh);
            var hdhh = data.ChiTiet_HoaDon_NhapHangs.Single(a => a.MaHang == mahh);
            var hd = data.ChiTiet_HoaDon_BanHangs.Single(a => a.MaHang == mahh);

            data.ChiTiet_HoaDon_NhapHangs.DeleteOnSubmit(hdhh);
            data.ChiTiet_HoaDon_BanHangs.DeleteOnSubmit(hd);
            data.Hang_Hoas.DeleteOnSubmit(p);
            data.SubmitChanges();
            return 1; ;

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
        public bool QLHDNhap(string mahd, string mancc, string mahh, int sl)
        {
            HoaDon_Nhap hd = data.HoaDon_Nhaps.Single(p => p.MaHoaDonNhap == mahd);
            var cts = from ct in data.ChiTiet_HoaDon_NhapHangs
                      where ct.MaHoaDonNhap == mahd
                      select ct;
            Hang_Hoa hh = data.Hang_Hoas.Single(p => p.MaHang == mahh);
            DateTime time = DateTime.Now;
            if (hd != null)
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
            }
            else
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

        //QL hóa đơn xuất
        public object  get_HDBH()
        {
            var hd = from x in data.HoaDon_BanHangs
                     from y in data.ChiTiet_HoaDon_BanHangs
                     where x.MaHoaDon == y.MaHoaDon
                     select new
                     {
                         MaHoaDon = x.MaHoaDon,
                         MaHang = y.MaHang,
                         SoLuongHang = y.SoLuongHang,
                         TongTienHang = y.TongTienHang,
                         TongTien = x.TongTien,
                         NgayLapHoaDon = x.NgayLapHoaDon,
                         MaKH = x.MaKH,
                         MaNV = x.MaNV
                     };
            return hd;
        }
        public object search_HDBH(string giatri)
        {
            var hd = from x in data.HoaDon_BanHangs
                     from y in data.ChiTiet_HoaDon_BanHangs
                     where x.MaHoaDon == y.MaHoaDon
                     select new
                     {
                         MaHoaDon = x.MaHoaDon,
                         MaHang = y.MaHang,
                         SoLuongHang = y.SoLuongHang,
                         TongTienHang = y.TongTienHang,
                         TongTien = x.TongTien,
                         NgayLapHoaDon = x.NgayLapHoaDon,
                         MaKH = x.MaKH,
                         MaNV = x.MaNV
                     }into hdbh where hdbh.MaHoaDon.Contains(giatri) || hdbh.MaHang.Contains(giatri) || hdbh.SoLuongHang.ToString().Contains(giatri) 
                      || hdbh.TongTienHang.ToString().Contains(giatri) || hdbh.TongTien.ToString().Contains(giatri) 
                      || hdbh.NgayLapHoaDon.ToString().Contains(giatri) || hdbh.MaKH.Contains(giatri) || hdbh.MaNV.Contains(giatri)
                     select hdbh;
            return hd;
        }
        public object delete_CTHDBH(string mahdbh, string mahang)
        {
            var cthd = from n in data.ChiTiet_HoaDon_BanHangs where n.MaHoaDon == mahdbh where n.MaHang == mahang select n;
            data.ChiTiet_HoaDon_BanHangs.DeleteAllOnSubmit(cthd);
            data.SubmitChanges();
            var cthd2 = from n in data.ChiTiet_HoaDon_BanHangs
                        where n.MaHoaDon == mahdbh
                        select n.TongTienHang;
            int tien = 0;
            foreach (int item in cthd2)
            {
                tien = tien + item;
            }
            HoaDon_BanHang hd = data.HoaDon_BanHangs.Single(a => a.MaHoaDon == mahdbh);
            hd.TongTien = tien;
            data.SubmitChanges();
            return cthd;
        }
        public object delete_HDBH(string mahdbh)
        {
            HoaDon_BanHang hd = data.HoaDon_BanHangs.Single(a => a.MaHoaDon == mahdbh);
            var cthd = from n in data.ChiTiet_HoaDon_BanHangs
                       where n.MaHoaDon == mahdbh
                       select n;
            data.ChiTiet_HoaDon_BanHangs.DeleteAllOnSubmit(cthd);
            data.SubmitChanges();
            data.HoaDon_BanHangs.DeleteOnSubmit(hd);
            data.SubmitChanges();
            return hd;
        }
        public object edit_CTHDBD(string mahdbh, string mahang, string sl, string tien)
        {
            var cthd = from n in data.ChiTiet_HoaDon_BanHangs where n.MaHoaDon == mahdbh where n.MaHang == mahang select n;
            foreach (var item in cthd)
            {
                item.SoLuongHang = Convert.ToInt32(sl);
                item.TongTienHang = Convert.ToInt32(tien);
            }
            data.SubmitChanges();
            var cthd2 = from n in data.ChiTiet_HoaDon_BanHangs
                        where n.MaHoaDon == mahdbh
                        select n.TongTienHang;
            int tien1 = 0;
            foreach (int item in cthd2)
            {
                tien1 = tien1 + item;
            }
            HoaDon_BanHang hd = data.HoaDon_BanHangs.Single(a => a.MaHoaDon == mahdbh);
            hd.TongTien = tien1;
            data.SubmitChanges();
            return cthd;
        }
        public object edit_HDBD(string mahdbh, string makh, string ngay, string manv)
        {
            HoaDon_BanHang hd = data.HoaDon_BanHangs.Single(a => a.MaHoaDon == mahdbh);
            hd.MaKH = makh;
            hd.NgayLapHoaDon = Convert.ToDateTime(ngay);
            hd.MaNV = manv;
            data.SubmitChanges();
            return hd;
        }
        public int add_CTHDBD(string mahdbh, string mahang, string sl, string tien)
        {
            ChiTiet_HoaDon_BanHang cthd = new ChiTiet_HoaDon_BanHang();
            cthd.MaHoaDon = mahdbh;
            cthd.MaHang = mahang;
            cthd.SoLuongHang = Convert.ToInt32(sl);
            cthd.TongTienHang = Convert.ToInt32(tien);
            data.ChiTiet_HoaDon_BanHangs.InsertOnSubmit(cthd);
            data.SubmitChanges();
            var cthd2 = from n in data.ChiTiet_HoaDon_BanHangs
                        where n.MaHoaDon == mahdbh
                        select n.TongTienHang;
            int tien1 = 0;
            foreach (int item in cthd2)
            {
                tien1 = tien1 + item;
            }
            HoaDon_BanHang hd = data.HoaDon_BanHangs.Single(a => a.MaHoaDon == mahdbh);
            hd.TongTien = tien1;
            data.SubmitChanges();
            return 1;
        }
        public int add_HDBD(string mahdbh, string makh, string ngay, string manv)
        {
            HoaDon_BanHang hd = new HoaDon_BanHang();
            int sohd = (from n in data.HoaDon_BanHangs where n.MaHoaDon == mahdbh select n).Count();
            if(sohd > 0)
            {
                MessageBox.Show("Đã tồn tại hóa đơn, kiểm tra mã!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                hd.MaHoaDon = mahdbh;
                hd.MaKH = makh;
                hd.NgayLapHoaDon = Convert.ToDateTime(ngay);
                hd.TongTien = 0;
                hd.MaNV = manv;
                data.HoaDon_BanHangs.InsertOnSubmit(hd);
                data.SubmitChanges();
                return 1;
            }
        }
    }
}
