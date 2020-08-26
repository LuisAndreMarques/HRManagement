CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(250) NOT NULL, 
    [LastName] NVARCHAR(250) NOT NULL, 
    [Email] NVARCHAR(250) NULL, 
    [Telephone] NVARCHAR(100) NULL, 
    [Address1] NVARCHAR(250) NOT NULL, 
    [Address2] NVARCHAR(250) NULL, 
    [NIF] NVARCHAR(25) NULL
)
