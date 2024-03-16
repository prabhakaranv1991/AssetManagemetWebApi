CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
begin
	select U.Id, U.FirstName, U.LastName, U.Phone, U.Address, U.Email
	from dbo.[User] AS U;
end

