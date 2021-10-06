CREATE PROCEDURE [dbo].[Products_GET]
AS
BEGIN

set nocount on;
	 SELECT Id,product_name,[description],retail_price,quantity_in_stock,is_taxable
	 FROM dbo.Products
	 ORDER BY product_name;

END
