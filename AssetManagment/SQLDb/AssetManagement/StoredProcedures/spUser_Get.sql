CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int
AS
	begin
		select U.Id, U.FirstName, U.LastName, U.Phone, U.Address, U.Email
		from dbo.[User] AS U
		where Id = @Id;
	end
