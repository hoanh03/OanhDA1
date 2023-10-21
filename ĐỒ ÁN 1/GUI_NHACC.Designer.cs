namespace ĐỒ_ÁN_1
{
    partial class GUI_NHACC
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvdsncc = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntimkiemncc = new System.Windows.Forms.Button();
            this.rdotenncc = new System.Windows.Forms.RadioButton();
            this.rdomancc = new System.Windows.Forms.RadioButton();
            this.txttkncc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsncc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.dgvdsncc);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1042, 261);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà cung cấp ";
            // 
            // dgvdsncc
            // 
            this.dgvdsncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdsncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsncc.Location = new System.Drawing.Point(6, 32);
            this.dgvdsncc.Name = "dgvdsncc";
            this.dgvdsncc.RowHeadersWidth = 62;
            this.dgvdsncc.RowTemplate.Height = 28;
            this.dgvdsncc.Size = new System.Drawing.Size(1030, 229);
            this.dgvdsncc.TabIndex = 20;
            this.dgvdsncc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsncc_CellClick);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnthoat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnthoat.Location = new System.Drawing.Point(856, 500);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(123, 47);
            this.btnthoat.TabIndex = 28;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Teal;
            this.btnxoa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnxoa.Location = new System.Drawing.Point(433, 500);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(106, 48);
            this.btnxoa.TabIndex = 27;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Teal;
            this.btnsua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnsua.Location = new System.Drawing.Point(257, 501);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(89, 47);
            this.btnsua.TabIndex = 26;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Teal;
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthem.Location = new System.Drawing.Point(74, 501);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 47);
            this.btnthem.TabIndex = 25;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmancc);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttenncc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 191);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã nhà cung cấp  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa chỉ : ";
            // 
            // txtmancc
            // 
            this.txtmancc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmancc.Location = new System.Drawing.Point(12, 75);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(203, 26);
            this.txtmancc.TabIndex = 19;
            // 
            // txtdiachi
            // 
            this.txtdiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdiachi.Location = new System.Drawing.Point(12, 152);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(203, 26);
            this.txtdiachi.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(331, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Họ tên nhà cung cấp:";
            // 
            // txttenncc
            // 
            this.txttenncc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttenncc.Location = new System.Drawing.Point(335, 75);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(203, 26);
            this.txttenncc.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(331, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số điện thoại : ";
            // 
            // txtsdt
            // 
            this.txtsdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsdt.Location = new System.Drawing.Point(335, 152);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(203, 26);
            this.txtsdt.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btntimkiemncc);
            this.groupBox3.Controls.Add(this.rdotenncc);
            this.groupBox3.Controls.Add(this.rdomancc);
            this.groupBox3.Controls.Add(this.txttkncc);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(628, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 191);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btntimkiemncc
            // 
            this.btntimkiemncc.BackColor = System.Drawing.Color.Teal;
            this.btntimkiemncc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntimkiemncc.Location = new System.Drawing.Point(95, 140);
            this.btntimkiemncc.Name = "btntimkiemncc";
            this.btntimkiemncc.Size = new System.Drawing.Size(240, 37);
            this.btntimkiemncc.TabIndex = 4;
            this.btntimkiemncc.Text = "Tìm Kiếm";
            this.btntimkiemncc.UseVisualStyleBackColor = false;
            this.btntimkiemncc.Click += new System.EventHandler(this.btntimkiemncc_Click);
            // 
            // rdotenncc
            // 
            this.rdotenncc.AutoSize = true;
            this.rdotenncc.Location = new System.Drawing.Point(228, 90);
            this.rdotenncc.Name = "rdotenncc";
            this.rdotenncc.Size = new System.Drawing.Size(140, 23);
            this.rdotenncc.TabIndex = 3;
            this.rdotenncc.TabStop = true;
            this.rdotenncc.Text = "Tên nhà cung cấp";
            this.rdotenncc.UseVisualStyleBackColor = true;
            // 
            // rdomancc
            // 
            this.rdomancc.AutoSize = true;
            this.rdomancc.Location = new System.Drawing.Point(29, 90);
            this.rdomancc.Name = "rdomancc";
            this.rdomancc.Size = new System.Drawing.Size(138, 23);
            this.rdomancc.TabIndex = 2;
            this.rdomancc.TabStop = true;
            this.rdomancc.Text = "Mã nhà cung cấp";
            this.rdomancc.UseVisualStyleBackColor = true;
            // 
            // txttkncc
            // 
            this.txttkncc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttkncc.Location = new System.Drawing.Point(153, 35);
            this.txttkncc.Name = "txttkncc";
            this.txttkncc.Size = new System.Drawing.Size(215, 26);
            this.txttkncc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm : ";
            // 
            // GUI_NHACC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1066, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUI_NHACC";
            this.Text = "GUI_NHACC";
            this.Load += new System.EventHandler(this.GUI_NHACC_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsncc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvdsncc;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttkncc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntimkiemncc;
        private System.Windows.Forms.RadioButton rdotenncc;
        private System.Windows.Forms.RadioButton rdomancc;
    }
}