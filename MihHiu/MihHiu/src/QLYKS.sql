﻿USE master
IF EXISTS(SELECT *FROM SYS.DATABASES WHERE NAME ='QLYKS')
DROP DATABASE QLYKS
GO
CREATE DATABASE QLYKS
GO
USE QLYKS
GO

--KHACHHANG
CREATE TABLE KHACHHANG
(
	MAKHACHHANG  NVARCHAR(250) NOT NULL PRIMARY KEY,
	HOTEN	NVARCHAR(250) NOT NULL,
	SDT		NVARCHAR(250)  NOT NULL,
	CCCD	NVARCHAR(250)	
)

--LOAIPHONG
CREATE TABLE LOAIPHONG
(
	MALOAI	NVARCHAR(250) NOT NULL PRIMARY KEY,
	TENLOAI	NVARCHAR(250) NOT NULL,
	GIAPHONG  NVARCHAR(250) NOT NULL,
	SUCCHUA		NVARCHAR(250)
)

--PHONG
CREATE TABLE PHONG
(
	MAPHONG NVARCHAR(250) NOT NULL PRIMARY KEY,
	MALOAIPHONG NVARCHAR(250) NOT NULL FOREIGN KEY REFERENCES LOAIPHONG(MALOAI),
	SOPHONG NVARCHAR(250) NOT NULL,
	SOTANG NVARCHAR(250) 
)

--PHIEUDATPHONG
CREATE TABLE PHIEUDATPHONG
(
	MAPHIEUDAT  NVARCHAR(250) NOT NULL PRIMARY KEY,
	MAKHACHHANG NVARCHAR(250) NOT NULL FOREIGN KEY REFERENCES KHACHHANG(MAKHACHHANG),
	NGAYDAT		DATETIME
)

--CHITIETPHIEUDAT
CREATE TABLE CTPD
(
	MAPHIEUDAT	NVARCHAR(250) NOT NULL FOREIGN KEY REFERENCES PHIEUDATPHONG(MAPHIEUDAT) ,
	MAPHONG		NVARCHAR(250) NOT NULL FOREIGN KEY REFERENCES PHONG(MAPHONG) ,
	NGAYTRAPHONG	DATETIME,
	
	
	
)

--HOADON
CREATE TABLE HOADON
(
	MAHOADON	NVARCHAR(250) NOT NULL PRIMARY KEY,
	TENHOADON	NVARCHAR(250)	NOT NULL,
	NGAYLAP		DATETIME
)


--DICHVU
CREATE TABLE DICHVU
(
	MADICHVU	NVARCHAR(250) NOT NULL PRIMARY KEY,
	TENDICHVU	NVARCHAR(250)	NOT NULL,
	GIATIEN		NVARCHAR(250)

)


--CHITIETHOADDON
CREATE TABLE CTHD
(
	MAHOADON	NVARCHAR(250)	NOT NULL FOREIGN KEY REFERENCES HOADON(MAHOADON),
	MAPHIEUDAT	NVARCHAR(250)	NOT NULL FOREIGN KEY REFERENCES PHIEUDATPHONG(MAPHIEUDAT),
	MAPHONG		NVARCHAR(250) NOT NULL FOREIGN KEY REFERENCES PHONG(MAPHONG),
	TONGTIEN	NVARCHAR(250)
)


-------------------------------------------------------------
----------------------NHAPLIEU-------------------------------
--------------------------------------------=----------------

--DICHVU
INSERT INTO DICHVU VALUES('DV1','Gym','200.000VND')
INSERT INTO DICHVU VALUES('DV2','Ăn Sáng','150.000VND')
INSERT INTO DICHVU VALUES('DV3','Suối nước nóng','150.000VND')
INSERT INTO DICHVU VALUES('DV4','Thuê xe máy','200.000VND')
INSERT INTO DICHVU VALUES('DV5','Đưa rước bằng xe du lịch','200.000VND')
select *FROM DICHVU


--KHACHHANG
INSERT INTO KHACHHANG VALUES('KH1','Trần Ngọc Quyên','0918999995','079198877856')
INSERT INTO KHACHHANG VALUES('KH2','Nguyễn Phương Trúc','0918676789','079576481764')
INSERT INTO KHACHHANG VALUES('KH3','Đặng Thế Nhân','0983838315','079999144555')
INSERT INTO KHACHHANG VALUES('KH4','Nguyễn Hoàng Huy','0985467849','079157830538')
INSERT INTO KHACHHANG VALUES('KH5','Trần Văn Tường','0918551746','079157930589')
select *from KHACHHANG


--LOAIPHONG
INSERT INTO LOAIPHONG VALUES('LO1','Phòng đơn','600.000VND','2 người')
INSERT INTO LOAIPHONG VALUES('LO2','Phòng đôi','900.000VND','4 người')
select *from LOAIPHONG

--PHONG
INSERT INTO PHONG VALUES('PH1','LO1','111','1')
INSERT INTO PHONG VALUES('PH2','LO2','124','2')
INSERT INTO PHONG VALUES('PH3','LO1','313','3')
INSERT INTO PHONG VALUES('PH4','LO1','311','3')
INSERT INTO PHONG VALUES('PH5','LO2','424','4')
INSERT INTO PHONG VALUES('PH6','LO1','415','4')
INSERT INTO PHONG VALUES('PH7','LO1','214','2')
SELECT *FROM PHONG


