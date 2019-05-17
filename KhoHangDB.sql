create database KhoHang
go

use KhoHang
go

create table NhaCungCap
(
	idNCC int identity primary key,
	tenNCC nvarchar(50) unique not null,
	diaChiNCC nvarchar(100) not null,
	sdtNCC nvarchar(15) not null,
	emailNCC nvarchar(50) not null
)
go

create table MatHang
(
	idMH int identity primary key,
	tenMH nvarchar(50) not null,
	donVi nvarchar(10) not null,
	idNCC int references NhaCungCap(idNCC)
)
go

create table PhieuNhap
(
	idPN int identity primary key,
	ngayNhap date not null
)
go

create table ChiTietPN
(
	idMH int references MatHang(idMH),
	idPN int references PhieuNhap(idPN),
	soLuongN int not null,
	giaN int not null,
	primary key (idMH, idPN)
)
go

create table PhieuXuat
(
	idPX int identity primary key,
	ngayXuat date not null
)
go

create table ChiTietPX
(
	idMH int references MatHang(idMH),
	idPX int references PhieuXuat(idPX),
	soLuongX int not null,
	giaX int not null,
	primary key (idMH, idPX)
)
go

create table QuyenUser
(
	idQU int identity primary key,
	tenQU nvarchar(50) not null
)
go

create table Account
(
	idACC int identity primary key,
	tenACC nvarchar(50) not null,
	username nvarchar(20) unique not null,
	pass nvarchar(20) not null,
	idQU int references QuyenUser(idQU)
)
go