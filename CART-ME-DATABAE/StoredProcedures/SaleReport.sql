CREATE PROCEDURE [dbo].[SaleReport]
AS
set nocount on;
	SELECT [S].[Id], [S].[sale_date], [S].[sub_total], [S].[tax], [S].[total], [u].[firstname], [u].[lastname], [u].[email]
	FROM dbo.Sale s
	inner join dbo.[Customers] u on  s.cashier_id = u.Id;
RETURN 0