namespace ĐỒ_ÁN_1
{
    partial class GUI_HoaDonBan
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
            this.btncthdb = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntkhdb = new System.Windows.Forms.Button();
            this.rdotenhdb = new System.Windows.Forms.RadioButton();
            this.rdomahdb = new System.Windows.Forms.RadioButton();
            this.txttkhdb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txthinhthuctt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpbir = new System.Windows.Forms.DateTimePicker();
            this.txtdongiaban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmahdb = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvdshdb = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshdb)).BeginInit();
            this.SuspendLayout();
            // 
            // btncthdb
            // 
            this.btncthdb.BackColor = System.Drawing.Color.Teal;
            this.btncthdb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncthdb.Location = new System.Drawing.Point(547, 573);
            this.btncthdb.Name = "btncthdb";
            this.btncthdb.Size = new System.Drawing.Size(95, 48);
            this.btncthdb.TabIndex = 47;
            this.btncthdb.Text = "CTHDB";
            this.btncthdb.UseVisualStyleBackColor = false;
            this.btncthdb.Click += new System.EventHandler(this.btncthdb_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox3.Controls.Add(this.btntkhdb);
            this.groupBox3.Controls.Add(this.rdotenhdb);
            this.groupBox3.Controls.Add(this.rdomahdb);
            this.groupBox3.Controls.Add(this.txttkhdb);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(600, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 238);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm hóa đơn bán";
            // 
            // btntkhdb
            // 
            this.btntkhdb.BackColor = System.Drawing.Color.Teal;
            this.btntkhdb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntkhdb.Location = new System.Drawing.Point(96, 174);
            this.btntkhdb.Name = "btntkhdb";
            this.btntkhdb.Size = new System.Drawing.Size(240, 37);
            this.btntkhdb.TabIndex = 4;
            this.btntkhdb.Text = "Tìm Kiếm";
            this.btntkhdb.UseVisualStyleBackColor = false;
            this.btntkhdb.Click += new System.EventHandler(this.btntkhdb_Click);
            // 
            // rdotenhdb
            // 
            this.rdotenhdb.AutoSize = true;
            this.rdotenhdb.Location = new System.Drawing.Point(233, 116);
            this.rdotenhdb.Name = "rdotenhdb";
            this.rdotenhdb.Size = new System.Drawing.Size(115, 23);
            this.rdotenhdb.TabIndex = 3;
            this.rdotenhdb.TabStop = true;
            this.rdotenhdb.Text = "Mã nhân viên";
            this.rdotenhdb.UseVisualStyleBackColor = true;
            // 
            // rdomahdb
            // 
            this.rdomahdb.AutoSize = true;
            this.rdomahdb.Location = new System.Drawing.Point(30, 116);
            this.rdomahdb.Name = "rdomahdb";
            this.rdomahdb.Size = new System.Drawing.Size(134, 23);
            this.rdomahdb.TabIndex = 2;
            this.rdomahdb.TabStop = true;
            this.rdomahdb.Text = "Mã hóa đơn bán";
            this.rdomahdb.UseVisualStyleBackColor = true;
            // 
            // txttkhdb
            // 
            this.txttkhdb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttkhdb.Location = new System.Drawing.Point(153, 54);
            this.txttkhdb.Name = "txttkhdb";
            this.txttkhdb.Size = new System.Drawing.Size(215, 26);
            this.txttkhdb.TabIndex = 1;
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
            this.groupBox1.Controls.Add(this.txthinhthuctt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpbir);
            this.groupBox1.Controls.Add(this.txtdongiaban);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmahdb);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 238);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn bán";
            // 
            // txthinhthuctt
            // 
            this.txthinhthuctt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthinhthuctt.Location = new System.Drawing.Point(12, 197);
            this.txthinhthuctt.Name = "txthinhthuctt";
            this.txthinhthuctt.Size = new System.Drawing.Size(203, 26);
            this.txthinhthuctt.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hình thức thanh toán :";
            // 
            // dtpbir
            // 
            this.dtpbir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbir.Location = new System.Drawing.Point(311, 124);
            this.dtpbir.Name = "dtpbir";
            this.dtpbir.Size = new System.Drawing.Size(200, 26);
            this.dtpbir.TabIndex = 5;
            // 
            // txtdongiaban
            // 
            this.txtdongiaban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdongiaban.Location = new System.Drawing.Point(311, 198);
            this.txtdongiaban.Name = "txtdongiaban";
            this.txtdongiaban.Size = new System.Drawing.Size(203, 26);
            this.txtdongiaban.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(307, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Đơn giá bán : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã hóa đơn bán  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã nhân viên : ";
            // 
            // txtmahdb
            // 
            this.txtmahdb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmahdb.Location = new System.Drawing.Point(12, 54);
            this.txtmahdb.Name = "txtmahdb";
            this.txtmahdb.Size = new System.Drawing.Size(203, 26);
            this.txtmahdb.TabIndex = 19;
            // 
            // txtmanv
            // 
            this.txtmanv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmanv.Location = new System.Drawing.Point(12, 124);
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
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã khách hàng:";
            // 
            // txtmakh
            // 
            this.txtmakh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmakh.Location = new System.Drawing.Point(311, 54);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(203, 26);
            this.txtmakh.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(307, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày bán : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.dgvdshdb);
            this.groupBox2.Location = new System.Drawing.Point(12, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1014, 278);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn bán ";
            // 
            // dgvdshdb
            // 
            this.dgvdshdb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdshdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdshdb.Location = new System.Drawing.Point(6, 31);
            this.dgvdshdb.Name = "dgvdshdb";
            this.dgvdshdb.RowHeadersWidth = 62;
            this.dgvdshdb.RowTemplate.Height = 28;
            this.dgvdshdb.Size = new System.Drawing.Size(1002, 241);
            this.dgvdshdb.TabIndex = 20;
            this.dgvdshdb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdshdb_CellClick);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnthoat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnthoat.Location = new System.Drawing.Point(886, 571);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(123, 47);
            this.btnthoat.TabIndex = 43;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Teal;
            this.btnxoa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnxoa.Location = new System.Drawing.Point(366, 573);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(99, 48);
            this.btnxoa.TabIndex = 42;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Teal;
            this.btnsua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnsua.Location = new System.Drawing.Point(192, 573);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(93, 47);
            this.btnsua.TabIndex = 41;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Teal;
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthem.Location = new System.Drawing.Point(24, 573);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(93, 47);
            this.btnthem.TabIndex = 40;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // GUI_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 643);
            this.Controls.Add(this.btncthdb);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUI_HoaDonBan";
            this.Text = "GUI_HoaDonBan";
            this.Load += new System.EventHandler(this.GUI_HoaDonBan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshdb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncthdb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btntkhdb;
        private System.Windows.Forms.RadioButton rdotenhdb;
        private System.Windows.Forms.RadioButton rdomahdb;
        private System.Windows.Forms.TextBox txttkhdb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpbir;
        private System.Windows.Forms.TextBox txtdongiaban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmahdb;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvdshdb;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txthinhthuctt;
        private System.Windows.Forms.Label label6;
    }
}