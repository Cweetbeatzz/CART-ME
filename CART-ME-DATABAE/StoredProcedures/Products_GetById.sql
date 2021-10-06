CREATE PROCEDURE [dbo].[Products_GetById]
	@iD INT
AS
BEGIN
set nocount on;
	 SELECT Id,product_name,[description],retail_price,quantity_in_stock,is_taxable
	 FROM dbo.Products
	 WHERE iD = Id;


END
