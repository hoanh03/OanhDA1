namespace ĐỒ_ÁN_1
{
    partial class GUI_SanPham
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
            this.gbtimkiem = new System.Windows.Forms.GroupBox();
            this.rdoTKTSP = new System.Windows.Forms.RadioButton();
            this.rdoTKMSP = new System.Windows.Forms.RadioButton();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtTKSPP = new System.Windows.Forms.TextBox();
            this.txtTKSP = new System.Windows.Forms.Label();
            this.gbdssp = new System.Windows.Forms.GroupBox();
            this.dgvdssp = new System.Windows.Forms.DataGridView();
            this.gbttsp = new System.Windows.Forms.GroupBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtchatlieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txtmau = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.gbtimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdssp)).BeginInit();
            this.gbttsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbtimkiem
            // 
            this.gbtimkiem.BackColor = System.Drawing.Color.MistyRose;
            this.gbtimkiem.Controls.Add(this.rdoTKTSP);
            this.gbtimkiem.Controls.Add(this.rdoTKMSP);
            this.gbtimkiem.Controls.Add(this.btntimkiem);
            this.gbtimkiem.Controls.Add(this.txtTKSPP);
            this.gbtimkiem.Controls.Add(this.txtTKSP);
            this.gbtimkiem.Location = new System.Drawing.Point(644, 23);
            this.gbtimkiem.Name = "gbtimkiem";
            this.gbtimkiem.Size = new System.Drawing.Size(401, 280);
            this.gbtimkiem.TabIndex = 33;
            this.gbtimkiem.TabStop = false;
            this.gbtimkiem.Text = "Tìm kiếm sản phẩm";
            this.gbtimkiem.Enter += new System.EventHandler(this.c);
            // 
            // rdoTKTSP
            // 
            this.rdoTKTSP.AutoSize = true;
            this.rdoTKTSP.Location = new System.Drawing.Point(209, 129);
            this.rdoTKTSP.Name = "rdoTKTSP";
            this.rdoTKTSP.Size = new System.Drawing.Size(118, 23);
            this.rdoTKTSP.TabIndex = 28;
            this.rdoTKTSP.TabStop = true;
            this.rdoTKTSP.Text = "Tên sản phẩm";
            this.rdoTKTSP.UseVisualStyleBackColor = true;
            // 
            // rdoTKMSP
            // 
            this.rdoTKMSP.AutoSize = true;
            this.rdoTKMSP.Location = new System.Drawing.Point(37, 129);
            this.rdoTKMSP.Name = "rdoTKMSP";
            this.rdoTKMSP.Size = new System.Drawing.Size(116, 23);
            this.rdoTKMSP.TabIndex = 27;
            this.rdoTKMSP.TabStop = true;
            this.rdoTKMSP.Text = "Mã sản phẩm";
            this.rdoTKMSP.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.Teal;
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntimkiem.Location = new System.Drawing.Point(111, 203);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(187, 50);
            this.btntimkiem.TabIndex = 26;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtTKSPP
            // 
            this.txtTKSPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTKSPP.Location = new System.Drawing.Point(162, 36);
            this.txtTKSPP.Name = "txtTKSPP";
            this.txtTKSPP.Size = new System.Drawing.Size(191, 26);
            this.txtTKSPP.TabIndex = 12;
            // 
            // txtTKSP
            // 
            this.txtTKSP.AutoSize = true;
            this.txtTKSP.BackColor = System.Drawing.Color.MistyRose;
            this.txtTKSP.ForeColor = System.Drawing.Color.Black;
            this.txtTKSP.Location = new System.Drawing.Point(16, 42);
            this.txtTKSP.Name = "txtTKSP";
            this.txtTKSP.Size = new System.Drawing.Size(72, 19);
            this.txtTKSP.TabIndex = 5;
            this.txtTKSP.Text = "Tìm kiếm :";
            // 
            // gbdssp
            // 
            this.gbdssp.BackColor = System.Drawing.Color.Snow;
            this.gbdssp.Location = new System.Drawing.Point(12, 316);
            this.gbdssp.Name = "gbdssp";
            this.gbdssp.Size = new System.Drawing.Size(1033, 234);
            this.gbdssp.TabIndex = 32;
            this.gbdssp.TabStop = false;
            this.gbdssp.Text = "Danh sách sản phẩm ";
            // 
            // dgvdssp
            // 
            this.dgvdssp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdssp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdssp.Location = new System.Drawing.Point(18, 342);
            this.dgvdssp.Name = "dgvdssp";
            this.dgvdssp.RowHeadersWidth = 62;
            this.dgvdssp.RowTemplate.Height = 28;
            this.dgvdssp.Size = new System.Drawing.Size(1021, 208);
            this.dgvdssp.TabIndex = 13;
            this.dgvdssp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdssp_CellClick);
            // 
            // gbttsp
            // 
            this.gbttsp.BackColor = System.Drawing.Color.MistyRose;
            this.gbttsp.Controls.Add(this.txtsoluong);
            this.gbttsp.Controls.Add(this.label1);
            this.gbttsp.Controls.Add(this.txtchatlieu);
            this.gbttsp.Controls.Add(this.label8);
            this.gbttsp.Controls.Add(this.txtsize);
            this.gbttsp.Controls.Add(this.label7);
            this.gbttsp.Controls.Add(this.label5);
            this.gbttsp.Controls.Add(this.label3);
            this.gbttsp.Controls.Add(this.txtmasp);
            this.gbttsp.Controls.Add(this.txtmau);
            this.gbttsp.Controls.Add(this.txttensp);
            this.gbttsp.Controls.Add(this.label4);
            this.gbttsp.Controls.Add(this.label2);
            this.gbttsp.Controls.Add(this.txtdongia);
            this.gbttsp.Location = new System.Drawing.Point(12, 23);
            this.gbttsp.Name = "gbttsp";
            this.gbttsp.Size = new System.Drawing.Size(592, 280);
            this.gbttsp.TabIndex = 31;
            this.gbttsp.TabStop = false;
            this.gbttsp.Text = "Thông tin sản phẩm";
            // 
            // txtsoluong
            // 
            this.txtsoluong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsoluong.Location = new System.Drawing.Point(329, 241);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(178, 26);
            this.txtsoluong.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Số lượng:";
            // 
            // txtchatlieu
            // 
            this.txtchatlieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtchatlieu.Location = new System.Drawing.Point(329, 179);
            this.txtchatlieu.Name = "txtchatlieu";
            this.txtchatlieu.Size = new System.Drawing.Size(178, 26);
            this.txtchatlieu.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MistyRose;
            this.label8.Location = new System.Drawing.Point(329, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Chất liệu :";
            // 
            // txtsize
            // 
            this.txtsize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsize.Location = new System.Drawing.Point(15, 214);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(178, 26);
            this.txtsize.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(15, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Size : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(329, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Màu sắc :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sản phẩm :";
            // 
            // txtmasp
            // 
            this.txtmasp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmasp.Location = new System.Drawing.Point(17, 73);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(176, 26);
            this.txtmasp.TabIndex = 6;
            // 
            // txtmau
            // 
            this.txtmau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmau.Location = new System.Drawing.Point(329, 106);
            this.txtmau.Name = "txtmau";
            this.txtmau.Size = new System.Drawing.Size(178, 26);
            this.txtmau.TabIndex = 19;
            // 
            // txttensp
            // 
            this.txttensp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttensp.Location = new System.Drawing.Point(329, 38);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(178, 26);
            this.txttensp.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(325, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên sản phẩm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá :";
            // 
            // txtdongia
            // 
            this.txtdongia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdongia.Location = new System.Drawing.Point(17, 146);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(176, 26);
            this.txtdongia.TabIndex = 5;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthoat.Location = new System.Drawing.Point(842, 567);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(125, 53);
            this.btnthoat.TabIndex = 30;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Teal;
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(406, 567);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(98, 42);
            this.btnxoa.TabIndex = 29;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Teal;
            this.btnsua.ForeColor = System.Drawing.Color.White;
            this.btnsua.Location = new System.Drawing.Point(229, 567);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(97, 42);
            this.btnsua.TabIndex = 28;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Teal;
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(52, 567);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 42);
            this.btnthem.TabIndex = 27;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // GUI_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1057, 643);
            this.Controls.Add(this.dgvdssp);
            this.Controls.Add(this.gbtimkiem);
            this.Controls.Add(this.gbdssp);
            this.Controls.Add(this.gbttsp);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUI_SanPham";
            this.Text = "GUI_SanPham";
            this.Load += new System.EventHandler(this.GUI_SanPham_Load);
            this.gbtimkiem.ResumeLayout(false);
            this.gbtimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdssp)).EndInit();
            this.gbttsp.ResumeLayout(false);
            this.gbttsp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbtimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtTKSPP;
        private System.Windows.Forms.Label txtTKSP;
        private System.Windows.Forms.GroupBox gbdssp;
        private System.Windows.Forms.DataGridView dgvdssp;
        private System.Windows.Forms.GroupBox gbttsp;
        private System.Windows.Forms.TextBox txtchatlieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txtmau;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoTKTSP;
        private System.Windows.Forms.RadioButton rdoTKMSP;
    }
}

