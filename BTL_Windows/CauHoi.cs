using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Windows
{
    class CauHoi
    {
        public string macauhoi { get; set; }
        public string noidung { get; set; }
        public CauHoi() { }
        public CauHoi(string mch)
        {
            macauhoi = mch;
        }
        public override bool Equals(Object obj)
        {
            return this.macauhoi == ((CauHoi)obj).macauhoi;
        }
    }
}
