using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Windows
{
    public partial class ThiSinh : Form
    {
        BLL bll = new BLL();
        public ThiSinh()
        {
            InitializeComponent();
        }
        private void ThiSinh_Load(object sender, EventArgs e)
        {
            DataTable tale = bll.LoadttThiSinh(BLL.tdn);
            if (tale.Rows.Count != 0)
            {
                //MessageBox.Show("Da co du lieu");
                txtmats.Text = tale.Rows[0]["maThiSinh"].ToString();
                txttents.Text = tale.Rows[0]["tenThiSinh"].ToString();
                if (tale.Rows[0]["gioiTinh"].Equals(true))
                {
                    rdbnam.Checked = true;
                }
                else rdbnu.Checked = true;
                txtcccd.Text = tale.Rows[0]["soCMT"].ToString();

            }
            else MessageBox.Show("chua co du lieu");
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
            this.Hide();
        }

        private void btnxemketqua_Click(object sender, EventArgs e)
        {
            Xemketqua xkq = new Xemketqua();
            xkq.Show();
            this.Hide();
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            doimatkhau dmk = new doimatkhau();
            dmk.Show();
            this.Hide();
        }

        private void btnvaothi_Click(object sender, EventArgs e)
        {
            DataTable table = bll.checklanthi();
            int dem = 0;
            foreach(DataRow r in table.Rows)
            {
                if(r["maThiSinh"].ToString() == BLL.tdn)
                {
                    dem++;
                }
            }
            if(dem >0)
            {
                MessageBox.Show("Bạn đã hoàn thành bài thi. Vui lòng chọn chức năng khác", "Thông báo");
                this.Show();
            }
            else
            {
                frmVaoThi vt = new frmVaoThi();
                vt.Show();
                this.Hide();
            }
            //frmVaoThi vt = new frmVaoThi();
            //vt.Show();
            //this.Hide();
        }
    }
}
