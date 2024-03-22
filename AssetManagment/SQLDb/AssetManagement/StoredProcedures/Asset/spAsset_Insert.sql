CREATE PROCEDURE [dbo].[spAsset_Insert]
	@AssetName nvarchar(50),
	@AssetSerialNumber nvarchar(50),
	@AssetType nvarchar(15),
	@AssetOwner nvarchar(50),
	@ApprovedBy	nvarchar(50)
AS
begin
	insert into dbo.[Asset] (AssetName, AssetSerialNumber, AssetType, AssetOwner, ApprovedBy)
	values (@AssetName, @AssetSerialNumber, @AssetType, @AssetOwner, @ApprovedBy);
end
