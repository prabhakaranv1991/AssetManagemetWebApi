CREATE PROCEDURE [dbo].[spAsset_Update]
	@AssetId int,
	@AssetName nvarchar(50),
	@AssetSerialNumber nvarchar(50),
	@AssetType nvarchar(15),
	@AssetOwner nvarchar(50),
	@ApprovedBy	nvarchar(50)
AS
begin
	update dbo.[Asset] 
	set  AssetName= @AssetName, AssetSerialNumber = @AssetSerialNumber, AssetType = @AssetType, AssetOwner = @AssetOwner, ApprovedBy = @ApprovedBy
	where AssetId = @AssetId;
end
