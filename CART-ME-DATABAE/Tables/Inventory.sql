CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[product_id] INT NOT NULL, 
	[quatity] INT NOT NULL DEFAULT 1, 
	[purchase_price] MONEY NOT NULL, 
	[purchase_date] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    CONSTRAINT [FK_Inventory_ToProoduct] FOREIGN KEY (product_id) REFERENCES Products(Id)
)
