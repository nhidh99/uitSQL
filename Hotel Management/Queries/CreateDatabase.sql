create database QuanLiKhachSan
go

use QuanLiKhachSan
go

/*==============================================================*/
/* Table: CTPT                                                  */
/*==============================================================*/
create table CTPT 
(
   MAPHIEU              integer                        not null,
   CMND                 varchar(15)                    not null,
   MALOAIKHACH          int			                   not null,
   TENKHACH             nvarchar(30)                   not null,
   DIACHI               nvarchar(50)                   not null,
   constraint PK_CTPT primary key (MAPHIEU, CMND)
);
go

/*==============================================================*/
/* Table: HOADON                                                */
/*==============================================================*/
create table HOADON 
(
   MAHOADON             integer		identity(1000,1)   not null ,
   TENKHACH             nvarchar(30)                   not null,
   DIACHI               nvarchar(50)                   not null,
   NGAYHOADON           date                           not null,
   TRIGIA               money                          not null,
   constraint PK_HOADON primary key (MAHOADON)
);
go

/*==============================================================*/
/* Table: LOAIKHACH                                             */
/*==============================================================*/
create table LOAIKHACH 
(
   MALOAIKHACH          int		 identity(2000, 1)	   not null,
   TENLOAIKHACH         nvarchar(30)                   not null,
   KHADUNG				bit				  		       not null,
   constraint PK_LOAIKHACH primary key (MALOAIKHACH)
);
go

/*==============================================================*/
/* Table: LOAIPHONG                                             */
/*==============================================================*/
create table LOAIPHONG 
(
   MALOAIPHONG          varchar(10)                    not null,
   DONGIA               money                          not null,
   constraint PK_LOAIPHONG primary key (MALOAIPHONG)
);
go

/*==============================================================*/
/* Table: PHIEUTHUE                                             */
/*==============================================================*/
create table PHIEUTHUE 
(
   MAPHIEU              integer    identity(3000,1)    not null,
   MAPHONG              varchar(10)                    not null,
   MAHOADON             integer                        null,
   NGAYTHUE             date                           not null,
   LOAIPHONG			varchar(10)					   not null,
   DONGIA               money                          not null,
   THANHTIEN            money                          null,
   constraint PK_PHIEUTHUE primary key (MAPHIEU)
);
go

/*==============================================================*/
/* Table: PHONG                                                 */
/*==============================================================*/
create table PHONG 
(
   MAPHONG              varchar(10)                    not null,
   MALOAIPHONG          varchar(10)                    null,
   MATINHTRANG          varchar(10)                    not null,
   GHICHU               nvarchar(40)                   null,
   constraint PK_PHONG primary key (MAPHONG),
);
go

/*==============================================================*/
/* Table: THAMSO                                                */
/*==============================================================*/
create table THAMSO 
(
   MATHAMSO             varchar(10)                    not null,
   TENTHAMSO            nvarchar(30)                   not null,
   GIATRI               float                          not null,
   constraint PK_THAMSO primary key (MATHAMSO)
);
go

/*==============================================================*/
/* Table: TINHTRANG                                             */
/*==============================================================*/
create table TINHTRANG 
(
   MATINHTRANG          varchar(10)                    not null,
   TENTINHTRANG         nvarchar(30)                   not null,
   constraint PK_TINHTRANG primary key (MATINHTRANG)
);
go

/*==============================================================*/
/* Table: PHANQUYEN                                             */
/*==============================================================*/
create table PHANQUYEN
(
	TENDANGNHAP varchar(30) not null,
	MATKHAU varchar(30) not null,
	PHANQUYEN varchar(10) not null,
	constraint PK_PHANQUYEN primary key (TENDANGNHAP)
);
go

SET DATEFORMAT MDY

INSERT INTO LOAIPHONG (MALOAIPHONG,DONGIA) VALUES ('A','150000');
INSERT INTO LOAIPHONG (MALOAIPHONG,DONGIA) VALUES ('B','170000');
INSERT INTO LOAIPHONG (MALOAIPHONG,DONGIA) VALUES ('C','200000');

INSERT INTO LOAIKHACH (TENLOAIKHACH,KHADUNG) VALUES (N'Nội địa','1');
INSERT INTO LOAIKHACH (TENLOAIKHACH,KHADUNG) VALUES (N'Nước ngoài','1');

INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('101','B','PHHO',NULL);
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('102','C','PHTR',NULL);
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('103','B','PHSC',N'Sửa bóng đèn');
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('104','A','PHHO',N'Sửa rèm cửa');
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('105','B','PHTR',NULL);
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('201','A','PHHO',N'Hỏng giường');
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('202','B','PHTR',NULL);
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('203','A','PHTR',NULL);
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('204','C','PHTR',NULL);
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('205','A','PHHO',NULL);
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('301','A','PHHO',N'Sửa ống nước');
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('302','B','PHTR',N'Thiếu gối ôm');
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('303','C','PHHO',N'Hỏng bồn rửa mặt');
INSERT INTO PHONG (MAPHONG,MALOAIPHONG,MATINHTRANG,GHICHU) VALUES ('304','C','PHHO',N'Máy lạnh khởi động chậm');

INSERT INTO TINHTRANG (MATINHTRANG,TENTINHTRANG) VALUES ('PHHO',N'Hỏng');
INSERT INTO TINHTRANG (MATINHTRANG,TENTINHTRANG) VALUES ('PHSC',N'Sửa');
INSERT INTO TINHTRANG (MATINHTRANG,TENTINHTRANG) VALUES ('PHTH',N'Thuê');
INSERT INTO TINHTRANG (MATINHTRANG,TENTINHTRANG) VALUES ('PHTR',N'Trống');

INSERT INTO PHANQUYEN (TENDANGNHAP,MATKHAU,PHANQUYEN) VALUES ('admin','admin','admin');
INSERT INTO PHANQUYEN (TENDANGNHAP,MATKHAU,PHANQUYEN) VALUES ('user','user','user');

INSERT INTO THAMSO (MATHAMSO,TENTHAMSO,GIATRI) VALUES ('KHTD',N'Số khách tối đa mỗi phòng','3');
INSERT INTO THAMSO (MATHAMSO,TENTHAMSO,GIATRI) VALUES ('PTK3',N'Phụ thu khách thứ 3','0.25');
INSERT INTO THAMSO (MATHAMSO,TENTHAMSO,GIATRI) VALUES ('PTNN',N'Phụ thu khách nước ngoài','0.5');

alter table CTPT
   add constraint FK_CTPT_PHIEUTHUE foreign key (MAPHIEU)
      references PHIEUTHUE (MAPHIEU)
alter table CTPT
   add constraint FK_CTPT_LOAIKHACH foreign key (MALOAIKHACH)
      references LOAIKHACH (MALOAIKHACH)

alter table PHIEUTHUE
   add constraint FK_PHIEUTHU_HOADON foreign key (MAHOADON)
      references HOADON (MAHOADON)
alter table PHIEUTHUE
   add constraint FK_PHIEUTHU_PHONG foreign key (MAPHONG)
      references PHONG (MAPHONG)

alter table PHONG
   add constraint FK_PHONG_LOAIPHONG foreign key (MALOAIPHONG) references LOAIPHONG(MALOAIPHONG)
   ON DELETE SET NULL ON UPDATE CASCADE
alter table PHONG
   add constraint FK_PHONG_TINHTRANG foreign key (MATINHTRANG)
      references TINHTRANG (MATINHTRANG)