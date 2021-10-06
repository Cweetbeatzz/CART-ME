CREATE TABLE [dbo].[Customers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 

    [firstname] NVARCHAR(50) NOT NULL, 
    [lastname] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(256) NOT NULL, 
    [create_date] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [password] NVARCHAR(256) NOT NULL, 
    [confirm_password] NVARCHAR(256) NOT NULL
)