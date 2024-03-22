CREATE PROCEDURE [dbo].[spTimeSheet_GetAll]
	AS
begin
	select EmpId,LoginTime, LogoutTime
		from dbo.[TimeSheet] 
end
