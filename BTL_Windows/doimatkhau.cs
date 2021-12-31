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
    public partial class doimatkhau : Form
    {
        BLL bll = new BLL();
        public doimatkhau()
        {
            InitializeComponent();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmkc.Text = "";
            txtmkm.Text = "";
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if(txtmkc.Text.Trim() =="")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtmkm.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            if (BLL.mk == txtmkc.Text)
            {
                bll.doimatkhau(txtmkm.Text, BLL.tdn);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmkc.Text = "";
                txtmkm.Text = "";
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmkc.Text = "";
                txtmkm.Text = "";
            }    
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            ThiSinh ts = new ThiSinh();
            ts.Show();
            this.Hide();
        }
    }
}
