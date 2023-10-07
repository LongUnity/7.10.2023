using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrungTamTheHinh
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;




            DSKH ds = new DSKH();

            ds.nhap();
            ds.xuat();





            Console.ReadKey();
        }
    }
}
