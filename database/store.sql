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
 

 create OR ALTER PROC USP_GetUserID @loginname nvarchar(100), @pass nvarchar(100)
 AS
 BEGIN 
	SELECT MAND, TrangThai FROM dbo.TAIKHOAN WHERE UserID=@loginname AND UserPassword=@pass
 END
 GO

  --Kiểm tra tài khoản có tồn tại
 CREATE PROC USP_CheckAccountExist @loginname nvarchar(100), @pass nvarchar(100)
 AS
 BEGIN
	SELECT*FROM dbo.TAIKHOAN WHERE UserID=@loginname AND UserPassword=@pass
 END
 GO
 
  CREATE OR ALTER FUNCTION getNumber(@userID NVARCHAR(100))
 RETURNS INT
 BEGIN 
	DECLARE @length INT
	DECLARE @user NVARCHAR(100)
	SET @user=@userID
	SET @length = LEN(@user)
	DECLARE @number NVARCHAR(100)
	SET @number = SUBSTRING(@user,3,@length)
	DECLARE @ordinal INT
	SET @ordinal =CAST(@number AS INT )
	RETURN @ordinal
 END
 GO

 --thêm tài khoản vảo bảng tài khoản
 CREATE OR ALTER PROC USP_InsertAccount @loginname NVARCHAR(100), @pass NVARCHAR(100), @roleUser NVARCHAR(100)
 AS
 BEGIN
	--tạo mã người dùng
	DECLARE @n INT 
	DECLARE @numberInID INT 
	DECLARE @newNumber INT 
	DECLARE @newUserID NVARCHAR(100)
	DECLARE @max INT = 0
	DECLARE @role NVARCHAR(100)
	DECLARE @id NVARCHAR(100)
	DECLARE @index INT = 1
	SET @role=@roleUser
	IF (@role=N'Tài xế')
	BEGIN
		--lấy mã người dùng lớn nhất
		
		
		SELECT @n=COUNT(*) FROM dbo.TAIXE 
		
		WHILE @index <= @n
		BEGIN
			--lay ma tai xe
			SELECT @id=dbo.TAIXE.MaTX
			FROM dbo.TAIXE,  (SELECT ROW_NUMBER() OVER(ORDER BY (SELECT 1)) AS MyIndex, MaTX 
													FROM dbo.TAIXE ) as T
			WHERE T.MyIndex=@index AND dbo.TAIXE.MaTX = t.MaTX
			
			--lấy số từ mã người dùng
			SELECT @numberInID=dbo.getNumber(@id)
			IF (@numberInID > @max )
			BEGIN
				SET @max=@numberInID
				SET @newNumber=@max+1 --tang gia tri len 1
            END
			SET @index=@index+1 --tang i
		END

		--tạo mã người dùng mới
		SET @newUserID = 'TX' + CAST(@newNumber AS NVARCHAR(100))
		--THÊM VÀO BẢNG TÀI KHOẢN
		INSERT INTO dbo.TAIKHOAN
		(
		    MaND,
		    UserID,
		    UserPassword,
		    TrangThai
		)
		VALUES
		(   @newUserID, -- MaND - nvarchar(100)
		    @loginname, -- UserID - nvarchar(100)
		    @pass, -- UserPassword - nvarchar(100)
		    2   -- TrangThai - int
		    )
		--THÊM VÀO BẢNG TÀI XẾ
		INSERT INTO TAIXE(MaTX) VALUES (@newUserID)
		RETURN 
    END

	--Nhân viên
	IF (@role=N'Nhân viên')
	BEGIN
		--lấy mã người dùng lớn nhất
		
		SELECT @n=COUNT(*) FROM dbo.NHANVIEN
		WHILE @index <= @n
		BEGIN
			--lay ma tai xe
			SELECT @id=dbo.NHANVIEN.MaNV
			FROM dbo.NHANVIEN,  (SELECT ROW_NUMBER() OVER(ORDER BY (SELECT 1)) AS StaffIndex, MaNV 
													FROM dbo.NHANVIEN ) as T
			WHERE T.StaffIndex=@index AND dbo.NHANVIEN.MaNV = t.MaNV
			
			--lấy số từ mã người dùng
			SELECT @numberInID=dbo.getNumber(@id)
			IF (@numberInID > @max )
			BEGIN
				SET @max=@numberInID
				SET @newNumber=@max+1 --tang gia tri len 1
            END
			SET @index=@index+1 --tang i
		END

		--tạo mã người dùng mới
		SET @newUserID = 'NV' + CAST(@newNumber AS NVARCHAR(100))
		--THÊM VÀO BẢNG TÀI KHOẢN
		INSERT INTO dbo.TAIKHOAN
		(
		    MaND,
		    UserID,
		    UserPassword,
		    TrangThai
		)
		VALUES
		(   @newUserID, -- MaND - nvarchar(100)
		    @loginname, -- UserID - nvarchar(100)
		    @pass, -- UserPassword - nvarchar(100)
		    2   -- TrangThai - int
		    )
		--THÊM VÀO BẢNG nhan vien
		INSERT INTO NHANVIEN(MaNV) VALUES (@newUserID)
		RETURN 
    END

	--khach hang
	IF (@role=N'Khách hàng')
	BEGIN
		--lấy mã người dùng lớn nhất
		
		SELECT @n=COUNT(*) FROM dbo.KHACHHANG
		WHILE @index <= @n
		BEGIN
			--lay ma tai xe
			SELECT @id=dbo.KHACHHANG.MaKH
			FROM dbo.KHACHHANG,  (SELECT ROW_NUMBER() OVER(ORDER BY (SELECT 1)) AS CusIndex, MaKH 
													FROM dbo.KHACHHANG ) as T
			WHERE T.CusIndex=@index AND dbo.KHACHHANG.MaKH = t.MaKH
			
			--lấy số từ mã người dùng
			SELECT @numberInID=dbo.getNumber(@id)
			IF (@numberInID > @max )
			BEGIN
				SET @max=@numberInID
				SET @newNumber=@max+1 --tang gia tri len 1
            END
			SET @index=@index+1 --tang i
		END

		--tạo mã người dùng mới
		SET @newUserID = 'KH' + CAST(@newNumber AS NVARCHAR(100))
		--THÊM VÀO BẢNG TÀI KHOẢN
		INSERT INTO dbo.TAIKHOAN
		(
		    MaND,
		    UserID,
		    UserPassword,
		    TrangThai
		)
		VALUES
		(   @newUserID, -- MaND - nvarchar(100)
		    @loginname, -- UserID - nvarchar(100)
		    @pass, -- UserPassword - nvarchar(100)
		    2   -- TrangThai - int
		    )
		--THÊM VÀO BẢNG khach hang
		INSERT INTO KHACHHANG(MaKH) VALUES (@newUserID)
		RETURN 
    END

	--doi tac
	IF (@role=N'Đối tác')
	BEGIN
		--lấy mã người dùng lớn nhất
		
		SELECT @n=COUNT(*) FROM dbo.DOITAC
		WHILE @index <= @n
		BEGIN
			--lay ma tai xe
			SELECT @id=dbo.DOITAC.MaDT
			FROM dbo.DOITAC,  (SELECT ROW_NUMBER() OVER(ORDER BY (SELECT 1)) AS SupIndex, MaDT
													FROM dbo.DOITAC ) as T
			WHERE T.SupIndex=@index AND dbo.DOITAC.MaDT = t.MaDT
			
			--lấy số từ mã người dùng
			SELECT @numberInID=dbo.getNumber(@id)
			IF (@numberInID > @max )
			BEGIN
				SET @max=@numberInID
				SET @newNumber=@max+1 --tang gia tri len 1
            END
			SET @index=@index+1 --tang i
		END

		--tạo mã người dùng mới
		SET @newUserID = 'DT' + CAST(@newNumber AS NVARCHAR(100))
		--THÊM VÀO BẢNG TÀI KHOẢN
		INSERT INTO dbo.TAIKHOAN
		(
		    MaND,
		    UserID,
		    UserPassword,
		    TrangThai
		)
		VALUES
		(   @newUserID, -- MaND - nvarchar(100)
		    @loginname, -- UserID - nvarchar(100)
		    @pass, -- UserPassword - nvarchar(100)
		    2   -- TrangThai - int
		    )
		--THÊM VÀO BẢNG nhan vien
		INSERT INTO DOITAC(MaDT) VALUES (@newUserID)
		RETURN 
    END
 END
 GO

 EXEC USP_InsertAccount 'khachhangmoi', '123456' , N'Khách hàng'
 
 DELETE dbo.TAIKHOAN WHERE MaND='tx8'
 SELECT dbo.getNumber('NV1000')
 
 DECLARE @index INT =2
 SELECT dbo.TAIXE.MaTX
 FROM dbo.TAIXE, (SELECT ROW_NUMBER() OVER(ORDER BY (SELECT 1)) AS MyIndex, MaTX 
													FROM dbo.TAIXE ) as t
 WHERE t.MyIndex=@index AND TAIXE.MaTX = t.MaTX


--kiểm tra user có bị trùng

SELECT ROW_NUMBER() OVER(ORDER BY (SELECT 1)) AS MyIndex, MaTX
FROM dbo.TAIXE 

--lấy thông tin trưng bày cho sản phẩm -- tên sản phẩm, tên đôi tác, tên chi nhánh, tên loại hàng, giá bán, giá giảm
CREATE PROC USP_GetInfoDisplayProduct @masp nvarchar(100)
AS
BEGIN
	SELECT D.TenDT, 
    FROM dbo.SANPHAM s, dbo.DOITAC d
	WHERE s.MaSP=@masp AND s.MaDT=d.MaDT AND s.MaDT=cn.MaDT AND s.MaCN=cn.MaCN
END
GO

--tạo đơn hàng mới
CREATE OR ALTER PROC USP_InsertOrder @makh NVARCHAR(100), @tinhtrang NVARCHAR(100), @hinhthuc NVARCHAR(100), @phivc MONEY, @thoigian datetime
AS
BEGIN
	--tìm đơn hàng có mã lớn nhất
	DECLARE @max INT = 0
	DECLARE @newOrderID NVARCHAR(100)
	DECLARE @numberInId INT
	DECLARE @newNumber INT
	DECLARE @n INT
	DECLARE @index INT = 1
	DECLARE @id NVARCHAR(100)
	SELECT @n=COUNT(*) FROM dbo.DONHANG
		WHILE @index <= @n
		BEGIN
			--lay ma don hang
			SELECT @id=dbo.DONHANG.MaDH
			FROM dbo.DONHANG,  (SELECT ROW_NUMBER() OVER(ORDER BY (SELECT 1)) AS OrderIndex, MaDH
													FROM dbo.DONHANG ) as T
			WHERE T.OrderIndex=@index AND dbo.DONHANG.MaDH = t.MaDH
			
			--lấy số từ mã người dùng
			SELECT @numberInID=dbo.getNumber(@id)
			IF (@numberInID > @max )
			BEGIN
				SET @max=@numberInID
				SET @newNumber=@max+1 --tang gia tri len 1
            END
			SET @index=@index+1 --tang i
		END
		--tạo mã ddon hang mới
		SET @newOrderID = 'DH' + CAST(@newNumber AS NVARCHAR(100))
	--them don hang voi ma khach hang tuong ung
	INSERT INTO DONHANG(MaDH, MaKH, TinhTrangDH,HinhThucThanhToan, PhiVC, ThoiGianDatHang) VALUES (@newOrderID, @makh, @tinhtrang, @hinhthuc, @phivc, @thoigian)

	--trả về mã đơn hàng vừa tạo
	SELECT * FROM dbo.DONHANG WHERE madh=@newOrderID
END
GO
EXEC dbo.USP_InsertOrder @makh = N'KH5' -- nvarchar(100)

--thêm chi tiết đơn hàng
CREATE OR ALTER PROC USP_InsertDetailOrder @madh nvarchar(100), @masp nvarchar(100), @sl int, @gia money, @thanhtien money
AS
BEGIN TRAN
	
	--kiểm tra hàng tồn của sản phẩm
	DECLARE @slton INT
	SET @slton = (SELECT SoLuongTon FROM dbo.SANPHAM WHERE masp=@masp)
	IF (@slton = 0)
	BEGIN
		RAISERROR(N'Sản phẩm hết hàng' ,15,1)
		ROLLBACK
		RETURN 
    END
	
	--nếu số lượng tồn < số lượng cần mua
	IF (@slton < @sl)
	BEGIN
		RAISERROR(N'Không đủ số lượng cung cấp',16,1)
		ROLLBACK
		return
    END

	--thêm 1 chi tiết đơn hàng 
	INSERT INTO dbo.CT_DONHANG
	(
	    MaDH,
	    MaSP,
	    SoLuong,
	    GiaTien,
	    ThanhTien
	)
	VALUES
	(   @madh,  -- MaDH - nvarchar(100)
	    @masp,  -- MaSP - nvarchar(100)
	    @sl,    -- SoLuong - int
	    @gia, -- GiaTien - money
	    @thanhtien  -- ThanhTien - money
	    )

	--cập nhật tổng tiền của đơn hàng
	UPDATE dbo.DONHANG
	SET TongTien = (SELECT SUM(THANHTIEN) FROM dbo.CT_DONHANG WHERE MaDH=@madh GROUP BY MaDH ) + PhiVC
	FROM dbo.DONHANG
	WHERE dbo.DONHANG.MaDH=@MADH
COMMIT TRAN
GO
 EXEC USP_INSERTDETAILORDER 'DH1000','SP1',2,1000,2000



