CREATE PROCEDURE [dbo].[Customer_DEL]
  @Id int
AS
BEGIN
set nocount on;
	 DELETE Id
	 FROM [dbo].[Customers]
	 WHERE Id = @Id
	 


END