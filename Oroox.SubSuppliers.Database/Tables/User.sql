CREATE TABLE [dbo].[User]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [CompanyName] NVARCHAR(100) NULL, 
    [ContactPersonName] NCHAR(30) NULL, 
    [AddressId] UNIQUEIDENTIFIER NULL, 
    [EmailAddress] NVARCHAR(75) NULL, 
    [CompanySizeId] UNIQUEIDENTIFIER NULL, 
    [WebsiteUrl] NCHAR(75) NULL, 
    [WebsiteUrl] NCHAR(75) NULL, 
    CONSTRAINT [FK_User_Address] FOREIGN KEY ([AddressId]) REFERENCES [Address](Id)
)
