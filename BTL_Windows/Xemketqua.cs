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
    public partial class Xemketqua : Form
    {
        BLL bll = new BLL();
        public Xemketqua()
        {
            InitializeComponent();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            ThiSinh ts = new ThiSinh();
            ts.Show();
            this.Hide();
        }

        private void Xemketqua_Load(object sender, EventArgs e)
        {
            DataTable tb = bll.hienthiKQTS(BLL.tdn);
            if(tb.Rows.Count !=0)
            {
                txthoten.Text = tb.Rows[0]["tenThiSinh"].ToString();
                txtdiem.Text = tb.Rows[0]["ketQua"].ToString();
                string ketqua = "Không đạt";
                if (Convert.ToInt32(tb.Rows[0]["ketQua"]) > 15) ketqua = "Đạt";
                txtketqua.Text = ketqua;
            }
            else
            {
                MessageBox.Show("Vui lòng hoàn thành bài thi để xem kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ThiSinh ts = new ThiSinh();
                ts.Show();
                this.Close();
            }
        }
    }
}
