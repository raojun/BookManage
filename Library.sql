use BookLibrary
go

create table ReaderType(
	rdType smallint not null,
	rdTypeName nvarchar(20) not null unique,
	CanLendQty int ,
	CanLendDay int ,
	CanContinueTimes int,
	PunishRate float,
	DateValid smallint,
constraint ReaderType_PK primary key (rdType)
)
go

create table [Reader](
	[rdID] int not null,
	[rdName] nvarchar(20) null,
	[rdSex] nchar(1) null,
	[rdType] smallint foreign key references ReaderType not null,
	[rdDept] nvarchar(20) null,
	[rdPhone] nvarchar(25) null,
	[rdEmail] nvarchar(25) null,
	[rdDateReg] datetime null,
	[rdPhoto] image null,
	[rdStatus] nchar(2) null,
	[rdBorrowQty] int null,
	[rdPwd] nvarchar(20) null,
	[rdAdminRoles] smallint null
constraint Reader_PK primary key(rdID)	
)
go

create table Book(
	bkID int not null,
	bkCode nvarchar(20) null,
	bkName nvarchar(50) null,
	bkAuthor nvarchar(30) null,
	bkPress nvarchar(50) null,
	bkdatePress datetime null,
	bkISBN nvarchar(15) null,
	bkCatalog nvarchar(30) null,
	bkLanguage smallint null,
	bkPages int null,
	bkPrice money null,
	bkDateIn datetime null,
	bkNum int null,
	bkBrief text null,
	bkCover image null,
	bkStatus nchar(2) null
constraint Book_PK primary key(bkID)
)
go

create table Borrow(
	BorrowId numeric(12,0) not null,
	rdID int foreign key references Reader not null,
	bkID int foreign key references Book not null,
	IdContinueTimes int null,
	IdDateOut datetime null,
	IdDateRetPlan datetime null,
	IdDateRetAct datetime null,
	IdOverDay int null,
	IdOverMoney money null,
	IdPunishMoney money null,
	IsHasReturn bit null,
	OperatorLend nvarchar(20) null,
	OperatorRet nvarchar(20) null
constraint Borrow_PK primary key(BorrowID)
)
go

insert into [ReaderType]	values(10,'教师',12,60,2,0.05,0);
insert into [ReaderType]	values(20,'本科生',8,30,1,0.05,4);
insert into [ReaderType]	values(21,'专科生',8,30,1,0.05,3);
insert into [ReaderType]	values(30,'硕士研究生',8,30,1,0.05,3);
insert into [ReaderType]	values(31,'博士研究生',8,30,1,0.05,4);
GO

insert into Reader values(11101,'饶俊','男',10,'长江大学计科院',null,null,'2012-4-12 0:00:00',null,'有效',1,123,8);
insert into Reader values(11102,'兔子','男',20,'计科院',null,null,'2013-10-21 0:00:00',null,'有效',2,123,0);
insert into Reader values(11103,'独孤影','男',21,'汉科',null,null,'2013-11-9 0:00:00',null,'有效',4,123,1);
insert into Reader values(11104,'小威','男',30,'计科院',null,null,'2013-1-23 0:00:00',null,'有效',3,123,2);
insert into Reader values(11105,'景恒','男',31,'计科院',null,null,'2013-3-21 0:00:00',null,'有效',2,123,4);
insert into Reader values(11106,'鹏鹏','男',20,'计科院',null,null,'2013-3-21 0:00:00',null,'无效',1,123,0);
GO