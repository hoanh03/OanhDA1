namespace ĐỒ_ÁN_1
{
    partial class GUI_HoaDonNhap
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntkhdn = new System.Windows.Forms.Button();
            this.rdoMaNV = new System.Windows.Forms.RadioButton();
            this.rdomahdn = new System.Windows.Forms.RadioButton();
            this.txttkhdn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpbir = new System.Windows.Forms.DateTimePicker();
            this.txtdongianhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmahdn = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvdshdn = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btncthdn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshdn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox3.Controls.Add(this.btntkhdn);
            this.groupBox3.Controls.Add(this.rdoMaNV);
            this.groupBox3.Controls.Add(this.rdomahdn);
            this.groupBox3.Controls.Add(this.txttkhdn);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(583, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 238);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm hóa đơn nhập";
            // 
            // btntkhdn
            // 
            this.btntkhdn.BackColor = System.Drawing.Color.Teal;
            this.btntkhdn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntkhdn.Location = new System.Drawing.Point(96, 174);
            this.btntkhdn.Name = "btntkhdn";
            this.btntkhdn.Size = new System.Drawing.Size(240, 37);
            this.btntkhdn.TabIndex = 4;
            this.btntkhdn.Text = "Tìm Kiếm";
            this.btntkhdn.UseVisualStyleBackColor = false;
            this.btntkhdn.Click += new System.EventHandler(this.btntkhdn_Click);
            // 
            // rdoMaNV
            // 
            this.rdoMaNV.AutoSize = true;
            this.rdoMaNV.Location = new System.Drawing.Point(233, 116);
            this.rdoMaNV.Name = "rdoMaNV";
            this.rdoMaNV.Size = new System.Drawing.Size(115, 23);
            this.rdoMaNV.TabIndex = 3;
            this.rdoMaNV.TabStop = true;
            this.rdoMaNV.Text = "Mã nhân viên";
            this.rdoMaNV.UseVisualStyleBackColor = true;
            // 
            // rdomahdn
            // 
            this.rdomahdn.AutoSize = true;
            this.rdomahdn.Location = new System.Drawing.Point(30, 116);
            this.rdomahdn.Name = "rdomahdn";
            this.rdomahdn.Size = new System.Drawing.Size(141, 23);
            this.rdomahdn.TabIndex = 2;
            this.rdomahdn.TabStop = true;
            this.rdomahdn.Text = "Mã hóa đơn nhập";
            this.rdomahdn.UseVisualStyleBackColor = true;
            // 
            // txttkhdn
            // 
            this.txttkhdn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttkhdn.Location = new System.Drawing.Point(153, 54);
            this.txttkhdn.Name = "txttkhdn";
            this.txttkhdn.Size = new System.Drawing.Size(215, 26);
            this.txttkhdn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.dtpbir);
            this.groupBox1.Controls.Add(this.txtdongianhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmahdn);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtmancc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 238);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn nhập ";
            // 
            // dtpbir
            // 
            this.dtpbir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbir.Location = new System.Drawing.Point(311, 124);
            this.dtpbir.Name = "dtpbir";
            this.dtpbir.Size = new System.Drawing.Size(200, 26);
            this.dtpbir.TabIndex = 5;
            // 
            // txtdongianhap
            // 
            this.txtdongianhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdongianhap.Location = new System.Drawing.Point(311, 198);
            this.txtdongianhap.Name = "txtdongianhap";
            this.txtdongianhap.Size = new System.Drawing.Size(203, 26);
            this.txtdongianhap.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(307, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Đơn giá nhập : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(8, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã hóa đơn nhập  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(8, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã nhân viên : ";
            // 
            // txtmahdn
            // 
            this.txtmahdn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmahdn.Location = new System.Drawing.Point(12, 90);
            this.txtmahdn.Name = "txtmahdn";
            this.txtmahdn.Size = new System.Drawing.Size(203, 26);
            this.txtmahdn.TabIndex = 19;
            // 
            // txtmanv
            // 
            this.txtmanv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmanv.Location = new System.Drawing.Point(12, 174);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(203, 26);
            this.txtmanv.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(307, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã nhà cung cấp:";
            // 
            // txtmancc
            // 
            this.txtmancc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmancc.Location = new System.Drawing.Point(311, 54);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(203, 26);
            this.txtmancc.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(307, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày nhập : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.dgvdshdn);
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(997, 278);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn nhập";
            // 
            // dgvdshdn
            // 
            this.dgvdshdn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdshdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdshdn.Location = new System.Drawing.Point(6, 31);
            this.dgvdshdn.Name = "dgvdshdn";
            this.dgvdshdn.RowHeadersWidth = 62;
            this.dgvdshdn.RowTemplate.Height = 28;
            this.dgvdshdn.Size = new System.Drawing.Size(985, 241);
            this.dgvdshdn.TabIndex = 20;
            this.dgvdshdn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdshdn_CellClick);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnthoat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnthoat.Location = new System.Drawing.Point(828, 559);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(123, 47);
            this.btnthoat.TabIndex = 35;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Teal;
            this.btnxoa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnxoa.Location = new System.Drawing.Point(346, 560);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(99, 48);
            this.btnxoa.TabIndex = 34;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Teal;
            this.btnsua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnsua.Location = new System.Drawing.Point(198, 560);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(93, 47);
            this.btnsua.TabIndex = 33;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Teal;
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthem.Location = new System.Drawing.Point(55, 560);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(93, 47);
            this.btnthem.TabIndex = 32;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btncthdn
            // 
            this.btncthdn.BackColor = System.Drawing.Color.Teal;
            this.btncthdn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncthdn.Location = new System.Drawing.Point(503, 561);
            this.btncthdn.Name = "btncthdn";
            this.btncthdn.Size = new System.Drawing.Size(95, 46);
            this.btncthdn.TabIndex = 39;
            this.btncthdn.Text = "CTHDN";
            this.btncthdn.UseVisualStyleBackColor = false;
            this.btncthdn.Click += new System.EventHandler(this.btncthdn_Click);
            // 
            // GUI_HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1021, 626);
            this.Controls.Add(this.btncthdn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUI_HoaDonNhap";
            this.Text = "GUI_HoaDonNhap";
            this.Load += new System.EventHandler(this.GUI_HoaDonNhap_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshdn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btntkhdn;
        private System.Windows.Forms.RadioButton rdoMaNV;
        private System.Windows.Forms.RadioButton rdomahdn;
        private System.Windows.Forms.TextBox txttkhdn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdongianhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmahdn;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvdshdn;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DateTimePicker dtpbir;
        private System.Windows.Forms.Button btncthdn;
    }
}