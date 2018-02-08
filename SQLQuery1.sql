CREATE TRIGGER trg_UpdateTimeAdd
ON dbo.tbl_user
AFTER UPDATE	
AS
    UPDATE dbo.tbl_user
    SET date_reg = GETDATE()
    WHERE userid IN (SELECT DISTINCT userId FROM Inserted)
----------------------------------------------------
Insert Into dbo.tbl_user ([userId],[password],[email],[role],[date_reg]) 
values ('test2' , 'test1' , 'test1@test1' , 3  , GETDATE());
go
--------------------PROCEDURE------------------------
CREATE PROCEDURE register_user
	@UserName varchar(50), @UserPassword varchar(50), 
	@UserEmail varchar(250), @FullName varchar(50),
	@Address nvarchar(250), @Phone varchar(15),
	@Gender int, @Role int
AS 
	Insert Into dbo.tbl_user ([userId],[password],[email],[fullname],[address],[phone],[gender],[role],[date_reg])
	values (@UserName,  @UserPassword, @UserEmail, @FullName, @Address, @Phone, @Gender, @Role, GETDATE());
GO
