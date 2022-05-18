﻿CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] VARCHAR(50) NOT NULL,
	[Age] INT NOT NULL,
	[Email] VARCHAR(50) NOT NULL,
	[CreatedDate] DATETIME NOT NULL, 
	CONSTRAINT [PK_PERSON] PRIMARY KEY CLUSTERED ([Id] ASC)
)
