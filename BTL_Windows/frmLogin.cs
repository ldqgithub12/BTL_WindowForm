using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BTL_Windows
{
    public partial class frmLogin : Form
    {
        BLL bll = new BLL();
        String tdn;
        public frmLogin()
        {
            InitializeComponent();
            BLL bll = new BLL();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(txttdn.Text.Trim() =="")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtmk.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            DataTable table = bll.DangNhap(txttdn.Text, txtmk.Text);
            BLL.tdn = txttdn.Text;
            BLL.mk = txtmk.Text;
            if (table.Rows.Count != 0)
            {
                if (Convert.ToInt32(table.Rows[0]["Quyen"]) == 1)
                {
                    AdminForm adm = new AdminForm();
                    adm.Show();
                }
                else
                {
                    ThiSinh ts = new ThiSinh();
                    ts.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác !!", "Thông Báo");
                txttdn.Text = "";
                txtmk.Text = "";
                txttdn.Focus();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
