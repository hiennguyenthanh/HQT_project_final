use QLHD
go

alter proc USP_ShowNotDoneOrderByArea @matx nvarchar(100)
as
set tran isolation level read committed
begin tran
	begin try
		if not exists(select*from TAIXE where matx=@matx)
		begin
			print('Ma tai xe khong ton tai')
			rollback tran
		end
		declare @diachihoatdong nvarchar(100)
		set @diachihoatdong = (select KHUVUCHOATDONG FROM TAIXE WHERE MATX=@matx)
		SELECT D.*
		FROM DONHANG D
		WHERE D.DIACHIGIAO LIKE '%' + @diachihoatdong+ '%' and D.MATX=@matx and (D.TINHTRANGDH=N'Tài xế đã nhận hàng' OR D.TinhTrangDH=N'Đang giao')
	end try
	begin catch
		print('loi he thong')
		rollback tran
	end catch
commit tran
go

--store xuất danh sách những đơn hàng đã hoàn thành theo mã tài xế
alter proc USP_ShowDoneOrderByArea @matx nvarchar(100), @status nvarchar(100) --đã giao
as
set tran isolation level read committed
begin tran
	begin try
		if not exists(select*from TAIXE where matx=@matx)
		begin
			print('Ma tai xe khong ton tai')
			rollback tran
		end
		SELECT D.*
		FROM DONHANG D
		WHERE D.MATX=@matx and D.TINHTRANGDH=@status
	end try
	begin catch
		print('loi he thong')
		rollback tran
	end catch
commit tran
go

-----
create proc USP_ShowDoneKH @matx nvarchar(100), @makh nvarchar(100)
as
set tran isolation level read committed
begin tran
	begin try
		if not exists(select*from TAIXE where matx=@matx)
		begin
			print('Ma tai xe khong ton tai')
			rollback tran
		end
		declare @diachihoatdong nvarchar(100)
		set @diachihoatdong = (select KHUVUCHOATDONG FROM TAIXE WHERE MATX=@matx)
		SELECT D.*
		FROM DONHANG D
		WHERE D.DIACHIGIAO LIKE '%' + @diachihoatdong+ '%' and D.MATX=@matx and D.MAKH=@makh
	end try
	begin catch
		print('loi he thong')
		rollback tran
	end catch
commit tran
go

declare @strin varchar(100)
set @strin='Đã giao'
exec USP_ShowDoneKH 'TX3', 'kh3'
select*from donhang
--lấy ra khu vực hoạt động của tài xế theo id
create proc USP_GetArea @matx nvarchar(100)
as
	select KhuVucHoatDong from taixe where matx=@matx
go

--xuất danh sách đơn hàng theo khu vực hoạt động của tài xế
alter proc USP_GetAllOrderByAreaOfDriver @matx nvarchar(100)
as
set tran isolation level read committed
begin tran
	begin try
		if not exists(select*from TAIXE where matx=@matx)
		begin
			print('Ma tai xe khong ton tai')
			rollback tran
		end
		declare @diachihoatdong nvarchar(100)
		set @diachihoatdong = (select KHUVUCHOATDONG FROM TAIXE WHERE MATX='TX1')
		SELECT D.*
		FROM DONHANG D
		WHERE D.DIACHIGIAO LIKE '%' + @diachihoatdong+ '%' AND  D.TINHTRANGDH=N'Đã đóng gói hàng' AND D.MATX is NULL
	end try
	begin catch
		print('loi he thong')
		rollback tran
	end catch
commit tran
go

--xuất thông tin tài xế theo mã tài xế
alter proc USP_GetInfoDriver @matx nvarchar(100)
as
begin
	select * from TAIKHOAN tk join TAIXE tx on tx.matx=tk.mand where tx.matx=@matx 
end
go
--store xuất danh sách những đơn hàng theo mã tài xế, theo trạng thái đơn hàng
alter proc USP_ShowDoneOrderByArea @matx nvarchar(100), @status nvarchar(100)
as
set tran isolation level read committed
begin tran
	begin try
		if not exists(select*from TAIXE where matx=@matx)
		begin
			print('Ma tai xe khong ton tai')
			rollback tran
		end
		declare @diachihoatdong nvarchar(100)
		set @diachihoatdong = (select KHUVUCHOATDONG FROM TAIXE WHERE MATX=@matx)
		SELECT D.*
		FROM DONHANG D
		WHERE D.DIACHIGIAO LIKE '%' + @diachihoatdong+ '%' and D.MATX=@matx and D.TINHTRANGDH=@status
	end try
	begin catch
		print('loi he thong')
		rollback tran
	end catch
commit tran
go

--update thông tin tài xế
create proc USP_UpdateInfoDriver @matx nvarchar(100), @tentx nvarchar(100), @cmnd nvarchar(100), @gioitinh nvarchar(100),
								@ngaysinh DATETIME, @sdt nvarchar(100), @biensoxe nvarchar(100), @khuvuc nvarchar(100), 
								@email nvarchar(100), @tk nvarchar(100), @sonha int, @duong nvarchar(100), @phuong nvarchar(100),
								@quan nvarchar(100), @tp nvarchar(100)
as
begin
	update TAIXE
	SET TenTX=@tentx, CMND=@cmnd, GioiTinh=@gioitinh,
	NgaySinh=@ngaysinh, SDT_TX=@sdt, BienSoXe=@biensoxe, KhuVucHoatDong=@khuvuc
	,Email_TX=@email, TKNganHang=@tk, SoNha_TX=@sonha, Duong_TX=@duong, Phuong_TX=@phuong, Quan_TX=@quan, ThanhPho_TX=@tp
	WHERE MaTX=@matx
	
end
go

--lấy đơn hàng theo mã đơn hàng
CREATE PROC USP_GetInfoOrder @madh NVARCHAR(100)
AS
BEGIN TRAN
SET TRAN ISOLATION LEVEL READ COMMITTED
	IF NOT EXISTS(SELECT*FROM dbo.DONHANG WHERE MaDH=@madh)
	BEGIN
		PRINT('khong ton tai don hang')
		ROLLBACK TRAN
    END
	SELECT*FROM dbo.DONHANG WHERE MaDH=@madh
COMMIT TRAN
GO

EXEC dbo.USP_GetInfoOrder @madh = N'dh100' -- nvarchar(100)

--cập nhật mã tài xế vào đơn hàng trống, và đổi trạng thái giao hàng sang đã nhận hàng
CREATE OR ALTER PROC USP_UpdateIDDriverIntoOrder @madh nvarchar(100), @matx nvarchar(100)
AS
BEGIN TRAN
	IF NOT EXISTS(SELECT*FROM dbo.DONHANG WHERE MaDH=@madh)
	BEGIN
		PRINT('khong ton tai don hang')
		ROLLBACK tran
    END
    IF NOT EXISTS(SELECT*FROM dbo.TAIXE WHERE MaTX=@matx)
	BEGIN
		PRINT('khong ton tai tai xe')
		ROLLBACK TRAN
	END
	IF EXISTS(SELECT*FROM dbo.DONHANG WHERE MaDH=@madh AND TinhTrangDH=N'Đã giao' OR TinhTrangDH=N'Đang giao')
	BEGIN
		PRINT('khong ton tai don hang phu hop')
		ROLLBACK TRAN
	END
	IF EXISTS(SELECT*FROM dbo.DONHANG WHERE MaDH=@madh AND MaTX IS NOT NULL)
	BEGIN
		PRINT('khong ton tai don hang phu hop')
		ROLLBACK TRAN
	END
	UPDATE dbo.DONHANG
	SET MaTX=@matx, TinhTrangDH=N'Tài xế đã nhận hàng'
	WHERE MaDH=@madh AND TinhTrangDH=N'Đã đóng gói hàng'
	
COMMIT TRAN
GO

 EXEC USP_UpdateIDDriverIntoOrder 'dh1','TX1' 

 --Cập nhật tình trạng đơn hàng của tài xế
 CREATE OR ALTER PROC USP_UpdateDriverOrderStatus @madh nvarchar(100), @matx nvarchar(100), @status nvarchar(100)
 AS
 BEGIN TRAN
	IF NOT EXISTS (SELECT*FROM dbo.DONHANG WHERE MaDH=@madh)
	BEGIN
		PRINT ('khong ton tai don hang')
		ROLLBACK TRAN
    END
	IF EXISTS(SELECT*FROM dbo.DONHANG WHERE MaDH=@madh AND MaTX != @matx )
	BEGIN 
		PRINT ('don hang da duoc chon truoc do')
		ROLLBACK TRAN
	END
	UPDATE dbo.DONHANG
	SET TinhTrangDH=@status
	WHERE MaDH=@madh AND MaTX=@matx

 COMMIT TRAN 
 GO
 
 --thêm đơn hàng của tài xế vào bảng thu nhập
 CREATE OR ALTER PROC USP_InsertOrderIntoIncomeDriver @madh NVARCHAR(100)
 AS
 BEGIN tran
	IF NOT EXISTS(SELECT*FROM dbo.DONHANG WHERE MaDH=@madh)
	BEGIN
		PRINT('khong the them')
		ROLLBACK TRAN
    END
	IF NOT EXISTS(SELECT*FROM dbo.DONHANG WHERE MaDH=@madh AND TinhTrangDH=N'Đã giao' AND MaTX IS NOT NULL)
	BEGIN
		PRINT('khong the them')
		ROLLBACK TRAN
    END
	--lấy mã tài xế của đơn hàng
	DECLARE @matx NVARCHAR(100)
	SELECT @matx=MaTX FROM dbo.DONHANG WHERE MaDH=@madh
	-- lấy phí vận chuyển từ đơn hàng

	DECLARE @ship MONEY
	SET @ship = (SELECT PhiVC FROM dbo.DONHANG WHERE MaDH=@madh AND TinhTrangDH=N'Đã giao')
	DECLARE @shipfee MONEY
	SET @shipfee=0.2*@ship
	
	--nếu đã tồn tại đơn hàng trong và tài xế trong bảng thì update phí
	IF EXISTS(SELECT*FROM dbo.THUNHAP_TAIXE WHERE MaDH=@madh AND MaTX=@matx)
	BEGIN
		UPDATE dbo.THUNHAP_TAIXE 
		SET PhiVanChuyen_TX=@shipfee
		WHERE MaDH=@madh AND MaTX=@matx
    END
	IF NOT EXISTS(SELECT*FROM dbo.THUNHAP_TAIXE  WHERE MaDH=@madh AND MaTX=@matx)
	BEGIN
		INSERT INTO dbo.THUNHAP_TAIXE
	(
	    MaTX,
	    MaDH,
	    PhiVanChuyen_TX
	)
	VALUES
	(   @matx, -- MaTX - nvarchar(100)
	    @madh, -- MaDH - nvarchar(100)
	    @shipfee -- PhiVanChuyen_TX - money
	    )
    END
	
	--nếu chưa tồn tại thì chỉ thêm vào
	
		
 COMMIT TRAN
 GO
 
 --cập nhật thu nhập của tài xế trong bảng tài xế
 CREATE PROC USP_UpdateDriverIncome @matx NVARCHAR(100)
 AS
 BEGIN TRAN
	IF NOT EXISTS(SELECT*FROM dbo.TAIXE WHERE MaTX=@matx)
	BEGIN
		PRINT('khong ton tai tai xe')
		ROLLBACK TRAN
    END
	--tính tổng thu nhập từ bảng thu nhập
	DECLARE @income MONEY

	SELECT @income=SUM(tn.PhiVanChuyen_TX)
    FROM dbo.THUNHAP_TAIXE tn
    WHERE tn.MaTX=@matx
	GROUP BY tn.MaTX

	UPDATE dbo.TAIXE
	SET ThuNhap=@income
	WHERE MaTX=@matx

 COMMIT TRAN
 GO
 
 EXEC dbo.USP_InsertOrderIntoIncomeDriver @madh = N'DH100' -- nvarchar(100)
                                           -- nvarchar(100)
 EXEC dbo.USP_UpdateDriverIncome @matx = N'TX1' -- nvarchar(100)
 