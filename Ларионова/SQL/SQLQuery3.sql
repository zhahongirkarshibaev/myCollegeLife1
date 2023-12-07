USE [test]
GO

 

INSERT INTO [dbo].[Otdely]
           ([N_otdela]
           ,[Name_otdela])
     VALUES
           (2, 'Бухгалтерия'),
           (3, 'Одел кадров'), 
           (4, 'Штат преподавателей')
GO
SELECT * FROM Otdely
GO

 

INSERT INTO [dbo].[Sotrydniki]
           ([N_sotrydnika]
           ,[Familia]
           ,[Data_roj]
           ,[N_otdela])
     VALUES
           (1, 'Иванов', '15/03/1995', 1),
           (2, 'Исаков', '13/06/2003', 2),
           (3, 'Марьин', '18/09/1999', 3),
           (4, 'Гребенников', '07/05/2000', 4)
GO
SELECT Otdely.Name_otdela, Sotrydniki.Familia from Otdely
INNER JOIN  Sotrydniki
ON Otdely.N_otdela = Sotrydniki.N_otdela
order by Sotrydniki.N_otdela, Sotrydniki.Familia