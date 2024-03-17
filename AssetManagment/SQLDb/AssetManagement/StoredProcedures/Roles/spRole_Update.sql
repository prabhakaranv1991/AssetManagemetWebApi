CREATE PROCEDURE [dbo].[spRole_Update]
	@Id int,
	@RoleName nvarchar(20),
	@Description nvarchar(20)
AS
begin
	update dbo.[Roles] 
	set RoleName = @RoleName, Description = @Description
	where Id = @Id;

end