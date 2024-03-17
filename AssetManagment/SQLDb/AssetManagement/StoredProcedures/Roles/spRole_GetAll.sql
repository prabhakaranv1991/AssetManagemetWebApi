CREATE PROCEDURE [dbo].[spRole_GetAll]
AS
begin
	select Id, RoleName, Description
	from dbo.[Roles]
end
