CREATE PROCEDURE [dbo].[spTimeSheet_Insert]
	@EmpId int,
	@Logintime datetime,
	@LogoutTime datetime
	
AS
begin
	insert into dbo.[TimeSheet] (EmpId, LoginTime, LogoutTime)
	values (@EmpId, @Logintime, @LogoutTime);
end
