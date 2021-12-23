use qlhd
go

alter TRIGGER TINH_THANHTIEN
ON dbo.CT_DONHANG AFTER INSERT,update
AS
BEGIN
	UPDATE dbo.CT_DONHANG
	SET dbo.CT_DONHANG.ThanhTien= dbo.CT_DONHANG.GiaTien * dbo.CT_DONHANG.SoLuong
	FROM inserted i
	WHERE i.MaDH = dbo.CT_DONHANG.MaDH AND i.MaSP = dbo.CT_DONHANG.MaSP
END
GO

CREATE TRIGGER TINH_GIATIEN
ON dbo.CT_DONHANG AFTER INSERT
AS
BEGIN
	UPDATE dbo.CT_DONHANG
	SET dbo.CT_DONHANG.GiaTien = dbo.SANPHAM.GiaBan - dbo.SANPHAM.GiaGiam
	FROM dbo.SANPHAM, inserted i
	WHERE dbo.SANPHAM.MaSP = dbo.CT_DONHANG.MaSP AND i.MaDH = dbo.CT_DONHANG.MaDH AND i.MaSP = dbo.CT_DONHANG.MaSP
END
GO

ALTER TRIGGER TINH_THUNHAP_TX
ON THUNHAP_TAIXE AFTER INSERT
AS
BEGIN
	UPDATE dbo.TAIXE
	SET dbo.TAIXE.ThuNhap = (SELECT SUM(tn.PhiVanChuyen_TX) 
								from THUNHAP_TAIXE tn
								WHERE tn.matx=dbo.TAIXE.MaTX)
	FROM inserted i
	WHERE i.MaTX = dbo.TAIXE.MaTX
END
GO
select*from donhang

CREATE TRIGGER TINH_TONGTIEN
ON CT_DONHANG AFTER INSERT,update 
AS
BEGIN
	UPDATE dbo.DONHANG
	SET dbo.DONHANG.TongTien = (SELECT SUM(ctdh.thanhTien) 
								FROM ct_donhang ctdh
								WHERE ctdh.MaDH = donhang.MaDH
								GROUP BY ctdh.MaDH) + dbo.DONHANG.PhiVC
	FROM inserted i
	WHERE i.MaDH = dbo.DONHANG.MaDH
END
GO

DROP TRIGGER TINH_TONGTIEN



alter TRIGGER TINH_PHIVANCHUYEN_TX
ON dbo.THUNHAP_TAIXE AFTER INSERT
AS
BEGIN
	UPDATE dbo.THUNHAP_TAIXE
	SET dbo.THUNHAP_TAIXE.PhiVanChuyen_TX = 0.2 * dbo.DONHANG.PhiVC
	FROM dbo.DONHANG, inserted i
	WHERE dbo.THUNHAP_TAIXE.MaDH = dbo.DONHANG.MaDH AND i.MaDH = dbo.THUNHAP_TAIXE.MaDH AND i.MaTX = dbo.THUNHAP_TAIXE.MaTX
END
GO


select*from doanhthu_dt


ALTER trigger tinh_doanhthu
on doanhthu_dt after insert
as
begin
	update doanhthu_dt
	set doanhthu_dt.doanhthu = (select sum(ctdh.thanhtien)
								from donhang dh, ct_donhang ctdh, sanpham sp
								where doanhthu_dt.madt=sp.madt and  sp.masp=ctdh.masp and ctdh.madh=dh.madh and dh.tinhtrangdh=N'Đã giao' 
								and doanhthu_dt.nam = year(dh.thoigiandathang) and doanhthu_dt.thang= month(dh.thoigiandathang))
	from inserted i
	where i.madt=doanhthu_dt.madt and i.thang=doanhthu_dt.thang and i.nam=doanhthu_dt.nam
end
go

 
alter TRIGGER TINH_PHIHOAHONG
ON dbo.DOANHTHU_DT AFTER INSERT,UPDATE
AS
BEGIN
	UPDATE dbo.DOANHTHU_DT
	SET dbo.DOANHTHU_DT.PhiHoaHong = 0.1 * dbo.DOANHTHU_DT.DoanhThu
	FROM inserted i
	WHERE i.MaDT = dbo.DOANHTHU_DT.MaDT and i.thang=doanhthu_dt.thang and i.nam=doanhthu_dt.nam
END
GO

CREATE TRIGGER KT_SOCHINHANHDK
ON dbo.HOPDONG FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS (SELECT *
	FROM INSERTED, dbo.HOPDONG, dbo.DOITAC
	WHERE INSERTED.MaHD = dbo.HOPDONG.MaHD AND dbo.DOITAC.MaDT = dbo.HOPDONG.MaDT 
	AND dbo.HOPDONG.SoChiNhanhDK > dbo.DOITAC.SoChiNhanh)
	BEGIN
		RAISERROR(N'Lỗi: Số chi nhánh đăng kí trong hợp đồng phải nhỏ hơn số chi nhánh của đối tác', 16,1)
		ROLLBACK
	END
END
GO

CREATE TRIGGER KT_HOPDONG_DOITAC
ON dbo.HOPDONG FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS (SELECT *
	FROM INSERTED, dbo.HOPDONG, dbo.DOITAC
	WHERE INSERTED.MaHD = dbo.HOPDONG.MaHD AND dbo.DOITAC.MaDT = dbo.HOPDONG.MaDT 
	AND dbo.HOPDONG.NguoiDaiDien_HD = dbo.DOITAC.NguoiDaiDien AND dbo.HOPDONG.MaSoThue_HD = dbo.DOITAC.MaSoThue)
	BEGIN
		RAISERROR(N'Lỗi: Số chi nhánh đăng kí trong hợp đồng phải nhỏ hơn số chi nhánh của đối tác', 16,1)
		ROLLBACK
	END
END
GO

CREATE TRIGGER KT_CTHOPDONG_CHINHANH
ON dbo.CT_HOPDONG FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS (SELECT *
	FROM INSERTED, dbo.CT_HOPDONG, dbo.CHINHANH
	WHERE INSERTED.MaDT = dbo.CHINHANH.MaDT AND dbo.CHINHANH.MaDT = dbo.CT_HOPDONG.MaDT 
	AND dbo.CT_HOPDONG.DiaChi != dbo.CHINHANH.DiaChi_CN)
	BEGIN
		RAISERROR(N'Lỗi: Số chi nhánh đăng kí trong hợp đồng phải nhỏ hơn số chi nhánh của đối tác', 16,1)
		ROLLBACK
	END
END
GO

select*from hopdong
drop trigger nguoidaidien_dt_hd
--ma so thue, ng dai dien
create TRIGGER NGUOIDAIDIEN_DT_HD
ON HOPDONG FOR INSERT
AS
BEGIN 
    UPDATE HOPDONG
	SET HOPDONG.NguoiDaiDien_HD = dt.NguoiDaiDien 
	FROM DOITAC dt, inserted I
	WHERE dt.MaDT = I.MaDT AND I.MaDT = HOPDONG.MaDT
END
GO


--ma so thue
drop trigger mst_dt_hd
create TRIGGER mst_DT_HD
ON HOPDONG FOR INSERT
AS
BEGIN 
    UPDATE HOPDONG
	SET  HOPDONG.MaSoThue_HD=dt.MaSoThue
	FROM DOITAC dt, inserted I
	WHERE dt.MaDT = I.MaDT AND I.MaDT = HOPDONG.MaDT
END
GO


--tong so chi nhanh
create TRIGGER KT_SOCHINHANHDK
ON ct_hopdong FOR INSERT, update
AS
BEGIN
	UPDATE dbo.HOPDONG
	SET SoChiNhanhDK = (select count(i.MaCNhanh)
						from ct_hopdong i
						where i.MaHD = dbo.HOPDONG.MaHD
						group by i.MaHD
						)
	from inserted i
	where i.mahd=hopdong.mahd
END
GO

create TRIGGER DIACHI_CN
ON ct_hopdong FOR INSERT,UPDATE
AS
BEGIN
	declare @diachi nvarchar(100)
	declare @sonha INT
	declare @sn nvarchar(100)
	declare @duong nvarchar(100)
	declare @phuong nvarchar(100)
	declare @quan nvarchar(100)
	declare @thanhpho nvarchar(100)

	set @sonha = (select cn.sonha_cn from chinhanh cn, inserted i 
				where i.madt=cn.madt and i.macnhanh=cn.macn)
	set @sn=cast(@sonha as nvarchar(100))
	set @duong = (select cn.duong_cn from chinhanh cn, inserted i 
				where i.madt=cn.madt and i.macnhanh=cn.macn)
	set @phuong = (select cn.phuong_cn from chinhanh cn, inserted i 
				where i.madt=cn.madt and i.macnhanh=cn.macn)
				set @duong = (select cn.duong_cn from chinhanh cn, inserted i 
				where i.madt=cn.madt and i.macnhanh=cn.macn)
	set @quan = (select cn.quan_cn from chinhanh cn, inserted i 
				where i.madt=cn.madt and i.macnhanh=cn.macn)

	set @thanhpho= (select cn.thanhpho_cn from chinhanh cn, inserted i 
				where i.madt=cn.madt and i.macnhanh=cn.macn)
	set @diachi= @sn + ', ' + @duong + ', ' + @phuong + ', ' + @quan + ', ' + @thanhpho
	update ct_hopdong
	set diachi_cn=@diachi
	from inserted i
	where ct_hopdong.mahd=i.mahd and ct_hopdong.madt=i.madt and ct_hopdong.macnhanh=i.macnhanh

END
GO

CREATE TRIGGER DIACHIGIAO_DH
ON DONHANG AFTER INSERT, UPDATE
AS
BEGIN
	declare @diachi nvarchar(100)
	declare @sonha INT
	declare @sn nvarchar(100)
	declare @duong nvarchar(100)
	declare @phuong nvarchar(100)
	declare @quan nvarchar(100)
	declare @thanhpho nvarchar(100)

	set @sonha = (select kh.sonha_kh from khachhang kh, inserted i 
				where i.makh=kh.makh )
	set @sn=cast(@sonha as nvarchar(100))
	set @duong = (select kh.duong_kh from khachhang kh, inserted i 
				where i.makh=kh.makh)
	set @phuong = (select kh.phuong_kh from khachhang kh, inserted i 
				where i.makh=kh.makh)
	set @quan = (select kh.quan_kh from khachhang kh, inserted i 
				where i.makh=kh.makh)

	set @thanhpho= (select kh.thanhpho_kh from khachhang kh, inserted i 
				where i.makh=kh.makh)
	set @diachi= @sn + ', ' + @duong + ', ' + @phuong + ', ' + @quan + ', ' + @thanhpho
	update donhang
	set diachigiao=@diachi
	from inserted i
	where i.madh=donhang.madh
END
GO

DROP TRIGGER  TINH_THANHTIEN
DROP TRIGGER TINH_GIATIEN
DROP TRIGGER TINH_THUNHAP_TX
DROP TRIGGER TINH_TONGTIEN
DROP TRIGGER TINH_PHIVANCHUYEN_TX
DROP TRIGGER TINH_DOANHTHU
DROP TRIGGER TINH_PHIHOAHONG
DROP TRIGGER KT_SOCHINHANHDK
DROP TRIGGER KT_HOPDONG_DOITAC
DROP TRIGGER KT_HOPDONG_CHINHANH
drop trigger diachigiao_khư
drop trigger diachi_cn