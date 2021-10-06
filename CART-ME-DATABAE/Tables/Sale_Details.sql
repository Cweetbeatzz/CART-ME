CREATE TABLE [dbo].[Sale_Details]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[sale_id] INT NOT NULL, 
	[product_id] INT NOT NULL, 
	[purchase_price] MONEY NOT NULL, 
	[tax] MONEY NOT NULL DEFAULT 0, 
	[quantity] INT NOT NULL DEFAULT 1, 
	CONSTRAINT [FK_sale_detail_ToSale] FOREIGN KEY (sale_id) REFERENCES Sale(Id), 
	CONSTRAINT [FK_sale_detail_ToProduct] FOREIGN KEY (product_id) REFERENCES Products(Id)
)