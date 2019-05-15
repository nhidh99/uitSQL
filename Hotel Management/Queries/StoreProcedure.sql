-- LIỆT KÊ PHÒNG HIỆN CÓ
CREATE PROCEDURE LietKeDanhMucPhong
AS
BEGIN
	SELECT MaPhong, Phong.MaLoaiPhong, FORMAT(DonGia, 'N0') DonGia, TenTinhTrang, GhiChu
	FROM Phong 
		JOIN LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong
		JOIN TinhTrang ON Phong.MaTinhTrang = TinhTrang.MaTinhTrang
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
		SELECT MaLoaiPhong, FORMAT(DonGia, 'N0') DonGia FROM LoaiPhong
END
GO

-- TÌM GIÁ PHÒNG TỪ LOẠI PHÒNG (SAU KHI ĐÃ CHỌN LOẠI PHÒNG TRONG COMBOBOX)
CREATE PROCEDURE TimGiaTheoLoaiPhong
	@MaLoaiPhong varchar(10)
AS
BEGIN
	SELECT FORMAT(DonGia, 'N0') DonGia
	FROM LoaiPhong
	WHERE MaLoaiPhong = @MaLoaiPhong
END
GO

-- TÌM GIÁ PHÒNG TỪ MÃ PHÒNG (SAU KHI ĐÃ CHỌN MÃ PHÒNG TRONG COMBOBOX)
CREATE PROCEDURE TimGiaTheoMaPhong
	@MaPhong varchar(10)
AS
BEGIN
	SELECT FORMAT(DonGia, 'N0') DonGia
	FROM Phong JOIN LoaiPhong
	ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong
	WHERE MaPhong = @MaPhong
END
GO

-- TÌM TRẠNG THÁI PHÒNG TỪ MÃ PHÒNG
CREATE PROCEDURE TimTinhTrangPhong
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
	@GhiChu nvarchar(50) = null
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
	@GhiChu nvarchar(50) = null
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

-- LIỆT KÊ CÁC PHÒNG TRỐNG (CÓ THỂ THUÊ)
CREATE PROCEDURE LietKePhongTrong
AS
BEGIN
	SELECT MaPhong FROM Phong
	WHERE MaTinhTrang = 'PHTR'
	AND MaLoaiPhong IS NOT NULL
END
GO

-- LIỆT KÊ CÁC LOẠI KHÁCH HIỆN CÓ
CREATE PROCEDURE LietKeLoaiKhach
AS
BEGIN
	SELECT TenLoaiKhach
	FROM LoaiKhach
	WHERE KhaDung = 1
END
GO

-- LIỆT KÊ CHI TIẾT PHÒNG THEO MÃ
CREATE PROCEDURE TimMaLoaiPhong
	@MaPhong varchar(10)
AS
BEGIN
	SELECT MaLoaiPhong
	FROM Phong
	WHERE MaPhong = @MaPhong
END
GO

-- TÌM SỐ KHÁCH TỐI ĐA
CREATE PROCEDURE TimSoKhachToiDa
AS
BEGIN
	SELECT GiaTri AS SoKhachToiDa 
	FROM ThamSo
	WHERE MaThamSo = 'KHTD'
END
GO

-- LẬP PHIẾU THUÊ PHÒNG
CREATE PROCEDURE ThemPhieuThuePhong
	@MaPhong varchar(10),
	@NgayThue date,
	@LoaiPhong varchar(10),
	@DonGia money
AS
BEGIN
	INSERT INTO PhieuThue (MaPhong, NgayThue, LoaiPhong, DonGia)
	VALUES (@MaPhong, @NgayThue, @LoaiPhong, @DonGia)

	UPDATE Phong
	SET MaTinhTrang = 'PHTH'
	WHERE MaPhong = @MaPhong
END
GO

-- TÌM MÃ PHIẾU THUÊ PHÒNG GẦN NHẤT THEO MÃ PHÒNG
CREATE PROCEDURE TimMaPhieuGanNhat
	@MaPhong varchar(10)
AS
BEGIN
	SELECT TOP 1 MaPhieu
	FROM PhieuThue
	WHERE MaPhong = @MaPhong
	ORDER BY MaPhieu DESC
END
GO

-- THÊM CHI TIẾT PHIẾU THUÊ PHÒNG
CREATE PROCEDURE ThemChiTietPhieuThue
	@MaPhieu int,
	@CMND varchar(15),
	@TenKhach nvarchar(30),
	@TenLoaiKhach nvarchar(30),
	@DiaChi nvarchar(50)
AS
BEGIN
	DECLARE @MaLoaiKhach int
	SET @MaLoaiKhach = (SELECT MaLoaiKhach FROM LoaiKhach WHERE TenLoaiKhach = @TenLoaiKhach)
	
	INSERT INTO CTPT (MaPhieu, CMND, MaLoaiKhach, TenKhach, DiaChi)
	VALUES (@MaPhieu, @CMND, @MaLoaiKhach, @TenKhach, @DiaChi)
END
GO

-- TÌM KIẾM PHÒNG THEO ĐIỀU KIỆN
CREATE PROCEDURE TraCuuPhong
	@MaPhong       varchar(10) = null,
	@MaLoaiPhong   varchar(10) = null,
	@DonGia        money = null,
	@TenTinhTrang  nvarchar(30) = null 
AS 
BEGIN

	DECLARE @query NVARCHAR(MAX);

	SET @query = N'	SELECT MaPhong, Phong.MaLoaiPhong, FORMAT(DonGia, ''N0'') DonGia, TenTinhTrang, GhiChu
				FROM Phong 
					JOIN TinhTrang ON Phong.MaTinhTrang = TinhTrang.MaTinhTrang
					JOIN LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong'

       + CASE WHEN @MaPhong IS NOT NULL 
              THEN ' AND MaPhong = @MaPhong' ELSE N' ' END 

       + CASE WHEN @MaLoaiPhong IS NOT NULL 
              THEN ' AND MaLoaiPhong = @MaLoaiPhong' ELSE N' ' END 

       + CASE WHEN @DonGia IS NOT NULL 
	          THEN ' AND DonGia = @DonGia' ELSE N' ' END 

       + CASE WHEN @TenTinhTrang IS NOT NULL 
              THEN N' AND TenTinhTrang = @TenTinhTrang' ELSE N' ' END 

	EXECUTE SP_EXECUTESQL @query,
                    N'	@MaPhong varchar(10),
						@MaLoaiPhong varchar(10),
						@DonGia money,
						@TenTinhTrang nvarchar(30) '
                    ,@MaPhong
                    ,@MaLoaiPhong
                    ,@DonGia
                    ,@TenTinhTrang
END

-- LIỆT KÊ ĐƠN GIÁ PHÒNG
CREATE PROCEDURE LietKeDonGiaPhong
AS
BEGIN
	SELECT DISTINCT(FORMAT(DonGia, 'N0')) + ' VND' DonGia
	FROM LoaiPhong
	ORDER BY DonGia ASC
END
