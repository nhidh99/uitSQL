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
	SELECT * FROM TinhTrang
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

-- KIỂM TRA MÃ PHÒNG CÓ BỊ TRÙNG KHÔNG
CREATE PROCEDURE KiemTraMaPhong
	@MaPhong varchar(10)
AS
BEGIN
	SELECT * FROM PHONG WHERE MaPhong = @MaPhong
END
GO

-- KIỂM TRA PHÒNG CHỌN CÓ ĐANG ĐƯỢC THUÊ KHÔNG
CREATE PROCEDURE KiemTraPhongThue
	@MaPhong varchar(10)
AS
BEGIN
	SELECT *
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
	@MaTinhTrang varchar(10),
	@GhiChu nvarchar(50) = null
AS
BEGIN
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
	@TenTinhTrang varchar(10),
	@GhiChu nvarchar(50) = null
AS
BEGIN
	UPDATE Phong
	SET MaLoaiPhong = @MaLoaiPhong, MaTinhTrang = @MaTinhTrang, GhiChu = @GhiChu
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

-- LIỆT KÊ CÁC PHÒNG ĐANG THUÊ SAU NGÀY CỤ THỂ
CREATE PROCEDURE LietKePhongThue
	@NgayThanhToan date
AS
BEGIN
	SELECT Phong.MaPhong
	FROM PhieuThue JOIN Phong
	ON PhieuThue.MaPhong = Phong.MaPhong
	WHERE MaTinhTrang = 'PHTH'
	AND NgayThue <= @NgayThanhToan
	ORDER BY MaPhong ASC
END
GO

-- TÌM CHI TIẾT THANH TOÁN (TỪ PHÒNG TRONG DANH SÁCH PHÒNG ĐANG ĐƯỢC THUÊ)
CREATE PROCEDURE TimChiTietThanhToan
	@MaPhong varchar(10),
	@NgayThanhToan date
AS
BEGIN
	DECLARE @DonGia money, @ThanhTien money, @PhuThuKhachThem money, @PhuThuKhachNuocNgoai money
	DECLARE @MaPhieu int, @SoNgayThue int, @SoKhach int

	SET @MaPhieu = (SELECT TOP 1 MaPhieu FROM PhieuThue WHERE MaPhong = @MaPhong ORDER BY MaPhieu DESC)
	SET @DonGia = (SELECT DonGia FROM PhieuThue WHERE MaPhieu = @MaPhieu)
	SET @SoNgayThue = (SELECT DATEDIFF(DAY, NgayThue, @NgayThanhToan) FROM PhieuThue WHERE MaPhieu = @MaPhieu)
	SET @ThanhTien = @SoNgayThue * (SELECT DonGia FROM PhieuThue WHERE MaPhieu = @MaPhieu) 
	SET @SoKhach = (SELECT COUNT(*) FROM CTPT WHERE MaPhieu = @MaPhieu)

	IF (@SoKhach >= 3)
	BEGIN
		SET @PhuThuKhachThem = @ThanhTien * (SELECT GiaTri FROM ThamSo WHERE MaThamSo = 'PTK3') * (@SoKhach - 2)
	END
	ELSE
	BEGIN
		SET @PhuThuKhachThem = 0
	END

	IF EXISTS (SELECT * FROM CTPT 
		JOIN LoaiKhach ON CTPT.MaLoaiKhach = LoaiKhach.MaLoaiKhach
		WHERE MaPhieu = @MaPhieu
		AND TenLoaiKhach = N'Nước ngoài')
	BEGIN
		SET @PhuThuKhachNuocNgoai = @ThanhTien * (SELECT GiaTri FROM ThamSo WHERE MaThamSo = 'PTNN')
	END
	ELSE
	BEGIN
		SET @PhuThuKhachNuocNgoai = 0
	END

	SET @ThanhTien = @ThanhTien + @PhuThuKhachNuocNgoai + @PhuThuKhachThem
	
	SELECT	@MaPhong AS MaPhong, FORMAT(@DonGia, 'N0') AS DonGia, @SoNgayThue AS SoNgayThue, FORMAT(@PhuThuKhachThem, 'N0') AS PhuThuKhachThuBa, 
			FORMAT(@PhuThuKhachNuocNgoai, 'N0') AS PhuThuKhachNuocNgoai, FORMAT(@ThanhTien, 'N0') AS ThanhTien
END

-- TẠO HOÁ ĐƠN THANH TOÁN PHÒNG
CREATE PROCEDURE ThemHoaDonThanhToan
	@TenKhach nvarchar(30),
	@DiaChi nvarchar(30),
	@NgayHoaDon date,
	@TriGia money
AS
BEGIN
	INSERT INTO HoaDon(TenKhach, DiaChi, NgayHoaDon, TriGia)
	VALUES (@TenKhach, @DiaChi, @NgayHoaDon, @TriGia)
END
GO

-- THANH TOÁN PHÒNG (SAU KHI TẠO HOÁ ĐƠN VÀ CÓ THÔNG TIN THANH TOÁN)
CREATE PROCEDURE ThemThongTinThanhToan
	@MaPhong varchar(10),
	@ThanhTien money
AS
BEGIN
	DECLARE @MaHoaDon varchar(10)	
	DECLARE @MaPhieu int

	SET @MaHoaDon = (SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY MaHoaDon DESC)
	SET @MaPhieu = (SELECT TOP 1 MaPhieu FROM PhieuThue WHERE MaPhong = @MaPhong ORDER BY MaPhieu DESC)
	
	UPDATE PhieuThue
	SET MaHoaDon = @MaHoaDon, ThanhTien = @ThanhTien
	WHERE MaPhieu = @MaPhieu
	
	UPDATE Phong
	SET MaTinhTrang = 'PHTR'
	WHERE MaPhong = @MaPhong
END
GO