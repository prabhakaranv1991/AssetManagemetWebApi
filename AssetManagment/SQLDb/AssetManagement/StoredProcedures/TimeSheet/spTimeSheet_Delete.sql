CREATE PROCEDURE [dbo].[spTimeSheet_Delete]
	@Id int
AS
	begin
		delete 
		from dbo.[TimeSheet]
		where EmpId= @Id;
	end