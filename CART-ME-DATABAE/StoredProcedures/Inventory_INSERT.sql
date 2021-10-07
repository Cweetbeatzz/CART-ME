CREATE PROCEDURE [dbo].[Inventory_INSERT]

 @product_id int,
 @quantity int,
 @purcahse_price money,
 @purchase_date datetime2
AS
BEGIN
set nocount on;
	 INSERT INTO dbo.Inventory (product_id,quantity,purchase_price,purchase_date)
	 VALUES (@product_id, @quantity, @purcahse_price, @purchase_date);
	
	 


END