create table tblTruongHaiBasUnit
(
	UnitID varchar(10) primary key,
	NameChinese nvarchar(100),
	NameVietnam nvarchar(100),
	NameEnglish nvarchar(100),
	NameOther nvarchar(100),
	Remark nvarchar(200) 
)
create table tblTruongHaiBasProductGroup
(
	GroupID varchar(10) primary key,
	NameChinese nvarchar(100),
	NameVietnam nvarchar(100),
	NameEnglish nvarchar(100),
	NameOther nvarchar(100),
	Remark nvarchar(200) 
)
create table tblTruongHaiBasProductType
(
	TypeID varchar(10) primary key,
	NameChinese nvarchar(100),
	NameVietnam nvarchar(100),
	NameEnglish nvarchar(100),
	NameOther nvarchar(100),
	Remark nvarchar(200) 
)
create table tblTruongHaiBasProductInfo
(
	ProductAID varchar(20) primary key,
	ProductID varchar(30),
	GroupID varchar(10), --khóa phụ
	NameChinese nvarchar(200),
	NameVietnam nvarchar(200),
	NameEnglish nvarchar(200),
	NameOther nvarchar(200),
	Specification nvarchar(200),
	TypeID varchar(10), --khóa phụ
	UnitID varchar(10), --khóa phụ 
	SafetyQty numeric(18,2),
	Remark nvarchar(200) 
)