use QLHD
go

select*from donhang
SELECT * FROM dbo.TAIXE
SELECT*FROM ct_donhang
SELECT*FROM dbo.THUNHAP_TAIXE
SELECT*FROM dbo.TAIKHOAN
SELECT*FROM dbo.NHANVIEN
SELECT*FROM dbo.HOPDONG
SELECT*FROM dbo.KHACHHANG
SELECT*FROM dbo.SANPHAM WHERE MaDT='DT5'
SELECT*FROM dbo.DOITAC
SELECT*FROM dbo.CHINHANH
SELECT*FROM dbo.SANPHAM
SELECT*FROM dbo.LOAIHANG

SELECT*FROM dbo.QUANLY

INSERT INTO dbo.TAIKHOAN
(
    MaND,
    UserID,
    UserPassword,
    TrangThai
)
VALUES
(    N'QL1', -- MaND - nvarchar(100)
    N'dlv', -- UserID - nvarchar(100)
    N'1345', -- UserPassword - nvarchar(100)
    1   -- TrangThai - int
    )
(
    MaND,
    UserID,
    UserPassword,
    TrangThai
)
VALUES
(   N'QL1', -- MaND - nvarchar(100)
    N'dlv', -- UserID - nvarchar(100)
    N'1345', -- UserPassword - nvarchar(100)
    1    -- TrangThai - int
    )

