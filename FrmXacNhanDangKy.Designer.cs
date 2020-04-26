namespace QuanLyCongTyDuLich
{
    partial class FrmXacNhanDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXacNhanDangKy));
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoiDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLichTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaLichTour = new System.Windows.Forms.ComboBox();
            this.cboMaTour = new System.Windows.Forms.ComboBox();
            this.txtSoNguoiDangKy = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaDangKy = new System.Windows.Forms.TextBox();
            this.txtSoLuongDangKy = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXacNhanDangKy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            // 
            // SoNguoiDangKy
            // 
            this.SoNguoiDangKy.DataPropertyName = "SoNguoiDangKy";
            this.SoNguoiDangKy.HeaderText = "Số Người Đăng Ký";
            this.SoNguoiDangKy.Name = "SoNguoiDangKy";
            // 
            // MaLichTour
            // 
            this.MaLichTour.DataPropertyName = "MaLichTour";
            this.MaLichTour.HeaderText = "Mã Lịch Tour";
            this.MaLichTour.Name = "MaLichTour";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichTour,
            this.SoNguoiDangKy,
            this.TongTien});
            this.dataGridView2.Location = new System.Drawing.Point(504, 198);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(385, 127);
            this.dataGridView2.TabIndex = 39;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // SoLuongDangKy
            // 
            this.SoLuongDangKy.DataPropertyName = "SoLuongDangKy";
            this.SoLuongDangKy.HeaderText = "Số Lượng Đăng Ký";
            this.SoLuongDangKy.Name = "SoLuongDangKy";
            // 
            // MaDangKy
            // 
            this.MaDangKy.DataPropertyName = "MaDangKy";
            this.MaDangKy.HeaderText = "Mã Đăng Ký";
            this.MaDangKy.Name = "MaDangKy";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDangKy,
            this.SoLuongDangKy,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(39, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 127);
            this.dataGridView1.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(343, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Xác Nhận Đăng Ký Tour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Mã Lịch Tour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(609, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tổng Tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Số Người Đăng Ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Mã Đăng Ký";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Số Lượng Đăng Ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã Tour";
            // 
            // cboMaLichTour
            // 
            this.cboMaLichTour.FormattingEnabled = true;
            this.cboMaLichTour.Location = new System.Drawing.Point(142, 116);
            this.cboMaLichTour.Name = "cboMaLichTour";
            this.cboMaLichTour.Size = new System.Drawing.Size(100, 21);
            this.cboMaLichTour.TabIndex = 28;
            // 
            // cboMaTour
            // 
            this.cboMaTour.FormattingEnabled = true;
            this.cboMaTour.Location = new System.Drawing.Point(142, 77);
            this.cboMaTour.Name = "cboMaTour";
            this.cboMaTour.Size = new System.Drawing.Size(100, 21);
            this.cboMaTour.TabIndex = 27;
            this.cboMaTour.SelectedIndexChanged += new System.EventHandler(this.cboMaTour_SelectedIndexChanged);
            // 
            // txtSoNguoiDangKy
            // 
            this.txtSoNguoiDangKy.Location = new System.Drawing.Point(764, 100);
            this.txtSoNguoiDangKy.Name = "txtSoNguoiDangKy";
            this.txtSoNguoiDangKy.Size = new System.Drawing.Size(100, 20);
            this.txtSoNguoiDangKy.TabIndex = 26;
            this.txtSoNguoiDangKy.TextChanged += new System.EventHandler(this.txtSoNguoiDangKy_TextChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(764, 136);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 25;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // txtMaDangKy
            // 
            this.txtMaDangKy.Location = new System.Drawing.Point(445, 138);
            this.txtMaDangKy.Name = "txtMaDangKy";
            this.txtMaDangKy.Size = new System.Drawing.Size(100, 20);
            this.txtMaDangKy.TabIndex = 24;
            // 
            // txtSoLuongDangKy
            // 
            this.txtSoLuongDangKy.Location = new System.Drawing.Point(445, 100);
            this.txtSoLuongDangKy.Name = "txtSoLuongDangKy";
            this.txtSoLuongDangKy.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongDangKy.TabIndex = 23;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(142, 156);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 22;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(652, 349);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 34);
            this.btnDong.TabIndex = 41;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXacNhanDangKy
            // 
            this.btnXacNhanDangKy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXacNhanDangKy.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanDangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXacNhanDangKy.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhanDangKy.Image")));
            this.btnXacNhanDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhanDangKy.Location = new System.Drawing.Point(142, 349);
            this.btnXacNhanDangKy.Name = "btnXacNhanDangKy";
            this.btnXacNhanDangKy.Size = new System.Drawing.Size(200, 35);
            this.btnXacNhanDangKy.TabIndex = 40;
            this.btnXacNhanDangKy.Text = "Xác Nhận Đăng Ký";
            this.btnXacNhanDangKy.UseVisualStyleBackColor = false;
            this.btnXacNhanDangKy.Click += new System.EventHandler(this.btnXacNhanDangKy_Click);
            // 
            // FrmXacNhanDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 396);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnXacNhanDangKy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaLichTour);
            this.Controls.Add(this.cboMaTour);
            this.Controls.Add(this.txtSoNguoiDangKy);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaDangKy);
            this.Controls.Add(this.txtSoLuongDangKy);
            this.Controls.Add(this.txtDonGia);
            this.Name = "FrmXacNhanDangKy";
            this.Text = "FrmXacNhanDangKy";
            this.Load += new System.EventHandler(this.FrmXacNhanDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoiDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichTour;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDangKy;
        private System.Windows.Forms.Button btnXacNhanDangKy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaLichTour;
        private System.Windows.Forms.ComboBox cboMaTour;
        private System.Windows.Forms.TextBox txtSoNguoiDangKy;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaDangKy;
        private System.Windows.Forms.TextBox txtSoLuongDangKy;
        private System.Windows.Forms.TextBox txtDonGia;
    }
}