CREATE PROCEDURE [dbo].[spTimeSheet_Get]
	@Id int
AS
	begin
		select EmpId, LoginTime, LogoutTime
		from dbo.[TimeSheet] 
		where EmpId = @Id;
	end
