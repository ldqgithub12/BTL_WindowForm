using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BTL_Windows
{
    class BLL
    {
        DAL dal = new DAL();
        public static string tdn = "";
        public static string mk = "";
        public DataTable DangNhap(String tdn , String mk)
        {
            String query = "Select * from TAIKHOAN where tenDangNhap = '"+tdn+"'and matKhau = '"+mk+"'";
            DataTable tb = dal.GetTable(query);
            return tb;
        }
        public DataTable LoadttThiSinh(String a)
        {
            String sql = "select * from THISINH where maThiSinh = '" + a + "' ";
            DataTable tb = dal.GetTable(sql);
            return tb;
        }
        public DataTable HienthiThiSinh()
        {
            String sql = "select * from THISINH";
            DataTable table = dal.GetTable(sql);
            return table;
        }
        public void updatets(String mats,String tents, Boolean gt ,string cmt)
        {
            string sql = "update THISINH set tenThiSinh = '" + tents + "',gioiTinh = '" + gt + "',soCMT = '" + cmt + "' where maThiSinh = '" + mats + "'";
            dal.ExecuteNoneQuery(sql);
        }
        public void InsertThiSinh(string mats,string tents,Boolean gt , string cmt)
        {
            string sql = "exec pr_taotaikhoan '"+mats+"','"+tents+"','"+gt+"','"+cmt+"','"+mats+"'";
            dal.ExecuteNoneQuery(sql);
        }
        public void doimatkhau(string mkm, string tdn)
        {
            string sql = "update TAIKHOAN set matKhau = '" + mkm + "' where tenDangNhap = '" + tdn + "'";
            dal.ExecuteNoneQuery(sql);
        }
        public DataTable laycauhoi()
        {
            string sql = "select * from CAUHOI";
            DataTable tb = dal.GetTable(sql);
            return tb;
        }
        public DataTable laycautralo()
        {
            string sql = "select * from DAPAN";
            DataTable tb = dal.GetTable(sql);
            return tb;
        }
        public void insertKQ(string msv,int diem)
        {
            string sql = "insert into KETQUA values('"+msv+"',"+diem+")";
            dal.ExecuteNoneQuery(sql);
        }
        public DataTable hienthiKQTS(string mts)
        {
            string sql = "select tenThiSinh, ketQua from THISINH inner join KETQUA on THISINH.maThiSinh = KETQUA.maThiSinh where KETQUA.maThiSinh = '"+mts+"' ";
            DataTable table = dal.GetTable(sql);
            return table;
        }
        public DataTable thongkeKQ()
        {
            string sql = "select KETQUA.maThiSinh , tenThiSinh, ketQua from KETQUA inner join THISINH on KETQUA.maThiSinh = THISINH.maThiSinh";
            DataTable tb = dal.GetTable(sql);
            return tb;
        }
        public DataTable checklanthi()
        {
            string sql = " select * from KETQUA";
            DataTable tb = dal.GetTable(sql);
            return tb;
        }
    }
}
