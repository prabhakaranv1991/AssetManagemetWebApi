CREATE PROCEDURE [dbo].[spTimeSheet_Update]
	@EmpId int,
	@Logintime datetime,
	@LogoutTime datetime
	
AS
begin
	update dbo.[TimeSheet] 
	set  EmpId= @EmpId, LoginTime = @Logintime, LogoutTime = @LogoutTime
	where EmpId = @EmpId;
end
