using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrungTamTheHinh
{
    internal class KhachHang
    {
        public int n { get; set; }
        public string Hoten { get; set; }
        public string CMND { get; set; }
        public Goidichvu Goidichvu { get; set; }
        public int Thoigian { get; set; }
        public KhachHang() { }


        public void nhap()
        {
            Console.WriteLine("Nhập tên khách hàng");
            Hoten = Console.ReadLine();
            Console.WriteLine("Nhập CMND");
            CMND = Console.ReadLine();
            
            Console.WriteLine("1.Premium: ");
            Console.WriteLine("2.Basic: ");
            Console.WriteLine("3.Non-Member: ");
            Console.WriteLine("Chọn Gói Dịch vụ: ");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Bạn đã chọn gói Premium");
                    Goidichvu = new Premium();
                    break;
                case 2:
                    Console.WriteLine("Bạn đã chọn gói Basic");
                    Console.WriteLine("Số Lớp học: ");
                    int m;
                    m = int.Parse(Console.ReadLine());
                    Goidichvu = new Basic(m);
                    break;
                case 3:
                    Console.WriteLine("Bạn đã chọn gói Non-member");
                    Goidichvu = new Non_m();
                    break;
                case 0:
                    break;
            }
            Console.WriteLine("Nhập Số tháng đăng kí");
            Thoigian = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            if (Goidichvu.GetType() == typeof(Premium))
            {
                Console.WriteLine("Bạn đã chọn gói Premium");
            }
            if (Goidichvu.GetType() == typeof(Basic))
            {
                Console.WriteLine("Bạn đã chọn gói Basic");
            }
            if (Goidichvu.GetType() == typeof(Non_m))
            {
                Console.WriteLine("Bạn đã chọn gói Non-member");
            }
            Console.WriteLine($"Khách hàng:{Hoten} với CMND: {CMND} đã mua gói dịch vụ trong vòng: {Thoigian} tháng");
            Console.WriteLine($"Tổng chi tiêu {tongChiTieu()}");
        }
        public int tongChiTieu() 
        {
            if (Goidichvu.GetType() == typeof(Premium))
            {
                return Goidichvu.Phicoban * Thoigian;
            }
            else if (Goidichvu.GetType() == typeof(Basic))
            {
                return (Goidichvu.Phicoban+Goidichvu.PT) * Thoigian;//+Goidichvu.Tongchiphilophoc
            }
            else
            {
                return Goidichvu.Phicoban * Goidichvu.PT;
            }
        }
        
    }
}
