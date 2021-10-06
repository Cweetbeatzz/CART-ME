CREATE PROCEDURE [dbo].[Customer_REG]
	@Id int,
	@firstname nvarchar(50),
	@lastname nvarchar(50),
	@email nvarchar(256),
	@password nvarchar(256),
	@confirm_password nvarchar(256)

AS
BEGIN


set nocount on;
	 INSERT INTO dbo.[Customers] (Id, firstname, lastname, email, [password], confirm_password) 
	 VALUES (@Id, @firstname, @lastname, @email,@password,@confirm_password); 
	 
	 
	 

END
