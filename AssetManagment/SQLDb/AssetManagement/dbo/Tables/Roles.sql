﻿CREATE TABLE [dbo].[Roles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RoleName] NVARCHAR(25) NOT NULL, 
    [Description] NVARCHAR(50) NULL
)
