﻿USE snkrkorea
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
----------------check exist---
IF EXISTS ( SELECT *	FROM [tbl_user] WHERE tbl_user.userId = 'testuser' AND tbl_user.password = 'Testuser1234')
Begin 
	print	'exist'
End
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
--Get comment of a comment
CREATE PROCEDURE GetCommentOfComment
@CoId int
AS
	SELECT *
	FROM [tbl_comment]
	WHERE parentId = @CoId
GO
--Delete comment 
CREATE PROCEDURE DeleteComment
@CoId int
AS
	DELETE
	FROM [tbl_comment]
	WHERE id = @CoId
GO
--Edit comment
CREATE PROCEDURE UpdateComment
@CoId int, @Title nvarchar(50), @Content nvarchar(MAX)
AS
	UPDATE [tbl_comment]
	SET	tbl_comment.title = @Title, tbl_comment.commentContent = @Content ,  tbl_comment.time=GETDATE()
	WHERE id = @CoId
GO
--Login 
CREATE PROCEDURE CheckLogin
@Role int OUTPUT,
@UserName varchar(50), @Password varchar(50)
AS
	BEGIN
		IF EXISTS (		SELECT *	FROM [tbl_user] WHERE tbl_user.userId = @UserName AND tbl_user.password=@Password	)
			SET @Role =  (		SELECT role	FROM [tbl_user] WHERE tbl_user.userId = @UserName AND tbl_user.password=@Password	);
		ELSE
			SET @Role = 0;
	END
--Change Password
CREATE PROCEDURE ChangePassword
@UserId varchar(50), @newPass varchar(50)
AS
	UPDATE [tbl_user]
	SET	[tbl_user].password = @newPass
	WHERE userId = @UserId
GO
--Get users by name
CREATE PROCEDURE GetUserByName
@FullName nvarchar(50)
AS
	SELECT *
	FROM [tbl_user]
	WHERE tbl_user.fullname like @FullName
GO
--Get list product with discount and time sale
SELECT dbo.tbl_product.*, dbo.tbl_product_deal.discount, dbo.tbl_product_deal.type, dbo.tbl_deal.startTime, dbo.tbl_deal.duration
FROM            dbo.tbl_deal INNER JOIN
                         dbo.tbl_product_deal ON dbo.tbl_deal.id = dbo.tbl_product_deal.dealId INNER JOIN
                         dbo.tbl_product ON dbo.tbl_product_deal.productId = dbo.tbl_product.productId
WHERE dbo.tbl_product.productId = dbo.tbl_product_deal.	productId	
--Add product
CREATE PROCEDURE AddProduct
@Id int, @Name nvarchar(50), @Brand nvarchar(50), @Price money, @Size int
--Update product information		
--Add order
--Update order status (staff)
--Delete order (staff)
--Add deal
--Delete Deal
--Get deal are activity
--Get product with deal
--Add product are allow in voucher
--Update voucher
CREATE PROCEDURE UpdateVoucher
@Id int, @type bit, @discount int, @description nvarchar(250), 
@startTime datetime, @duration int, @amount int
AS
	UPDATE dbo.tbl_voucher
	SET	dbo.tbl_voucher.type = @type, dbo.tbl_voucher.discount = @discount, dbo.tbl_voucher.description = @description,
		dbo.tbl_voucher.startTime = @startTime, dbo.tbl_voucher.duration = @duration, dbo.tbl_voucher.amount =@amount
	WHERE dbo.tbl_voucher.voucherId = @Id
GO
--Get all voucher
SELECT *
FROM dbo.tbl_voucher
------------------NGOC -----------------
--------------PROCEDURE-----------------
----- get role name ---------
select name
from tbl_role
where roleid = 1
------ get image of product ------
select url
from tbl_image
where productId = 1
---------- add image ---------
create procedure AddImageOfProduct
@Url varchar(255),
@ProductId int
AS
	INSERT INTO tbl_image(url, productId)
	VALUES (@Url, @ProductId)
GO

create procedure AddImageOfPost
@Url varchar(255),
@PostId int
AS
	INSERT INTO tbl_image(url, postId)
	VALUES (@Url, @PostId)
GO

--------- Update Post ------------
create procedure UpdatePost
@Title nvarchar(50),
@Content nvarchar(MAX),
@PostId int
AS
	UPDATE tbl_post
	SET title = @Title, postContent = @Content
	WHERE postId = @PostId
GO

--------- Add Post --------------
create procedure AddPost
@Title nvarchar(50),
@Content nvarchar(MAX),
@UserId varchar(50)
AS
	INSERT INTO tbl_post(title, postContent, timePost, userId)
	VALUES(@Title, @Content, GETDATE(), @UserId)
GO

---------Add Comment -------------
create procedure AddCommentOFProduct
@Title nvarchar(50),
@Content nvarchar(MAX),
@ProductId int, 
@AuthorId varchar(50)
AS
	INSERT INTO tbl_comment(title, commentContent, productId, time, authorId)
	VALUES (@Title, @Content, @ProductId, GETDATE(), @AuthorId)
GO

create procedure AddCommentOFPost
@Title nvarchar(50),
@Content nvarchar(MAX),
@PostId int, 
@AuthorId varchar(50)
AS
	INSERT INTO tbl_comment(title, commentContent, postId, time, authorId)
	VALUES (@Title, @Content, @PostId, GETDATE(), @AuthorId)
GO

create procedure ReplyComment
@Title nvarchar(50),
@Content nvarchar(MAX), 
@ParentId int,
@AuthorId varchar(50)
AS
	INSERT INTO tbl_comment(title, commentContent, parentId, time, authorId)
	VALUES (@Title, @Content, @ParentId, GETDATE(), @AuthorId)
GO

-------- Add Account --------------
create procedure AddAccount
@UserId varchar(50),
@Password varchar(50),
@Email varchar(250),
@Fullname varchar(50),
@Address nvarchar(250),
@Phone varchar(15),
@Gender int, 
@Role int
AS
	INSERT INTO tbl_user(userId, password, email, fullname, address, phone, gender, role, date_reg)
	VALUES (@UserId, @Password, @Email, @Fullname, @Address, @Phone, @Gender, GETDATE())
GO

--------------Update Profile ---------------
create procedure UpdateProfile
@UserId varchar(50),
@Password varchar(50),
@Email varchar(250),
@Fullname varchar(50),
@Address nvarchar(250),
@Phone varchar(15),
@Gender int, 
@Role int
AS
	UPDATE tbl_user
	SET email = @Email, 
		phone = @Phone, 
		fullname = @Fullname, 
		address = @Address, 
		gender = @Gender
	WHERE userId = @UserId
GO

create procedure ChangeRole
@UserId varchar(50),
@Role int
AS
	UPDATE tbl_user
	SET role = @Role
	WHERE role = @Role
GO

----------- delete product ------------
create procedure DeleteProduct
@ProductId int
AS
	DELETE 
	FROM tbl_product
	WHERE productId = @ProductId
GO

----------- update quantity product -----------
create procedure UpdateQuantityProduct
@ProductId int,
@Quantity int
AS
	UPDATE tbl_product
	SET quantity = @Quantity
	WHERE productId = @ProductId
GO
------------ cancel order ---------------
create procedure CancelOrder
@OrderId int
AS
	UPDATE tbl_order
	SET status =  5 --status Cancel -----
	WHERE id = @OrderId
GO

---------- add deal for each product -------------
create procedure AddDealForProduct
@ProductId int,
@Discount int,
@Type bit
AS
	INSERT INTO tbl_product_deal(productId, discount, type)
	VALUES (@ProductId, @Discount, @Type)
GO

------------ update deal --------------
create procedure UpdateDealInformation
@DealId int,
@Content nvarchar(50),
@StartTime datetime,
@Duration int
AS
	UPDATE tbl_deal
	SET dealContent = @Content, startTime = @StartTime, duration = @Duration
	WHERE id = @DealId
GO

create procedure ChangeProductDiscount
@DealId int,
@ProductId int,
@Discount int,
@Type bit
AS
	UPDATE tbl_product_deal
	SET discount = @Discount, type = @Type
	WHERE productId = @ProductId AND dealId = @DealId
GO

---------- add product for voucher ---------
create procedure AddProductOfVoucher
@Voucher varchar(50),
@ProductId int
AS
	INSERT INTO tbl_voucher_product(voucherId, productId)
	VALUES(@Voucher, @ProductId)
GO

--------- delete voucher ---------------
create procedure DeleteVoucher
@VoucherId int
AS
	DELETE 
	FROM tbl_voucher
	WHERE voucherId = @VoucherId
GO
