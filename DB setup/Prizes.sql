USE [Tournaments]
GO

/****** Object:  Table [dbo].[Prizes]    Script Date: 9/17/2023 10:55:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prizes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaceNumber] [int] NOT NULL,
	[PlaceName] [nvarchar](50) NOT NULL,
	[PrizeAmount] [money] NULL,
	[PrizePercentage] [float] NULL,
 CONSTRAINT [PK_Prizes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

