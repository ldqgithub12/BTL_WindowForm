
namespace BTL_Windows
{
    partial class QLTS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtghienthi = new System.Windows.Forms.DataGridView();
            this.maThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.soCMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsocccd = new System.Windows.Forms.TextBox();
            this.txttents = new System.Windows.Forms.TextBox();
            this.txtmats = new System.Windows.Forms.TextBox();
            this.btndangXuat = new System.Windows.Forms.Button();
            this.btnsuathongtin = new System.Windows.Forms.Button();
            this.btnthemts = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbnu = new System.Windows.Forms.RadioButton();
            this.rdbnam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmats = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtghienthi)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dtghienthi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.55556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 567);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtghienthi
            // 
            this.dtghienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtghienthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThiSinh,
            this.tenThiSinh,
            this.gioiTinh,
            this.soCMT,
            this.tenDangNhap});
            this.dtghienthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtghienthi.Location = new System.Drawing.Point(3, 345);
            this.dtghienthi.Name = "dtghienthi";
            this.dtghienthi.RowHeadersWidth = 51;
            this.dtghienthi.RowTemplate.Height = 24;
            this.dtghienthi.Size = new System.Drawing.Size(794, 219);
            this.dtghienthi.TabIndex = 0;
            this.dtghienthi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtghienthi_CellClick);
            // 
            // maThiSinh
            // 
            this.maThiSinh.DataPropertyName = "maThiSinh";
            this.maThiSinh.HeaderText = "Mã thí sinh";
            this.maThiSinh.MinimumWidth = 6;
            this.maThiSinh.Name = "maThiSinh";
            this.maThiSinh.Width = 125;
            // 
            // tenThiSinh
            // 
            this.tenThiSinh.DataPropertyName = "tenThiSinh";
            this.tenThiSinh.HeaderText = "Tên thí sinh";
            this.tenThiSinh.MinimumWidth = 6;
            this.tenThiSinh.Name = "tenThiSinh";
            this.tenThiSinh.Width = 125;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới Tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Width = 125;
            // 
            // soCMT
            // 
            this.soCMT.DataPropertyName = "soCMT";
            this.soCMT.HeaderText = "Số CCCD";
            this.soCMT.MinimumWidth = 6;
            this.soCMT.Name = "soCMT";
            this.soCMT.Width = 125;
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.DataPropertyName = "tenDangNhap";
            this.tenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.tenDangNhap.MinimumWidth = 6;
            this.tenDangNhap.Name = "tenDangNhap";
            this.tenDangNhap.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtsocccd);
            this.panel1.Controls.Add(this.txttents);
            this.panel1.Controls.Add(this.txtmats);
            this.panel1.Controls.Add(this.btndangXuat);
            this.panel1.Controls.Add(this.btnsuathongtin);
            this.panel1.Controls.Add(this.btnthemts);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblmats);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 336);
            this.panel1.TabIndex = 1;
            // 
            // txtsocccd
            // 
            this.txtsocccd.Location = new System.Drawing.Point(200, 226);
            this.txtsocccd.Name = "txtsocccd";
            this.txtsocccd.Size = new System.Drawing.Size(367, 22);
            this.txtsocccd.TabIndex = 8;
            // 
            // txttents
            // 
            this.txttents.Location = new System.Drawing.Point(200, 77);
            this.txttents.Name = "txttents";
            this.txttents.Size = new System.Drawing.Size(367, 22);
            this.txttents.TabIndex = 8;
            // 
            // txtmats
            // 
            this.txtmats.Location = new System.Drawing.Point(200, 41);
            this.txtmats.Name = "txtmats";
            this.txtmats.Size = new System.Drawing.Size(367, 22);
            this.txtmats.TabIndex = 8;
            // 
            // btndangXuat
            // 
            this.btndangXuat.Location = new System.Drawing.Point(511, 265);
            this.btndangXuat.Name = "btndangXuat";
            this.btndangXuat.Size = new System.Drawing.Size(126, 53);
            this.btndangXuat.TabIndex = 7;
            this.btndangXuat.Text = "Quay lại";
            this.btndangXuat.UseVisualStyleBackColor = true;
            this.btndangXuat.Click += new System.EventHandler(this.btndangXuat_Click);
            // 
            // btnsuathongtin
            // 
            this.btnsuathongtin.Location = new System.Drawing.Point(339, 265);
            this.btnsuathongtin.Name = "btnsuathongtin";
            this.btnsuathongtin.Size = new System.Drawing.Size(149, 53);
            this.btnsuathongtin.TabIndex = 6;
            this.btnsuathongtin.Text = "Sửa thông tin thí sinh";
            this.btnsuathongtin.UseVisualStyleBackColor = true;
            this.btnsuathongtin.Click += new System.EventHandler(this.btnsuathongtin_Click);
            // 
            // btnthemts
            // 
            this.btnthemts.Location = new System.Drawing.Point(200, 265);
            this.btnthemts.Name = "btnthemts";
            this.btnthemts.Size = new System.Drawing.Size(111, 53);
            this.btnthemts.TabIndex = 5;
            this.btnthemts.Text = "Thêm thí sinh";
            this.btnthemts.UseVisualStyleBackColor = true;
            this.btnthemts.Click += new System.EventHandler(this.btnthemts_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số CCCD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbnu);
            this.groupBox1.Controls.Add(this.rdbnam);
            this.groupBox1.Location = new System.Drawing.Point(112, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rdbnu
            // 
            this.rdbnu.AutoSize = true;
            this.rdbnu.Location = new System.Drawing.Point(250, 36);
            this.rdbnu.Name = "rdbnu";
            this.rdbnu.Size = new System.Drawing.Size(47, 21);
            this.rdbnu.TabIndex = 0;
            this.rdbnu.TabStop = true;
            this.rdbnu.Text = "Nữ";
            this.rdbnu.UseVisualStyleBackColor = true;
            // 
            // rdbnam
            // 
            this.rdbnam.AutoSize = true;
            this.rdbnam.Location = new System.Drawing.Point(88, 36);
            this.rdbnam.Name = "rdbnam";
            this.rdbnam.Size = new System.Drawing.Size(58, 21);
            this.rdbnam.TabIndex = 0;
            this.rdbnam.TabStop = true;
            this.rdbnam.Text = "Nam";
            this.rdbnam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // lblmats
            // 
            this.lblmats.AutoSize = true;
            this.lblmats.Location = new System.Drawing.Point(109, 41);
            this.lblmats.Name = "lblmats";
            this.lblmats.Size = new System.Drawing.Size(76, 17);
            this.lblmats.TabIndex = 1;
            this.lblmats.Text = "Mã thí sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thí sinh";
            // 
            // QLTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QLTS";
            this.Text = "QLTS";
            this.Load += new System.EventHandler(this.QLTS_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtghienthi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtghienthi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsocccd;
        private System.Windows.Forms.TextBox txttents;
        private System.Windows.Forms.TextBox txtmats;
        private System.Windows.Forms.Button btndangXuat;
        private System.Windows.Forms.Button btnsuathongtin;
        private System.Windows.Forms.Button btnthemts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbnu;
        private System.Windows.Forms.RadioButton rdbnam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThiSinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhap;
    }
}