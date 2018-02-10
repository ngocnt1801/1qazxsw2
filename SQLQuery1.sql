USE snkrkorea
GO
----------
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


---use LoginDB------

Create Procedure getInfo3
@username varchar(50),
@password varchar(50) OUTPUT
as
	select @password = password from tbl_users where username = @username

go
/*run procedure*/
getInfo

------use output parameter---------------
Declare @Pass varchar(50)
execute getInfo3 'ngoc', @password = @Pass OUTPUT
print 'Pass is ' + @Pass
go


--- không cần thiết phải làm trigger cho insert một dòng vào bảng order thì nó lấy ngày hiện tại
-- chỉ cần để giá trị default của nó là GETDATE() là được 
-- đã test cách này thành công

create procedure insertOrder
@user varchar(50),
@orderId varchar(50),
@totalAmount varchar(50)
as
	insert into tbl_order(username,orderID,totalAmount)
	values(@user,@orderId,@totalAmount)
go

insertOrder 'ngoc','ngoc3',25

create trigger insertNewOrder
ON tbl_order
after INSERT
AS
Begin
	update tbl_order
	set date = GETDATE()
	where orderID = 
end


-----QUAN----------------------------------------------
--GetAllRole
SELECT name
FROM tbl_role
--GetImageOfPost
CREATE PROCEDURE GetImageOfPost
@postId int
AS
	SELECT url
	FROM [tbl_image]
	WHERE postId = @postId
GO
--DeleteImage
CREATE PROCEDURE DeleteImage
@imageId int
AS
	DELETE 
	FROM [tbl_image]
	WHERE imageId = @imageId
GO
--Get a Post by postID
CREATE PROCEDURE GetPostById
@Id int
AS
	SELECT * 
	FROM [tbl_post]
	WHERE postId = @Id
GO
--Delete Post 
CREATE PROCEDURE DeletePost
@Id int
AS
	DELETE 
	FROM [tbl_post]
	WHERE postId = @Id
GO
--Get all comment of post 
CREATE PROCEDURE GetPostComment
@PostId int
AS
	SELECT *
	FROM [tbl_comment]
	WHERE postId = @PostId
GO
--