
namespace BTL_Windows
{
    partial class frmVaoThi
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
            this.txtcauhoi = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.rdbnopbai = new System.Windows.Forms.Button();
            this.lblcauhoi = new System.Windows.Forms.Label();
            this.lblsocau = new System.Windows.Forms.Label();
            this.txtdapana = new System.Windows.Forms.TextBox();
            this.txtdapanc = new System.Windows.Forms.TextBox();
            this.txtdapanb = new System.Windows.Forms.TextBox();
            this.rdbdapanc = new System.Windows.Forms.RadioButton();
            this.rdbdapanb = new System.Windows.Forms.RadioButton();
            this.rdbdapana = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtcauhoi
            // 
            this.txtcauhoi.Enabled = false;
            this.txtcauhoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcauhoi.Location = new System.Drawing.Point(163, 12);
            this.txtcauhoi.Multiline = true;
            this.txtcauhoi.Name = "txtcauhoi";
            this.txtcauhoi.ReadOnly = true;
            this.txtcauhoi.Size = new System.Drawing.Size(594, 63);
            this.txtcauhoi.TabIndex = 0;
            this.txtcauhoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(586, 377);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(119, 47);
            this.btnnext.TabIndex = 3;
            this.btnnext.Text = ">>";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // rdbnopbai
            // 
            this.rdbnopbai.Location = new System.Drawing.Point(177, 377);
            this.rdbnopbai.Name = "rdbnopbai";
            this.rdbnopbai.Size = new System.Drawing.Size(128, 47);
            this.rdbnopbai.TabIndex = 4;
            this.rdbnopbai.Text = "Nộp bài";
            this.rdbnopbai.UseVisualStyleBackColor = true;
            this.rdbnopbai.Click += new System.EventHandler(this.rdbnopbai_Click);
            // 
            // lblcauhoi
            // 
            this.lblcauhoi.AutoSize = true;
            this.lblcauhoi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcauhoi.Location = new System.Drawing.Point(6, 25);
            this.lblcauhoi.Name = "lblcauhoi";
            this.lblcauhoi.Size = new System.Drawing.Size(103, 33);
            this.lblcauhoi.TabIndex = 11;
            this.lblcauhoi.Text = "Câu hỏi";
            // 
            // lblsocau
            // 
            this.lblsocau.AutoSize = true;
            this.lblsocau.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsocau.Location = new System.Drawing.Point(115, 29);
            this.lblsocau.Name = "lblsocau";
            this.lblsocau.Size = new System.Drawing.Size(0, 29);
            this.lblsocau.TabIndex = 13;
            // 
            // txtdapana
            // 
            this.txtdapana.Enabled = false;
            this.txtdapana.Location = new System.Drawing.Point(163, 109);
            this.txtdapana.Multiline = true;
            this.txtdapana.Name = "txtdapana";
            this.txtdapana.ReadOnly = true;
            this.txtdapana.Size = new System.Drawing.Size(594, 64);
            this.txtdapana.TabIndex = 14;
            // 
            // txtdapanc
            // 
            this.txtdapanc.Enabled = false;
            this.txtdapanc.Location = new System.Drawing.Point(163, 284);
            this.txtdapanc.Multiline = true;
            this.txtdapanc.Name = "txtdapanc";
            this.txtdapanc.ReadOnly = true;
            this.txtdapanc.Size = new System.Drawing.Size(594, 64);
            this.txtdapanc.TabIndex = 14;
            // 
            // txtdapanb
            // 
            this.txtdapanb.Enabled = false;
            this.txtdapanb.Location = new System.Drawing.Point(163, 199);
            this.txtdapanb.Multiline = true;
            this.txtdapanb.Name = "txtdapanb";
            this.txtdapanb.ReadOnly = true;
            this.txtdapanb.Size = new System.Drawing.Size(594, 64);
            this.txtdapanb.TabIndex = 14;
            // 
            // rdbdapanc
            // 
            this.rdbdapanc.AutoSize = true;
            this.rdbdapanc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdapanc.Location = new System.Drawing.Point(108, 284);
            this.rdbdapanc.Name = "rdbdapanc";
            this.rdbdapanc.Size = new System.Drawing.Size(50, 30);
            this.rdbdapanc.TabIndex = 7;
            this.rdbdapanc.TabStop = true;
            this.rdbdapanc.Text = "C";
            this.rdbdapanc.UseVisualStyleBackColor = true;
            // 
            // rdbdapanb
            // 
            this.rdbdapanb.AutoSize = true;
            this.rdbdapanb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdapanb.Location = new System.Drawing.Point(108, 199);
            this.rdbdapanb.Name = "rdbdapanb";
            this.rdbdapanb.Size = new System.Drawing.Size(49, 30);
            this.rdbdapanb.TabIndex = 6;
            this.rdbdapanb.TabStop = true;
            this.rdbdapanb.Text = "B";
            this.rdbdapanb.UseVisualStyleBackColor = true;
            // 
            // rdbdapana
            // 
            this.rdbdapana.AutoSize = true;
            this.rdbdapana.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdapana.Location = new System.Drawing.Point(108, 109);
            this.rdbdapana.Name = "rdbdapana";
            this.rdbdapana.Size = new System.Drawing.Size(50, 30);
            this.rdbdapana.TabIndex = 5;
            this.rdbdapana.TabStop = true;
            this.rdbdapana.Text = "A";
            this.rdbdapana.UseVisualStyleBackColor = true;
            // 
            // frmVaoThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdapanb);
            this.Controls.Add(this.txtdapanc);
            this.Controls.Add(this.txtdapana);
            this.Controls.Add(this.lblsocau);
            this.Controls.Add(this.lblcauhoi);
            this.Controls.Add(this.rdbdapanc);
            this.Controls.Add(this.rdbdapanb);
            this.Controls.Add(this.rdbdapana);
            this.Controls.Add(this.rdbnopbai);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.txtcauhoi);
            this.Name = "frmVaoThi";
            this.Text = "frmVaoThi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcauhoi;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button rdbnopbai;
        private System.Windows.Forms.Label lblcauhoi;
        private System.Windows.Forms.Label lblsocau;
        private System.Windows.Forms.TextBox txtdapana;
        private System.Windows.Forms.TextBox txtdapanc;
        private System.Windows.Forms.TextBox txtdapanb;
        private System.Windows.Forms.RadioButton rdbdapanc;
        private System.Windows.Forms.RadioButton rdbdapanb;
        private System.Windows.Forms.RadioButton rdbdapana;
    }
}