namespace QuanLyCongTyDuLich
{
    partial class FrmBC2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTPBC2TuNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTPBC2DenNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewBC2 = new System.Windows.Forms.DataGridView();
            this.MaCongTy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCongTy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoatBC2 = new System.Windows.Forms.Button();
            this.btnInBC2 = new System.Windows.Forms.Button();
            this.btnHienThiBC2 = new System.Windows.Forms.Button();
            this.btnBatDauBC2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày";
            // 
            // dateTPBC2TuNgay
            // 
            this.dateTPBC2TuNgay.CustomFormat = "yyyy-MM-dd";
            this.dateTPBC2TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPBC2TuNgay.Location = new System.Drawing.Point(376, 67);
            this.dateTPBC2TuNgay.Name = "dateTPBC2TuNgay";
            this.dateTPBC2TuNgay.Size = new System.Drawing.Size(175, 20);
            this.dateTPBC2TuNgay.TabIndex = 2;
            // 
            // dateTPBC2DenNgay
            // 
            this.dateTPBC2DenNgay.CustomFormat = "yyyy-MM-dd";
            this.dateTPBC2DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPBC2DenNgay.Location = new System.Drawing.Point(376, 102);
            this.dateTPBC2DenNgay.Name = "dateTPBC2DenNgay";
            this.dateTPBC2DenNgay.Size = new System.Drawing.Size(175, 20);
            this.dateTPBC2DenNgay.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(44, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(596, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "BÁO CÁO DOANH THU CÁC TOUR CỦA CÁC CÔNG TY";
            // 
            // dataGridViewBC2
            // 
            this.dataGridViewBC2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewBC2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBC2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCongTy,
            this.TenCongTy,
            this.DoanhThu});
            this.dataGridViewBC2.Location = new System.Drawing.Point(118, 152);
            this.dataGridViewBC2.Name = "dataGridViewBC2";
            this.dataGridViewBC2.RowHeadersWidth = 51;
            this.dataGridViewBC2.Size = new System.Drawing.Size(432, 134);
            this.dataGridViewBC2.TabIndex = 5;
            // 
            // MaCongTy
            // 
            this.MaCongTy.DataPropertyName = "MaCongTy";
            this.MaCongTy.HeaderText = "Mã Công Ty";
            this.MaCongTy.MinimumWidth = 6;
            this.MaCongTy.Name = "MaCongTy";
            this.MaCongTy.Width = 125;
            // 
            // TenCongTy
            // 
            this.TenCongTy.DataPropertyName = "TenCongTy";
            this.TenCongTy.HeaderText = "Tên Công Ty";
            this.TenCongTy.MinimumWidth = 6;
            this.TenCongTy.Name = "TenCongTy";
            this.TenCongTy.Width = 125;
            // 
            // DoanhThu
            // 
            this.DoanhThu.DataPropertyName = "DoanhThu";
            this.DoanhThu.HeaderText = "Doanh Thu";
            this.DoanhThu.MinimumWidth = 6;
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCongTyDuLich.Properties.Resources.paper;
            this.pictureBox1.Location = new System.Drawing.Point(118, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoatBC2
            // 
            this.btnThoatBC2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatBC2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoatBC2.Image = global::QuanLyCongTyDuLich.Properties.Resources.close__1_1;
            this.btnThoatBC2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatBC2.Location = new System.Drawing.Point(538, 318);
            this.btnThoatBC2.Name = "btnThoatBC2";
            this.btnThoatBC2.Size = new System.Drawing.Size(83, 31);
            this.btnThoatBC2.TabIndex = 9;
            this.btnThoatBC2.Text = "Thoát";
            this.btnThoatBC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatBC2.UseVisualStyleBackColor = true;
            this.btnThoatBC2.Click += new System.EventHandler(this.btnThoatBC2_Click);
            // 
            // btnInBC2
            // 
            this.btnInBC2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInBC2.Image = global::QuanLyCongTyDuLich.Properties.Resources.center_alignment;
            this.btnInBC2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInBC2.Location = new System.Drawing.Point(194, 318);
            this.btnInBC2.Name = "btnInBC2";
            this.btnInBC2.Size = new System.Drawing.Size(123, 32);
            this.btnInBC2.TabIndex = 8;
            this.btnInBC2.Text = "In Báo Cáo";
            this.btnInBC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInBC2.UseVisualStyleBackColor = true;
            this.btnInBC2.Click += new System.EventHandler(this.btnInBC2_Click);
            // 
            // btnHienThiBC2
            // 
            this.btnHienThiBC2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiBC2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHienThiBC2.Image = global::QuanLyCongTyDuLich.Properties.Resources.preview;
            this.btnHienThiBC2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThiBC2.Location = new System.Drawing.Point(376, 318);
            this.btnHienThiBC2.Name = "btnHienThiBC2";
            this.btnHienThiBC2.Size = new System.Drawing.Size(105, 32);
            this.btnHienThiBC2.TabIndex = 7;
            this.btnHienThiBC2.Text = "Hiển Thị";
            this.btnHienThiBC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThiBC2.UseVisualStyleBackColor = true;
            this.btnHienThiBC2.Click += new System.EventHandler(this.btnHienThiBC2_Click);
            // 
            // btnBatDauBC2
            // 
            this.btnBatDauBC2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDauBC2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBatDauBC2.Image = global::QuanLyCongTyDuLich.Properties.Resources.television_copy;
            this.btnBatDauBC2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatDauBC2.Location = new System.Drawing.Point(49, 318);
            this.btnBatDauBC2.Name = "btnBatDauBC2";
            this.btnBatDauBC2.Size = new System.Drawing.Size(100, 31);
            this.btnBatDauBC2.TabIndex = 6;
            this.btnBatDauBC2.Text = "Bắt đầu";
            this.btnBatDauBC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBatDauBC2.UseVisualStyleBackColor = true;
            this.btnBatDauBC2.Click += new System.EventHandler(this.btnBatDauBC2_Click);
            // 
            // FrmBC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(676, 395);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoatBC2);
            this.Controls.Add(this.btnInBC2);
            this.Controls.Add(this.btnHienThiBC2);
            this.Controls.Add(this.btnBatDauBC2);
            this.Controls.Add(this.dataGridViewBC2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTPBC2DenNgay);
            this.Controls.Add(this.dateTPBC2TuNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBC2";
            this.Text = "BÁO CÁO DOANH THU ";
            this.Load += new System.EventHandler(this.FrmBC2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTPBC2TuNgay;
        private System.Windows.Forms.DateTimePicker dateTPBC2DenNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewBC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCongTy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCongTy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.Button btnBatDauBC2;
        private System.Windows.Forms.Button btnHienThiBC2;
        private System.Windows.Forms.Button btnInBC2;
        private System.Windows.Forms.Button btnThoatBC2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}