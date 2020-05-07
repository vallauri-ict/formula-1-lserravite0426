CREATE TABLE [dbo].[Races_Scores] (
    [extDriver]     INT          NOT NULL,
    [extPos]        INT          NOT NULL,
    [extRace]     INT          NOT NULL,
    [fastestLap] VARCHAR (30) DEFAULT (N'') NULL,
    PRIMARY KEY CLUSTERED ([extDriver] ASC, [extRace] ASC),
    FOREIGN KEY ([extDriver]) REFERENCES [dbo].[Drivers]([id]),
    FOREIGN KEY ([extPos]) REFERENCES [dbo].[Scores]([pos]),
    FOREIGN KEY ([extRace]) REFERENCES [dbo].[Races]([id])
);

--Gara 1
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(2, 1, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(1, 2, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(7, 3, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(3, 4, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(5, 5, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(17, 6, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(11, 7, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(14, 8, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(15, 9, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(20, 10, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(4, 11, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(10, 12, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(12, 13, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(8, 14, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(16, 15, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(19, 16, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(13, 17, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(18, 0, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(6, 0, 1, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(9, 0, 1, N'');

--Gara 2
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(2, 1, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(1, 2, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(7, 3, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(3, 4, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(5, 5, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(17, 6, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(11, 7, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(14, 8, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(15, 9, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(20, 10, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(4, 11, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(10, 12, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(12, 13, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(8, 14, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(16, 15, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(19, 16, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(13, 17, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(18, 0, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(6, 0, 2, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(9, 0, 2, N'');

--Gara 3
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(2, 1, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(1, 2, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(7, 3, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(3, 4, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(5, 5, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(17, 6, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(11, 7, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(14, 8, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(15, 9, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(20, 10, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(4, 11, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(10, 12, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(12, 13, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(8, 14, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(16, 15, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(19, 16, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(13, 17, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(18, 0, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(6, 0, 3, N'');
INSERT INTO [dbo].[Races_Scores]([extDriver], [extPos], [extRace], [fastestLap]) VALUES(9, 0, 3, N'');