CREATE PROCEDURE [dbo].[Inventory_GetAll]
AS
BEGIN
set nocount on;
	 SELECT [Id],[product_id],[quatity],[purchase_price],[purchase_date]
	 FROM dbo.Inventory
	 


END
