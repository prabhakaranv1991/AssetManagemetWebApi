CREATE PROCEDURE [dbo].[spRole_Get]
	@Id int
AS
	begin
		select Id, RoleName, Description
		from dbo.Roles
		where Id = @Id;
	end
