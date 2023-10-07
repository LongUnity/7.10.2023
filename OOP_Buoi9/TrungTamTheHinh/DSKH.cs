using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrungTamTheHinh
{
    internal class DSKH
    {
        public int n { get; set; }
        public List<KhachHang> arr { get; set; }
        public DSKH() { }

        public void nhap()
        {
            arr = new List<KhachHang>();

            Console.Write("Nhập số lượng khách hàng:");
            n= int.Parse(Console.ReadLine());

            for (int i=0; i < n; i++)
            {
                KhachHang a = new KhachHang();
                a.nhap();
                arr.Add(a);
            }            
        }
        public void xuat()
        {
            foreach (var item in arr)
            {
                item.xuat();
            }
        }
        public void chiTieuMax()
        {
            KhachHang kh = new KhachHang();
            int max = kh.tongChiTieu();
            foreach (KhachHang item in arr)
            {
                if(item.tongChiTieu() > max)
                {
                    max = item.tongChiTieu();
                }
            }
        }
    }
}
