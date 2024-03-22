CREATE PROCEDURE [dbo].[spAsset_Get]
	@Id int
AS
	begin
		select AssetId, AssetName, AssetSerialNumber, AssetType, AssetOwner, ApprovedBy
		from dbo.[Asset] 
		where AssetId = @Id;
	end
