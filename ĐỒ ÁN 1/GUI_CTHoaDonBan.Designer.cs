namespace ĐỒ_ÁN_1
{
    partial class GUI_CTHoaDonBan
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
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvdsCTHDB = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaCTHDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.btntongtien = new System.Windows.Forms.Button();
            this.txttongtienn = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsCTHDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnthoat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnthoat.Location = new System.Drawing.Point(842, 554);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(137, 45);
            this.btnthoat.TabIndex = 69;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Teal;
            this.btnxoa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnxoa.Location = new System.Drawing.Point(346, 498);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(96, 45);
            this.btnxoa.TabIndex = 68;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Teal;
            this.btnsua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnsua.Location = new System.Drawing.Point(182, 497);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(92, 46);
            this.btnsua.TabIndex = 67;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Teal;
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthem.Location = new System.Drawing.Point(18, 497);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(93, 45);
            this.btnthem.TabIndex = 66;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.dgvdsCTHDB);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 257);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết HDB :";
            // 
            // dgvdsCTHDB
            // 
            this.dgvdsCTHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdsCTHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsCTHDB.Location = new System.Drawing.Point(6, 27);
            this.dgvdsCTHDB.Name = "dgvdsCTHDB";
            this.dgvdsCTHDB.RowHeadersWidth = 62;
            this.dgvdsCTHDB.RowTemplate.Height = 28;
            this.dgvdsCTHDB.Size = new System.Drawing.Size(972, 227);
            this.dgvdsCTHDB.TabIndex = 20;
            this.dgvdsCTHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsCTHDB_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttongtien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaCTHDB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaHDB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 191);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết HDB :";
            // 
            // txtSL
            // 
            this.txtSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSL.Location = new System.Drawing.Point(742, 67);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(225, 28);
            this.txtSL.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(8, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã CT hóa đơn bán :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MistyRose;
            this.label8.Location = new System.Drawing.Point(738, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Thành tiền : ";
            // 
            // txttongtien
            // 
            this.txttongtien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttongtien.Location = new System.Drawing.Point(742, 148);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(225, 28);
            this.txttongtien.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hóa đơn bán : ";
            // 
            // txtMaCTHDB
            // 
            this.txtMaCTHDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaCTHDB.Location = new System.Drawing.Point(12, 67);
            this.txtMaCTHDB.Name = "txtMaCTHDB";
            this.txtMaCTHDB.Size = new System.Drawing.Size(225, 28);
            this.txtMaCTHDB.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(738, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng :";
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHDB.Location = new System.Drawing.Point(12, 148);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(225, 28);
            this.txtMaHDB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(374, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã sản phẩm :";
            // 
            // txtSP
            // 
            this.txtSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSP.Location = new System.Drawing.Point(378, 67);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(225, 28);
            this.txtSP.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(374, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn giá : ";
            // 
            // txtdongia
            // 
            this.txtdongia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdongia.Location = new System.Drawing.Point(378, 148);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(225, 28);
            this.txtdongia.TabIndex = 10;
            // 
            // btntongtien
            // 
            this.btntongtien.BackColor = System.Drawing.Color.MistyRose;
            this.btntongtien.ForeColor = System.Drawing.Color.Black;
            this.btntongtien.Location = new System.Drawing.Point(617, 500);
            this.btntongtien.Name = "btntongtien";
            this.btntongtien.Size = new System.Drawing.Size(107, 42);
            this.btntongtien.TabIndex = 70;
            this.btntongtien.Text = "Tổng tiền";
            this.btntongtien.UseVisualStyleBackColor = false;
            this.btntongtien.Click += new System.EventHandler(this.btntongtien_Click);
            // 
            // txttongtienn
            // 
            this.txttongtienn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttongtienn.Location = new System.Drawing.Point(754, 506);
            this.txttongtienn.Name = "txttongtienn";
            this.txttongtienn.Size = new System.Drawing.Size(225, 28);
            this.txttongtienn.TabIndex = 71;
            // 
            // GUI_CTHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 629);
            this.Controls.Add(this.txttongtienn);
            this.Controls.Add(this.btntongtien);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUI_CTHoaDonBan";
            this.Text = "GUI_CTHoaDonBan";
            this.Load += new System.EventHandler(this.GUI_CTHoaDonBan_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsCTHDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvdsCTHDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaCTHDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Button btntongtien;
        private System.Windows.Forms.TextBox txttongtienn;
    }
}