CREATE PROCEDURE [dbo].[spRole_Insert]
	@RoleName nvarchar(20),
	@Description nvarchar(20)
AS
begin
	insert into dbo.[Roles] (RoleName, Description)
	values (@RoleName, @Description);
end
