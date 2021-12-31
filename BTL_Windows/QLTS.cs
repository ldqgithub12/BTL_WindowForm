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
    public partial class QLTS : Form
    {
        BLL bll = new BLL();
        public QLTS()
        {
            InitializeComponent();
        }

        private void QLTS_Load(object sender, EventArgs e)
        {
            DataTable tb = bll.HienthiThiSinh();
            dtghienthi.DataSource = tb;
        }

        private void dtghienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if(row >= 0)
            {
                txtmats.Text = dtghienthi.Rows[row].Cells[0].Value.ToString();
                txttents.Text = dtghienthi.Rows[row].Cells[1].Value.ToString();
                if (dtghienthi.Rows[row].Cells[2].Value.Equals(true))
                    rdbnam.Checked = true;
                else rdbnu.Checked = true;
                txtsocccd.Text = dtghienthi.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void btnthemts_Click(object sender, EventArgs e)
        {
            Boolean gt = false;
            if (rdbnam.Checked) gt = true;
            bll.InsertThiSinh(txtmats.Text, txttents.Text, gt, txtsocccd.Text);
            QLTS_Load(sender, e);
        }

        private void btnsuathongtin_Click(object sender, EventArgs e)
        {
            Boolean gt = false;
            if (rdbnam.Checked == true) gt = true;
            bll.updatets(txtmats.Text, txttents.Text, gt, txtsocccd.Text);
            QLTS_Load(sender, e);
        }

        private void btndangXuat_Click(object sender, EventArgs e)
        {
            AdminForm adm = new AdminForm();
            adm.Show();
            this.Close();
        }
    }
}
