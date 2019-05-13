-- LIỆT KÊ PHÒNG HIỆN CÓ
CREATE PROCEDURE LietKeDanhMucPhong
AS
BEGIN
	SELECT MaPhong, Phong.MaLoaiPhong, FORMAT(DonGia, 'N0') DonGia, GhiChu
	FROM Phong JOIN LoaiPhong
	ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong
END
GO

-- LIỆT KÊ TÌNH TRẠNG PHÒNG HIỆN CÓ (ĐỂ ĐƯA DỮ LIỆU VÀO COMBOBOX)
CREATE PROCEDURE LietKeTinhTrangPhong
AS
BEGIN
	SELECT TenTinhTrang FROM TinhTrang
END
GO

-- LIỆT KÊ CÁC LOẠI PHÒNG HIỆN CÓ (ĐỂ ĐƯA DỮ LIỆU VÀO COMBOBOX)
CREATE PROCEDURE LietKeLoaiPhong
AS
BEGIN
	SELECT MaLoaiPhong FROM LoaiPhong
END
GO

-- TÌM GIÁ PHÒNG TỪ LOẠI PHÒNG (SAU KHI ĐÃ CHỌN LOẠI PHÒNG TRONG COMBOBOX)
CREATE PROCEDURE TimGiaPhong
	@MaLoaiPhong varchar(10)
AS
BEGIN
	SELECT FORMAT(DonGia, 'N0') DonGia
	FROM LoaiPhong
	WHERE MaLoaiPhong = @MaLoaiPhong
END
GO

-- TÌM TRẠNG THÁI PHÒNG TỪ MÃ PHÒNG
CREATE PROCEDURE TimTrangThaiPhong
	@MaPhong varchar(10)
AS
BEGIN
	SELECT TenTinhTrang
	FROM TinhTrang JOIN Phong
	ON TinhTrang.MaTinhTrang = Phong.MaTinhTrang
	WHERE MaPhong = @MaPhong
END
GO

-- KIỂM TRA PHÒNG CHỌN CÓ ĐANG ĐƯỢC THUÊ KHÔNG
CREATE PROCEDURE KiemTraPhongThue
	@MaPhong varchar(10)
AS
BEGIN
	SELECT COUNT(*)
	FROM Phong JOIN TinhTrang
	ON Phong.MaTinhTrang = TinhTrang.MaTinhTrang
	WHERE MaPhong = @MaPhong
	AND Phong.MaTinhTrang = 'PHTH'
END
GO

-- THÊM MỘT PHÒNG VÀO DANH MỤC PHÒNG
CREATE PROCEDURE ThemPhong
	@MaPhong varchar(10), 
	@MaLoaiPhong varchar(10),
	@TenTinhTrang nvarchar(30),
	@GhiChu nvarchar(50)
AS
BEGIN
	DECLARE @MaTinhTrang varchar(10)
	SET @MaTinhTrang =	(SELECT MaTinhTrang
						FROM TinhTrang
						WHERE TenTinhTrang = @TenTinhTrang)
	INSERT INTO Phong (MaPhong, MaLoaiPhong, MaTinhTrang, GhiChu)
	VALUES (@MaPhong, @MaLoaiPhong, @MaTinhTrang, @GhiChu)
END
GO

-- XOÁ MỘT PHÒNG TRONG DANH MỤC PHÒNG
CREATE PROCEDURE XoaPhong
	@MaPhong varchar(10)
AS
BEGIN
	DELETE Phong
	WHERE MaPhong = @MaPhong
END
GO

-- SỬA MỘT PHÒNG TRONG DANH MỤC PHÒNG
CREATE PROCEDURE SuaPhong
	@MaPhong varchar(10),
	@MaLoaiPhong varchar(10),
	@TenTinhTrang nvarchar(30),
	@GhiChu nvarchar(50)
AS
BEGIN
	DECLARE @MaTinhTrang varchar(10)
	SET @MaTinhTrang =	(SELECT MaTinhTrang
						FROM TinhTrang
						WHERE TenTinhTrang = @TenTinhTrang)
	UPDATE Phong
	SET MaLoaiPhong = @MaLoaiPhong, MaTinhTrang = @TenTinhTrang, GhiChu = @GhiChu
	WHERE MaPhong = @MaPhong
END
GO

-- ĐỌC TÁC DỤNG CỦA HÀM EXECUTE [COUNT] TRONG C# KHI THỰC THI CÂU LỆNH SQL