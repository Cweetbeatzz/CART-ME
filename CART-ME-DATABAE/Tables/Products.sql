CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[product_name] NVARCHAR(50) NOT NULL, 
	[description] NVARCHAR(MAX) NOT NULL,
	[retail_price] MONEY NOT NULL, 
	[quantity_in_stock] INT NOT NULL DEFAULT 1,
	[create_date] DATETIME2 NOT NULL DEFAULT getutcdate(), 
	[last_modified] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [is_taxable] BIT NULL DEFAULT 1, 
	
)