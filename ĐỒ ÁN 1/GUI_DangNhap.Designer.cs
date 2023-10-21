namespace ĐỒ_ÁN_1
{
    partial class GUI_DangNhap
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
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.lbltendangnhap = new System.Windows.Forms.Label();
            this.lblDN = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ckbHTMK = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.LightCoral;
            this.btndangnhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndangnhap.Location = new System.Drawing.Point(169, 419);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(155, 50);
            this.btndangnhap.TabIndex = 14;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnthoat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(436, 419);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(156, 50);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmatkhau.Location = new System.Drawing.Point(249, 302);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(270, 28);
            this.txtmatkhau.TabIndex = 12;
            this.txtmatkhau.TextChanged += new System.EventHandler(this.txtmatkhau_TextChanged);
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttendangnhap.Location = new System.Drawing.Point(249, 225);
            this.txttendangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(270, 28);
            this.txttendangnhap.TabIndex = 11;
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatkhau.Location = new System.Drawing.Point(118, 305);
            this.lblmatkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(89, 22);
            this.lblmatkhau.TabIndex = 10;
            this.lblmatkhau.Text = "Mật khẩu ";
            // 
            // lbltendangnhap
            // 
            this.lbltendangnhap.AutoSize = true;
            this.lbltendangnhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltendangnhap.Location = new System.Drawing.Point(90, 231);
            this.lbltendangnhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltendangnhap.Name = "lbltendangnhap";
            this.lbltendangnhap.Size = new System.Drawing.Size(136, 22);
            this.lbltendangnhap.TabIndex = 9;
            this.lbltendangnhap.Text = "Tên đăng nhập ";
            // 
            // lblDN
            // 
            this.lblDN.AutoSize = true;
            this.lblDN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDN.Location = new System.Drawing.Point(330, 170);
            this.lblDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(139, 28);
            this.lblDN.TabIndex = 8;
            this.lblDN.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ĐỒ_ÁN_1.Properties.Resources._91f00793e3223dee57a089f5f66cb7c7;
            this.pictureBox1.Location = new System.Drawing.Point(299, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ckbHTMK
            // 
            this.ckbHTMK.AutoSize = true;
            this.ckbHTMK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHTMK.Location = new System.Drawing.Point(249, 355);
            this.ckbHTMK.Name = "ckbHTMK";
            this.ckbHTMK.Size = new System.Drawing.Size(175, 26);
            this.ckbHTMK.TabIndex = 16;
            this.ckbHTMK.Text = "hiển thị mật khẩu";
            this.ckbHTMK.UseVisualStyleBackColor = true;
            this.ckbHTMK.CheckedChanged += new System.EventHandler(this.ckbHTMK_CheckedChanged);
            // 
            // GUI_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 534);
            this.Controls.Add(this.ckbHTMK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.lblmatkhau);
            this.Controls.Add(this.lbltendangnhap);
            this.Controls.Add(this.lblDN);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_DangNhap";
            this.Text = "GUI_DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Label lbltendangnhap;
        private System.Windows.Forms.Label lblDN;
        private System.Windows.Forms.CheckBox ckbHTMK;
    }
}