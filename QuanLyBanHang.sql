-- QUẢN LÍ BÁN HÀNG
CREATE DATABASE QuanLyBanHang
GO

USE QuanLyBanHang
GO

-- Tạo bảng KHACHHANG
CREATE TABLE KHACHHANG
(
	MAKH CHAR(4),
	HOTEN VARCHAR(40),
	DCHI VARCHAR(50),
	SODT VARCHAR(20),
	NGSINH SMALLDATETIME,
	NGDK SMALLDATETIME,
	DOANHSO MONEY,
	CONSTRAINT PK_KHACHHANG PRIMARY KEY (MAKH)
)

-- Tạo bảng NHANVIEN
CREATE TABLE NHANVIEN
(
	MANV CHAR(4),
	HOTEN VARCHAR(40),
	SODT VARCHAR(20),
	NGVL SMALLDATETIME
	CONSTRAINT PK_NHANVIEN PRIMARY KEY (MANV)
)

-- Tạo bảng SANPHAM
CREATE TABLE SANPHAM
(
	MASP CHAR(4),
	TENSP VARCHAR(40),
	DVT VARCHAR(20),
	NUOCSX VARCHAR(40),
	GIA MONEY
	CONSTRAINT PK_SANPHAM PRIMARY KEY (MASP)
)

-- Tạo bảng HOADON
CREATE TABLE HOADON
(
	SOHD INT,
	NGHD SMALLDATETIME,
	MAKH CHAR(4),
	MANV CHAR(4),
	TRIGIA MONEY
	CONSTRAINT PK_HOADON PRIMARY KEY (SOHD),
	CONSTRAINT FK_MAKH FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	CONSTRAINT FK_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)

-- Tạo bảng CTHD (Chi tiết hóa đơn)
CREATE TABLE CTHD
(
	SOHD INT,
	MASP CHAR(4),
	SL INT,
	CONSTRAINT PK_CTHD PRIMARY KEY (SOHD, MASP),
	CONSTRAINT FK_MASP FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP)
)

-- I.2 Thêm vào thuộc tính GHICHU có kiểu dữ liệu varchar(20) cho quan hệ SANPHAM
ALTER TABLE SANPHAM
ADD GHICHU VARCHAR(20)

-- I.3 Thêm vào thuộc tính LOAIKH có kiểu dữ liệu là tinyint cho quan hệ KHACHHANG
ALTER TABLE KHACHHANG
ADD LOAIKH TINYINT

-- I.4 Sửa kiểu dữ liệu của thuộc tính GHICHU trong quan hệ SANPHAM thành varchar(100)
ALTER TABLE SANPHAM
ALTER COLUMN GHICHU VARCHAR(100)

-- I.5 Xóa thuộc tính GHICHU trong quan hệ SANPHAM
ALTER TABLE SANPHAM
DROP COLUMN GHICHU

-- I.6 Làm thế nào để thuộc tính LOAIKH trong quan hệ KHACHHANG có thể lưu các giá trị là: “Vang lai”, “Thuong xuyen”, “Vip”, … 
ALTER TABLE KHACHHANG
ALTER COLUMN LOAIKH VARCHAR(8)

ALTER TABLE KHACHHANG
ADD CONSTRAINT CHK_LOAIKH
CHECK (LOAIKH IN ('Vang lai', 'Thuong xuyen', 'Vip'))

-- I.7 Đơn vị tính của sản phẩm chỉ có thể là (“cay”,”hop”,”cai”,”quyen”,”chuc”)
ALTER TABLE SANPHAM
ADD CONSTRAINT CHK_DVT
CHECK (DVT IN ('cay', 'hop', 'cai', 'quyen', 'chuc'))

-- I.8 Giá bán của sản phẩm từ 500 đồng trở lên
ALTER TABLE SANPHAM
ADD CONSTRAINT CHK_GIA
CHECK (GIA >= 500)

-- I.9 Mỗi lần mua hàng, khách hàng phải mua ít nhất 1 sản phẩm
ALTER TABLE CTHD
ADD CONSTRAINT CHK_SL
CHECK (SL >= 1)

-- I.10 Ngày khách hàng đăng ký là khách hàng thành viên phải lớn hơn ngày sinh của người đó
ALTER TABLE KHACHHANG
ADD CONSTRAINT CHK_NGDK
CHECK (NGDK > NGSINH)

-- II.1 Nhập dữ liệu cho các quan hệ trên
SET DATEFORMAT DMY

-- Nhập dữ liệu cho KHACHHANG
INSERT INTO KHACHHANG VALUES('KH01','Nguyen Van A','731 Tran Hung Dao, Q5, TpHCM','8823451','22/10/1960','22/07/2006',13060000)
INSERT INTO KHACHHANG VALUES('KH02','Tran Ngoc Han','23/5 Nguyen Trai, Q5, TpHCM','908256478','03/04/1974','30/07/2006',280000)
INSERT INTO KHACHHANG VALUES('KH03','Tran Ngoc Linh','45 Nguyen Canh Chan, Q1, TpHCM','938776266','12/06/1980','08/05/2006',3860000)
INSERT INTO KHACHHANG VALUES('KH04','Tran Minh Long','50/34 Le Dai Hanh, Q10, TpHCM','917325476','09/03/1965','10/02/2006',250000)
INSERT INTO KHACHHANG VALUES('KH05','Le Nhat Minh','34 Truong Dinh, Q3, TpHCM','8246108','10/03/1950','28/10/2006',21000)
INSERT INTO KHACHHANG VALUES('KH06','Le Hoai Thuong','227 Nguyen Van Cu, Q5, TpHCM','8631738','31/12/1981','24/11/2006',915000)
INSERT INTO KHACHHANG VALUES('KH07','Nguyen Van Tam','32/3 Tran Binh Trong, Q5, TpHCM','916783565','06/04/1971','12/01/2006',12500)
INSERT INTO KHACHHANG VALUES('KH08','Phan Thi Thanh','45/2 An Duong Vuong, Q5, TpHCM','938435756','10/01/1971','13/12/2006',365000)
INSERT INTO KHACHHANG VALUES('KH09','Le Ha Vinh','873 Le Hong Phong, Q5, TpHCM','8654763','03/09/1979','14/01/2007',70000)
INSERT INTO KHACHHANG VALUES('KH10','Ha Duy Lap','34/34B Nguyen Trai, Q1, TpHCM','8768904','02/05/1983','16/01/2007',67500)

-- Nhập dữ liệu cho NHANVIEN
INSERT INTO NHANVIEN VALUES('NV01','Nguyen Nhu Nhut','927345678','13/04/2006')
INSERT INTO NHANVIEN VALUES('NV02','Le Thi Phi Yen','987567390','21/04/2006')
INSERT INTO NHANVIEN VALUES('NV03','Nguyen Van B','997047382','27/04/2006')
INSERT INTO NHANVIEN VALUES('NV04','Ngo Thanh Tuan','913758498','24/06/2006')
INSERT INTO NHANVIEN VALUES('NV05','Nguyen Thi Truc Thanh','918590387','20/07/2006')

-- Nhập dữ liệu cho SANPHAM
INSERT INTO SANPHAM VALUES('BC01','But chi','cay','Singapore',3000)
INSERT INTO SANPHAM VALUES('BC02','But chi','cay','Singapore',5000)
INSERT INTO SANPHAM VALUES('BC03','But chi','cay','Viet Nam',3500)
INSERT INTO SANPHAM VALUES('BC04','But chi','hop','Viet Nam',30000)
INSERT INTO SANPHAM VALUES('BB01','But bi','cay','Viet Nam',5000)
INSERT INTO SANPHAM VALUES('BB02','But bi','cay','Trung Quoc',7000)
INSERT INTO SANPHAM VALUES('BB03','But bi','hop','Thai Lan',100000)
INSERT INTO SANPHAM VALUES('TV01','Tap 100 giay mong','quyen','Trung Quoc',2500)
INSERT INTO SANPHAM VALUES('TV02','Tap 200 giay mong','quyen','Trung Quoc',4500)
INSERT INTO SANPHAM VALUES('TV03','Tap 100 giay tot','quyen','Viet Nam',3000)
INSERT INTO SANPHAM VALUES('TV04','Tap 200 giay tot','quyen','Viet Nam',5500)
INSERT INTO SANPHAM VALUES('TV05','Tap 100 trang','chuc','Viet Nam',23000)
INSERT INTO SANPHAM VALUES('TV06','Tap 200 trang','chuc','Viet Nam',53000)
INSERT INTO SANPHAM VALUES('TV07','Tap 100 trang','chuc','Trung Quoc',34000)
INSERT INTO SANPHAM VALUES('ST01','So tay 500 trang','quyen','Trung Quoc',40000)
INSERT INTO SANPHAM VALUES('ST02','So tay loai 1','quyen','Viet Nam',55000)
INSERT INTO SANPHAM VALUES('ST03','So tay loai 2','quyen','Viet Nam',51000)
INSERT INTO SANPHAM VALUES('ST04','So tay','quyen','Thai Lan',55000)
INSERT INTO SANPHAM VALUES('ST05','So tay mong','quyen','Thai Lan',20000)
INSERT INTO SANPHAM VALUES('ST06','Phan viet bang','hop','Viet Nam',5000)
INSERT INTO SANPHAM VALUES('ST07','Phan khong bui','hop','Viet Nam',7000)
INSERT INTO SANPHAM VALUES('ST08','Bong bang','cai','Viet Nam',1000)
INSERT INTO SANPHAM VALUES('ST09','But long','cay','Viet Nam',5000)
INSERT INTO SANPHAM VALUES('ST10','But long','cay','Trung Quoc',7000)

-- Nhập dữ liệu cho HOADON
INSERT INTO HOADON VALUES(1001,'23/07/2006','KH01','NV01',320000)
INSERT INTO HOADON VALUES(1002,'12/08/2006','KH01','NV02',840000)
INSERT INTO HOADON VALUES(1003,'23/08/2006','KH02','NV01',100000)
INSERT INTO HOADON VALUES(1004,'01/09/2006','KH02','NV01',180000)
INSERT INTO HOADON VALUES(1005,'20/10/2006','KH01','NV02',3800000)
INSERT INTO HOADON VALUES(1006,'16/10/2006','KH01','NV03',2430000)
INSERT INTO HOADON VALUES(1007,'28/10/2006','KH03','NV03',510000)
INSERT INTO HOADON VALUES(1008,'28/10/2006','KH01','NV03',440000)
INSERT INTO HOADON VALUES(1009,'28/10/2006','KH03','NV04',200000)
INSERT INTO HOADON VALUES(1010,'01/11/2006','KH01','NV01',5200000)
INSERT INTO HOADON VALUES(1011,'04/11/2006','KH04','NV03',250000)
INSERT INTO HOADON VALUES(1012,'30/11/2006','KH05','NV03',21000)
INSERT INTO HOADON VALUES(1013,'12/12/2006','KH06','NV01',5000)
INSERT INTO HOADON VALUES(1014,'31/12/2006','KH03','NV02',3150000)
INSERT INTO HOADON VALUES(1015,'01/01/2007','KH06','NV01',910000)
INSERT INTO HOADON VALUES(1016,'01/01/2007','KH07','NV02',12500)
INSERT INTO HOADON VALUES(1017,'02/01/2007','KH08','NV03',35000)
INSERT INTO HOADON VALUES(1018,'13/01/2007','KH08','NV03',330000)
INSERT INTO HOADON VALUES(1019,'13/01/2007','KH01','NV03',30000)
INSERT INTO HOADON VALUES(1020,'14/01/2007','KH09','NV04',70000)
INSERT INTO HOADON VALUES(1021,'16/01/2007','KH10','NV03',67500)
INSERT INTO HOADON VALUES(1022,'16/01/2007',Null,'NV03',7000)
INSERT INTO HOADON VALUES(1023,'17/01/2007',Null,'NV01',330000)

-- Nhập dữ liệu cho CTHD
INSERT INTO CTHD VALUES(1001,'TV02',10)
INSERT INTO CTHD VALUES(1001,'ST01',5)
INSERT INTO CTHD VALUES(1001,'BC01',5)
INSERT INTO CTHD VALUES(1001,'BC02',10)
INSERT INTO CTHD VALUES(1001,'ST08',10)
INSERT INTO CTHD VALUES(1002,'BC04',20)
INSERT INTO CTHD VALUES(1002,'BB01',20)
INSERT INTO CTHD VALUES(1002,'BB02',20)
INSERT INTO CTHD VALUES(1003,'BB03',10)
INSERT INTO CTHD VALUES(1004,'TV01',20)
INSERT INTO CTHD VALUES(1004,'TV02',10)
INSERT INTO CTHD VALUES(1004,'TV03',10)
INSERT INTO CTHD VALUES(1004,'TV04',10)
INSERT INTO CTHD VALUES(1005,'TV05',50)
INSERT INTO CTHD VALUES(1005,'TV06',50)
INSERT INTO CTHD VALUES(1006,'TV07',20)
INSERT INTO CTHD VALUES(1006,'ST01',30)
INSERT INTO CTHD VALUES(1006,'ST02',10)
INSERT INTO CTHD VALUES(1007,'ST03',10)
INSERT INTO CTHD VALUES(1008,'ST04',8)
INSERT INTO CTHD VALUES(1009,'ST05',10)
INSERT INTO CTHD VALUES(1010,'TV07',50)
INSERT INTO CTHD VALUES(1010,'ST07',50)
INSERT INTO CTHD VALUES(1010,'ST08',100)
INSERT INTO CTHD VALUES(1010,'ST04',50)
INSERT INTO CTHD VALUES(1010,'TV03',100)
INSERT INTO CTHD VALUES(1011,'ST06',50)
INSERT INTO CTHD VALUES(1012,'ST07',3)
INSERT INTO CTHD VALUES(1013,'ST08',5)
INSERT INTO CTHD VALUES(1014,'BC02',80)
INSERT INTO CTHD VALUES(1014,'BB02',100)
INSERT INTO CTHD VALUES(1014,'BC04',60)
INSERT INTO CTHD VALUES(1014,'BB01',50)
INSERT INTO CTHD VALUES(1015,'BB02',30)
INSERT INTO CTHD VALUES(1015,'BB03',7)
INSERT INTO CTHD VALUES(1016,'TV01',5)
INSERT INTO CTHD VALUES(1017,'TV02',1)
INSERT INTO CTHD VALUES(1017,'TV03',1)
INSERT INTO CTHD VALUES(1017,'TV04',5)
INSERT INTO CTHD VALUES(1018,'ST04',6)
INSERT INTO CTHD VALUES(1019,'ST05',1)
INSERT INTO CTHD VALUES(1019,'ST06',2)
INSERT INTO CTHD VALUES(1020,'ST07',10)
INSERT INTO CTHD VALUES(1021,'ST08',5)
INSERT INTO CTHD VALUES(1021,'TV01',7)
INSERT INTO CTHD VALUES(1021,'TV02',10)
INSERT INTO CTHD VALUES(1022,'ST07',1)
INSERT INTO CTHD VALUES(1023,'ST04',6)


-- II.2 Tạo quan hệ SANPHAM1 chứa toàn bộ dữ liệu của quan hệ SANPHAM
-- Tạo quan hệ KHACHHANG1 chứa toàn bộ dữ liệu của quan hệ KHACHHANG
SELECT * INTO SANPHAM1
FROM SANPHAM

SELECT * INTO KHACHHANG1
FROM KHACHHANG

-- II.3 Cập nhật giá tăng 5% đối với những sản phẩm do “Thai Lan” sản xuất (cho quan hệ SANPHAM1)
UPDATE SANPHAM1
SET GIA = 1.05 * GIA
WHERE NUOCSX = 'Thai Lan'

-- II.4 Cập nhật giá giảm 5% đối với những sản phẩm do “Trung Quoc” sản xuất có giá từ 10.000 trở xuống (cho quan hệ SANPHAM1)
UPDATE SANPHAM1
SET GIA = 0.95 * GIA
WHERE NUOCSX = 'Trung Quoc' AND GIA <= 10000


-- II.5 Cập nhật giá trị LOAIKH là “Vip” đối với những khách hàng đăng ký thành viên trước ngày 1/1/2007 có doanh số từ 10.000.000
-- trở lên hoặc khách hàng đăng ký thành viên từ 1/1/2007 trở về sau có doanh số từ 2.000.000 trở lên (cho quan hệ KHACHHANG1). 
UPDATE KHACHHANG1
SET LOAIKH = 'Vip'
WHERE (NGDK < '1/1/2007' AND DOANHSO >= 10000000)
OR (NGDK >= '1/1/2007' AND DOANHSO >= 2000000)

-- III.1 In ra danh sách các sản phẩm (MASP,TENSP) do “Trung Quoc” sản xuất
SELECT MASP, TENSP
FROM SANPHAM
WHERE NUOCSX = 'Trung Quoc'

-- III.2 In ra danh sách các sản phẩm (MASP, TENSP) có đơn vị tính là “cay”, ”quyen”
SELECT MASP, TENSP
FROM SANPHAM
WHERE DVT in ('cay', 'quyen')

-- III.3 In ra danh sách các sản phẩm (MASP,TENSP) có mã sản phẩm bắt đầu là “B” và kết thúc là “01”
SELECT MASP, TENSP
FROM SANPHAM
WHERE MASP LIKE 'B_01'

-- III.4 In ra danh sách các sản phẩm (MASP,TENSP) do “Trung Quốc” sản xuất có giá từ 30.000 đến 40.000
SELECT MASP, TENSP
FROM SANPHAM
WHERE NUOCSX = 'Trung Quoc' AND GIA BETWEEN 30000 AND 40000

-- III.5 In ra danh sách các sản phẩm (MASP,TENSP) do “Trung Quoc” hoặc “Thai Lan” sản xuất có giá từ 30.000 đến 40.000
SELECT MASP, TENSP
FROM SANPHAM
WHERE NUOCSX IN ('Trung Quoc', 'Thai Lan') AND GIA BETWEEN 30000 AND 40000

-- III.6 In ra các số hóa đơn, trị giá hóa đơn bán ra trong ngày 1/1/2007 và ngày 2/1/2007
SET DATEFORMAT DMY
SELECT SOHD, TRIGIA
FROM HOADON
WHERE NGHD IN ('1/1/2007', '2/1/2007')

-- III.7 In ra các số hóa đơn, trị giá hóa đơn trong tháng 1/2007
-- sắp xếp theo ngày (tăng dần) và trị giá của hóa đơn (giảm dần)
SELECT SOHD, TRIGIA
FROM HOADON
WHERE MONTH(NGHD) = 1 AND YEAR(NGHD) = 2007
ORDER BY NGHD ASC, TRIGIA DESC

-- III.8 In ra danh sách các khách hàng (MAKH, HOTEN) đã mua hàng trong ngày 1/1/2007
SELECT DISTINCT KH.MAKH, KH.HOTEN
FROM KHACHHANG KH
	INNER JOIN HOADON HD
	ON KH.MAKH = HD.MAKH
WHERE NGHD = '1/1/2007'

-- III.9 In ra số hóa đơn, trị giá các hóa đơn do nhân viên có tên “Nguyen Van B” lập trong ngày 28/10/2006
SET DATEFORMAT DMY
SELECT SOHD, TRIGIA
FROM HOADON HD
	INNER JOIN NHANVIEN NV
	ON HD.MANV = NV.MANV
WHERE HOTEN = 'Nguyen Van B' AND NGHD = '28/10/2006'

-- III.10 In ra danh sách các sản phẩm (MASP,TENSP) được khách hàng có tên “Nguyen Van A” mua trong tháng 10/2006
SELECT DISTINCT SP.MASP, SP.TENSP
FROM HOADON HD
	INNER JOIN KHACHHANG KH ON HD.MAKH = KH.MAKH
	INNER JOIN CTHD CT ON HD.SOHD = CT.SOHD
	INNER JOIN SANPHAM SP ON CT.MASP = SP.MASP
WHERE KH.HOTEN = 'Nguyen Van A' AND MONTH(NGHD) = 10 AND YEAR(NGHD) = 2006

-- III.11 Tìm các số hóa đơn đã mua sản phẩm có mã số “BB01” hoặc “BB02”.
SELECT DISTINCT HD.SOHD
FROM HOADON HD
	INNER JOIN CTHD CT
	ON HD.SOHD = CT.SOHD
WHERE MASP IN ('BB01', 'BB02')

-- III.12 Tìm các số hóa đơn đã mua sản phẩm có mã số “BB01” hoặc “BB02”, mỗi sản phẩm mua với số lượng từ 10 đến 20
SELECT DISTINCT HD.SOHD
FROM HOADON HD
	INNER JOIN CTHD CT
	ON HD.SOHD = CT.SOHD
WHERE MASP IN ('BB01', 'BB02') AND SL BETWEEN 10 AND 20

-- III.13 Tìm các số hóa đơn mua cùng lúc 2 sản phẩm có mã số “BB01” và “BB02”, mỗi sản phẩm mua với số lượng từ 10 đến 20
SELECT SOHD
FROM CTHD
WHERE MASP = 'BB01' AND SL BETWEEN 10 AND 20
INTERSECT 
(
	SELECT SOHD
	FROM CTHD
	WHERE MASP = 'BB02' AND SL BETWEEN 10 AND 20
)

-- III.13 (Cách 2)
SELECT SOHD
FROM CTHD A
WHERE MASP = 'BB01'
AND SL BETWEEN 10 AND 20
AND EXISTS
	(SELECT *
	FROM CTHD B
	WHERE MASP = 'BB02'
	AND SL BETWEEN 10 AND 20)

-- III.14 In ra danh sách các sản phẩm (MASP,TENSP) do “Trung Quoc” sản xuất
-- hoặc các sản phẩm được bán ra trong ngày 1/1/2007
SELECT MASP, TENSP
FROM SANPHAM
WHERE NUOCSX = 'Trung Quoc'
OR MASP IN (SELECT MASP
			FROM CTHD CT
				INNER JOIN HOADON HD 
				ON HD.SOHD = CT.SOHD
			WHERE NGHD = '1/1/2007')

-- III.15 In ra danh sách các sản phẩm (MASP,TENSP) không bán được
SELECT MASP, TENSP
FROM SANPHAM
WHERE MASP IN
	((SELECT MASP FROM SANPHAM) EXCEPT (SELECT MASP FROM CTHD))

-- III.16 In ra danh sách các sản phẩm (MASP,TENSP) không bán được trong năm 2006
SELECT MASP, TENSP
FROM SANPHAM
WHERE MASP IN
		((SELECT MASP FROM SANPHAM) 
		EXCEPT (SELECT MASP
				FROM CTHD CT 
					INNER JOIN HOADON HD
					ON CT.SOHD = HD.SOHD
				WHERE YEAR(NGHD) = 2006))

-- III.17 In ra danh sách các sản phẩm (MASP,TENSP) do “Trung Quoc” sản xuất không bán được trong năm 2006. 
SELECT MASP, TENSP
FROM SANPHAM
WHERE MASP IN
		((SELECT MASP FROM SANPHAM WHERE NUOCSX = 'Trung Quoc')
		EXCEPT (SELECT MASP
				FROM CTHD CT 
					INNER JOIN HOADON HD
					ON CT.SOHD = HD.SOHD
				WHERE YEAR(NGHD) = 2006))

-- III.18 Tìm số hóa đơn đã mua tất cả các sản phẩm do Singapore sản xuất
SELECT DISTINCT CT1.SOHD
FROM CTHD CT1
WHERE NOT EXISTS (
	SELECT *
		FROM SANPHAM SP
		WHERE NUOCSX = 'Singapore'
		AND NOT EXISTS (
			SELECT *
			FROM CTHD CT2
			WHERE CT1.SOHD = CT2.SOHD AND CT2.MASP = SP.MASP
		))

-- III.19 Tìm số hóa đơn trong năm 2006 đã mua ít nhất tất cả các sản phẩm do Singapore sản xuất
SELECT DISTINCT SOHD
FROM HOADON HD
WHERE YEAR(NGHD) = 2006
AND NOT EXISTS (
	SELECT *
	FROM SANPHAM SP
	WHERE NUOCSX = 'Singapore'
	AND NOT EXISTS (
		SELECT *
		FROM CTHD CT
		WHERE HD.SOHD = CT.SOHD AND CT.MASP = SP.MASP
	))

-- III.20 Có bao nhiêu hóa đơn không phải của khách hàng đăng ký thành viên mua?
SELECT COUNT(SOHD) DEM_HD_NOT_TV
FROM HOADON
WHERE MAKH IS NULL

-- III.21 Có bao nhiêu sản phẩm khác nhau được bán ra trong năm 2006
SELECT COUNT(DISTINCT MASP) DEM_SP_2006
FROM HOADON HD 
	INNER JOIN CTHD CT
	ON HD.SOHD = CT.SOHD
WHERE YEAR(NGHD) = 2006

-- III.22 Cho biết trị giá hóa đơn cao nhất, thấp nhất là bao nhiêu ?
SELECT MIN(TRIGIA) MIN_HD_GIATRI, MAX(TRIGIA) MAX_HD_GIATRI
FROM HOADON

-- III.23 Trị giá trung bình của tất cả các hóa đơn được bán ra trong năm 2006 là bao nhiêu
SELECT AVG(TRIGIA) AVG_HD_GIATRI
FROM HOADON
WHERE YEAR(NGHD) = 2006

-- III.24 Tính doanh thu bán hàng trong năm 2006
SELECT SUM(TRIGIA) DOANHTHU_2006
FROM HOADON
WHERE YEAR(NGHD) = 2006

-- III.25 Tìm số hóa đơn có trị giá cao nhất trong năm 2006
SELECT SOHD
FROM HOADON
WHERE TRIGIA = (SELECT MAX(TRIGIA) FROM HOADON)

-- III.26 Tìm họ tên khách hàng đã mua hóa đơn có trị giá cao nhất trong năm 2006
SELECT HOTEN
FROM HOADON HD
	INNER JOIN KHACHHANG KH
	ON HD.MAKH = KH.MAKH
WHERE TRIGIA = (
	SELECT MAX(TRIGIA) 
	FROM HOADON 
	WHERE YEAR(NGHD) = 2006
)

--  III.27 In ra danh sách 3 khách hàng (MAKH, HOTEN) có doanh số cao nhất
SELECT TOP 3 MAKH, HOTEN
FROM KHACHHANG
ORDER BY DOANHSO DESC

-- III.28 In ra danh sách các sản phẩm (MASP, TENSP) có giá bán bằng 1 trong 3 mức giá cao nhất.
SELECT MASP, TENSP
FROM SANPHAM
WHERE GIA IN (
	SELECT DISTINCT TOP 3 GIA 
	FROM SANPHAM 
	ORDER BY GIA DESC
)

-- III.29 In ra danh sách các sản phẩm (MASP, TENSP) do “Thai Lan” sản xuất có giá bằng 1 trong 3 mức giá cao nhất (của tất cả các sản phẩm)
SELECT MASP, TENSP
FROM SANPHAM
WHERE NUOCSX = 'Thai Lan'
AND GIA IN (
	SELECT DISTINCT TOP 3 GIA 
	FROM SANPHAM 
	ORDER BY GIA DESC
)

-- III.30 In ra danh sách các sản phẩm (MASP, TENSP) do “Trung Quoc” sản xuất có giá bằng 1 trong 3 mức giá cao nhất (của sản phẩm do “Trung Quoc” sản xuất)
SELECT MASP, TENSP
FROM SANPHAM
WHERE NUOCSX = 'Trung Quoc'
AND GIA IN (
	SELECT DISTINCT TOP 3 GIA 
	FROM SANPHAM 
	ORDER BY GIA DESC
)

-- III.31 In ra danh sách 3 khách hàng có doanh số cao nhất (sắp xếp theo kiểu xếp hạng)
SELECT TOP 3 *
FROM KHACHHANG
ORDER BY DOANHSO DESC

-- III.32 Tính tổng số sản phẩm do “Trung Quoc” sản xuất
SELECT COUNT(MASP) DEM_SP_TQ
FROM SANPHAM
WHERE NUOCSX = 'Trung Quoc'

-- III.33 Tính tổng số sản phẩm của từng nước sản xuất
SELECT NUOCSX, COUNT(MASP) SOSP
FROM SANPHAM
GROUP BY NUOCSX

-- III.34 Với từng nước sản xuất, tìm giá bán cao nhất, thấp nhất, trung bình của các sản phẩm
SELECT NUOCSX, MAX(GIA) MAX_GIA, MIN(GIA) MIN_GIA, AVG(GIA) TB_GIA
FROM SANPHAM
GROUP BY NUOCSX

-- III.35 Tính doanh thu bán hàng mỗi ngày
SELECT NGHD, SUM(TRIGIA) DOANHTHU
FROM HOADON
GROUP BY NGHD

--- III.36 Tính tổng số lượng của từng sản phẩm bán ra trong tháng 10/2006
SELECT SP.MASP, SP.TENSP, COUNT(SL) TONGSL
FROM SANPHAM SP
	INNER JOIN CTHD CT ON SP.MASP = CT.MASP
	INNER JOIN HOADON HD ON CT.SOHD = HD.SOHD
GROUP BY SP.MASP, SP.TENSP, MONTH(NGHD), YEAR(NGHD)
HAVING MONTH(NGHD) = 10 AND YEAR(NGHD) = 2006

-- III.37 Tính doanh thu bán hàng của từng tháng trong năm 2006
SELECT MONTH(NGHD) THANG, SUM(TRIGIA) DOANHTHU
FROM HOADON
WHERE YEAR(NGHD) = 2006
GROUP BY MONTH(NGHD)

-- III.38 Tìm hóa đơn có mua ít nhất 4 sản phẩm khác nhau
SELECT SOHD
FROM CTHD
GROUP BY SOHD
HAVING COUNT(DISTINCT MASP) >= 4

-- III.39 Tìm hóa đơn có mua 3 sản phẩm do “Viet Nam” sản xuất (3 sản phẩm khác nhau). 
SELECT SOHD
FROM (SELECT SOHD, CT.MASP, NUOCSX
	FROM CTHD CT
	INNER JOIN SANPHAM SP
	ON CT.MASP = SP.MASP) AS A
GROUP BY SOHD, NUOCSX
HAVING NUOCSX = 'Viet Nam' AND COUNT(DISTINCT MASP) >= 3

-- III.40 Tìm khách hàng (MAKH, HOTEN) có số lần mua hàng nhiều nhất
SELECT MAKH, HOTEN
FROM KHACHHANG
WHERE MAKH = (
		SELECT TOP 1 MAKH
		FROM HOADON
		GROUP BY MAKH
		ORDER BY COUNT(SOHD) DESC
	)

-- III.41 Tháng mấy trong năm 2006, doanh số bán hàng cao nhất
SELECT TOP 1 MONTH(NGHD) THANG_DT_MAX
FROM HOADON
GROUP BY MONTH(NGHD), YEAR(NGHD)
HAVING YEAR(NGHD) = 2006
ORDER BY SUM(TRIGIA) DESC

-- III.42 Tìm sản phẩm (MASP, TENSP) có tổng số lượng bán ra thấp nhất trong năm 2006
SELECT MASP, TENSP
FROM SANPHAM
WHERE MASP = (
	SELECT TOP 1 MASP
	FROM (SELECT MASP, SL
		FROM CTHD CT
		INNER JOIN HOADON HD
		ON CT.SOHD = HD.SOHD
		WHERE YEAR(NGHD) = 2006
	) AS CT_HD
	GROUP BY MASP
	ORDER BY SUM(SL) ASC
)

-- III.43 Mỗi nước sản xuất, tìm sản phẩm (MASP,TENSP) có giá bán cao nhất
SELECT A.NUOCSX, MASP, TENSP
FROM SANPHAM SP
	INNER JOIN (
		SELECT NUOCSX, MAX(GIA) MAX_GIA
		FROM SANPHAM
		GROUP BY NUOCSX) AS A
ON SP.GIA = MAX_GIA AND SP.NUOCSX = A.NUOCSX

-- III.44 Tìm nước sản xuất sản xuất ít nhất 3 sản phẩm có giá bán khác nhau
SELECT NUOCSX, COUNT(DISTINCT GIA)
FROM SANPHAM
GROUP BY NUOCSX
HAVING COUNT(DISTINCT GIA) >= 3

-- III.45 Trong 10 khách hàng có doanh số cao nhất, tìm khách hàng có số lần mua hàng nhiều nhất
SELECT *
FROM KHACHHANG
WHERE MAKH = (
	SELECT TOP 1 A.MAKH	
	FROM
	(
		SELECT TOP 10 MAKH
		FROM KHACHHANG
		ORDER BY DOANHSO DESC
	) AS A INNER JOIN 
	(
		SELECT MAKH, COUNT(SOHD) DEM_HD
		FROM HOADON
		GROUP BY MAKH
	) AS B ON A.MAKH = B.MAKH
	ORDER BY DEM_HD DESC
)

-- QUẢN LÍ GIÁO VỤ
CREATE DATABASE QuanLyGiaoVu
GO

USE QuanLyGiaoVu
GO

-- Tạo bảng KHOA
CREATE TABLE KHOA 
(
	MAKHOA VARCHAR(4),
	TENKHOA VARCHAR(40),
	NGTLAP SMALLDATETIME,
	TRGKHOA CHAR(4)
	CONSTRAINT PK_KHOA PRIMARY KEY (MAKHOA)
)
GO

-- Tạo bảng MONHOC
CREATE TABLE MONHOC
(
	MAMH VARCHAR(10),
	TENMH VARCHAR(40),
	TCLT TINYINT,
	TCTH TINYINT,
	MAKHOA VARCHAR(4),
	CONSTRAINT PK_MONHOC PRIMARY KEY (MAMH),
	CONSTRAINT FK_MAKHOA FOREIGN KEY (MAKHOA) REFERENCES KHOA(MAKHOA)
)
GO

-- Tạo bảng DIEUKIEN
CREATE TABLE DIEUKIEN
(
	MAMH VARCHAR(10),
	MAMH_TRUOC VARCHAR(10),
	CONSTRAINT PK_DIEUKIEN PRIMARY KEY (MAMH, MAMH_TRUOC),
	CONSTRAINT FK_MAMH FOREIGN KEY (MAMH) REFERENCES MONHOC(MAMH),
	CONSTRAINT FK_MAMH_TRUOC FOREIGN KEY (MAMH_TRUOC) REFERENCES MONHOC(MAMH)
)
GO

-- Tạo bảng GIAOVIEN
CREATE TABLE GIAOVIEN
(
	MAGV CHAR(4),
	HOTEN VARCHAR(40),
	HOCVI VARCHAR(10),
	HOCHAM VARCHAR(10),
	GIOITINH VARCHAR(3),
	NGSINH SMALLDATETIME,
	NGVL SMALLDATETIME,
	HESO NUMERIC(4,2),
	MUCLUONG MONEY,
	MAKHOA VARCHAR(4)
	CONSTRAINT PK_GIAOVIEN PRIMARY KEY (MAGV),
	CONSTRAINT FK_MAKHOA_2 FOREIGN KEY (MAKHOA) REFERENCES KHOA(MAKHOA)
)
GO

-- Tạo bảng HOCVIEN
CREATE TABLE HOCVIEN
(
	MAHV CHAR(5),
	HO VARCHAR(40),
	TEN VARCHAR(10),
	NGSINH SMALLDATETIME,
	GIOITINH VARCHAR(3),
	NOISINH VARCHAR(40),
	MALOP CHAR(3),
	CONSTRAINT PK_HOCVIEN PRIMARY KEY (MAHV),
)
GO

-- Tạo bảng LOP
CREATE TABLE LOP
(
	MALOP CHAR(3),
	TENLOP VARCHAR(40),
	TRGLOP CHAR(5),
	SISO TINYINT,
	MAGVCN CHAR(4)
	CONSTRAINT PK_LOP PRIMARY KEY (MALOP),
	CONSTRAINT FK_MAGVCN FOREIGN KEY (MAGVCN) REFERENCES GIAOVIEN(MAGV)
)
GO

-- Tạo khóa ngoại giữa HOCVIEN và LOP
ALTER TABLE LOP ADD CONSTRAINT FK_TRGLOP FOREIGN KEY (TRGLOP) REFERENCES HOCVIEN(MAHV)
ALTER TABLE HOCVIEN ADD CONSTRAINT FK_LOP FOREIGN KEY (MALOP) REFERENCES LOP(MALOP)

-- Tạo bảng GIANGDAY
CREATE TABLE GIANGDAY
(
	MALOP CHAR(3),
	MAMH VARCHAR(10),
	MAGV CHAR(4),
	HOCKY TINYINT,
	NAM SMALLINT,
	TUNGAY SMALLDATETIME,
	DENNGAY SMALLDATETIME
	CONSTRAINT PK_GIANGDAY PRIMARY KEY (MALOP, MAMH),
	CONSTRAINT FK_MAGV FOREIGN KEY (MAGV) REFERENCES GIAOVIEN(MAGV)
)
GO

-- Tạo bảng KETQUATHI
CREATE TABLE KETQUATHI
(
	MAHV CHAR(5),
	MAMH VARCHAR(10),
	LANTHI TINYINT,
	NGTHI SMALLDATETIME,
	DIEM NUMERIC(4,2),
	KQUA VARCHAR(10)
	CONSTRAINT PK_KETQUATHI PRIMARY KEY (MAHV, MAMH, LANTHI)
	CONSTRAINT FK_MAHV FOREIGN KEY (MAHV) REFERENCES HOCVIEN(MAHV),
	CONSTRAINT FK_MAMH_2 FOREIGN KEY (MAMH) REFERENCES MONHOC(MAMH)
)
GO

-- Nhập dữ liệu cho KHOA --
insert into KHOA values('KHMT','Khoa hoc may tinh','6/7/2005','GV01')
insert into KHOA values('HTTT','He thong thong tin','6/7/2005','GV02')
insert into KHOA values('CNPM','Cong nghe phan mem','6/7/2005','GV04')
insert into KHOA values('MTT','Mang va truyen thong','10/20/2005','GV03')
insert into KHOA values('KTMT','Ky thuat may tinh','12/20/2005','')

-- Nhập dữ liệu cho GIAOVIEN --
insert into GIAOVIEN values('GV01','Ho Thanh Son','PTS','GS','Nam','5/2/1950','1/11/2004',5.00,2250000,'KHMT')
insert into GIAOVIEN values('GV02','Tran Tam Thanh','TS','PGS','Nam','12/17/1965','4/20/2004',4.50,2025000,'HTTT')
insert into GIAOVIEN values('GV03','Do Nghiem Phung','TS','GS','Nu','8/1/1950','9/23/2004',4.00,1800000,'CNPM')
insert into GIAOVIEN values('GV04','Tran Nam Son','TS','PGS','Nam','2/22/1961','1/12/2005',4.50,2025000,'KTMT')
insert into GIAOVIEN values('GV05','Mai Thanh Danh','ThS','GV','Nam','3/12/1958','1/12/2005',3.00,1350000,'HTTT')
insert into GIAOVIEN values('GV06','Tran Doan Hung','TS','GV','Nam','3/11/1953','1/12/2005',4.50,2025000,'KHMT')
insert into GIAOVIEN values('GV07','Nguyen Minh Tien','ThS','GV','Nam','11/23/1971','3/1/2005',4.00,1800000,'KHMT')
insert into GIAOVIEN values('GV08','Le Thi Tran','KS','','Nu','3/26/1974','3/1/2005',1.69,760500,'KHMT')
insert into GIAOVIEN values('GV09','Nguyen To Lan','ThS','GV','Nu','12/31/1966','3/1/2005',4.00,1800000,'HTTT')
insert into GIAOVIEN values('GV10','Le Tran Anh Loan','KS','','Nu','7/17/1972','3/1/2005',1.86,837000,'CNPM')
insert into GIAOVIEN values('GV11','Ho Thanh Tung','CN','GV','Nam','1/12/1980','5/15/2005',2.67,1201500,'MTT')
insert into GIAOVIEN values('GV12','Tran Van Anh','CN','','Nu','3/29/1981','5/15/2005',1.69,760500,'CNPM')
insert into GIAOVIEN values('GV13','Nguyen Linh Dan','CN','','Nu','5/23/1980','5/15/2005',1.69,760500,'KTMT')
insert into GIAOVIEN values('GV14','Truong Minh Chau','ThS','GV','Nu','11/30/1976','5/15/2005',3.00,1350000,'MTT')
insert into GIAOVIEN values('GV15','Le Ha Thanh','ThS','GV','Nam','5/4/1978','5/15/2005',3.00,1350000,'KHMT')
 
-- Nhập dữ liệu cho MONHOC --
insert into MONHOC values('THDC','Tin hoc dai cuong',4,1,'KHMT')
insert into MONHOC values('CTRR','Cau truc roi rac',5,0,'KHMT')
insert into MONHOC values('CSDL','Co so du lieu',3,1,'HTTT')
insert into MONHOC values('CTDLGT','Cau truc du lieu va giai thuat',3,1,'KHMT')
insert into MONHOC values('PTTKTT','Phan tich thiet ke thuat toan',3,0,'KHMT')
insert into MONHOC values('DHMT','Do hoa may tinh',3,1,'KHMT')
insert into MONHOC values('KTMT','Kien truc may tinh',3,0,'KTMT')
insert into MONHOC values('TKCSDL','Thiet ke co so du lieu',3,1,'HTTT')
insert into MONHOC values('PTTKHTTT','Phan tich thiet ke he thong thong tin',4,1,'HTTT')
insert into MONHOC values('HDH','He dieu hanh',4,0,'KTMT')
insert into MONHOC values('NMCNPM','Nhap mon cong nghe phan mem',3,0,'CNPM')
insert into MONHOC values('LTCFW','Lap trinh C for win',3,1,'CNPM')
insert into MONHOC values('LTHDT','Lap trinh huong doi tuong',3,1,'CNPM')

-- Nhập dữ liệu cho LOP --
insert into LOP values('K11','Lop 1 khoa 1','K1108',11,'GV07')
insert into LOP values('K12','Lop 2 khoa 1','K1205',12,'GV09')
insert into LOP values('K13','Lop 3 khoa 1','K1305',12,'GV14')

-- Nhập dữ liệu cho HOCVIEN --
insert into HOCVIEN values('K1101','Nguyen Van','A','1/27/1986','Nam','TpHCM','K11')
insert into HOCVIEN values('K1102','Tran Ngoc','Han','3/1/1986','Nu','Kien Giang','K11')
insert into HOCVIEN values('K1103','Ha Duy','Lap','4/18/1986','Nam','Nghe An','K11')
insert into HOCVIEN values('K1104','Tran Ngoc','Linh','3/30/1986','Nu','Tay Ninh','K11')
insert into HOCVIEN values('K1105','Tran Minh','Long','2/27/1986','Nam','TpHCM','K11')
insert into HOCVIEN values('K1106','Le Nhat','Minh','1/24/1986','Nam','TpHCM','K11')
insert into HOCVIEN values('K1107','Nguyen Nhu','Nhut','1/27/1986','Nam','Ha Noi','K11')
insert into HOCVIEN values('K1108','Nguyen Manh','Tam','2/27/1986','Nam','Kien Giang','K11')
insert into HOCVIEN values('K1109','Phan Thi Thanh','Tam','1/27/1986','Nu','Vinh Long','K11')
insert into HOCVIEN values('K1110','Le Hoai','Thuong','2/5/1986','Nu','Can Tho','K11')
insert into HOCVIEN values('K1111','Le Ha','Vinh','12/25/1986','Nam','Vinh Long','K11')
insert into HOCVIEN values('K1201','Nguyen Van','B','2/11/1986','Nam','TpHCM','K12')
insert into HOCVIEN values('K1202','Nguyen Thi Kim','Duyen','1/18/1986','Nu','TpHCM','K12')
insert into HOCVIEN values('K1203','Tran Thi Kim','Duyen','9/17/1986','Nu','TpHCM','K12')
insert into HOCVIEN values('K1204','Truong My','Hanh','5/19/1986','Nu','Dong Nai','K12')
insert into HOCVIEN values('K1205','Nguyen Thanh','Nam','4/17/1986','Nam','TpHCM','K12')
insert into HOCVIEN values('K1206','Nguyen Thi Truc','Thanh','3/4/1986','Nu','Kien Giang','K12')
insert into HOCVIEN values('K1207','Tran Thi Bich','Thuy','2/8/1986','Nu','Nghe An','K12')
insert into HOCVIEN values('K1208','Huynh Thi Kim','Trieu','4/8/1986','Nu','Tay Ninh','K12')
insert into HOCVIEN values('K1209','Pham Thanh','Trieu','2/23/1986','Nam','TpHCM','K12')
insert into HOCVIEN values('K1210','Ngo Thanh','Tuan','2/14/1986','Nam','TpHCM','K12')
insert into HOCVIEN values('K1211','Do Thi','Xuan','3/9/1986','Nu','Ha Noi','K12')
insert into HOCVIEN values('K1212','Le Thi Phi','Yen','3/12/1986','Nu','TpHCM','K12')
insert into HOCVIEN values('K1301','Nguyen Thi Kim','Cuc','6/9/1986','Nu','Kien Giang','K13')
insert into HOCVIEN values('K1302','Truong Thi My','Hien','3/18/1986','Nu','Nghe An','K13')
insert into HOCVIEN values('K1303','Le Duc','Hien','3/12/1986','Nam','Tay Ninh','K13')
insert into HOCVIEN values('K1304','Le Quang','Hien','4/18/1986','Nam','TpHCM','K13')
insert into HOCVIEN values('K1305','Le Thi','Huong','3/27/1986','Nu','TpHCM','K13')
insert into HOCVIEN values('K1306','Nguyen Thai','Huu','3/30/1986','Nam','Ha Noi','K13')
insert into HOCVIEN values('K1307','Tran Minh','Man','5/28/1986','Nam','TpHCM','K13')
insert into HOCVIEN values('K1308','Nguyen Hieu','Nghia','4/8/1986','Nam','Kien Giang','K13')
insert into HOCVIEN values('K1309','Nguyen Trung','Nghia','1/18/1987','Nam','Nghe An','K13')
insert into HOCVIEN values('K1310','Tran Thi Hong','Tham','4/22/1986','Nu','Tay Ninh','K13')
insert into HOCVIEN values('K1311','Tran Minh','Thuc','4/4/1986','Nam','TpHCM','K13')
insert into HOCVIEN values('K1312','Nguyen Thi Kim','Yen','9/7/1986','Nu','TpHCM','K13')

-- Nhập dữ liệu cho GIANGDAY --
insert into GIANGDAY values('K11','THDC','GV07',1,2006,'1/2/2006','5/12/2006')
insert into GIANGDAY values('K12','THDC','GV06',1,2006,'1/2/2006','5/12/2006')
insert into GIANGDAY values('K13','THDC','GV15',1,2006,'1/2/2006','5/12/2006')
insert into GIANGDAY values('K11','CTRR','GV02',1,2006,'1/9/2006','5/17/2006')
insert into GIANGDAY values('K12','CTRR','GV02',1,2006,'1/9/2006','5/17/2006')
insert into GIANGDAY values('K13','CTRR','GV08',1,2006,'1/9/2006','5/17/2006')
insert into GIANGDAY values('K11','CSDL','GV05',2,2006,'6/1/2006','7/15/2006')
insert into GIANGDAY values('K12','CSDL','GV09',2,2006,'6/1/2006','7/15/2006')
insert into GIANGDAY values('K13','CTDLGT','GV15',2,2006,'6/1/2006','7/15/2006')
insert into GIANGDAY values('K13','CSDL','GV05',3,2006,'8/1/2006','12/15/2006')
insert into GIANGDAY values('K13','DHMT','GV07',3,2006,'8/1/2006','12/15/2006')
insert into GIANGDAY values('K11','CTDLGT','GV15',3,2006,'8/1/2006','12/15/2006')
insert into GIANGDAY values('K12','CTDLGT','GV15',3,2006,'8/1/2006','12/15/2006')
insert into GIANGDAY values('K11','HDH','GV04',1,2007,'1/2/2007','2/18/2007')
insert into GIANGDAY values('K12','HDH','GV04',1,2007,'1/2/2007','3/20/2007')
insert into GIANGDAY values('K11','DHMT','GV07',1,2007,'2/18/2007','3/20/2007')

-- NHẬP DỮ LIỆU CHO DIEUKIEN --
insert into DIEUKIEN values('CSDL','CTRR')
insert into DIEUKIEN values('CSDL','CTDLGT')
insert into DIEUKIEN values('CTDLGT','THDC')
insert into DIEUKIEN values('PTTKTT','THDC')
insert into DIEUKIEN values('PTTKTT','CTDLGT')
insert into DIEUKIEN values('DHMT','THDC')
insert into DIEUKIEN values('LTHDT','THDC')
insert into DIEUKIEN values('PTTKHTTT','CSDL')

-- Nhập dữ liệu cho KETQUATHI --
insert into KETQUATHI values('K1101','CSDL',1,'7/20/2006',10.00,'Dat')
insert into KETQUATHI values('K1101','CTDLGT',1,'12/28/2006',9.00,'Dat')
insert into KETQUATHI values('K1101','THDC',1,'5/20/2006',9.00,'Dat')
insert into KETQUATHI values('K1101','CTRR',1,'5/13/2006',9.50,'Dat')
insert into KETQUATHI values('K1102','CSDL',1,'7/20/2006',4.00,'Khong Dat')
insert into KETQUATHI values('K1102','CSDL',2,'7/27/2006',4.25,'Khong Dat')
insert into KETQUATHI values('K1102','CSDL',3,'8/10/2006',4.50,'Khong Dat')
insert into KETQUATHI values('K1102','CTDLGT',1,'12/28/2006',4.50,'Khong Dat')
insert into KETQUATHI values('K1102','CTDLGT',2,'1/5/2007',4.00,'Khong Dat')
insert into KETQUATHI values('K1102','CTDLGT',3,'1/15/2007',6.00,'Dat')
insert into KETQUATHI values('K1102','THDC',1,'5/20/2006',5.00,'Dat')
insert into KETQUATHI values('K1102','CTRR',1,'5/13/2006',7.00,'Dat')
insert into KETQUATHI values('K1103','CSDL',1,'7/20/2006',3.50,'Khong Dat')
insert into KETQUATHI values('K1103','CSDL',2,'7/27/2006',8.25,'Dat')
insert into KETQUATHI values('K1103','CTDLGT',1,'12/28/2006',7.00,'Dat')
insert into KETQUATHI values('K1103','THDC',1,'5/20/2006',8.00,'Dat')
insert into KETQUATHI values('K1103','CTRR',1,'5/13/2006',6.50,'Dat')
insert into KETQUATHI values('K1104','CSDL',1,'7/20/2006',3.75,'Khong Dat')
insert into KETQUATHI values('K1104','CTDLGT',1,'12/28/2006',4.00,'Khong Dat')
insert into KETQUATHI values('K1104','THDC',1,'5/20/2006',4.00,'Khong Dat')
insert into KETQUATHI values('K1104','CTRR',1,'5/13/2006',4.00,'Khong Dat')
insert into KETQUATHI values('K1104','CTRR',2,'5/20/2006',3.50,'Khong Dat')
insert into KETQUATHI values('K1104','CTRR',3,'6/30/2006',4.00,'Khong Dat')
insert into KETQUATHI values('K1201','CSDL',1,'7/20/2006',6.00,'Dat')
insert into KETQUATHI values('K1201','CTDLGT',1,'12/28/2006',5.00,'Dat')
insert into KETQUATHI values('K1201','THDC',1,'5/20/2006',8.50,'Dat')
insert into KETQUATHI values('K1201','CTRR',1,'5/13/2006',9.00,'Dat')
insert into KETQUATHI values('K1202','CSDL',1,'7/20/2006',8.00,'Dat')
insert into KETQUATHI values('K1202','CTDLGT',1,'12/28/2006',4.00,'Khong Dat')
insert into KETQUATHI values('K1202','CTDLGT',2,'1/5/2007',5.00,'Dat')
insert into KETQUATHI values('K1202','THDC',1,'5/20/2006',4.00,'Khong Dat')
insert into KETQUATHI values('K1202','THDC',2,'5/27/2006',4.00,'Khong Dat')
insert into KETQUATHI values('K1202','CTRR',1,'5/13/2006',3.00,'Khong Dat')
insert into KETQUATHI values('K1202','CTRR',2,'5/20/2006',4.00,'Khong Dat')
insert into KETQUATHI values('K1202','CTRR',3,'6/30/2006',6.25,'Dat')
insert into KETQUATHI values('K1203','CSDL',1,'7/20/2006',9.25,'Dat')
insert into KETQUATHI values('K1203','CTDLGT',1,'12/28/2006',9.50,'Dat')
insert into KETQUATHI values('K1203','THDC',1,'5/20/2006',10.00,'Dat')
insert into KETQUATHI values('K1203','CTRR',1,'5/13/2006',10.00,'Dat')
insert into KETQUATHI values('K1204','CSDL',1,'7/20/2006',8.50,'Dat')
insert into KETQUATHI values('K1204','CTDLGT',1,'12/28/2006',6.75,'Dat')
insert into KETQUATHI values('K1204','THDC',1,'5/20/2006',4.00,'Khong Dat')
insert into KETQUATHI values('K1204','CTRR',1,'5/13/2006',6.00,'Dat')
insert into KETQUATHI values('K1301','CSDL',1,'12/20/2006',4.25,'Khong Dat')
insert into KETQUATHI values('K1301','CTDLGT',1,'7/25/2006',8.00,'Dat')
insert into KETQUATHI values('K1301','THDC',1,'5/20/2006',7.75,'Dat')
insert into KETQUATHI values('K1301','CTRR',1,'5/13/2006',8.00,'Dat')
insert into KETQUATHI values('K1302','CSDL',1,'12/20/2006',6.75,'Dat')
insert into KETQUATHI values('K1302','CTDLGT',1,'7/25/2006',5.00,'Dat')
insert into KETQUATHI values('K1302','THDC',1,'5/20/2006',8.00,'Dat')
insert into KETQUATHI values('K1302','CTRR',1,'5/13/2006',8.50,'Dat')
insert into KETQUATHI values('K1303','CSDL',1,'12/20/2006',4.00,'Khong Dat')
insert into KETQUATHI values('K1303','CTDLGT',1,'7/25/2006',4.50,'Khong Dat')
insert into KETQUATHI values('K1303','CTDLGT',2,'8/7/2006',4.00,'Khong Dat')
insert into KETQUATHI values('K1303','CTDLGT',3,'8/15/2006',4.25,'Khong Dat')
insert into KETQUATHI values('K1303','THDC',1,'5/20/2006',4.50,'Khong Dat')
insert into KETQUATHI values('K1303','CTRR',1,'5/13/2006',3.25,'Khong Dat')
insert into KETQUATHI values('K1303','CTRR',2,'5/20/2006',5.00,'Dat')
insert into KETQUATHI values('K1304','CSDL',1,'12/20/2006',7.75,'Dat')
insert into KETQUATHI values('K1304','CTDLGT',1,'7/25/2006',9.75,'Dat')
insert into KETQUATHI values('K1304','THDC',1,'5/20/2006',5.50,'Dat')
insert into KETQUATHI values('K1304','CTRR',1,'5/13/2006',5.00,'Dat')
insert into KETQUATHI values('K1305','CSDL',1,'12/20/2006',9.25,'Dat')
insert into KETQUATHI values('K1305','CTDLGT',1,'7/25/2006',10.00,'Dat')
insert into KETQUATHI values('K1305','THDC',1,'5/20/2006',8.00,'Dat')
insert into KETQUATHI values('K1305','CTRR',1,'5/13/2006',10.00,'Dat')

-- I.1 Tạo quan hệ và khai báo tất cả các ràng buộc khóa chính, khóa ngoại.
-- Thêm vào 3 thuộc tính GHICHU, DIEMTB, XEPLOAI cho quan hệ HOCVIEN
ALTER TABLE HOCVIEN ADD GHICHU VARCHAR(50), DIEMTB NUMERIC(4,2), XEPLOAI VARCHAR(10)

-- I.2 Mã học viên là một chuỗi 5 ký tự, 3 ký tự đầu là mã lớp, 2 ký tự cuối cùng là số thứ tự học viên trong lớp
CREATE FUNCTION dbo.chk_MAHV(@MAHV VARCHAR(5))
RETURNS INT
AS
BEGIN
	DECLARE @CHK INT
	SELECT @CHK = 
		CASE 
			WHEN (LEN(@MAHV) = 5)
			AND (LEFT(@MAHV, 3) = HV.MALOP)
			AND (CAST(RIGHT(@MAHV, 2) AS INT) BETWEEN 1 AND SISO)
			THEN 1 ELSE 0
		END
	FROM HOCVIEN HV INNER JOIN LOP ON HV.MALOP = LOP.MALOP
	WHERE @MAHV = HV.MAHV
	RETURN @CHK
END

ALTER TABLE HOCVIEN ADD CONSTRAINT CHECK_MAHV CHECK (dbo.chk_MAHV(MAHV) = 1)

-- I.3 Thuộc tính GIOITINH chỉ có giá trị là “Nam” hoặc “Nu”
ALTER TABLE HOCVIEN ADD CONSTRAINT CHECK_GTHV CHECK (GIOITINH IN ('Nam', 'Nu'))
ALTER TABLE GIAOVIEN ADD CONSTRAINT CHECK_GTGV CHECK (GIOITINH IN ('Nam', 'Nu'))

-- I.4 Điểm số của một lần thi có giá trị từ 0 đến 10 và cần lưu đến 2 số lẽ (VD: 6.22)
ALTER TABLE KETQUATHI ADD CONSTRAINT CHECK_DIEM CHECK 
(
	DIEM BETWEEN 0 AND 10
	AND RIGHT(CAST(DIEM AS VARCHAR), 3) LIKE '.__'
)

-- I.5 Kết quả thi là “Dat” nếu điểm từ 5 đến 10  và “Khong dat” nếu điểm nhỏ hơn 5
ALTER TABLE KETQUATHI ADD CONSTRAINT CHECK_KETQUA CHECK
(	
	(KQUA = 'Dat' AND DIEM BETWEEN 5 AND 10)
	OR (KQUA = 'Khong dat' AND DIEM < 5)
)

-- I.6 Học viên thi một môn tối đa 3 lần
ALTER TABLE KETQUATHI ADD CONSTRAINT CHECK_LANTHI CHECK (LANTHI <= 3)

-- I.7 Học kỳ chỉ có giá trị từ 1 đến 3
ALTER TABLE GIANGDAY ADD CONSTRAINT CHECK_HOCKY CHECK (HOCKY BETWEEN 1 AND 3)

-- I.8 Học vị của giáo viên chỉ có thể là “CN”, “KS”, “Ths”, ”TS”, ”PTS”
ALTER TABLE GIAOVIEN ADD CONSTRAINT CHECK_HOCVI CHECK (HOCVI IN ('CN', 'KS', 'Ths', 'TS', 'PTS'))

-- I.9 Lớp trưởng của một lớp phải là học viên của lớp đó
ALTER TABLE LOP ADD CONSTRAINT CHECK_TRGLOP CHECK (LEFT(TRGLOP, 3) = MALOP)

-- I.10 Trưởng khoa phải là giáo viên thuộc khoa và có học vị “TS” hoặc “PTS”
CREATE FUNCTION chk_TRGKHOA(@TRGKHOA VARCHAR(4))
RETURNS INT
AS
BEGIN
	DECLARE @CHK INT
	SELECT @CHK = 
		CASE
			WHEN (HOCVI IN ('TS', 'PTS'))
			AND (GV.MAKHOA = KHOA.MAKHOA)
			THEN 1 ELSE 0
		END
	FROM KHOA INNER JOIN GIAOVIEN GV
	ON KHOA.TRGKHOA = GV.MAGV
	WHERE @TRGKHOA = KHOA.TRGKHOA
	RETURN @CHK
END

ALTER TABLE KHOA ADD CONSTRAINT CHECK_TRGKHOA CHECK (dbo.chk_TRGKHOA(TRGKHOA) = 1)

-- I.11 Học viên ít nhất là 18 tuổi
ALTER TABLE HOCVIEN ADD CONSTRAINT CHECK_TUOI CHECK (YEAR(GETDATE()) - YEAR(NGSINH) >= 18)

-- I.12 Giảng dạy một môn học ngày bắt đầu (TUNGAY) phải nhỏ hơn ngày kết thúc (DENNGAY)
ALTER TABLE GIANGDAY ADD CONSTRAINT CHECK_GIANGDAY CHECK (TUNGAY < DENNGAY)

-- I.13 Giáo viên khi vào làm ít nhất là 22 tuổi
ALTER TABLE GIAOVIEN ADD CONSTRAINT CHECK_TUOILAM CHECK (YEAR(NGVL) - YEAR(NGSINH) >= 22)

-- I.14 Tất cả các môn học đều có số tín chỉ lý thuyết và tín chỉ thực hành chênh lệch nhau không quá 3
ALTER TABLE MONHOC ADD CONSTRAINT CHECK_TINCHI CHECK (ABS(TCLT - TCTH) <= 3)

-- II.1 Tăng hệ số lương thêm 0.2 cho những giáo viên là trưởng khoa
UPDATE GIAOVIEN
SET HESO = 1.2 * HESO
WHERE MAGV IN (SELECT TRGKHOA FROM KHOA)

-- II.2 Cập nhật giá trị điểm trung bình tất cả các môn học (DIEMTB) của mỗi học viên (tất cả các môn học đều có hệ số 1 và nếu học viên thi một môn nhiều lần, chỉ lấy điểm của lần thi sau cùng)
UPDATE HOCVIEN
SET DIEMTB =
	(
		SELECT AVG(DIEM)
		FROM 
		(
			SELECT MAHV, MAMH, MAX(LANTHI) MAX_LANTHI
			FROM KETQUATHI
			GROUP BY MAHV, MAMH
		) AS A JOIN KETQUATHI B
		ON A.MAHV = B.MAHV AND A.MAMH = B.MAMH AND B.LANTHI = MAX_LANTHI
		GROUP BY B.MAHV
		HAVING B.MAHV = HOCVIEN.MAHV
	)

-- II.3 Cập nhật giá trị cho cột GHICHU là “Cam thi” đối với trường hợp: học viên có một môn bất kỳ thi lần thứ 3 dưới 5 điểm
UPDATE HOCVIEN
SET GHICHU = 'Cam thi'
WHERE MAHV IN 
	(
		SELECT MAHV
		FROM KETQUATHI
		WHERE LANTHI = 3 AND DIEM < 5
	)

-- II.4 Cập nhật giá trị cho cột XEPLOAI trong quan hệ HOCVIEN như sau: 
-- Nếu DIEMTB >= 9 thì XEPLOAI = ”XS”
-- Nếu 8 <= DIEMTB < 9 thì XEPLOAI = “G”
-- Nếu 6.5 <= DIEMTB < 8 thì XEPLOAI = “K”
-- Nếu 5 <= DIEMTB < 6.5 thì XEPLOAI = “TB” 
-- Nếu DIEMTB < 5 thì XEPLOAI = ”Y” 

UPDATE HOCVIEN
SET XEPLOAI =
(
	CASE 
		WHEN DIEMTB >= 9 THEN 'XS'
		WHEN DIEMTB >= 8 AND DIEMTB < 9 THEN 'G'
		WHEN DIEMTB >= 6.5 AND DIEMTB < 8 THEN 'K'
		WHEN DIEMTB >= 5 AND DIEMTB < 6.5 THEN 'TB'
		WHEN DIEMTB < 5 THEN 'Y'
	END
)
WHERE DIEMTB IS NOT NULL

-- III.1 In ra danh sách (mã học viên, họ tên, ngày sinh, mã lớp) lớp trưởng của các lớp
SELECT MAHV, (HO+' '+TEN) HOTEN, NGSINH, MALOP
FROM HOCVIEN
WHERE MAHV IN (SELECT TRGLOP FROM LOP)

-- III.2 In ra bảng điểm khi thi (mã học viên, họ tên , lần thi, điểm số) môn CTRR của lớp “K12”, sắp xếp theo tên, họ học viên
SELECT HV.MAHV, (HO+' '+TEN) HOTEN, LANTHI, KQ.DIEM
FROM KETQUATHI KQ INNER JOIN HOCVIEN HV
ON KQ.MAHV = HV.MAHV
WHERE MAMH = 'CTRR' AND MALOP = 'K12'
ORDER BY TEN ASC, HO ASC

-- III.3 In ra danh sách những học viên (mã học viên, họ tên) và những môn học mà học viên đó thi lần thứ nhất đã đạt
SELECT KQ.MAHV, (HO+' '+TEN) HOTEN, MAMH
FROM KETQUATHI KQ INNER JOIN HOCVIEN HV
ON KQ.MAHV = HV.MAHV
WHERE LANTHI = 1 AND KQUA = 'Dat'

-- III.4 In ra danh sách học viên (mã học viên, họ tên) của lớp “K11” thi môn CTRR không đạt (ở lần thi 1)
SELECT KQ.MAHV, (HO+' '+TEN) HOTEN
FROM KETQUATHI KQ INNER JOIN HOCVIEN HV
ON KQ.MAHV = HV.MAHV
WHERE MAMH = 'CTRR' AND LANTHI = 1 AND KQUA = 'Khong dat'

-- III.5  Danh sách học viên (mã học viên, họ tên) của lớp “K” thi môn CTRR không đạt (ở tất cả các lần thi)
SELECT MAHV, (HO+' '+TEN) HOTEN
FROM HOCVIEN
WHERE MAHV LIKE 'K%'
AND MAHV IN 
(
	SELECT A.MAHV
	FROM
		(
			SELECT MAHV, MAX(LANTHI) MAX_LANTHI
			FROM KETQUATHI
			GROUP BY MAHV, MAMH
			HAVING MAMH = 'CTRR'
		) AS A INNER JOIN
		(
			SELECT MAHV, COUNT(KQUA) COUNT_FAIL
			FROM KETQUATHI
			GROUP BY MAHV, MAMH, KQUA
			HAVING MAMH = 'CTRR' AND KQUA = 'Khong dat'
		) AS B ON A.MAHV = B.MAHV
	WHERE MAX_LANTHI = COUNT_FAIL
)

-- III.6 Tìm tên những môn học mà giáo viên có tên “Tran Tam Thanh” dạy trong học kỳ 1 năm 2006
SELECT DISTINCT TENMH
FROM MONHOC MH
	INNER JOIN GIANGDAY GD ON MH.MAMH = GD.MAMH
	INNER JOIN GIAOVIEN GV ON GD.MAGV = GV.MAGV
WHERE HOTEN = 'Tran Tam Thanh' AND HOCKY = 1 AND NAM = 2006

-- III.7 Tìm những môn học (mã môn học, tên môn học) mà giáo viên chủ nhiệm lớp “K11” dạy trong học kỳ 1 năm 2006
SELECT DISTINCT MH.MAMH, TENMH
FROM MONHOC MH
	INNER JOIN GIANGDAY GD ON MH.MAMH = GD.MAMH
	INNER JOIN LOP ON GD.MAGV = LOP.MAGVCN
WHERE LOP.MALOP = 'K11' AND HOCKY = 1 AND NAM = 2006

-- III.8 Tìm họ tên lớp trưởng của các lớp mà giáo viên có tên “Nguyen To Lan” dạy môn “Co So Du Lieu”
SELECT (HO+' '+TEN) HOTEN
FROM HOCVIEN
WHERE MAHV IN
(
	SELECT TRGLOP
	FROM LOP 
		JOIN GIANGDAY GD ON LOP.MALOP = GD.MALOP
		JOIN GIAOVIEN GV ON GV.MAGV = GD.MAGV
		JOIN MONHOC MH ON MH.MAMH = GD.MAMH
	WHERE GV.HOTEN = 'Nguyen To Lan' AND TENMH = 'Co So Du Lieu'
)

-- III.9 In ra danh sách những môn học (mã môn học, tên môn học) phải học liền trước môn “Co So Du Lieu”
SELECT MAMH, TENMH
FROM MONHOC
WHERE MAMH IN
(
	SELECT MAMH_TRUOC
	FROM DIEUKIEN DK
		JOIN MONHOC MH ON DK.MAMH = MH.MAMH
	WHERE TENMH = 'Co So Du Lieu'
)

-- III.10 Môn “Cau Truc Roi Rac” là môn bắt buộc phải học liền trước những môn học (mã môn học, tên môn học) nào
SELECT MAMH, TENMH
FROM MONHOC
WHERE MAMH IN
(
	SELECT DK.MAMH
	FROM DIEUKIEN DK
		JOIN MONHOC MH ON DK.MAMH_TRUOC = MH.MAMH
	WHERE TENMH = 'Cau Truc Roi Rac'
)

-- III.11 Tìm họ tên giáo viên dạy môn CTRR cho cả hai lớp “K11” và “K12” trong cùng học kỳ 1 năm 2006
SELECT HOTEN
FROM
(
	SELECT DISTINCT GV.MAGV, HOTEN
	FROM GIAOVIEN GV
		INNER JOIN GIANGDAY GD
	ON GV.MAGV = GD.MAGV
	WHERE HOCKY = 1 AND NAM = 2006 AND MAMH = 'CTRR'
	AND GV.MAGV IN
	(
		(SELECT MAGV FROM GIANGDAY WHERE MALOP = 'K11')
		INTERSECT (SELECT MAGV FROM GIANGDAY WHERE MALOP = 'K12')
	)
) AS A

-- III.12 Tìm những học viên (mã học viên, họ tên) thi không đạt môn CSDL ở lần thi thứ 1 nhưng chưa thi lại môn này
SELECT B.MAHV, (HO+' '+TEN) HOTEN
FROM
(
	SELECT DISTINCT A.MAHV
	FROM
	(
		SELECT MAHV, MAX(LANTHI) MAX_LANTHI
		FROM KETQUATHI
		GROUP BY MAHV, MAMH
		HAVING MAMH = 'CSDL'
	) AS A JOIN KETQUATHI KQ
	ON KQ.MAHV = A.MAHV AND LANTHI = MAX_LANTHI
	WHERE MAX_LANTHI = 1 AND KQUA = 'Khong dat'
) AS B JOIN HOCVIEN HV ON HV.MAHV = B.MAHV

-- III.13 Tìm giáo viên (mã giáo viên, họ tên) không được phân công giảng dạy bất kỳ môn học nào
SELECT MAGV, HOTEN
FROM GIAOVIEN
WHERE MAGV IN
(
	SELECT MAGV FROM GIAOVIEN
	EXCEPT SELECT DISTINCT MAGV FROM GIANGDAY
)

-- III.14 Tìm giáo viên (mã giáo viên, họ tên) không được phân công giảng dạy bất kỳ môn học nào thuộc khoa giáo viên đó phụ trách
-- => Tìm MAGV, HOTEN trong GIAOVIEN mà không có môn học nào thuộc khoa giáo viên đó xuất hiện trong các môn học giáo viên đó giảng dạy
SELECT MAGV, HOTEN
FROM GIAOVIEN GV
WHERE NOT EXISTS
(
	SELECT MAMH
	FROM MONHOC MH
	WHERE MH.MAKHOA = GV.MAKHOA
	AND EXISTS
	(
		SELECT MAMH
		FROM GIANGDAY GD
		WHERE GD.MAMH = MH.MAMH
		AND GD.MAGV = GV.MAGV
	)
)

-- III.15 Tìm họ tên các học viên thuộc lớp “K11” thi một môn bất kỳ quá 3 lần vẫn “Khong dat” hoặc thi lần thứ 2 môn CTRR được 5 điểm
SELECT (HO+' '+TEN) HOTEN
FROM HOCVIEN HV
	JOIN KETQUATHI KQ ON HV.MAHV = KQ.MAHV
WHERE MALOP = 'K11'
AND ((LANTHI >= 3 AND KQUA = 'Khong dat')
OR (LANTHI = 2 AND MAMH = 'CTRR' AND DIEM = 5))

-- III.16 Tìm họ tên giáo viên dạy môn CTRR cho ít nhất hai lớp trong cùng một học kỳ của một năm học
SELECT HOTEN
FROM GIAOVIEN
WHERE MAGV IN
(
	SELECT MAGV
	FROM GIANGDAY
	GROUP BY MAGV, HOCKY, NAM
	HAVING COUNT(MALOP) >= 2
)

-- III.17 Danh sách học viên và điểm thi môn CSDL (chỉ lấy điểm của lần thi sau cùng)
SELECT HV.*, B.DIEM 'Điểm thi CSDL sau cùng'
FROM HOCVIEN HV JOIN
(
	SELECT A.MAHV, KQ.DIEM
	FROM
	(
		SELECT MAHV, MAX(LANTHI) MAX_LANTHI
		FROM KETQUATHI
		GROUP BY MAHV, MAMH
		HAVING MAMH = 'CSDL'
	) AS A JOIN KETQUATHI KQ
	ON A.MAHV = KQ.MAHV AND KQ.LANTHI = MAX_LANTHI
	WHERE MAMH = 'CSDL'
) AS B ON HV.MAHV = B.MAHV

-- III.18 Danh sách học viên và điểm thi môn “Co So Du Lieu” (chỉ lấy điểm cao nhất của các lần thi)
SELECT HV.*, A.DIEM_MAX 'Điểm thi CSDL cao nhất' 
FROM HOCVIEN HV JOIN
(
	SELECT MAHV, MAX(DIEM) DIEM_MAX
	FROM KETQUATHI
	GROUP BY MAHV, MAMH
	HAVING MAMH = 'CSDL'
) AS A ON HV.MAHV = A.MAHV

-- III.19 Khoa nào (mã khoa, tên khoa) được thành lập sớm nhất
SELECT MAKHOA, TENKHOA
FROM KHOA
WHERE NGTLAP = (SELECT MIN(NGTLAP) FROM KHOA)

-- III.20 Có bao nhiêu giáo viên có học hàm là “GS” hoặc “PGS”
SELECT COUNT(*) 'Số giáo viên có học hàm GS hoặc PGS'
FROM GIAOVIEN
WHERE HOCHAM IN ('GS', 'PGS')

-- III.21 Thống kê có bao nhiêu giáo viên có học vị là “CN”, “KS”, “Ths”, “TS”, “PTS” trong mỗi khoa. 
SELECT MAKHOA, HOCVI, COUNT(*) 'Số giáo viên'
FROM GIAOVIEN
GROUP BY MAKHOA, HOCVI
ORDER BY MAKHOA

-- III.22 Mỗi môn học thống kê số lượng học viên theo kết quả (đạt và không đạt). 
SELECT MAMH, KQUA, COUNT(*) 'Số học viên'
FROM KETQUATHI KQ
GROUP BY MAMH, KQUA
ORDER BY MAMH

-- III.23 Tìm giáo viên (mã giáo viên, họ tên) là giáo viên chủ nhiệm của một lớp, đồng thời dạy cho lớp đó ít nhất một môn học. 
SELECT DISTINCT MAGVCN, HOTEN
FROM LOP, GIAOVIEN GV, GIANGDAY GD
WHERE MAGVCN = GD.MAGV AND GD.MALOP = LOP.MALOP
AND GV.MAGV = GD.MAGV

-- III.24 Tìm họ tên lớp trưởng của lớp có sỉ số cao nhất
SELECT HO+' '+TEN 'Họ tên lớp trưởng của lớp có sỉ số cao nhất'
FROM HOCVIEN
WHERE MAHV IN 
(
	SELECT TRGLOP
	FROM LOP
	WHERE SISO = (SELECT MAX(SISO) FROM LOP)
)

-- III.25 Tìm họ tên những LOPTRG thi không đạt quá 3 môn (mỗi môn đều thi không đạt ở tất cả các lần thi)
SELECT (HO+' '+TEN) HOTEN
FROM LOP, HOCVIEN HV,
((SELECT DISTINCT MAHV, MAMH FROM KETQUATHI) EXCEPT (SELECT DISTINCT MAHV, MAMH FROM KETQUATHI WHERE KQUA = 'Dat')) AS A
WHERE A.MAHV = LOP.TRGLOP AND A.MAHV = HV.MAHV
GROUP BY A.MAHV, HO, TEN
HAVING COUNT(*) > 3

-- III.26 Tìm học viên (mã học viên, họ tên) có số môn đạt điểm 9,10 nhiều nhất. 
SELECT MAHV, (HO+' '+TEN) HOTEN
FROM HOCVIEN
WHERE MAHV IN
(
	SELECT MAHV
	FROM KETQUATHI KQ
	WHERE DIEM >= 9
	GROUP BY MAHV
	HAVING COUNT(*) =
	(
		SELECT MAX(SOMON) MAX_SOMON
		FROM
		(
			SELECT MAHV, COUNT(*) SOMON
			FROM KETQUATHI
			WHERE DIEM >= 9
			GROUP BY MAHV
		) AS A
	)
)

-- III.27 Trong từng lớp, tìm học viên (mã học viên, họ tên) có số môn đạt điểm 9,10 nhiều nhất.
SELECT A.MALOP, A.MAHV, (HO+' '+TEN) HOTEN
FROM HOCVIEN HV,
(
	SELECT HV.MALOP, HV.MAHV, COUNT(*) SOMH_TREN9
	FROM KETQUATHI KQ, HOCVIEN HV
	WHERE KQ.MAHV = HV.MAHV AND DIEM >= 9
	GROUP BY HV.MAHV, HV.MALOP
) AS A,
(
	SELECT MALOP, MAX(SOMH_TREN9) MAX_SOMH_TREN9
	FROM 
	(	
		SELECT MALOP, COUNT(*) SOMH_TREN9
		FROM KETQUATHI KQ, HOCVIEN HV
		WHERE KQ.MAHV = HV.MAHV AND DIEM >= 9
		GROUP BY HV.MAHV, HV.MALOP
	) AS B
	GROUP BY B.MALOP
) AS C
WHERE A.MALOP = C.MALOP AND A.SOMH_TREN9 = C.MAX_SOMH_TREN9 AND HV.MAHV = A.MAHV
ORDER BY A.MALOP

-- III.28 Trong từng học kỳ của từng năm, mỗi giáo viên phân công dạy bao nhiêu môn học, bao nhiêu lớp.
SELECT MAGV, COUNT(DISTINCT MAMH) SOMONHOC, COUNT(DISTINCT MALOP) SOLOP
FROM GIANGDAY
GROUP BY MAGV

-- III.29 Trong từng học kỳ của từng năm, tìm giáo viên (mã giáo viên, họ tên) giảng dạy nhiều nhất. 
SELECT GV.MAGV, HOTEN
FROM GIAOVIEN GV, GIANGDAY GD
WHERE GV.MAGV = GD.MAGV
GROUP BY GV.MAGV, HOTEN
HAVING COUNT(*) =
(
	SELECT MAX(SOGD)
	FROM (SELECT COUNT(*) SOGD FROM GIANGDAY GROUP BY MAGV) AS A
)

-- III.30 Tìm môn học (mã môn học, tên môn học) có nhiều học viên thi không đạt (ở lần thi thứ 1) nhất.
SELECT KQ.MAMH, TENMH
FROM MONHOC MH, KETQUATHI KQ
WHERE MH.MAMH = KQ.MAMH AND KQUA = 'Khong dat'
GROUP BY KQ.MAMH, TENMH
HAVING COUNT(*) =
(
	SELECT MAX(SOKD)
	FROM (SELECT COUNT(*) SOKD FROM KETQUATHI WHERE KQUA = 'Khong dat' GROUP BY MAMH) AS A
)

-- III.31 Tìm học viên (mã học viên, họ tên) thi môn nào cũng đạt (chỉ xét lần thi thứ 1)
SELECT HV.MAHV, (HO+' '+TEN) HOTEN
FROM HOCVIEN HV,
(SELECT MAHV, COUNT(DISTINCT MAMH) SOMONTHI FROM KETQUATHI KQ GROUP BY MAHV) AS A,
(SELECT MAHV, COUNT(*) SOMONDAT FROM KETQUATHI KQ WHERE LANTHI = 1 AND KQUA = 'Dat' GROUP BY MAHV) AS B
WHERE HV.MAHV = A.MAHV AND A.MAHV = B.MAHV AND SOMONTHI = SOMONDAT

-- III.32 Tìm học viên (mã học viên, họ tên) thi môn nào cũng đạt (chỉ xét lần thi sau cùng).
SELECT HV.MAHV, (HO+' '+TEN) HOTEN
FROM HOCVIEN HV JOIN
(
	SELECT A.MAHV
	FROM
	(
		SELECT MAHV, COUNT(DISTINCT MAMH) COUNT_MH
		FROM KETQUATHI
		GROUP BY MAHV
	) AS A JOIN
	(
		SELECT MAHV, COUNT(*) COUNT_PASS
		FROM (
			SELECT KQ.MAHV, KQ.MAMH, MAX_LANTHI, KQUA
			FROM KETQUATHI KQ JOIN
			(
				SELECT MAHV, MAMH, MAX(LANTHI) MAX_LANTHI
				FROM KETQUATHI
				GROUP BY MAHV, MAMH
			) AS B
			ON KQ.MAHV = B.MAHV AND KQ.MAMH = B.MAMH AND LANTHI = MAX_LANTHI
		) AS C
		GROUP BY MAHV, KQUA
		HAVING KQUA = 'Dat'
	) AS D
	ON A.MAHV = D.MAHV AND COUNT_MH = COUNT_PASS
) AS E ON HV.MAHV = E.MAHV

-- III.33 Tìm học viên (mã học viên, họ tên) đã thi tất cả các môn đều đạt (chỉ xét lần thi thứ 1)
SELECT HV.MAHV, (HO+' '+TEN) HOTEN
FROM HOCVIEN HV JOIN
(
	SELECT A.MAHV
	FROM
	(
		SELECT MAHV, COUNT(*) COUNT_PASS
		FROM KETQUATHI
		GROUP BY MAHV, LANTHI, KQUA
		HAVING LANTHI = 1 AND KQUA = 'Dat'
	) AS A
	WHERE COUNT_PASS = (SELECT COUNT(*) FROM MONHOC)
) AS B ON HV.MAHV = B.MAHV

-- III.35 Tìm học viên (mã học viên, họ tên) có điểm thi cao nhất trong từng môn (lấy điểm ở lần thi sau cùng). 
SELECT HV.MAHV, (HO+' '+TEN) HOTEN, KQ.MAMH
FROM HOCVIEN HV
JOIN KETQUATHI KQ ON HV.MAHV = KQ.MAHV
JOIN
(
	SELECT MAMH, MAX(DIEM) MAX_DIEM
	FROM 
	(
		SELECT KQ.MAHV, KQ.MAMH, MAX_LANTHI, DIEM
		FROM KETQUATHI KQ JOIN
		(
			SELECT MAHV, MAMH, MAX(LANTHI) MAX_LANTHI
			FROM KETQUATHI
			GROUP BY MAHV, MAMH
		) AS B
		ON KQ.MAHV = B.MAHV AND KQ.MAMH = B.MAMH AND LANTHI = MAX_LANTHI
	) AS C
	GROUP BY MAMH
) AS D
ON KQ.MAMH = D.MAMH AND DIEM = MAX_DIEM