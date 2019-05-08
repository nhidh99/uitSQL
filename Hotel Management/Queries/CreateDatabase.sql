/*==============================================================*/
/* Table: CTPT                                                  */
/*==============================================================*/
create table CTPT 
(
   CMND                 varchar(15)                    not null,
   MAPHIEU              integer                        not null,
   MALOAIKHACH          varchar(10)                    not null,
   TENKHACH             nvarchar(30)                   not null,
   DIACHI               nvarchar(50)                   not null,
   constraint PK_CTPT primary key (CMND, MAPHIEU)
);

/*==============================================================*/
/* Table: HOADON                                                */
/*==============================================================*/
create table HOADON 
(
   MAHOADON             integer                        not null,
   TENKHACH             nvarchar(30)                   not null,
   DIACHI               nvarchar(50)                   not null,
   NGAYHOADON           date                           not null,
   PHUTHU               money                          not null,
   TRIGIA               money                          not null,
   constraint PK_HOADON primary key (MAHOADON)
);

/*==============================================================*/
/* Table: LOAIKHACH                                             */
/*==============================================================*/
create table LOAIKHACH 
(
   MALOAIKHACH          varchar(10)                    not null,
   TENLOAIKHACH         nvarchar(30)                   not null,
   constraint PK_LOAIKHACH primary key (MALOAIKHACH)
);

/*==============================================================*/
/* Table: LOAIPHONG                                             */
/*==============================================================*/
create table LOAIPHONG 
(
   MALOAIPHONG          varchar(10)                    not null,
   TENLOAIPHONG         nvarchar(30)                   not null,
   DONGIA               money                          not null,
   constraint PK_LOAIPHONG primary key (MALOAIPHONG)
);

/*==============================================================*/
/* Table: PHIEUTHUE                                             */
/*==============================================================*/
create table PHIEUTHUE 
(
   MAPHIEU              integer                        not null,
   MAPHONG              varchar(10)                    not null,
   MAHOADON             integer                        null,
   NGAYTHUE             date                           not null,
   DONGIA               money                          not null,
   THANHTIEN            money                          null,
   constraint PK_PHIEUTHUE primary key (MAPHIEU)
);

/*==============================================================*/
/* Table: PHONG                                                 */
/*==============================================================*/
create table PHONG 
(
   MAPHONG              varchar(10)                    not null,
   MALOAIPHONG          varchar(10)                    not null,
   MATINHTRANG          varchar(10)                    not null,
   GHICHU               nvarchar(40)                   null,
   constraint PK_PHONG primary key (MAPHONG)
);

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

/*==============================================================*/
/* Table: TINHTRANG                                             */
/*==============================================================*/
create table TINHTRANG 
(
   MATINHTRANG          varchar(10)                    not null,
   TENTINHTRANG         nvarchar(30)                   not null,
   constraint PK_TINHTRANG primary key (MATINHTRANG)
);

alter table CTPT
   add constraint FK_CTPT_PHIEUTHU foreign key (MAPHIEU)
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
   add constraint FK_PHONG_LOAIPHONG foreign key (MALOAIPHONG)
      references LOAIPHONG (MALOAIPHONG)
alter table PHONG
   add constraint FK_PHONG_TINHTRANG foreign key (MATINHTRANG)
      references TINHTRANG (MATINHTRANG)
