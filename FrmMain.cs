using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace QuanLyCongTyDuLich
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Functions.connect();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Functions.closeConnect();
            Application.Exit();
        }


        private void báoCáoDSTourChưaKhởiHànhTheoPhạmViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBCTourChuaKhoiHanh frmBC1 = new FrmBCTourChuaKhoiHanh();
            frmBC1.ShowDialog();
        }

        private void báoCáo5TourCóSốNgườiĐKNhiềuNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBC3 fbc3 = new FrmBC3();
            fbc3.ShowDialog();
        }

        private void báoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBC2 fbc2 = new FrmBC2();
            fbc2.ShowDialog();
        }

        private void đăngKýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangKy fDK = new FrmDangKy();
            fDK.Show();
        }

        private void trườngĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTruongDaoTao frmtdt = new FrmTruongDaoTao();
            frmtdt.ShowDialog();
        }

        private void phạmViToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPhamVi frmpv = new FrmPhamVi();
            frmpv.ShowDialog();
        }

        private void HDV_Click(object sender, EventArgs e)
        {
            FrmHDV fHDV = new FrmHDV();
            fHDV.Show();
        }

        private void lịchTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLichTour fLT = new FrmLichTour();
            fLT.Show();
        }

        private void KhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang fKH = new FrmKhachHang();
            fKH.Show();
        }

        private void TrinhDo_Click(object sender, EventArgs e)
        {
            FrmTrinhDo fTD = new FrmTrinhDo();
            fTD.Show();
        }

        private void DanhMucTour_Click(object sender, EventArgs e)
        {
            FrmDMTour f = new FrmDMTour();
            f.Show();
        }

        
        private void NgoaiNgu_Click(object sender, EventArgs e)
        {
            FrmNgoaiNgu f = new FrmNgoaiNgu();
            f.Show();
        }

        private void CongTy_Click(object sender, EventArgs e)
        {
            FrmCongTy f = new FrmCongTy();
            f.Show();
        }

        private void Mua_Click(object sender, EventArgs e)
        {
            FrmMua f = new FrmMua();
            f.Show();
        }

        private void QuocTich_Click(object sender, EventArgs e)
        {
            FrmQuocTich f = new FrmQuocTich();
            f.Show();
        }

        private void XepLoai_Click(object sender, EventArgs e)
        {
            FrmXepLoai f = new FrmXepLoai();
            f.Show();
        }

        private void đăngKýTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangKyTour fDK = new FrmDangKyTour();
            fDK.Show();
        }

        private void tỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTinh fT = new FrmTinh();
            fT.Show();
        }

        private void hDVNgoạiNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHDV_NgoaiNgu fHDVNN = new FrmHDV_NgoaiNgu();
            fHDVNN.Show();
        }

        private void xácNhậnĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXacNhanDangKy fXNDK = new FrmXacNhanDangKy();
            fXNDK.Show();
        }
    }
}
