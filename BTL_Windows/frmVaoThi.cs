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
    public partial class frmVaoThi : Form
    {
        BLL bll = new BLL();
        XuLyDuLieu xldl = new XuLyDuLieu();
        private List<CauHoi> listCH;
        private List<DapAn> listDA;
        private List<DapAn> DAchon;
        int questionIndex = 1;
        int diem = 0;
        int mch;
        TextBox[] txtdapanthi;
        RadioButton[] rdbdachon;
        public frmVaoThi()
        {
            InitializeComponent();
            listCH = xldl.getCauHoi();
            listDA = xldl.getDapAn();
            txtdapanthi = new TextBox[] { txtdapana, txtdapanb, txtdapanc };
            rdbdachon = new RadioButton[] { rdbdapana, rdbdapanb, rdbdapanc };
            Hienthicauhoi(questionIndex);
            Hienthicautraloi(questionIndex);
            DAchon = new List<DapAn>();
        }
        public void Hienthicauhoi(int i)
        {
            lblsocau.Text = Convert.ToString(i);
            Random r = new Random();
            int k = r.Next(1, 25);
            foreach(CauHoi ch in listCH)
            {
                if(Convert.ToInt32(ch.macauhoi) == k)
                {
                    txtcauhoi.Text = ch.noidung;
                    mch = k;
                }
            }
        }
        public void Hienthicautraloi(int i)
        {
            int j = 0;
            foreach(DapAn da in listDA)
            {
                if (Convert.ToInt32(da.macauhoi) == mch)
                {
                    txtdapanthi[j].Text = da.cautraloi;
                    j++;
                }
            }  
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            if (rdbdapana.Checked)
            {
                foreach(DapAn a in listDA)
                {
                    if(a.cautraloi == txtdapana.Text)
                    { DAchon.Add(a); }
                }    
            }
            if(rdbdapanb.Checked)
            {
                foreach (DapAn a in listDA)
                {
                    if (a.cautraloi == txtdapanb.Text)
                    { DAchon.Add(a); }
                }
            }
            if(rdbdapanc.Checked)
            {
                foreach (DapAn a in listDA)
                {
                    if (a.cautraloi == txtdapanc.Text)
                    { DAchon.Add(a); }
                }
            }
            if(questionIndex <20)
            {
                questionIndex++;
                Hienthicauhoi(questionIndex);
                Hienthicautraloi(questionIndex);
                clearChoose();
            }
            
        }
        private void clearChoose()
        {
            rdbdapana.Checked = false;
            rdbdapanb.Checked = false;
            rdbdapanc.Checked = false;
        }
        private void rdbnopbai_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Submit ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(rs == DialogResult.Yes)
            {
                foreach (DapAn a in listDA)
                {
                   foreach(DapAn b in DAchon)
                    {
                        if(a.cautraloi==b.cautraloi && a.macauhoi == b.macauhoi && a.dungsai == 1)
                        {
                            diem++;
                        }
                    }
                }
            }
            DialogResult kq = MessageBox.Show("Số điểm của bạn là: " + diem, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(kq == DialogResult.OK)
            {
                bll.insertKQ(BLL.tdn, diem);
                ThiSinh ts = new ThiSinh();
                ts.Show();
                this.Close();
            }
        }
    }
}
