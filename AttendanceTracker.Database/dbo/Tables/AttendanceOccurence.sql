﻿CREATE TABLE [dbo].[AttendanceOccurence]
(
	[Id] INT NOT NULL PRIMARY KEY CLUSTERED IDENTITY(1, 1),
	[DateOfOccurence] DATE NOT NULL,
	[Notes] NVARCHAR(MAX) NOT NULL,
	[IsExcused] BIT NOT NULL DEFAULT (0)
)
