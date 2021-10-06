CREATE PROCEDURE [dbo].[Customer_REG]
	@Id nvarchar(128),
	@firstname nvarchar(50),
	@lastname nvarchar(50),
	@email nvarchar(256)

AS
BEGIN


set nocount on;
	 INSERT INTO dbo.[Customers] (Id, firstname, lastname, email) 
	 VALUES (@Id, @firstname, @lastname, @email); 
	 
	 
	 

END
