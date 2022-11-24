
/****** Object:  Table [dbo].[Person]    Script Date: 11/24/2022 12:30:01 ******/
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[Person] ([Id]          [INT]          NOT NULL
                           , [First Name]  [NVARCHAR](10) NOT NULL
                           , [Last Name]   [NVARCHAR](10) NULL
                           , [Legal]       [BIT]          NOT NULL
                           , [National Id] [NCHAR](10)    NOT NULL
                           , [Insurer]     [BIT]          NOT NULL
                           , [Insured]     [BIT]          NOT NULL
                           , [Beneficiary] [BIT]          NOT NULL
                           , [MARKETER]    [BIT]          NOT NULL
                           , [USER]        [BIT]          NOT NULL
                           , [MANAGER]     [BIT]          NOT NULL
                           , [UNIT]        [INT]          NULL
                           , [USERNAME]    [NVARCHAR](20) NULL
                           , [PASSWORD]    [NVARCHAR](20) NULL
                           , CONSTRAINT [PRYMERYKEY_PERSON_ID] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (PAD_INDEX = OFF
                                                                                                    , STATISTICS_NORECOMPUTE = OFF
                                                                                                    , IGNORE_DUP_KEY = OFF
                                                                                                    , ALLOW_ROW_LOCKS = ON
                                                                                                    , ALLOW_PAGE_LOCKS = ON
                                                                                                    , OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                           , CONSTRAINT [UNIQUE_PERSON_ID] UNIQUE NONCLUSTERED ([Id] ASC) WITH (PAD_INDEX = OFF
                                                                                              , STATISTICS_NORECOMPUTE = OFF
                                                                                              , IGNORE_DUP_KEY = OFF
                                                                                              , ALLOW_ROW_LOCKS = ON
                                                                                              , ALLOW_PAGE_LOCKS = ON
                                                                                              , OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                           , CONSTRAINT [UNIQUE_PERSON_NATIONALID] UNIQUE NONCLUSTERED ([National Id] ASC) WITH (PAD_INDEX = OFF
                                                                                                               , STATISTICS_NORECOMPUTE = OFF
                                                                                                               , IGNORE_DUP_KEY = OFF
                                                                                                               , ALLOW_ROW_LOCKS = ON
                                                                                                               , ALLOW_PAGE_LOCKS = ON
                                                                                                               , OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY];
GO
/****** Object:  Table [dbo].[Policy]    Script Date: 11/24/2022 12:30:02 ******/
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[Policy] ([Id]        [INT]          IDENTITY(1, 1) NOT NULL
                           , [Insurer]   [INT]          NOT NULL
                           , [User]      [INT]          NOT NULL
                           , [Item]      [NVARCHAR](50) NOT NULL
                           , [Premium]   AS (ABS(DATEDIFF(DAY, [From Date], [To Date])) * (19.9))
                           , [From Date] [DATE]         NOT NULL
                           , [To Date]   [DATE]         NOT NULL
                           , [Period]    AS (ABS(DATEDIFF(DAY, [From Date], [To Date])))
                           , [Marketer]  [INT]          NULL
                           , CONSTRAINT [Primarykey_Policy_id] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (PAD_INDEX = OFF
                                                                                                    , STATISTICS_NORECOMPUTE = OFF
                                                                                                    , IGNORE_DUP_KEY = OFF
                                                                                                    , ALLOW_ROW_LOCKS = ON
                                                                                                    , ALLOW_PAGE_LOCKS = ON
                                                                                                    , OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY];
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 11/24/2022 12:30:02 ******/
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[Unit] ([Id]        [INT]          NOT NULL
                         , [UNIT NAME] [NVARCHAR](20) NOT NULL
                         , [Branch]    [NVARCHAR](10) NULL
                         , [agent]     [NVARCHAR](10) NULL
                         , [broker]    [NVARCHAR](10) NULL
                         , CONSTRAINT [primarykey_unit_id] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (PAD_INDEX = OFF
                                                                                                , STATISTICS_NORECOMPUTE = OFF
                                                                                                , IGNORE_DUP_KEY = OFF
                                                                                                , ALLOW_ROW_LOCKS = ON
                                                                                                , ALLOW_PAGE_LOCKS = ON
                                                                                                , OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                         , CONSTRAINT [unique_unit_agent] UNIQUE NONCLUSTERED ([agent] ASC) WITH (PAD_INDEX = OFF
                                                                                                , STATISTICS_NORECOMPUTE = OFF
                                                                                                , IGNORE_DUP_KEY = OFF
                                                                                                , ALLOW_ROW_LOCKS = ON
                                                                                                , ALLOW_PAGE_LOCKS = ON
                                                                                                , OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
                         , CONSTRAINT [unique_unit_branch] UNIQUE NONCLUSTERED ([Branch] ASC) WITH (PAD_INDEX = OFF
                                                                                                  , STATISTICS_NORECOMPUTE = OFF
                                                                                                  , IGNORE_DUP_KEY = OFF
                                                                                                  , ALLOW_ROW_LOCKS = ON
                                                                                                  , ALLOW_PAGE_LOCKS = ON
                                                                                                  , OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY];
GO