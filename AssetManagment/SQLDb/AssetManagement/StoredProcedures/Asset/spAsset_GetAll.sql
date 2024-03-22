CREATE PROCEDURE [dbo].[spAsset_GetAll]
	AS
begin
	select AssetId, AssetName, AssetSerialNumber, AssetType, AssetOwner, ApprovedBy
		from dbo.[Asset] 
end
