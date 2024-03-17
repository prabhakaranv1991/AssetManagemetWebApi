CREATE PROCEDURE [dbo].[spUser_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Phone nvarchar(15),
	@Address nvarchar(50),
	@Email	nvarchar(50)
AS
begin
	insert into dbo.[User] (FirstName, LastName, Phone, Address, Email)
	values (@FirstName, @LastName, @Phone, @Address, @Email);
end