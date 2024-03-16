CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Phone nvarchar(15),
	@Address nvarchar(50),
	@Email	nvarchar(50)
AS
begin
	update dbo.[User] 
	set FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Address = @Address, Email = @Email
	where Id = @Id;

end
