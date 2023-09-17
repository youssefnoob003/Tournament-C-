USE [Tournaments]
GO

/****** Object:  Table [dbo].[Tournaments]    Script Date: 9/17/2023 10:56:23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tournaments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentName] [nvarchar](100) NOT NULL,
	[EntryFee] [money] NOT NULL,
	[Active] [int] NULL,
 CONSTRAINT [PK_Tournaments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

