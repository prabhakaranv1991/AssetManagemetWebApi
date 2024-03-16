if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName, LastName, Phone, Address, Email)
	values ('Test', 'User', '+919874563210', 'India', 'Test@xz.com');
end