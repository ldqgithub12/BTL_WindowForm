
namespace BTL_Windows
{
    partial class ThiSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThiSinh));
            this.btnvaothi = new System.Windows.Forms.Button();
            this.btnxemketqua = new System.Windows.Forms.Button();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.lblmats = new System.Windows.Forms.Label();
            this.lbltents = new System.Windows.Forms.Label();
            this.grbgioitinh = new System.Windows.Forms.GroupBox();
            this.rdbnu = new System.Windows.Forms.RadioButton();
            this.rdbnam = new System.Windows.Forms.RadioButton();
            this.lblsocmt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmats = new System.Windows.Forms.TextBox();
            this.txttents = new System.Windows.Forms.TextBox();
            this.txtcccd = new System.Windows.Forms.TextBox();
            this.btndoimatkhau = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbgioitinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvaothi
            // 
            this.btnvaothi.Location = new System.Drawing.Point(70, 353);
            this.btnvaothi.Name = "btnvaothi";
            this.btnvaothi.Size = new System.Drawing.Size(142, 57);
            this.btnvaothi.TabIndex = 0;
            this.btnvaothi.Text = "Vào thi";
            this.btnvaothi.UseVisualStyleBackColor = true;
            this.btnvaothi.Click += new System.EventHandler(this.btnvaothi_Click);
            // 
            // btnxemketqua
            // 
            this.btnxemketqua.Location = new System.Drawing.Point(425, 353);
            this.btnxemketqua.Name = "btnxemketqua";
            this.btnxemketqua.Size = new System.Drawing.Size(139, 57);
            this.btnxemketqua.TabIndex = 1;
            this.btnxemketqua.Text = "Xem kết quả";
            this.btnxemketqua.UseVisualStyleBackColor = true;
            this.btnxemketqua.Click += new System.EventHandler(this.btnxemketqua_Click);
            // 
            // btndangxuat
            // 
            this.btndangxuat.Location = new System.Drawing.Point(594, 353);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(138, 57);
            this.btndangxuat.TabIndex = 2;
            this.btndangxuat.Text = "Đăng Xuất";
            this.btndangxuat.UseVisualStyleBackColor = true;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // lblmats
            // 
            this.lblmats.AutoSize = true;
            this.lblmats.Location = new System.Drawing.Point(238, 62);
            this.lblmats.Name = "lblmats";
            this.lblmats.Size = new System.Drawing.Size(84, 17);
            this.lblmats.TabIndex = 3;
            this.lblmats.Text = "Mã thí sinh: ";
            // 
            // lbltents
            // 
            this.lbltents.AutoSize = true;
            this.lbltents.Location = new System.Drawing.Point(238, 112);
            this.lbltents.Name = "lbltents";
            this.lbltents.Size = new System.Drawing.Size(58, 17);
            this.lbltents.TabIndex = 4;
            this.lbltents.Text = "Họ tên: ";
            // 
            // grbgioitinh
            // 
            this.grbgioitinh.Controls.Add(this.rdbnu);
            this.grbgioitinh.Controls.Add(this.rdbnam);
            this.grbgioitinh.Enabled = false;
            this.grbgioitinh.Location = new System.Drawing.Point(241, 153);
            this.grbgioitinh.Name = "grbgioitinh";
            this.grbgioitinh.Size = new System.Drawing.Size(323, 100);
            this.grbgioitinh.TabIndex = 5;
            this.grbgioitinh.TabStop = false;
            this.grbgioitinh.Text = "Giới tính";
            // 
            // rdbnu
            // 
            this.rdbnu.AutoSize = true;
            this.rdbnu.Location = new System.Drawing.Point(212, 45);
            this.rdbnu.Name = "rdbnu";
            this.rdbnu.Size = new System.Drawing.Size(47, 21);
            this.rdbnu.TabIndex = 1;
            this.rdbnu.TabStop = true;
            this.rdbnu.Text = "Nữ";
            this.rdbnu.UseVisualStyleBackColor = true;
            // 
            // rdbnam
            // 
            this.rdbnam.AutoSize = true;
            this.rdbnam.Location = new System.Drawing.Point(43, 45);
            this.rdbnam.Name = "rdbnam";
            this.rdbnam.Size = new System.Drawing.Size(58, 21);
            this.rdbnam.TabIndex = 0;
            this.rdbnam.TabStop = true;
            this.rdbnam.Text = "Nam";
            this.rdbnam.UseVisualStyleBackColor = true;
            // 
            // lblsocmt
            // 
            this.lblsocmt.AutoSize = true;
            this.lblsocmt.Location = new System.Drawing.Point(238, 291);
            this.lblsocmt.Name = "lblsocmt";
            this.lblsocmt.Size = new System.Drawing.Size(74, 17);
            this.lblsocmt.TabIndex = 6;
            this.lblsocmt.Text = "Số CCCD: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "TRUNG TÂM THI BẰNG LÁI XE";
            // 
            // txtmats
            // 
            this.txtmats.Enabled = false;
            this.txtmats.Location = new System.Drawing.Point(356, 62);
            this.txtmats.Name = "txtmats";
            this.txtmats.ReadOnly = true;
            this.txtmats.Size = new System.Drawing.Size(208, 22);
            this.txtmats.TabIndex = 8;
            // 
            // txttents
            // 
            this.txttents.Enabled = false;
            this.txttents.Location = new System.Drawing.Point(356, 112);
            this.txttents.Name = "txttents";
            this.txttents.ReadOnly = true;
            this.txttents.Size = new System.Drawing.Size(208, 22);
            this.txttents.TabIndex = 8;
            // 
            // txtcccd
            // 
            this.txtcccd.Enabled = false;
            this.txtcccd.Location = new System.Drawing.Point(356, 286);
            this.txtcccd.Name = "txtcccd";
            this.txtcccd.ReadOnly = true;
            this.txtcccd.Size = new System.Drawing.Size(208, 22);
            this.txtcccd.TabIndex = 9;
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.Location = new System.Drawing.Point(241, 353);
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.Size = new System.Drawing.Size(151, 57);
            this.btndoimatkhau.TabIndex = 10;
            this.btndoimatkhau.Text = "Đổi mật khẩu";
            this.btndoimatkhau.UseVisualStyleBackColor = true;
            this.btndoimatkhau.Click += new System.EventHandler(this.btndoimatkhau_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 169);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ThiSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndoimatkhau);
            this.Controls.Add(this.txtcccd);
            this.Controls.Add(this.txttents);
            this.Controls.Add(this.txtmats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsocmt);
            this.Controls.Add(this.grbgioitinh);
            this.Controls.Add(this.lbltents);
            this.Controls.Add(this.lblmats);
            this.Controls.Add(this.btndangxuat);
            this.Controls.Add(this.btnxemketqua);
            this.Controls.Add(this.btnvaothi);
            this.Name = "ThiSinh";
            this.Text = "ThiSinh";
            this.Load += new System.EventHandler(this.ThiSinh_Load);
            this.grbgioitinh.ResumeLayout(false);
            this.grbgioitinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvaothi;
        private System.Windows.Forms.Button btnxemketqua;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.Label lblmats;
        private System.Windows.Forms.Label lbltents;
        private System.Windows.Forms.GroupBox grbgioitinh;
        private System.Windows.Forms.RadioButton rdbnu;
        private System.Windows.Forms.RadioButton rdbnam;
        private System.Windows.Forms.Label lblsocmt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmats;
        private System.Windows.Forms.TextBox txttents;
        private System.Windows.Forms.TextBox txtcccd;
        private System.Windows.Forms.Button btndoimatkhau;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}