USE [test]
GO

 

INSERT INTO [dbo].[Otdely]
           ([N_otdela]
           ,[Name_otdela])
     VALUES
           (2, '�����������'),
           (3, '���� ������'), 
           (4, '���� ��������������')
GO
SELECT * FROM Otdely
GO

 

INSERT INTO [dbo].[Sotrydniki]
           ([N_sotrydnika]
           ,[Familia]
           ,[Data_roj]
           ,[N_otdela])
     VALUES
           (1, '������', '15/03/1995', 1),
           (2, '������', '13/06/2003', 2),
           (3, '������', '18/09/1999', 3),
           (4, '�����������', '07/05/2000', 4)
GO
SELECT Otdely.Name_otdela, Sotrydniki.Familia from Otdely
INNER JOIN  Sotrydniki
ON Otdely.N_otdela = Sotrydniki.N_otdela
order by Sotrydniki.N_otdela, Sotrydniki.Familia