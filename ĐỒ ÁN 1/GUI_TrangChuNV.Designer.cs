namespace ĐỒ_ÁN_1
{
    partial class GUI_TrangChuNV
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnhdb = new System.Windows.Forms.Button();
            this.btnsp = new System.Windows.Forms.Button();
            this.btnkh = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnthoat.Location = new System.Drawing.Point(882, 504);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(131, 50);
            this.btnthoat.TabIndex = 18;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(38, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 55);
            this.label1.TabIndex = 17;
            this.label1.Text = "KIO SHOP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(11, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1062, 354);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ĐỒ_ÁN_1.Properties.Resources.Mau_thiet_ke_shop_tui_xach_hien_dai_31;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1062, 352);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(551, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(8, 10);
            this.button5.TabIndex = 15;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.btnhdb);
            this.groupBox1.Controls.Add(this.btnsp);
            this.groupBox1.Controls.Add(this.btnkh);
            this.groupBox1.Location = new System.Drawing.Point(11, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 76);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trang chủ ";
            // 
            // btnhdb
            // 
            this.btnhdb.BackColor = System.Drawing.Color.MistyRose;
            this.btnhdb.Location = new System.Drawing.Point(762, 24);
            this.btnhdb.Name = "btnhdb";
            this.btnhdb.Size = new System.Drawing.Size(161, 37);
            this.btnhdb.TabIndex = 6;
            this.btnhdb.Text = "Hóa đơn bán";
            this.btnhdb.UseVisualStyleBackColor = false;
            this.btnhdb.Click += new System.EventHandler(this.btnhdb_Click);
            // 
            // btnsp
            // 
            this.btnsp.BackColor = System.Drawing.Color.MistyRose;
            this.btnsp.Location = new System.Drawing.Point(137, 24);
            this.btnsp.Name = "btnsp";
            this.btnsp.Size = new System.Drawing.Size(166, 37);
            this.btnsp.TabIndex = 3;
            this.btnsp.Text = "Sản phẩm";
            this.btnsp.UseVisualStyleBackColor = false;
            this.btnsp.Click += new System.EventHandler(this.btnsp_Click);
            // 
            // btnkh
            // 
            this.btnkh.BackColor = System.Drawing.Color.MistyRose;
            this.btnkh.Location = new System.Drawing.Point(457, 24);
            this.btnkh.Name = "btnkh";
            this.btnkh.Size = new System.Drawing.Size(171, 37);
            this.btnkh.TabIndex = 1;
            this.btnkh.Text = "Khách hàng";
            this.btnkh.UseVisualStyleBackColor = false;
            this.btnkh.Click += new System.EventHandler(this.btnkh_Click);
            // 
            // GUI_TrangChuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 598);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUI_TrangChuNV";
            this.Text = "GUI_TrangChuNV";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnhdb;
        private System.Windows.Forms.Button btnsp;
        private System.Windows.Forms.Button btnkh;
    }
}