CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [sale_date] DATETIME2 NOT NULL, 
    [sub_total] MONEY NOT NULL, 
    [tax] MONEY NOT NULL, 
    [total] MONEY NOT NULL, 
    [cashier_id] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [FK_Sale_ToUser] FOREIGN KEY (cashier_id) REFERENCES [Customers](Id)
)

