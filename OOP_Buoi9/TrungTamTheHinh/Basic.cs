using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrungTamTheHinh
{
    internal class Basic:Goidichvu
    {
        public int lop { get; set; }
        public Basic(int lop)
        {
            Phicoban = 500 * 1000;
            Chiphilophoc = 100;
            Xonghoi = false;
            PT = 100;
            this.lop = lop;
        }
        
    }
}
