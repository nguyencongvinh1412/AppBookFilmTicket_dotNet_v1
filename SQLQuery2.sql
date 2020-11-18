/*
- Các table cần dùng :
  + DangNhap
  + Fiml
  + Ghe
- các phương thức( nên dùng procedures)
  + thêm acc ( insert DangNhap)
  + quên mk  ( update DangNhap)
  + thêm ghê đã đăt cho từng fiml ( insert Ghe)
  + 1 pro sẽ được gọi thực hiện nếu sau thời gian time nào đó ( các ghế sẽ được hủy toàn bộ )
*/


-- create tables
create table DangNhap
(
	Ten nvarchar(100) primary key,
	MK nvarchar(500),
)

create table Fiml
(
	TenFiml nvarchar(500),
	MaFiml int primary key,
	TG date,
	TheLoai nvarchar(500),
	QuocGia nvarchar(500)
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

-- chèn database vào bảng fiml
insert into Fiml values(N'Dinh Thự Oan Khuất' , 0, '2020-11-4', N'Kinh Dị', N'Mỹ')
insert into Fiml values(N'Bán Đảo BENINSULA' , 1, '2020-11-4', N'Kinh Dị', N'Hàn Quốc')
insert into Fiml values(N'Kẻ Cuồng Sát' , 2, '2020-11-4', N'Hành Động', N'Mỹ')
insert into Fiml values(N'Hồn Ma Văn Sĩ' , 3, '2020-11-4', N'hài Hước', N'Indonesia')
insert into Fiml values(N'Biệt Đội Big Hero 6' , 4, '2020-11-4', N'Hoạt Hình', N'Nhật Bản')
insert into Fiml values(N'Cậu Bé Người Gỗ PINOCHIO' , 5, '2020-11-4', N'Hoạt Hình', N'Ý')
insert into Fiml values(N'Chuyến Du Lịch Chết Chóc' , 6, '2020-11-4', N'Kinh Dị', N'Mỹ')
insert into Fiml values(N'Cuôc Phiêu Lưu Của SCOOBY DOO' , 7, '2020-11-4',N'Hoạt Hình', N'Mỹ')
insert into Fiml values(N'Yêu Nhau Mùa Ế' , 8, '2020-11-4', N'Tình Cảm', N'Thái')
insert into Fiml values(N'Sài Gòn Trong Cơn Mưa' , 9, '2020-11-4', N'Tình Cảm', N'Viêt Nam')
insert into Fiml values(N'Tiệc Trăng Máu' , 10, '2020-11-4', N'Hài Hước', N'Việt Nam')
insert into Fiml values(N'Kỳ Nghĩ Nhớ Đời' , 11, '2020-11-4', N'Hài Hước', N'Hàn Quốc')
insert into Fiml values(N'Ngạ Quỷ' , 12, '2020-11-4', N'Kinh Dị', N'Việt Nam')


-- create methods

-- tạo stored procedures 
-- cú pháp :
/*
create proc tên_stored
danh_sách_tham_số (nếu có )
as
begin
	// các câu lênh
end
*/

-- để gọi thực thi stored procedures 
-- có nhiều cách gọi thực thi
/*
cách 1 : dùng tên đầy đủ của tham số
	exec tên_stored @tham_số_1 = giá trị , @tham_số_2 = giá trị
cách 2 : không dùng tên đầy đủ của tham số
	exec tên_stored giá trị 1 , giá trị 2
*/

-- insert DangNhap

create proc addDangNhap
@name nvarchar(100), @pass nvarchar(500)
as
begin
	insert into DangNhap(Ten, MK) values(@name, @pass);
end

-- update DangNhap
create proc resetPassDangNhap
@name nvarchar(100), @newPass nvarchar(500)
as 
begin
	update DangNhap set MK = @newPass where DangNhap.Ten = @name;
end

-- add Ghe into Ghe table
create proc SQLDatGhe
@maghe int ,@ten nvarchar(100),@sdt nvarchar(100), @pttt nvarchar(100),@mafiml int
as
begin
	insert into Ghe (MaGhe, MauGhe, TG,SDT,PTTT,Ten,MaFiml) values (@maghe,'Red',GETDATE() , @sdt,@pttt,@ten,@mafiml);
end

-- reset data 

/*
B1 : tạo biến cursor 
	declare tên_cursor cursor for (câu lệnh select)  -- câu lệnh select để lấy dữ liệu để con trỏ trỏ đến
B2 : mở con trỏ để sử dụng
	Open tên_cursor
B3 : tạo biến để lưu giá trị cursor đọc được
	declare @tên_biến_1 kiểu_dữ_liệu
	declare @tên_biến_2 kiểu_dữ_liệu
B4 : đưa con trỏ đến dòng đầu tiên của bảng
	fetch next from tên_cursor into @tên_biến_1 , @tên_biến_2
B5 : dùng vòng lặp để đọc lần lược dữ liệu sang các record tiếp theo trong bảng
	while @@fetch_status = 0  -- nếu còn đọc được dữ liệu trong bảng thì @@fetch_status = 0 , ngược lại
		begin
			// câu lệnh với dữ liệu
			-- đưa con trỏ sang record tiếp theo
			fetch next from tên_cursor into @tên_biến_1, @tên_biến_2
		end
B6 : đóng con trỏ và hủy vùng nhớ cấp phát cho con trỏ
	close tên_cursor
	deallocate tên_cursor
*/
create proc resetData
as
begin
	declare cursorTimeFiml cursor for(select Ghe.MaFiml from Ghe) 
	Open cursorTimeFiml
	declare @maxTime int
	declare @maFiml int
	fetch next from cursorTimeFiml into @maFiml
	while @@FETCH_STATUS = 0 
	begin
		select @maxTime = max(DATEPART(DAY,GETDATE()) - DATEPART(DAY,TG)) from Ghe where MaFiml = @maFiml;
		if @maxTime > 2 delete Ghe where MaFiml = @maFiml;
		fetch next from cursorTimeFiml into @maFiml
	end
	close cursorTimeFiml
	deallocate cursorTimeFiml
end
select * from Fiml