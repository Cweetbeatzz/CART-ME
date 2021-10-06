CREATE PROCEDURE [dbo].[Sale_INSERT]
@Id int output,
@cashier_id nvarchar(128),
@sale_date datetime2,
@sub_total money,
@tax money,
@total money
AS
BEGIN

set nocount on;
	 INSERT INTO dbo.Sale (cashier_id,sale_date,sub_total,tax,total)
	 VALUES (@cashier_id,@sale_date,@sub_total,@tax,@total);
	 
	 SELECT @Id = SCOPE_IDENTITY();

END
