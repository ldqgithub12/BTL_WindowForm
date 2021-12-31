using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BTL_Windows
{
    class XuLyDuLieu
    {
        BLL bll = new BLL();
        public List<CauHoi>getCauHoi()
        {
            DataTable table = new DataTable();
            table = bll.laycauhoi();
            List<CauHoi> list = new List<CauHoi>();
            foreach(DataRow row in table.Rows)
            {
                CauHoi ch = new CauHoi();
                ch.macauhoi = row["maCauHoi"].ToString();
                ch.noidung = row["cauHoi"].ToString();
                list.Add(ch);
            }
            return list;
        }
        public List<DapAn> getDapAn()
        {
            DataTable table = new DataTable();
            table = bll.laycautralo();
            List<DapAn> list = new List<DapAn>();
            foreach(DataRow row in table.Rows)
            {
                DapAn da = new DapAn();
                da.madapan = row["maDA"].ToString();
                da.cautraloi = row["noiDungDA"].ToString();
                da.dungsai = Convert.ToInt32(row["dung"]);
                da.macauhoi = row["maCauHoi"].ToString();
                list.Add(da);
            }
            return list;
        }
    }
}
