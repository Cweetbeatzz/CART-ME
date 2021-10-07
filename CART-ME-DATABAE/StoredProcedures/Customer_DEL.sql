CREATE PROCEDURE [dbo].[Customer_DEL]
  @Id int
AS
BEGIN
set nocount on;
	 DELETE 
	 FROM [dbo].[Customers]
	 WHERE Id = @Id
	 


END