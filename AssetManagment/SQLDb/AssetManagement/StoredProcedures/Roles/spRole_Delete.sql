CREATE PROCEDURE [dbo].[spRole_Delete]
	@Id int
AS
	begin
		delete 
		from dbo.Roles
		where Id = @Id;
	end
