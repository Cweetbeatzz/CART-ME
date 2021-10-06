CREATE TABLE [dbo].[Customers]
(
	[Id] NVARCHAR(128) NOT NULL PRIMARY KEY, 

    [firstname] NVARCHAR(50) NOT NULL, 
    [lastname] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(256) NOT NULL, 
    [create_date] DATETIME2 NOT NULL DEFAULT getutcdate()
)