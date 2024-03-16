if not exists (select 1 from dbo.[Roles])
begin
	insert into dbo.[Roles] (RoleName, Description)
	values ('Associate Engg', 'Associate Engineer'),
	('Software Engg','Software Engineer'),
	('Sr.Software Engg','Senior Software Engineer'),
	('Lead Engg','Lead Engineer'),
	('Associate Test Engg', 'Associate Engineer'),
	('Test Engg','Testing Engineer'),
	('Sr.Test Engg','Senior Testing Engineer'),
	('Test Lead','Test Lead Engineer'),
	('Project Manager','Project Manager'),
	('Team Manager','Team Manager');
end