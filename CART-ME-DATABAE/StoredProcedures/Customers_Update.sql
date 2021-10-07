CREATE PROCEDURE [dbo].[Customers_UPDATE]
	@Id int,
	@firstname nvarchar(50),
	@lastname nvarchar(50),
	@email nvarchar(256),
	@password nvarchar(256),
	@confirm_password nvarchar(256)

AS
BEGIN


set nocount on;
	 UPDATE dbo.Customers
	 SET 
		   firstname = @firstname, 
		   lastname = @lastname, 
		   email = @email, 
		   [password] = @password, 
		   confirm_password = @confirm_password
		 
	 WHERE Id = @Id;

END