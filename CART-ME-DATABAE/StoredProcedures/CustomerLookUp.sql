CREATE PROCEDURE [dbo].[CustomerLookUp]
	@cashier_id int,
	@sale_date datetime2

AS
BEGIN


set nocount on;
	 SELECT Id 
	 FROM dbo.Sale 
	 WHERE (cashier_id = @cashier_id AND sale_date = @sale_date);
	 
	 
	 

END
