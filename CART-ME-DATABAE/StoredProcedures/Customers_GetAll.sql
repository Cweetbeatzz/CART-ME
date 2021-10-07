CREATE PROCEDURE [dbo].[Customers_GetAll]
AS
BEGIN
set nocount on;
	 SELECT *
	 --[Id],[firstname],[lastname],[email],[password],[confirm_password]
	 FROM dbo.Customers
	 


END
