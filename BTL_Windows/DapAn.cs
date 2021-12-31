using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Windows
{
    class DapAn
    {
        public string madapan { get; set; }
        public string cautraloi { get; set; }
        public string macauhoi { get; set; }
        public int dungsai { get; set; }
        public DapAn() { }
        public DapAn(string mch)
        {
            madapan = mch;
        }
        public override bool Equals(Object obj)
        {
            return this.madapan == ((DapAn)obj).madapan;
        }
    }
}
