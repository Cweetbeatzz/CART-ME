CREATE PROCEDURE [dbo].[spCustomers]
	@Id nvarchar(128)
AS
BEGIN
SET NOCOUNT ON;
	SELECT Id,firstname,lastname,email,create_date
	FROM [dbo].[Customers]
	where Id = @Id
END
