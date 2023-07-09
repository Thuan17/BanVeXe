Create DataBase BanVeXe
go

use BanVeXe
Go

Create Table BenXe(
TenBenXe nvarchar(30)primary key,
Tinh nvarchar(30)
)
SELect * from BenXe


create Table ChuyenXe(
MaChuyenXe char(12) primary key,
MaXe char(10),
TenBenDi nvarchar(30),
TenBenDen nvarchar(30),
NgayXuatPhat date,
GioKhoiHanh time
)
GO
select MaChuyenXe from ChuyenXe


create table Ve(
MaVe char(11) primary key,
MaChuyenXe char(12),
TenBenDi nvarchar(30),
TenBenDen nvarchar(30),
TenKhachHang nvarchar(50),
GiaVe float,
GioKhoiHanh Time ,
NgayKhoiHanh Date

)
go


Create Table Xe(
MaXe char(10)primary key,
SoGhe int,
LoaiXe nvarchar(6)
)
GO


create Table NhanVien(
MaNV Char(5)primary key,
TenNV nvarChar(50),
NgaySinh Date ,
DiaChi NvarChar(50),
 ChucNang nvarchar(10),
 userNV char(15),
pWNV char(20)
)
go
-----khoa ngoai
alter table Ve
add constraint VtoCX
foreign key (MaChuyenXe)
references ChuyenXe

alter table ChuyenXe
add constraint CXtoV
foreign key (MaXe)
references Xe




alter table ChuyenXe
add constraint CXtoBDi
foreign key (TenBenDi)
references BenXe

alter table ChuyenXe
add constraint CXtoBDen
foreign key (TenBenDen)
references BenXe


-----dư liệu
insert into BenXe values (N'Bến Xe Miền Tây',N' Kinh Dương Vương/TPHCM')
insert into BenXe values (N'Bến Xe Miền Đông',N'Bình Thạnh/TPHCM')
insert into BenXe values (N'Bến Xe An Sương',N'Q12/TPHCM')
insert into BenXe values (N'Bến Xe Chợ Lơn',N'Q5/TPHCM')
insert into BenXe values (N'Bến Xe Bến Tre',N'Tỉnh Bến Tre')
insert into BenXe values (N'Bến Xe Cần Thơ',N'TP.Cần Thơ')
insert into BenXe values (N'Bến Xe Vĩnh Long',N'Tỉnh.Vĩnh Long')
insert into BenXe values (N'Bến Xe Hậu Giang',N'TP.Vị Thanh')
insert into BenXe values (N'Bến Xe Bà Rịa',N'Tỉnh.Bà Rịa')
insert into BenXe values (N'Bến Xe Vũng Tàu',N'Tỉnh.Bà Rịa')
select * from BenXe



Update ChuyenXe set MaXe ='X010' , TenBenDi =N'Bến Xe Cần Thơ',TenBenDen=N'Bến Xe Chợ Lơn',NgayXuatPhat='2022-12-04' where MaChuyenXe='CX601357824 '
insert into Xe values('X001',45,N'Thường')
insert into Xe values('X002',35,N'Thường')
insert into Xe values('X003',39,N'Thường')
insert into Xe values('X004',16,N'Thường')
insert into Xe values('X005',22,N'Phòng')
insert into Xe values('X006',34,N'Phòng')
insert into Xe values('X007',7,N'Limo')
insert into Xe values('X008',10,N'Limo')
insert into Xe values('X009',44,N'Giường')
insert into Xe values('X010',34,N'Giường')
select * from Xe
insert into Xe values('X010',34,N'Giường')




insert into ChuyenXe values('CX001','X005',N'Bến Xe Miền Tây',N'Bến Xe Hậu Giang','2022-11-24','09:30:00')
insert into ChuyenXe values('CX002','X001',N'Bến Xe Miền Tây ',N'Bến Xe Cần Thơ','2022-11-24','19:45:00')
insert into ChuyenXe values('CX003','X003',N'Bến Xe Miền Đông',N'Bến Xe Bà Rịa','2022-11-24','18:45:00')
insert into ChuyenXe values('CX004','X010',N'Bến Xe An Sương',N'Bến Xe Cần Thơ','2022-11-24','07:15:00')
insert into ChuyenXe values('CX005','X006',N'Bến Xe Bà Rịa',N'Bến Xe Miền Đông','2022-11-24','21:05:00')
insert into ChuyenXe values('CX006','X008',N'Bến Xe Vũng Tàu',N'Bến Xe Chợ Lơn','2022-11-24','23:25:00')
insert into ChuyenXe values('CX007','X009',N'Bến Xe Vũng Tàu',N'Bến Xe An Sương','2022-11-24','08:35:00')
insert into ChuyenXe values('CX008','X002',N'Bến Xe Vĩnh Long',N'Bến Xe Vũng Tàu','2022-11-24','07:15:00')
insert into ChuyenXe values('CX009','X004',N'Bến Xe Bến Tre',N'Bến Xe Cần Thơ','2022-11-24','08:35:00')
insert into ChuyenXe values('CX010','X006',N'Bến Xe Bà Rịa',N'Bến Xe Vĩnh Long','2022-11-24','07:15:00')
insert into ChuyenXe values('CX011','X002',N'Bến Xe Vĩnh Long',N'Bến Xe Vũng Tàu','2022-11-24','07:15:00')
insert into ChuyenXe values('CX012','X003',N'Bến Xe Vĩnh Long',N'Bến Xe Vũng Tàu','2022-11-24','07:15:00')
insert into ChuyenXe values('CX013825471','X002',N'Bến Xe Bà Rịa',N'Bến Xe Miền Đông','2022-11-24','07:15:00')
insert into ChuyenXe values('CX013825476','X002',N'Bến Xe Vũng Tàu',N'Bến Xe Miền Đông','2022-11-24','07:15:00')
insert into ChuyenXe values('CX013825477','X002',N'Bến Xe Miền Tây',N'Bến Xe Cần Thơ','2022-11-24','07:15:00')
select*from ChuyenXe
 

insert into Ve Values ('V0001','CX010',N'Bến Xe Bà Rịa',N'Bến Xe Vĩnh Long',N'Huỳnh Thuận',200000,'07:15:00','2022-11-24')
insert into Ve Values ('V0002','CX002',N'Bến Xe Miền Tây ',N'Bến Xe Cần Thơ',N'Minh Quân',150000,'19:45:00','2022-11-24')
insert into Ve Values ('V0003','CX004',N'Bến Xe An Sương',N'Bến Xe Cần Thơ',N'Văn Tài',149000,'07:15:00','2022-11-24')
insert into Ve Values ('V0004','CX010',N'Bến Xe Bà Rịa',N'Bến Xe Vĩnh Long',N'Thành An',200000,'07:15:00','2022-11-24')
insert into Ve Values ('V0005','CX010',N'Bến Xe Bà Rịa',N'Bến Xe Vĩnh Long',N'Thị Tuyết',200000,'07:15:00','2022-11-24')
insert into Ve Values ('V0006','CX005',N'Bến Xe Bà Rịa',N'Bến Xe Miền Đông',N'Mai Cường',230000,'21:05:00','2022-11-24')
insert into Ve Values ('V0007','CX003',N'Bến Xe Miền Đông',N'Bến Xe Bà Rịa',N'Thúy Hằng',175000,'18:45:00','2022-11-24')
insert into Ve Values ('V0008','CX003',N'Bến Xe Miền Đông',N'Bến Xe Bà Rịa',N'Văn Tuyết',175000,'18:45:00','2022-11-24')
insert into Ve Values ('V0009','CX006',N'Bến Xe Vũng Tàu',N'Bến Xe Chợ Lơn',N'Châu Quân',145000,'23:25:00','2022-11-24')
insert into Ve Values ('V0010','CX006',N'Bến Xe Vũng Tàu',N'Bến Xe Chợ Lơn',N'Châu Hoàng',145000,'23:25:00','2022-11-24')
select* from Ve

insert into NhanVien Values ('NV001',N'Gia Thuận','2002-11-17',N'Hóc Môn',N'Taì Xế','thuanhuynh','mapuu17')
insert into NhanVien Values ('NV002',N'Tài Em','1973-05-27',N'Bà Điểm',N'Taì Xế','taiem','123')
insert into NhanVien Values ('NV003',N'Tài Anh','1980-10-23',N'TPHCM',N'Taì Xế','taihoang','123')
insert into NhanVien Values ('NV004',N'Văn Hoàng','1979-02-27',N'Tiềng Giang',N'Taì Xế','vanhoang','123')
insert into NhanVien Values ('NV005',N'Hoàng Tèo','1991-01-06',N'An Sương',N'Bán Vé','hoangteo','123')
insert into NhanVien Values ('NV006',N'Mai Cường','1975-04-19',N'Châu Thành',N'Bán Vé','maicuong','123')
insert into NhanVien Values ('NV007',N'Tuấn Anh','1985-04-21',N'Củ Chỉ',N'Bán Vé','tuananh','123')
insert into NhanVien Values ('NV008',N'Ngọc Ánh','1985-10-12',N'Bình Dương',N'Bán Vé','ngocanh','123')
select*from NhanVien


--Sửa Nhân Viên
create proc EditEmployee
@MaNV char(5),
@TenNV nvarchar(50),
@Ngsinh date,
@DiaChi nvarchar(50),
@ChucNang nvarchar(20)
as
begin
    update NhanVien set 
    TenNV = @TenNV,
    NgaySinh = @Ngsinh,
	DiaChi = @DiaChi,
	ChucNang = @ChucNang
    where MaNV = @MaNV
end
go
-- Thêm nhân viên
create proc AddEmployee
@MaNV char(5),
@TenNV nvarchar(50),
@Ngsinh date,
@DiaChi nvarchar(50),
@ChucNang nvarchar(20)
as
begin
    insert into NhanVien values(@MaNV,@TenNV,@Ngsinh,@DiaChi,@ChucNang)
end
go
-- Xóa nhân vien
create proc DeleteEmployee
@MaNV char(5)
as
begin
   delete from NhanVien where MaNV = @MaNV
end