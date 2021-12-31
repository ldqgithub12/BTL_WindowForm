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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
            this.Hide();
        }

        private void btnqlts_Click(object sender, EventArgs e)
        {
            QLTS ql = new QLTS();
            ql.Show();
            this.Hide();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            ThongKeKQ kq = new ThongKeKQ();
            kq.Show();
            this.Hide();
        }
    }
}
