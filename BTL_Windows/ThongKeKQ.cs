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
    public partial class ThongKeKQ : Form
    {
        BLL bll = new BLL();
        int i, j = 0;
        public ThongKeKQ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm adm = new AdminForm();
            adm.Show();
            this.Close();
        }

        private void ThongKeKQ_Load(object sender, EventArgs e)
        {
            DataTable table =  bll.thongkeKQ();
            foreach(DataRow row in table.Rows)
            {
                if (Convert.ToInt32(row["ketQua"]) >= 16)
                {
                    i++;
                }
                else j++;
            }
            dtgthongke.DataSource = table;
            txtdat.Text = Convert.ToString(i);
            txtkdat.Text = Convert.ToString(j);

        }
    }
}
