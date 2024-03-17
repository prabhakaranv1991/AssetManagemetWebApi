CREATE TABLE [dbo].[TimeSheet]
(
	[EmpId] INT NOT NULL PRIMARY KEY, 
    [LoginTime] DATETIME NOT NULL, 
    [LogoutTime] DATETIME NOT NULL
)
