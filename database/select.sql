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
SELECT*FROM dbo.SANPHAM
SELECT*FROM dbo.DOITAC
SELECT*FROM dbo.CHINHANH
SELECT*FROM dbo.SANPHAM
SELECT*FROM dbo.LOAIHANG

SELECT*FROM dbo.QUANLY

update taixe
set khuvuchoatdong  = N'Quận 2'
where matx='TX3'

UPDATE dbo.SANPHAM
SET SoLuongTon=1
WHERE masp='sp1'
UPDATE dbo.TAIKHOAN
SET TrangThai=1
WHERE UserID='demo1' OR UserID='demo2'
update donhang
set tinhtrangdh=N'Đã đóng gói hàng'
where madh='DH2254'
update donhang
set tinhtrangdh=N'Đã đóng gói hàng', matx = null
where madh='dh922'
update taixe
set quan_tx=N'Quận 2'
where matx='tx3'