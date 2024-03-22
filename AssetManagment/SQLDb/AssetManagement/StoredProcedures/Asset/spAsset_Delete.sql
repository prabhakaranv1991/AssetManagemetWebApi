CREATE PROCEDURE [dbo].[spAsset_Delete]
	@Id int
AS
	begin
		delete 
		from dbo.[Asset]
		where AssetId= @Id;
	end
