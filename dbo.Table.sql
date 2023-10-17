USE [master]
GO

/****** Object:  Table [dbo].[Table_1]    Script Date: 16/10/2023 15:00:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Table_1](
	[lastname] [text] NULL,
	[firstname] [text] NULL,
	[middlename] [text] NULL,
	[year] [int] NULL,
	[gender] [char](10) NULL,
	[mark1] [int] NULL,
	[mark2] [int] NULL,
	[mark3] [int] NULL,
	[mark4] [int] NULL,
	[markavg] [int] NULL,
	[payment] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


