CREATE PROCEDURE [dbo].[SaleDB_Insert]
@sale_id int,
@product_id int,
@purchase_price money,
@tax money,
@quantity int

AS
BEGIN

set nocount on;
	 INSERT INTO dbo.Sale_Details(sale_id,product_id,purchase_price,tax,quantity)
	 VALUES (@sale_id,@product_id,@purchase_price,@tax,@quantity);
	 
	 

END