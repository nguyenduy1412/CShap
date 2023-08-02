using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau3
{
    internal class Program
    {
        class Phong
        {
            public string loaiPhong { get; set; }
            public double gia { get; set; }

            public Phong(string loaiPhong, double gia)
            {
                this.loaiPhong = loaiPhong;
                this.gia = gia;
            }
        }

        class DatPhong
        {
            public Phong Phong { get; set; }
            public string TenKhachHang { get; set; }
            public string DiaChi { get; set; }
            public int SoNgayO { get; set; }
            public List<string> DSTienNghi { get; set; }
            public List<string> DSDichVu { get; set; }

            public DatPhong(Phong Phong, string TenKhachHang, string DiaChi, int SoNgayO, List<string> DSTienNghi, List<string> DSDichVu)
            {
                this.Phong = Phong;
                this.TenKhachHang = TenKhachHang;
                this.DiaChi = DiaChi;
                this.SoNgayO = SoNgayO;
                this.DSTienNghi = DSTienNghi;
                this.DSDichVu = DSDichVu;
            }

            public void ThemDSTienNghi(string DSTienNghi)
            {
                this.DSTienNghi.Add(DSTienNghi);
            }

            public void ThemDSDV(string DSDichVu)
            {
                this.DSDichVu.Add(DSDichVu);
            }
        }

        class ThanhToan
        {
            public DatPhong DatPhong { get; set; }

            public ThanhToan(DatPhong datPhong)
            {
                DatPhong = datPhong;
            }

            public double TongTien()
            {
                double tien = DatPhong.Phong.gia * DatPhong.SoNgayO;

                foreach (string amenity in DatPhong.DSTienNghi)
                {
                    tien += 10000;
                }

                foreach (string service in DatPhong.DSDichVu)
                {
                    if (service == "Karaoke")
                    {
                        tien += 50000;
                    }
                    else if (service == "Ăn sáng")
                    {
                        tien += 15000 * DatPhong.SoNgayO;
                    }
                }

                return tien;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Phong phongDon = new Phong("Phòng đơn", 300000);
            Phong phongDoi = new Phong("Phòng đôi", 350000);
            Phong PhongBa = new Phong("Phòng ba", 400000);

            List<string> DSTN = new List<string>();
            List<string> DSDV = new List<string>();

            DatPhong datphong = new DatPhong(phongDon, "Lê Quang Anh", "TP HCM", 3,DSTN, DSDV);

            datphong.ThemDSTienNghi("Ti Vi");
            datphong.ThemDSTienNghi("Internet");
            datphong.ThemDSTienNghi("May Nuoc Nong");
            datphong.ThemDSDV("Ăn sáng");

            ThanhToan thanhToan = new ThanhToan(datphong);
            double tongTien = thanhToan.TongTien();

            Console.WriteLine("Tổng số tiền khách hàng phải trả là: {0} đồng", tongTien);
            Console.ReadKey();
        }
    }
}
