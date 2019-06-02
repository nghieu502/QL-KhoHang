create database KhoHang
go

use KhoHang
go

create table QuyenUser
(
	idQU int identity primary key,
	tenQU nvarchar(50) not null
)
go

create table Users
(
	idUS int identity primary key,
	tenUS nvarchar(50) not null,
	username nvarchar(20) unique not null,
	pass nvarchar(20) not null,
	idQU int references QuyenUser(idQU)
)
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
	ngayNhap date not null,
	soLuongN int not null,
	giaN int not null,
	idMH int references MatHang(idMH)
)
go

create table PhieuXuat
(
	idPX int identity primary key,
	ngayXuat date not null,
	soLuongX int not null,
	giaX int not null,
	idMH int references MatHang(idMH)
)
go