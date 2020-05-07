CREATE TABLE [dbo].[Scores] (
    [pos]     INT           IDENTITY (1, 1) NOT NULL,
    [score]   INT           NOT NULL,
    [details] VARCHAR (128) NOT NULL,
    PRIMARY KEY CLUSTERED ([pos] ASC)
);

SET IDENTITY_INSERT [dbo].[Scores] ON;
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(0, 0, N'Retired');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(1, 25, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(2, 18, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(3, 15, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(4, 12, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(5, 10, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(6, 8, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(7, 6, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(8, 4, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(9, 2, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(10, 1, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(11, 0, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(12, 0, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(13, 0, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(14, 0, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(15, 0, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(16, 0, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(17, 0, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(18, 0, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(19, 0, N'');
INSERT INTO [dbo].[Scores] ([pos], [score], [details]) VALUES(20, 0, N'');
SET IDENTITY_INSERT [dbo].[Scores] OFF;