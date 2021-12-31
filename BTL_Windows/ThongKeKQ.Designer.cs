
namespace BTL_Windows
{
    partial class ThongKeKQ
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
            this.dtgthongke = new System.Windows.Forms.DataGridView();
            this.lbldat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtdat = new System.Windows.Forms.TextBox();
            this.txtkdat = new System.Windows.Forms.TextBox();
            this.maThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgthongke)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgthongke
            // 
            this.dtgthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgthongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThiSinh,
            this.tenThiSinh,
            this.ketQua});
            this.dtgthongke.Location = new System.Drawing.Point(-1, -1);
            this.dtgthongke.Name = "dtgthongke";
            this.dtgthongke.RowHeadersWidth = 51;
            this.dtgthongke.RowTemplate.Height = 24;
            this.dtgthongke.Size = new System.Drawing.Size(797, 256);
            this.dtgthongke.TabIndex = 0;
            // 
            // lbldat
            // 
            this.lbldat.AutoSize = true;
            this.lbldat.Location = new System.Drawing.Point(62, 281);
            this.lbldat.Name = "lbldat";
            this.lbldat.Size = new System.Drawing.Size(98, 17);
            this.lbldat.TabIndex = 1;
            this.lbldat.Text = "Số thí sinh đạt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số thí sinh không đạt";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdat
            // 
            this.txtdat.Location = new System.Drawing.Point(166, 281);
            this.txtdat.Name = "txtdat";
            this.txtdat.ReadOnly = true;
            this.txtdat.Size = new System.Drawing.Size(100, 22);
            this.txtdat.TabIndex = 4;
            // 
            // txtkdat
            // 
            this.txtkdat.Location = new System.Drawing.Point(588, 281);
            this.txtkdat.Name = "txtkdat";
            this.txtkdat.ReadOnly = true;
            this.txtkdat.Size = new System.Drawing.Size(100, 22);
            this.txtkdat.TabIndex = 4;
            // 
            // maThiSinh
            // 
            this.maThiSinh.DataPropertyName = "maThiSinh";
            this.maThiSinh.HeaderText = "Mã thí sinh";
            this.maThiSinh.MinimumWidth = 6;
            this.maThiSinh.Name = "maThiSinh";
            this.maThiSinh.Width = 175;
            // 
            // tenThiSinh
            // 
            this.tenThiSinh.DataPropertyName = "tenThiSinh";
            this.tenThiSinh.HeaderText = "Tên thí sinh";
            this.tenThiSinh.MinimumWidth = 6;
            this.tenThiSinh.Name = "tenThiSinh";
            this.tenThiSinh.Width = 195;
            // 
            // ketQua
            // 
            this.ketQua.DataPropertyName = "ketQua";
            this.ketQua.HeaderText = "Điểm";
            this.ketQua.MinimumWidth = 6;
            this.ketQua.Name = "ketQua";
            this.ketQua.Width = 175;
            // 
            // ThongKeKQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkdat);
            this.Controls.Add(this.txtdat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldat);
            this.Controls.Add(this.dtgthongke);
            this.Name = "ThongKeKQ";
            this.Text = "ThongKeKQ";
            this.Load += new System.EventHandler(this.ThongKeKQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgthongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgthongke;
        private System.Windows.Forms.Label lbldat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdat;
        private System.Windows.Forms.TextBox txtkdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketQua;
    }
}