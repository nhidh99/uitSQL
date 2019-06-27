-- LIỆT KÊ PHÒNG HIỆN CÓ (*)
CREATE PROCEDURE LietKeDanhMucPhong
AS
BEGIN
	SELECT MaPhong, Phong.MaLoaiPhong, FORMAT(DonGia, 'N0') DonGia, TenTinhTrang, GhiChu
	FROM Phong 
		JOIN LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong
		JOIN TinhTrang ON Phong.MaTinhTrang = TinhTrang.MaTinhTrang
END
GO

-- TÌM GIÁ PHÒNG TỪ MÃ PHÒNG (SAU KHI ĐÃ CHỌN MÃ PHÒNG TRONG COMBOBOX) (*)
CREATE PROCEDURE TimGiaTheoMaPhong
	@MaPhong varchar(10)
AS
BEGIN
	SELECT DonGia
	FROM Phong JOIN LoaiPhong
	ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong
	WHERE MaPhong = @MaPhong
END
GO

-- THÊM MỘT PHÒNG VÀO DANH MỤC PHÒNG (*)
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

-- SỬA MỘT PHÒNG TRONG DANH MỤC PHÒNG (*)
CREATE PROCEDURE SuaPhong
	@MaPhong varchar(10),
	@MaLoaiPhong varchar(10),
	@TenTinhTrang varchar(10),
	@GhiChu nvarchar(50) = null,
	@MaTinhTrang varchar(10)
AS
BEGIN
	UPDATE Phong
	SET MaLoaiPhong = @MaLoaiPhong, MaTinhTrang = @MaTinhTrang, GhiChu = @GhiChu
	WHERE MaPhong = @MaPhong
END
GO

-- LẬP PHIẾU THUÊ PHÒNG (*)
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

-- THÊM CHI TIẾT PHIẾU THUÊ PHÒNG (*)
CREATE PROCEDURE ThemChiTietPhieuThue
	@MaPhieu int,
	@CMND varchar(15),
	@TenKhach nvarchar(30),
	@MaLoaiKhach nvarchar(30),
	@DiaChi nvarchar(50)
AS
BEGIN	
	INSERT INTO CTPT (MaPhieu, CMND, MaLoaiKhach, TenKhach, DiaChi)
	VALUES (@MaPhieu, @CMND, @MaLoaiKhach, @TenKhach, @DiaChi)
END
GO

-- TÌM KIẾM PHÒNG THEO ĐIỀU KIỆN (*)
CREATE PROCEDURE TraCuuPhong
	@MaPhong       varchar(10) = null,
	@MaLoaiPhong   varchar(10) = null,
	@DonGia        money = null,
	@MaTinhTrang  varchar(10) = null 
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
              THEN ' AND Phong.MaLoaiPhong = @MaLoaiPhong' ELSE N' ' END 

       + CASE WHEN @DonGia IS NOT NULL 
	          THEN ' AND DonGia = @DonGia' ELSE N' ' END 

       + CASE WHEN @MaTinhTrang IS NOT NULL 
              THEN N' AND Phong.MaTinhTrang = @MaTinhTrang' ELSE N' ' END 

EXECUTE SP_EXECUTESQL @query,
                    N'	@MaPhong varchar(10),
						@MaLoaiPhong varchar(10),
						@DonGia money,
						@MaTinhTrang varchar(10) '
                    ,@MaPhong
                    ,@MaLoaiPhong
                    ,@DonGia
                    ,@MaTinhTrang
END
GO

-- LIỆT KÊ CÁC PHÒNG ĐANG THUÊ SAU NGÀY CỤ THỂ (*)
CREATE PROCEDURE LietKePhongThue
	@NgayThanhToan date
AS
BEGIN
	SELECT MaPhong
	FROM PhieuThue
	WHERE MaHoaDon IS NULL
	AND NgayThue <= @NgayThanhToan
	ORDER BY MaPhong ASC
END
GO

-- TÌM CHI TIẾT THANH TOÁN (TỪ PHÒNG TRONG DANH SÁCH PHÒNG ĐANG ĐƯỢC THUÊ) (*)
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
	
	SELECT	@MaPhong AS MaPhong, @DonGia AS DonGia, @SoNgayThue AS SoNgayThue, @PhuThuKhachThem AS PhuThuKhachThem, 
			@PhuThuKhachNuocNgoai AS PhuThuKhachNuocNgoai, @ThanhTien AS ThanhTien
END
GO

-- TẠO HOÁ ĐƠN THANH TOÁN PHÒNG (*)
CREATE PROCEDURE ThemHoaDon
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

-- THANH TOÁN PHÒNG (SAU KHI TẠO HOÁ ĐƠN VÀ CÓ THÔNG TIN THANH TOÁN) (*)
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

-- THỐNG KÊ DOANH THU CÁC LOẠI PHÒNG THEO THÁNG (*)
CREATE PROCEDURE BaoCaoDoanhThuThang
	@Thang int
AS
BEGIN
	DECLARE @TongDoanhThu MONEY
	SET @TongDoanhThu = (SELECT SUM(TriGia) FROM HoaDon WHERE MONTH(NgayHoaDon) = @Thang)

	SELECT LoaiPhong, SUM(ThanhTien) AS DoanhThu, (SUM(ThanhTien) / @TongDoanhThu * 100) AS TiLe
	FROM HoaDon JOIN PhieuThue
	ON HoaDon.MaHoaDon = PhieuThue.MaHoaDon
	WHERE MONTH(NgayHoaDon) = @Thang
	GROUP BY LoaiPhong
	ORDER BY LoaiPhong
END
GO

-- THÊM LOẠI KHÁCH (*)
CREATE PROCEDURE ThemLoaiKhach
	@TenLoaiKhach nvarchar(30)
AS
BEGIN
	IF (EXISTS (SELECT * FROM LoaiKhach WHERE TenLoaiKhach = @TenLoaiKhach))
	BEGIN
		UPDATE LoaiKhach
		SET KhaDung = 1
		WHERE TenLoaiKhach = @TenLoaiKhach
	END
	ELSE
	BEGIN
		INSERT INTO LoaiKhach(TenLoaiKhach, KhaDung)
		VALUES (@TenLoaiKhach, 1)
	END
END
GO

-- XOÁ LOẠI KHÁCH (*)
CREATE PROCEDURE XoaLoaiKhach
	@TenLoaiKhach nvarchar(30)
AS
BEGIN
	IF (EXISTS (SELECT * FROM CTPT JOIN LoaiKhach 
				ON CTPT.MaLoaiKhach = LoaiKhach.MaLoaiKhach
				WHERE TenLoaiKhach = @TenLoaiKhach))
	BEGIN
		UPDATE LoaiKhach
		SET KhaDung = 0
		WHERE TenLoaiKhach = @TenLoaiKhach
	END
	ELSE
	BEGIN
		DELETE LoaiKhach
		WHERE TenLoaiKhach = @TenLoaiKhach
	END
END
GO

-- ĐĂNG NHẬP (*)
CREATE PROCEDURE DangNhap
	@TenDangNhap varchar(30),
	@MatKhau varchar(30)
AS
BEGIN
	SELECT PhanQuyen FROM PhanQuyen
	WHERE TenDangNhap = @TenDangNhap
	AND MatKhau = (@MatKhau COLLATE Latin1_General_CS_AS)
END
GO

