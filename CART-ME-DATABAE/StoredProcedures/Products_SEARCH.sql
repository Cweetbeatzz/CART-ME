CREATE PROCEDURE [dbo].[Products_SEARCH]

@Fither nvarchar(50)

AS
BEGIN
     SELECT * 
     FROM dbo.Products
     WHERE product_name = @Fither

END