Скрипт базы данных с заполнеными таблицами и добавленными условиями.

USE [master]
GO
/****** Object:  Database [TestTask] ******/
CREATE DATABASE [TestTask]

USE [TestTask]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[deps] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deps](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_deps] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persons] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persons](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](100) NOT NULL,
	[second_name] [nvarchar](100) NOT NULL,
	[last_name] [nvarchar](100) NOT NULL,
	[date_employ] [datetime2](7) NULL,
	[date_unemploy] [datetime2](7) NULL,
	[status] [int] NOT NULL,
	[id_dep] [int] NOT NULL,
	[id_post] [int] NOT NULL,
 CONSTRAINT [PK_persons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[posts] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[posts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_posts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[status] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_status] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250827220100_first', N'3.1.32')
GO
SET IDENTITY_INSERT [dbo].[deps] ON 

INSERT [dbo].[deps] ([id], [name]) VALUES (2, N'IT отдел')
INSERT [dbo].[deps] ([id], [name]) VALUES (3, N'Бухгалтерия')
INSERT [dbo].[deps] ([id], [name]) VALUES (1, N'Отдел кадров')
INSERT [dbo].[deps] ([id], [name]) VALUES (4, N'Отдел маркетинга')
SET IDENTITY_INSERT [dbo].[deps] OFF
GO
SET IDENTITY_INSERT [dbo].[persons] ON 

INSERT [dbo].[persons] ([id], [first_name], [second_name], [last_name], [date_employ], [date_unemploy], [status], [id_dep], [id_post]) VALUES (2, N'Петр', N'Анатольевич', N'Иванов', CAST(N'2011-01-20T00:00:00.0000000' AS DateTime2), CAST(N'2017-01-25T00:00:00.0000000' AS DateTime2), 2, 2, 3)
INSERT [dbo].[persons] ([id], [first_name], [second_name], [last_name], [date_employ], [date_unemploy], [status], [id_dep], [id_post]) VALUES (3, N'Афанасий', N'Григорьевич', N'Никитин', CAST(N'2023-01-20T00:00:00.0000000' AS DateTime2), NULL, 1, 2, 3)
INSERT [dbo].[persons] ([id], [first_name], [second_name], [last_name], [date_employ], [date_unemploy], [status], [id_dep], [id_post]) VALUES (9, N'Анатолий', N'Васильевич', N'Краснов', CAST(N'2000-01-20T00:00:00.0000000' AS DateTime2), CAST(N'2023-01-21T00:00:00.0000000' AS DateTime2), 2, 1, 1)
SET IDENTITY_INSERT [dbo].[persons] OFF
GO
SET IDENTITY_INSERT [dbo].[posts] ON 

INSERT [dbo].[posts] ([id], [name]) VALUES (1, N'Начальник отдела')
INSERT [dbo].[posts] ([id], [name]) VALUES (2, N'Помощник начальника отдела')
INSERT [dbo].[posts] ([id], [name]) VALUES (3, N'Работник')
INSERT [dbo].[posts] ([id], [name]) VALUES (4, N'Стажер')
SET IDENTITY_INSERT [dbo].[posts] OFF
GO
SET IDENTITY_INSERT [dbo].[status] ON 

INSERT [dbo].[status] ([id], [name]) VALUES (1, N'Работает')
INSERT [dbo].[status] ([id], [name]) VALUES (2, N'Уволен')
SET IDENTITY_INSERT [dbo].[status] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [unique_deps_name] ******/
ALTER TABLE [dbo].[deps] ADD  CONSTRAINT [unique_deps_name] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_persons_id_dep] ******/
CREATE NONCLUSTERED INDEX [IX_persons_id_dep] ON [dbo].[persons]
(
	[id_dep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_persons_id_post] ******/
CREATE NONCLUSTERED INDEX [IX_persons_id_post] ON [dbo].[persons]
(
	[id_post] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_persons_status] ******/
CREATE NONCLUSTERED INDEX [IX_persons_status] ON [dbo].[persons]
(
	[status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [unique_Post] ******/
CREATE UNIQUE NONCLUSTERED INDEX [unique_Post] ON [dbo].[persons]
(
	[id_dep] ASC,
	[id_post] ASC
)
WHERE (([id_post] IN ((1), (2))) AND [status]<>(2))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [unique_posts_name] ******/
ALTER TABLE [dbo].[posts] ADD  CONSTRAINT [unique_posts_name] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [unique_status_name] ******/
ALTER TABLE [dbo].[status] ADD  CONSTRAINT [unique_status_name] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[persons]  WITH CHECK ADD  CONSTRAINT [FK_Person_Dep] FOREIGN KEY([id_dep])
REFERENCES [dbo].[deps] ([id])
GO
ALTER TABLE [dbo].[persons] CHECK CONSTRAINT [FK_Person_Dep]
GO
ALTER TABLE [dbo].[persons]  WITH CHECK ADD  CONSTRAINT [FK_Person_Post] FOREIGN KEY([id_post])
REFERENCES [dbo].[posts] ([id])
GO
ALTER TABLE [dbo].[persons] CHECK CONSTRAINT [FK_Person_Post]
GO
ALTER TABLE [dbo].[persons]  WITH CHECK ADD  CONSTRAINT [FK_Person_Status] FOREIGN KEY([status])
REFERENCES [dbo].[status] ([id])
GO
ALTER TABLE [dbo].[persons] CHECK CONSTRAINT [FK_Person_Status]
GO
ALTER TABLE [dbo].[persons]  WITH CHECK ADD  CONSTRAINT [check_Date_Order] CHECK  (([date_unemploy] IS NULL OR [date_unemploy]>=[date_employ]))
GO
ALTER TABLE [dbo].[persons] CHECK CONSTRAINT [check_Date_Order]
GO
ALTER TABLE [dbo].[persons]  WITH CHECK ADD  CONSTRAINT [check_Status] CHECK  ((NOT ([status]=(2) AND [date_unemploy] IS NULL)))
GO
ALTER TABLE [dbo].[persons] CHECK CONSTRAINT [check_Status]
GO
ALTER TABLE [dbo].[persons]  WITH CHECK ADD  CONSTRAINT [check_StatusAndDate] CHECK  ((NOT ([date_unemploy] IS NOT NULL AND [status]=(1))))
GO
ALTER TABLE [dbo].[persons] CHECK CONSTRAINT [check_StatusAndDate]
GO
ALTER TABLE [dbo].[persons]  WITH CHECK ADD  CONSTRAINT [CHK_Date_Employ_Min] CHECK  (([date_employ]>='2000-01-01'))
GO
ALTER TABLE [dbo].[persons] CHECK CONSTRAINT [CHK_Date_Employ_Min]
GO
USE [master]
GO
ALTER DATABASE [TestTask] SET  READ_WRITE 
GO
