CREATE TABLE [dbo].[Asset]
(
	[AssetId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AssetName] NVARCHAR(50) NOT NULL, 
    [AssetSerialNumber] NVARCHAR(50) NOT NULL, 
    [AssetOwner] INT NOT NULL, 
    [ApprovedBy] INT NOT NULL, 
    [AssetType] NVARCHAR(25) NOT NULL
)
