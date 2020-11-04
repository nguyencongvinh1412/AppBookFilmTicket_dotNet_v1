
----------------------------------------------------
create table DangNhap
(
	Ten nvarchar(100) primary key,
	MK nvarchar(500),
)

create table Fiml
(
	TenFiml nvarchar(500),
	MaFiml int primary key
)

create table Ghe
(
	MaGhe int,
	MauGhe varchar(100) default  'Red',
	TG datetime,
	SDT nvarchar(100),
	PTTT nvarchar(100),
	Ten nvarchar(100) foreign key(Ten) references DangNhap(Ten),
	MaFiml int foreign key(MaFiml) references Fiml(MaFiml)
)

-- tạo stored procedured để cập nhật lại thời gian đặt vé 
-- lấy max của khoảng thời gian đặt vé
-- nếu lớn hơn 2 ngày thì xóa tất cả các ghế của fiml đó trong table Ghe
-- tham số là mafiml
create proc CapNhatMauGhe
@mafim int
as
begin
	declare @maxtg int
	select @maxtg = max(DATEPART(DAY,GETDATE()) - DATEPART(DAY,TG)) from Ghe where MaFiml =  @mafim
	if @maxtg > 2 delete Ghe where MaFiml = @mafim
end


-- tạo proc để Đặt ghế 
-- 3 tham số : mã ghế, màu ghế, tên 
create proc SQLDatGhe
@maghe int ,@ten nvarchar(100),@sdt nvarchar(100), @pttt nvarchar(100),@mafiml int
as
begin
	insert into Ghe (MaGhe, MauGhe, TG,SDT,PTTT,Ten,MaFiml) values (@maghe,'Red',GETDATE() , @sdt,@pttt,@ten,@mafiml) 
end

-- chèn database vào bảng fiml
insert into Fiml values(N'Dinh Thự Oan Khuất' , 0)
insert into Fiml values(N'Bán Đảo BENINSULA' , 1)
insert into Fiml values(N'Kẻ Cuồng Sát' , 2)
insert into Fiml values(N'Hồn Ma Văn Sĩ' , 3)
insert into Fiml values(N'Biết Đội Big Hero 6' , 4)
insert into Fiml values(N'Cậu Bé Người Gỗ PINOCHIO' , 5)
insert into Fiml values(N'Chuyến Du Lịch Chết Chóc' , 6)
insert into Fiml values(N'Cuôc Phiêu Lưu Của SCOOBY DOO' , 7)
insert into Fiml values(N'Yêu Nhau Mùa Ế' , 8)



-- select truy vấn cho form hiển thị thông tin Acc và form hiển thị thông tin khách hàng cho tài khoản admin
select (select TenFiml from Fiml where Fiml.MaFiml = Ghe.MaFiml) as N'Tên Fiml' , MaGhe, TG,PTTT,SDT from Ghe where Ten = 'congvinh'

-- select truy vấn để load màu ghế khi vào form DatVe ( trong sự kiện form_load)
select MaGhe,MauGhe from Ghe where MaFiml = 1