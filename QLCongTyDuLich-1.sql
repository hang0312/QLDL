create database QLCongTyDuLich

create table DangNhap
(
	TenDangNhap varchar(50) not null,
	MatKhau varchar(50) not null
)

create table QuocTich
(
	MaQuocTich nvarchar(10) primary key,
	TenQuocTich nvarchar(50) not null
)

create table KhachHang
(
	MaKhach nchar (10) Primary Key,
	TenKhach nvarchar (50) not null,
	DiaChi nvarchar(50) not null,
	DienThoai nchar(10) not null,
	QuocTich nvarchar(10) foreign key references QuocTich(MaQuocTich),
	GhiChu nvarchar(50)	
)

create table XepLoai
(
	MaXepLoai nvarchar(10) primary key,
	TenXepLoai nvarchar(50) not null, 
)

create table TruongDaoTao
(
	MaTruongDT nvarchar(10) primary key,
	TenTruongDT nvarchar(50) not null,
	DiaChi nvarchar(50) not null,
	DienThoai char(10) not null,
)

create table TrinhDo
(
	MaTrinhDo varchar(10) primary key,
	TenTrinhDo nvarchar(50) not null
)

create table Tinh
(
	MaTinh char(10) primary key,
	TenTinh nvarchar(50) not null
)

create table PhamVi
(
	MaPhamVi varchar(10) primary key,
	TenPhamVi nvarchar(50) not null
)

create table NgoaiNgu
(
	MaNgoaiNgu nchar(10) primary key,
	TenNgoaiNgu nvarchar(50) not null
)

create table Mua
(
	MaMua nchar(10) primary key,
	TenMua nvarchar(50) not null
)

 create table CongTy
 (
	MaCongTy nchar(10) primary key,
	TenCongTy nvarchar(50) not null,
	DiaChi nvarchar(50) not null,
	DienThoai char(10) not null,
	Email nchar(50) not null,
	MaPhamVi varchar(10) foreign key references PhamVi(MaPhamVi)
)

create table HuongDanVien
(
	MaHDV nchar(10) primary key,
	TenHDV nvarchar(50) not null,
	MaCongTy nchar(10) foreign key references CongTy(MaCongTy),
	NgaySinh datetime not null,
	GioiTinh nvarchar(10) not null,
	MaTinh char(10) foreign key references Tinh(MaTinh),
	MaTrinhDo varchar(10) foreign key references TrinhDo(MaTrinhDo),
	MaTruongDT nvarchar(10) foreign key references TruongDaoTao(MaTruongDT),
	NgayVaoCongTy datetime not null
)

create table HDV_NgoaiNgu
(
	MaHDV nchar(10) foreign key references HuongDanVien(MaHDV),
	MaNgoaiNgu nchar(10) foreign key references NgoaiNgu(MaNgoaiNgu),
	MaXepLoai nvarchar(10) foreign key references XepLoai(MaXepLoai)
	primary key(MaHDV, MaNgoaiNgu)
)

create table DanhMucTour
(
	MaTour nchar(10) not null,
	MaCongTy nchar(10) not null,
	MaPhamVi varchar(10) foreign key references PhamVi(MaPhamVi),
	TenTour nvarchar(50) not null,
	MaMua nchar(10) foreign key references Mua(MaMua),
	SoNgay int not null,
	DonGia money not null,
	GhiChu nvarchar(100),
	primary key (MaTour, MaCongTy)
)

create table LichTour
(
	MaLichTour	nchar(10) primary key,
	MaCongTy nchar(10) foreign key references CongTy(MaCongTy),
	MaTour nchar(10) ,
	MaHDV nchar(10) foreign key references HuongDanVien(MaHDV),
	NgayKhoiHanh datetime not null,
	SoNguoiDangKy int default 0,
	TongTien money default 0,
	DaKhoiHanh nvarchar(50) not null,
	CONSTRAINT [FK_MaTour] FOREIGN KEY([MaTour], [MaCongTy]) REFERENCES DanhMucTour ([MaTour], [MaCongTy])
)

create table DangKiTour
(
	MaDangKy nchar(10) primary key,
	MaKhach nchar(10) foreign key references KhachHang(MaKhach),
	MaLichTour nchar(10) foreign key references LichTour(MaLichTour),
	NgayDangKy datetime default getdate() ,
	SoLuongDangKy int not null,
	ThanhTien money not null
)

insert into DangNhap values ('Nhom8', 'Nhom8XinhGai')

insert into TruongDaoTao values ('TDT01', N'Trường ĐT số 1', N'Hà Nội', '0346552764')
insert into TruongDaoTao values ('TDT02', N'Trường ĐT số 2', N'Nha Trang', '0832465119')
insert into TruongDaoTao values ('TDT03', N'Trường ĐT số 3', N'Hà Nội', '0396645126')
insert into TruongDaoTao values ('TDT04', N'Trường ĐT số 4', N'Sài Gòn', '0384664596')
insert into TruongDaoTao values ('TDT05', N'Trường ĐT số 5', N'Hà Nội', '0942557681')

insert into XepLoai values ('XL1', N'Tốt')
insert into XepLoai values ('XL2', N'Khá Tốt')
insert into XepLoai values ('XL3', N'Bình Thường')
insert into XepLoai values ('XL4', N'Kém')

insert into TrinhDo values ('TD1', N'Xuất Sắc')
insert into TrinhDo values ('TD2', N'Khá')
insert into TrinhDo values ('TD3', N'Trung bình')
insert into TrinhDo values ('TD4', N'Kém')

insert into Tinh values ('01', N'Hà Nội')
insert into Tinh values ('02', N'TP HCM')
insert into Tinh values ('03', N'Hải Phòng')
insert into Tinh values ('04', N'Đà Nẵng')
insert into Tinh values ('17', N'Quảng Ninh')
insert into Tinh values ('41', N'Khánh Hòa')

insert into QuocTich values ('SPG', 'Singapore')
insert into QuocTich values ('TL', N'Thái Lan')
insert into QuocTich values ('TQ', N'Trung Quốc')
insert into QuocTich values ('VN', N'Việt Nam')
insert into QuocTich values ('HQ', N'Hàn Quốc')

insert into PhamVi values ('PV1', N'Miền Bắc')
insert into PhamVi values ('PV2', N'Miền Trung')
insert into PhamVi values ('PV3', N'Miền Nam')

insert into NgoaiNgu values ('CHINA', N'Trung Quốc')
insert into NgoaiNgu values ('ENG', N'Tiếng Anh')
insert into NgoaiNgu values ('FRANCE', N'Tiếng Pháp')
insert into NgoaiNgu values ('VIETNAM', N'Việt Nam')
insert into NgoaiNgu values ('KOREA', N'Hàn Quốc')

insert into Mua values ('M1', N'Mùa Xuân')
insert into Mua values ('M2', N'Mùa Hè')
insert into Mua values ('M3', N'Mùa Thu')
insert into Mua values ('M4', N'Mùa Đông')

insert into CongTy values ('CT01', N'CT Du Lịch Phương Đông ', N'Hà Nội', '0864513544', 'ctdlphuongdong@gmail.com', 'PV1')
insert into CongTy values ('CT02', N'CT Du Lịch Hải Dương ', N'Nha Trang', '0369452145', 'ctdlhaiduong@gmail.com', 'PV2')
insert into CongTy values ('CT03', N'CT Du Lịch Sài Gòn ', N'Sài Gòn', '0346859169', 'ctdlsaigon@gmail.com', 'PV3')
insert into CongTy values ('CT04', N'CT Du Lịch Ba Miền ', N'Hà Nội', '0942116335', 'ctdlbamien@gmail.com', 'PV1')
insert into CongTy values ('CT05', N'CT Du Lịch Hà Nội', N'Hà Nội', '0126495354', 'ctdlhanoi@gmail.com' ,'PV1')

insert into HuongDanVien values ('HDV01', N'Bùi Thị Hằng', 'CT01', '2000-12-23',N'Nữ', '01', 'TD1', 'TDT01', '2020-04-10')
insert into HuongDanVien values ('HDV02', N'Nguyễn Thị Minh', 'CT02', '2000-02-15',N'Nữ', '02', 'TD2', 'TDT03', '2020-04-09')
insert into HuongDanVien values ('HDV03', N'Lê Thị Thanh Tâm', 'CT03', '1996-05-19',N'Nữ', '01', 'TD3', 'TDT04', '2020-01-19')
insert into HuongDanVien values ('HDV04', N'Chu Thúy Vân', 'CT04', '2004-11-19',N'Nữ', '01', 'TD1', 'TDT02', '2019-12-20')
insert into HuongDanVien values ('HDV05', N'Đỗ Hải Nam', 'CT05', '2005-06-19', N'Nam', '03', 'TD2', 'TDT01', '2018-03-02')
insert into HuongDanVien values ('HDV06', N'Cao Văn Tập', 'CT05', '1995-06-20', N'Nam', '01', 'TD2', 'TDT01', '2020-01-22')

insert into HDV_NgoaiNgu values ('HDV01', 'ENG', 'XL2')
insert into HDV_NgoaiNgu values ('HDV02', 'VIETNAM', 'XL1')
insert into HDV_NgoaiNgu values ('HDV03', 'KOREA', 'XL3')
insert into HDV_NgoaiNgu values ('HDV04', 'FRANCE', 'XL2')

insert into DanhMucTour values ('T01', 'CT01', 'PV1', N'Hà Nội - Quảng Ninh', 'M2', 15, 700, N'Sẽ diễn ra')
insert into DanhMucTour values ('T02', 'CT02', 'PV2', N'Nha Trang - Đà Nẵng', 'M2', 10, 1000, N'Sắp diễn ra')
insert into DanhMucTour values ('T03', 'CT03', 'PV1', N'Hà Nội - SaPa', 'M1', 5, 4000, N'Đang diễn ra')
insert into DanhMucTour values ('T04', 'CT04', 'PV3', N'Vũng Tàu - Côn Đảo', 'M4', 15, 5000, N'Sắp diễn ra')
insert into DanhMucTour values ('T05', 'CT01', 'PV3', N'Cát Bà - Côn Đảo', 'M4', 15, 5000, N'Sắp diễn ra')
insert into DanhMucTour values ('T06', 'CT02', 'PV2', N'Hà Nội - TP.Hồ Chí Minh', 'M1', 20, 10000, N'Sắp diễn ra')

insert into LichTour values ('LT01', 'CT01', 'T01', 'HDV01', '2020-05-25', 16, 112000, N'Chưa')
insert into LichTour values ('LT02', 'CT02', 'T02', 'HDV02', '2020-04-19', 5, 5000, N'Sắp')
insert into LichTour values ('LT03', 'CT03', 'T03', 'HDV03', '2020-04-10', 3, 12000 ,N'Đang')
insert into LichTour values ('LT04', 'CT04', 'T04', 'HDV04', '2020-04-30', 10, 50000, N'Chưa')
insert into LichTour values ('LT05', 'CT01', 'T01', 'HDV01', '2020-04-30', 0, 0, N'Chưa')
insert into LichTour values ('LT06', 'CT01', 'T01', 'HDV02', '2020-04-30', 0, 0, N'Chưa')
insert into LichTour values ('LT07', 'CT01', 'T05', 'HDV05', '2020-04-30', 0, 0, N'Chưa')

insert into KhachHang values ('KH001', N'Nguyễn Thu Thúy', N'Hà Nội', '0384695336', 'VN', N'Chưa thanh toán')
insert into KhachHang values ('KH002', N'Cao Thị Mai', N'Hà Nội', '0964553769', 'VN', N'Chưa thanh toán')
insert into KhachHang values ('KH003', N'Trần Thị Ngân', N'Hà Nội', '0864559312', 'VN', N'Đã thanh toán')
insert into KhachHang values ('KH004', N'Phạm Thanh Nhàn', N'Sài Gòn', '0344965824', 'VN', N'Đã thanh toán')
insert into KhachHang values ('KH005', N'Nguyễn Như Quỳnh', N'Nha Trang', '0966789589', 'VN', N'Chưa thanh toán')
insert into KhachHang values ('KH006', N'Đặng Văn Lâm', N'Sài Gòn', '0864552346', 'VN', N'Đã thanh toán')
insert into KhachHang values ('KH007', N'Cao Nam Trung', N'Hà Nội', '0864235998', 'VN', N'Đã thanh toán')
insert into KhachHang values ('KH008', N'Phạm Trung Hiếu', N'Nha Trang', '0964231533', 'VN', N'Đã thanh toán')
insert into KhachHang values ('KH009', N'Bùi Xuân Nam', N'Hà Nội', '0968456955', 'VN', N'Chưa thanh toán')
insert into KhachHang values ('KH010', N'Nguyễn Văn Tuấn', N'Hà Nội', '0981236558', 'VN', N'Đã thanh toán')

insert into DangKiTour values ('DK01', 'KH001', 'LT01', '2020-03-10', 10, 7000)
insert into DangKiTour values ('DK02', 'KH002', 'LT02', '2020-02-20', 5, 5000)
insert into DangKiTour values ('DK03', 'KH003', 'LT03', '2020-03-15', 3, 12000)
insert into DangKiTour values ('DK04', 'KH004', 'LT04', '2020-02-28', 4, 20000)
insert into DangKiTour values ('DK05', 'KH005', 'LT04', '2020-02-15', 6, 30000)
insert into DangKiTour values ('DK06', 'KH006', 'LT01', '2020-02-15', 6, 4200)

