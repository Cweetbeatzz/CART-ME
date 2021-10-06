CREATE PROCEDURE [dbo].[spCustomers]
	@Id int
AS
BEGIN
SET NOCOUNT ON;
	SELECT Id,firstname,lastname,email,create_date
	FROM [dbo].[Customers]
	where Id = @Id
END
