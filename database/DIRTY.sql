BEGIN TRAN
	INSERT INTO dbo.SANPHAM
	(
	    MaSP,
	    MaDT,
	    TenSP,
	    MaCN,
	    GiaBan,
	    GiaGiam,
	    SoLuongTon,
	    MaLoaiHang,
	    HinhAnh
	)
	VALUES
	(   N'SP2222',  -- MaSP - nvarchar(100)
	    N'DT3',  -- MaDT - nvarchar(100)
	    N'DAY CON LAM NGUOI',  -- TenSP - nvarchar(100)
	    N'CN1',  -- MaCN - nvarchar(100)
	    NULL, -- GiaBan - money
	    NULL, -- GiaGiam - money
	    100,    -- SoLuongTon - int
	    N'LH1',  -- MaLoaiHang - nvarchar(100)
	    'SDFSDFSD'    -- HinhAnh - varchar(150)
	    )

	WAITFOR DELAY '00:00:05'
	ROLLBACK TRAN
	RETURN
COMMIT TRAN

SET TRAN ISOLATION LEVEL READ COMMITTED
BEGIN TRAN
	SELECT*FROM SANPHAM WHERE MADT='DT3'
COMMIT TRAN
SELECT*FROM HOPDONG
