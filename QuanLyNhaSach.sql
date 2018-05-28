CREATE DATABASE QuanLyNhaSach
GO

USE QuanLyNhaSach
GO

CREATE TABLE CategoryBook
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)
)
GO

CREATE TABLE Book
(
	id INT IDENTITY  PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT '',
	idCategory INT NOT NULL FOREIGN KEY REFERENCES CategoryBook(id),
	author NVARCHAR(100) NOT NULL DEFAULT '',
	count INT NOT NULL DEFAULT 0,
	priceIn FLOAT NOT NULL DEFAULT 0
)
GO

CREATE TABLE ImportBook
(
	id INT IDENTITY PRIMARY KEY,
	
	date DATE NOT NULL DEFAULT GETDATE()
)
GO

CREATE TABLE ImportBookInfo
(
	idImportBook INT NOT NULL FOREIGN KEY REFERENCES ImportBook(id),
	idBook INT NOT NULL FOREIGN KEY REFERENCES Book(id),
	count INT NOT NULL DEFAULT 0,
	priceIn FLOAT NOT NULL DEFAULT 0
	CONSTRAINT PK_ImportBookInfo PRIMARY KEY (idImportBook,idBook)
)

CREATE TABLE Customer
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT ' ',
	address NVARCHAR(200)NOT NULL DEFAULT ' ',
	phoneNumber VARCHAR(11)NOT NULL DEFAULT ' ',
	email VARCHAR(100)NOT NULL DEFAULT ' ',
	owe FLOAT NOT NULL DEFAULT 0
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	idCustomer INT NOT NULL FOREIGN KEY REFERENCES Customer(id),
	date DATE NOT NULL DEFAULT GETDATE(),
	value FLOAT NOT NULL DEFAULT 0,
	owe float NOT NULL DEFAULT 0
)
GO

CREATE TABLE BillInfo
(
	idBill INT NOT NULL FOREIGN KEY REFERENCES Bill(id),
	idBook INT NOT NULL FOREIGN KEY REFERENCES Book(id),
	count INT NOT NULL DEFAULT 0,
	priceOut FLOAT NOT NULL DEFAULT 0
	CONSTRAINT PK_BillInfo PRIMARY KEY(idBill,idBook)
)
GO


CREATE TABLE CollectMoney
(
	id INT IDENTITY PRIMARY KEY,
	idCustomer INT NOT NULL FOREIGN KEY REFERENCES Customer(id),
	date DATE NOT NULL DEFAULT GETDATE(),
	money FLOAT NOT NULL DEFAULT 0
)
GO

CREATE TABLE ReportCount
(
	month INT CHECK(month >=0 and month <=12) DEFAULT MONTH(GETDATE()),
	year INT CHECK(year!=0) DEFAULT YEAR(GETDATE()) ,
	CONSTRAINT PK_ReportCount PRIMARY KEY(month,year)
)
GO

CREATE TABLE ReportCountInfo
(
	month INT NOT NULL ,
	year INT NOT NULL ,
	idBook INT NOT NULL FOREIGN KEY REFERENCES Book(id),
	firstCount INT NOT NULL DEFAULT 0,
	lastCount INT NOT NULL DEFAULT 0,
	addCount INT NOT NULL DEFAULT 0,
	CONSTRAINT PK_ReportCountInfo PRIMARY KEY( month,year,idBook)
)
GO
ALTER TABLE ReportCountInfo ADD CONSTRAINT PK_FK FOREIGN KEY(month,year)REFERENCES ReportCount(month,year)
GO

CREATE TABLE ReportOwe
(
	month INT CHECK(month >=0 and month <=12) DEFAULT MONTH(GETDATE()),
	year INT CHECK(year!=0) DEFAULT YEAR(GETDATE()),
	CONSTRAINT PK_ReportOwe PRIMARY KEY(month,year)
)
GO

CREATE TABLE ReportOweInfo
(
	month INT NOT NULL,
	year INT NOT NULL,
	idCustomer INT NOT NULL FOREIGN KEY REFERENCES Customer(id),
	firstOwe FLOAT NOT NULL DEFAULT 0,
	lastOwe FLOAT NOT NULL DEFAULT 0,
	addOwe FLOAT NOT NULL DEFAULT 0,
	CONSTRAINT PK_ReportOweInfo PRIMARY KEY (month,year,idCustomer)
)
GO
ALTER TABLE ReportOweInfo ADD CONSTRAINT PK_FKReportOweInfo FOREIGN KEY(month,year) REFERENCES ReportOwe(month,year)
GO

CREATE TABLE Account
(
	userName VARCHAR(100) NOT NULL DEFAULT '' PRIMARY KEY,
	displayName NVARCHAR(100),
	passWord VARCHAR(100) NOT NULL DEFAULT '',
	type INT NOT NULL DEFAULT 0 --0:Admin, 1:staff
)
GO


INSERT dbo.THAMSO VALUES('MinImport',150)
GO
INSERT dbo.THAMSO VALUES('MaxCount',300)
GO
INSERT dbo.THAMSO VALUES('MinCount',300)
GO
INSERT dbo.THAMSO VALUES('MaxOwe',300)
GO
INSERT dbo.THAMSO VALUES('PercentPrice',1.05)
GO
INSERT dbo.THAMSO VALUES('check',1)
GO


INSERT dbo.Account VALUES('tan',N'A','tnd','0')
GO


CREATE PROC USP_Login
@userName VARCHAR(100),
@passWord VARCHAR(100)
AS
BEGIN
SELECT * FROM dbo.Account WHERE @userName=userName AND @passWord=passWord
END
GO

CREATE PROC USP_LoadListBook
AS
BEGIN
SELECT b.id,b.name,c.name as nameCategory,b.author,b.priceIn,b.count
FROM Book b,CategoryBook c
WHERE b.idCategory=c.id
END 
GO


CREATE PROC USP_GetListCategory
AS
BEGIN
SELECT * FROM CategoryBook 
END
GO



CREATE PROC USP_AddBook
@name NVARCHAR(100),
@idCategory INT,
@author NVARCHAR(100),
@priceIn INT,
@count INT
AS
BEGIN
INSERT dbo.Book(name,idCategory,author,priceIn,count) VALUES (
	@name,
	@idCategory,
	@author,
	@priceIn,
	@count)

END 
GO

CREATE PROC USP_RemoveBookByBookID
@id INT
AS
BEGIN
DELETE Book WHERE id=@id
END
GO

CREATE PROC USP_UpdateBook
@id INT,	
@name NVARCHAR(100),
@idCategory INT,
@author NVARCHAR(100),
@count INT,
@priceIn FLOAT
AS
BEGIN
UPDATE Book 
SET name=@name, idCategory=@idCategory,author=@author,priceIn=@priceIn,count=@count
WHERE id=@id
END
GO

CREATE PROC USP_AddCategory
@name NVARCHAR(100)
AS
BEGIN
INSERT CategoryBook(name) VALUES (@name)
END
GO

CREATE PROC USP_RemoveCategoryByCategoryID
@id INT
AS
BEGIN
DELETE CategoryBook WHERE id =@id
END
GO

CREATE PROC USP_UpdateCategory
@id INT,
@name NVARCHAR(100)
AS
BEGIN
UPDATE CategoryBook SET name=@name WHERE id = @id
END
GO

CREATE PROC USP_GetListCustomer
AS
BEGIN
SELECT*FROM Customer
END
GO


CREATE PROC USP_AddCustomer
@name NVARCHAR(100),
@address NVARCHAR(100),
@phoneNumber VARCHAR(100),
@email VARCHAR(100),
@owe FLOAT
AS
BEGIN
	INSERT Customer(name,address,phoneNumber,email,owe) VALUES(
	@name,
	@address,
	@phoneNumber,
	@email,
	@owe
	)
END
GO

CREATE PROC USP_UpdateCustomer
@id INT,
@name NVARCHAR(100),
@address NVARCHAR(100),
@phoneNumber VARCHAR(100),
@email VARCHAR(100),
@owe FLOAT
AS
BEGIN
	UPDATE Customer 
	SET
		name=@name,
		address=@address,
		phoneNumber=@phoneNumber,
		email=@email,
		owe=@owe
	WHERE id=@id
END
GO

CREATE PROC USP_RemoveCustomerByCustomerID
@id INT
AS
BEGIN
	DELETE Customer WHERE id= @id
END
GO

CREATE PROC USP_GetListBook
AS
BEGIN
	SELECT * FROM Book
END
GO

CREATE PROC USP_GetCategoryBookByBookID
@id INT
AS
BEGIN
	SELECT c.id,c.name FROM Book b,CategoryBook c WHERE b.idCategory=c.id AND b.id=@id
END
GO

CREATE PROC USP_InsertImportBookIntoDatabase
@date DATE
AS
BEGIN
	INSERT ImportBook(date) VALUES (@date)
END
GO

CREATE PROC USP_InsertImportBookInfoIntoDatabase
@idBook INT,
@count INT,
@priceIn FLOAT
AS
BEGIN
	DECLARE @importBookID INT
	SELECT @importBookID=MAX(id) FROM ImportBook

	INSERT ImportBookInfo(idImportBook,	idBook,	count ,	priceIn)VALUES(
		@importBookID,
		@idBook,
		@count,
		@priceIn
		)
END
GO

CREATE TRIGGER UTG_InsertImportBookInfo ON ImportBookInfo
FOR INSERT
AS
DECLARE @idBook INT
DECLARE @priceIn INT
DECLARE @count INT

DECLARE @priceBook INT
DECLARE @countBook INT
BEGIN
	SELECT @idBook=idBook,@priceIn=priceIn,@count=count  FROM inserted
	UPDATE Book SET count=count + @count , priceIn=@priceIn WHERE id=@idBook
END
GO

CREATE PROC USP_GetBookByBookID
@id INT
AS
BEGIN
SELECT * FROM Book WHERE id=@id
END
GO 


CREATE PROC USP_InsertBillIntoDatabase
@idCustomer INT,
@date Date,
@value FLOAT,
@owe FLOAT
AS
BEGIN
	INSERT dbo.Bill(idCustomer,date,value,owe)VALUES(
	@idCustomer,
	@date,
	@value,
	@owe
	)
END
GO

CREATE PROC USP_InsertBillInfoIntoDatabase
@idBook INT,
@count INT,
@priceOut FLOAT
AS
BEGIN
	DECLARE @BillID INT
	SELECT @BillID=MAX(id) FROM Bill

	INSERT BillInfo(idBill,idBook,count,priceOut)VALUES(
	@BillID,
	@idBook,
	@count,
	@priceOut
	)

END
GO

CREATE PROC USP_GetCustomerByCustomerID
@id INT
AS
BEGIN
	SELECT * FROM Customer WHERE id=@id
END
GO

CREATE PROC USP_InsertCollectMoneyIntoDatabase
@idCustomer INT,
@date Date,
@money FLOAT
AS
BEGIN
	INSERT CollectMoney(idCustomer,date,money)VALUES(
	@idCustomer,
	@date,
	@money
	)
END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO


CREATE PROC USP_GetAccountByUserName
@userName VARCHAR(100)
AS
BEGIN
	SELECT * FROM Account WHERE userName=@userName
END
GO

CREATE PROC USP_GetListAccount
AS
BEGIN
	SELECT*FROM Account
END
GO

CREATE PROC USP_InsertAccount
@userName VARCHAR(100),
@displayName NVARCHAR(100),
@passWord VARCHAR(100),
@type INT
AS
BEGIN
	IF((SELECT COUNT(*)FROM Account WHERE userName=@userName) = 0 AND @userName!='' AND @passWord!='')
		INSERT dbo.Account VALUES(@userName,@displayName,@passWord,@type)
END
GO

CREATE PROC USP_RemoveAccountByUserName
@userName VARCHAR(100)
AS 
BEGIN
	DELETE Account WHERE userName=@userName
END
GO

CREATE PROC USP_UpdateAccountByUserName
@userName VARCHAR(100),
@displayName NVARCHAR(100),
@passWord VARCHAR(100),
@type INT
AS 
BEGIN
	UPDATE Account SET displayName=@displayName ,passWord=@passWord, type=@type WHERE userName=@userName
END
GO

CREATE PROC USP_GetMinImport
AS
SELECT GiaTri FROM THAMSO WHERE TenThamSo='MinImport'
GO

CREATE PROC USP_SetMinImport
@minImport INT
AS
UPDATE THAMSO SET GiaTri=@minImport WHERE TenThamSo='MinImport'
GO

CREATE PROC USP_GetMaxCount
AS
SELECT GiaTri FROM THAMSO WHERE TenThamSo='MaxCount'
GO

CREATE PROC USP_SetMaxCount
@maxCount INT
AS
UPDATE THAMSO SET GiaTri=@maxCount WHERE TenThamSo='MaxCount'
GO

CREATE PROC USP_GetMinCount
AS
SELECT GiaTri FROM THAMSO WHERE TenThamSo='MinCount'
GO

CREATE PROC USP_SetMinCount
@minCount INT
AS
UPDATE THAMSO SET GiaTri=@minCount WHERE TenThamSo='MinCount'
GO

CREATE PROC USP_GetMaxOwe
AS
SELECT GiaTri FROM THAMSO WHERE TenThamSo='MaxOwe'
GO

CREATE PROC USP_SetMaxOwe
@maxOwe INT
AS
UPDATE THAMSO SET GiaTri=@maxOwe WHERE TenThamSo='MaxOwe'
GO

CREATE PROC USP_GetPercentPrice
AS
SELECT GiaTri FROM THAMSO WHERE TenThamSo='PercentPrice'
GO

CREATE PROC USP_SetPercentPrice
@percentPrice FLOAT
AS
UPDATE THAMSO SET GiaTri=@perCentPrice WHERE TenThamSo='PercentPrice'
GO

CREATE PROC USP_GetCheck
AS
SELECT GiaTri FROM THAMSO WHERE TenThamSo='check'
GO

CREATE PROC USP_SetCheck
@check INT
AS
UPDATE THAMSO SET GiaTri=@check WHERE TenThamSo='check'
GO

CREATE PROC USP_GetReportCount
@month INT,
@year INT
AS
BEGIN
	SELECT*FROM ReportCount WHERE month=@month AND year=@year
END
GO

CREATE PROC USP_LoadReportCount
@month INT,
@year INT
AS
BEGIN 
	SELECT b.name as bookName,rcI.firstCount as firstCount,rcI.addCount as addCount,rcI.lastCount as lastCount
	FROM ReportCount rc,ReportCountInfo rcI,Book b
	WHERE rc.month=rcI.month AND rc.year=rcI.year AND rcI.idBook=b.id AND rc.month=@month AND rc.year=@year
END
GO

CREATE PROC USP_InsertReportCount
@month INT,
@year INT
AS
BEGIN
	INSERT ReportCount VALUES(@month,@year)
END
GO

CREATE PROC USP_InsertReportCountInfo
@month INT,
@year INT,
@idBook INT,
@firstCount INT,
@lastCount INT,
@addCount INT
AS
BEGIN
	INSERT ReportCountInfo VALUES(
	@month ,
	@year ,
	@idBook ,
	@firstCount ,
	@lastCount ,
	@addCount 
	)
END
GO

CREATE PROC USP_GetReportCountInfoByTimeAndBookID
@month INT,
@year INT,
@idBook INT
AS
BEGIN
	SELECT * FROM ReportCountInfo rpI WHERE rpI.month=@month AND rpI.year=@year AND rpI.idBook=@idBook
END
GO

CREATE PROC USP_GetListBookID
AS
BEGIN
	SELECT distinct id FROM Book
END
GO

CREATE PROC USP_GetListImportBookInfoByTime
@month INT,
@year INT
AS
BEGIN
	SELECT imbI.idImportBook as idImportBook,imbI.idBook as idBook,imbI.count as count,imbI.priceIn as priceIn 
	FROM ImportBook imb,ImportBookInfo imbI 
	WHERE imb.id=imbI.idImportBook AND MONTH(imb.date)=@month AND YEAR(imb.date)=@year 
END
GO

CREATE PROC USP_GetListBillInfoByTime
@month INT,
@year INT
AS
BEGIN
	SELECT bI.idBill,bI.idBook,bI.count,bI.priceOut
	FROM Bill b,BillInfo bI
	WHERE b.id=bI.idBill AND MONTH(b.date)=@month AND YEAR(b.date)=@year 
END
GO

CREATE PROC USP_RemoveAllReportCountInfoInTime
@month INT,
@year INT
AS
BEGIN
	DELETE ReportCountInfo WHERE month=@month AND year=@year
END
GO

CREATE PROC USP_RemoveReportCount
@month INT,
@year INT
AS
BEGIN
	DELETE ReportCount WHERE month=@month AND year=@year
END
GO

CREATE PROC USP_GetReportOwe
@month INT,
@year INT
AS
BEGIN
	SELECT * FROM ReportOwe WHERE month=@month AND year=@year
END
GO

CREATE PROC USP_GetListCustomerID
AS
SELECT distinct id FROM Customer
GO

CREATE PROC USP_GetListCollectMoneyByTime
@month INT,
@year INT
AS 
BEGIN
	SELECT* FROM CollectMoney WHERE MONTH(date)=@month AND YEAR(date)=@year
END 
GO

CREATE PROC USP_GetListBillByTime
@month INT,
@year INT
AS 
BEGIN
	SELECT* FROM Bill WHERE MONTH(date)=@month AND YEAR(date)=@year
END 
GO

CREATE PROC USP_GetReportOweInfoByTimeAndCustomerID
@month INT,
@year INT,
@idCustomer INT
AS
BEGIN
	SELECT * FROM ReportOweInfo rpI WHERE rpI.month=@month AND rpI.year=@year AND rpI.idCustomer=@idCustomer
END
GO

CREATE PROC USP_InsertReportOweInfo
@month INT ,
@year INT,
@idCustomer INT,
@firstOwe FLOAT,
@lastOwe FLOAT,
@addOwe FLOAT
AS
BEGIN
	INSERT ReportOweInfo VALUES(@month , @year , @idCustomer , @firstOwe , @lastOwe , @addOwe)
END
GO

CREATE PROC USP_RemoveAllReportOweInfoInTime
@month INT,
@year INT
AS
BEGIN
	DELETE ReportOweInfo WHERE month=@month AND year=@year
END
GO

CREATE PROC USP_RemoveReportOwe
@month INT,
@year INT
AS
BEGIN
	DELETE ReportOwe WHERE month=@month AND year=@year
END
GO

CREATE PROC USP_LoadReportOwe
@month INT,
@year INT
AS
BEGIN 
	SELECT c.name as customerName,rcI.firstOwe as firstOwe,rcI.addOwe as addOwe,rcI.lastOwe as lastOwe
	FROM ReportOwe rc,ReportOweInfo rcI,Customer c
	WHERE rc.month=rcI.month AND rc.year=rcI.year AND rcI.idCustomer=c.id AND rc.month=@month AND rc.year=@year
END
GO

CREATE PROC USP_InsertReportOwe 
@month INT,
@year INT
AS 
BEGIN
	INSERT ReportOwe VALUES(@month,@year)
END
GO

CREATE TRIGGER UTG_InsertBillInfo ON BillInfo
FOR INSERT
AS
DECLARE @idBook INT
DECLARE @count INT
BEGIN
	SELECT @idBook=idBook, @count=count FROM inserted
	UPDATE Book SET count=count-@count WHERE id=@idBook
END
GO

CREATE PROC USP_GetListImportBook
AS
BEGIN
	SELECT*FROM ImportBook
END
GO

CREATE PROC USP_LoadListImportBookInfo
@id INT
AS
BEGIN
	SELECT b.id as idBook,b.name as nameBook,c.name as category,b.author as author, b.count as count,b.priceIn as priceIn
	FROM ImportBookInfo i,Book b,CategoryBook c
	WHERE i.idImportBook=@id AND i.idBook=b.id AND b.idCategory=c.id
END
GO

CREATE PROC USP_GetListBill
AS
BEGIN
	SELECT b.id as idBill, c.id as idCustomer, c.name as nameCustomer, b.date as date, b.value as value 
	FROM Bill b, Customer c 
	WHERE B.idCustomer=c.id
END
GO

CREATE PROC USP_LoadListBillInfo
@id INT
AS
BEGIN
	SELECT b.id as idBook,b.name as nameBook,c.name as category,b.author as author, bi.count as count,bi.priceOut as priceOut
	FROM BillInfo bi,Book b,CategoryBook     DateTime date = dtpkDateIn.Value;
            SaveImportBook(date);
	WHERE bi.idBill=@id AND bi.idBook=b.id AND b.idCategory=c.id
END
GO

delete ReportOwe
delete ReportOweInfo
delete CollectMoney
delete BillInfo
delete Bill
delete ImportBookInfo
delete ImportBook
delete ReportCountInfo
delete ReportCount
delete Book
delete CategoryBook

SELECT*FROM ReportCount
SELECT*FROM ReportCountInfo
select*from Customer
select*from Book
select*from ImportBook
select*from ImportBookInfo