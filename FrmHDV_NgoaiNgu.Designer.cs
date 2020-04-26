namespace QuanLyCongTyDuLich
{
    partial class FrmHDV_NgoaiNgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHDV_NgoaiNgu));
            this.dataGridView_HDVNgoaiNgu = new System.Windows.Forms.DataGridView();
            this.MaHDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNgoaiNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaXepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMaXepLoai = new System.Windows.Forms.ComboBox();
            this.txtMaHDV = new System.Windows.Forms.TextBox();
            this.txtMaNgoaiNgu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDVNgoaiNgu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_HDVNgoaiNgu
            // 
            this.dataGridView_HDVNgoaiNgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HDVNgoaiNgu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDV,
            this.MaNgoaiNgu,
            this.MaXepLoai});
            this.dataGridView_HDVNgoaiNgu.Location = new System.Drawing.Point(499, 69);
            this.dataGridView_HDVNgoaiNgu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_HDVNgoaiNgu.Name = "dataGridView_HDVNgoaiNgu";
            this.dataGridView_HDVNgoaiNgu.Size = new System.Drawing.Size(345, 159);
            this.dataGridView_HDVNgoaiNgu.TabIndex = 19;
            this.dataGridView_HDVNgoaiNgu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HDVNgoaiNgu_CellClick);
            // 
            // MaHDV
            // 
            this.MaHDV.DataPropertyName = "MaHDV";
            this.MaHDV.HeaderText = "Mã HDV";
            this.MaHDV.Name = "MaHDV";
            // 
            // MaNgoaiNgu
            // 
            this.MaNgoaiNgu.DataPropertyName = "MaNgoaiNgu";
            this.MaNgoaiNgu.HeaderText = "Mã Ngoại Ngữ";
            this.MaNgoaiNgu.Name = "MaNgoaiNgu";
            // 
            // MaXepLoai
            // 
            this.MaXepLoai.DataPropertyName = "MaXepLoai";
            this.MaXepLoai.HeaderText = "Mã Xếp Loại";
            this.MaXepLoai.Name = "MaXepLoai";
            // 
            // cboMaXepLoai
            // 
            this.cboMaXepLoai.FormattingEnabled = true;
            this.cboMaXepLoai.Location = new System.Drawing.Point(190, 201);
            this.cboMaXepLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaXepLoai.Name = "cboMaXepLoai";
            this.cboMaXepLoai.Size = new System.Drawing.Size(180, 27);
            this.cboMaXepLoai.TabIndex = 18;
            // 
            // txtMaHDV
            // 
            this.txtMaHDV.Location = new System.Drawing.Point(190, 66);
            this.txtMaHDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHDV.Name = "txtMaHDV";
            this.txtMaHDV.Size = new System.Drawing.Size(180, 26);
            this.txtMaHDV.TabIndex = 17;
            // 
            // txtMaNgoaiNgu
            // 
            this.txtMaNgoaiNgu.Location = new System.Drawing.Point(190, 137);
            this.txtMaNgoaiNgu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNgoaiNgu.Name = "txtMaNgoaiNgu";
            this.txtMaNgoaiNgu.Size = new System.Drawing.Size(180, 26);
            this.txtMaNgoaiNgu.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã Xếp Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Ngoại Ngữ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã HDV";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(767, 271);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 34);
            this.btnDong.TabIndex = 25;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuy.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(623, 271);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 34);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(479, 271);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 34);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(168, 271);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 34);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(325, 271);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 34);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(24, 271);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 34);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(358, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "HDV_NgoaiNgu";
            // 
            // FrmHDV_NgoaiNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 332);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_HDVNgoaiNgu);
            this.Controls.Add(this.cboMaXepLoai);
            this.Controls.Add(this.txtMaHDV);
            this.Controls.Add(this.txtMaNgoaiNgu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmHDV_NgoaiNgu";
            this.Text = "FrmHDV_NgoaiNgu";
            this.Load += new System.EventHandler(this.FrmHDV_NgoaiNgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDVNgoaiNgu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_HDVNgoaiNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNgoaiNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXepLoai;
        private System.Windows.Forms.ComboBox cboMaXepLoai;
        private System.Windows.Forms.TextBox txtMaHDV;
        private System.Windows.Forms.TextBox txtMaNgoaiNgu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
    }
}