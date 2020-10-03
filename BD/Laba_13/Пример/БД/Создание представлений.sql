IF OBJECT_ID ('View_Карты', 'V') IS NOT NULL
DROP VIEW View_Карты;

GO

CREATE VIEW View_Карты
AS
SELECT a.[Код пациента]  as ID, a.Имя, a.Фамилия, a.Отчество, b.Улица, b.Дом, b.Квартира, c.Возраст, c.Вес, c.Рост
FROM Пациенты as a inner join Адреса as b on a.[Код адреса] = b.[Код адреса] 
				   inner join Карты as c on a.[Код пациента] = c.[Код карты]

GO
------------------------------------------------------------------------------------

IF OBJECT_ID ('View_График_работы', 'V') IS NOT NULL
DROP VIEW View_График_работы;

GO

CREATE VIEW View_График_работы
AS
SELECT gw.[Код записи графика] as ID, p.[Код сотрудника], p.Фамилия, p.Имя, p.Отчество, tp.Название as Специальность, d.Название as [День недели], gt.[Начало дня], gt.[Конец дня], kab.[номер] as Кабинет
FROM [График работы] as gw inner join [Время работы] as gt on gw.[Код записи времени]= gt.[Код записи] 
						   inner join [Дни недели] as d on gt.[код дня] = d.[код дня]
						   inner join Кабинеты as kab on gw.[код кабинета] = kab.[код кабинета]
						   Inner join Персонал as p on p.[код сотрудника] = gw.[код сотрудника]
						   Inner join [типы персонала] as tp on p.[код типа] = tp.[Код типа]
						   
GO
----------------------------------------------------------
						 
IF OBJECT_ID ('View_Сотрудники', 'V') IS NOT NULL
DROP VIEW View_Сотрудники;

GO

CREATE VIEW View_Сотрудники
AS
SELECT per.[Код сотрудника] as ID, per.Фамилия,per.Имя,per.Отчество,sp.Название as Специальность
FROM Персонал as per inner join [Типы персонала] as sp on per.[Код типа] = sp.[Код типа]

GO
----------------------------------------------------------

IF OBJECT_ID ('View_График_работы_сотрудника', 'V') IS NOT NULL
DROP VIEW View_График_работы_сотрудника;

GO

CREATE VIEW View_График_работы_сотрудника
AS
SELECT gw.[Код записи графика] as ID, p.[Код сотрудника], d.Название as [День недели], gt.[Начало дня], gt.[Конец дня], kab.[номер] as Кабинет
FROM [График работы] as gw inner join [Время работы] as gt on gw.[Код записи времени]= gt.[Код записи] 
						   inner join [Дни недели] as d on gt.[код дня] = d.[код дня]
						   inner join Кабинеты as kab on gw.[код кабинета] = kab.[код кабинета]
						   Inner join Персонал as p on p.[код сотрудника] = gw.[код сотрудника]
						   
GO
----------------------------------------------------------

IF OBJECT_ID ('View_Записи_по_талону', 'V') IS NOT NULL
DROP VIEW View_Записи_по_талону;

GO

CREATE VIEW View_Записи_по_талону
AS
SELECT p.Фамилия, z.[Код записи] as ID, p.Имя, z.Дата as [Дата записи], 
	   z.Время as [Время записи], tal.[Код талона], z.Закончено, d.Название as Диагноз, s.[Начало больничного],s.[Конец больничного]
FROM [Запись на прием] as z inner join Пациенты as p on z.[Код пациента] = p.[Код пациента]
							left join Талоны as tal on z.[Код талона] = tal.[Код талона]
							left join Диагнозы as d on z.[Код диагноза] = d.[Код диагноза]
							left join Справки as s on z.[Код справки] = s.[Код справки]
WHERE z.[Код типа] = 1
						  
GO
----------------------------------------------------------

IF OBJECT_ID ('View_Записи_на_дом', 'V') IS NOT NULL
DROP VIEW View_Записи_на_дом;

GO

CREATE VIEW View_Записи_на_дом
AS
SELECT p.Фамилия, z.[Код записи] as ID, p.Имя, z.Дата as [Дата записи], 
	   z.Время as [Время записи], z.Закончено, d.Название as Диагноз, s.[Начало больничного],
	   s.[Конец больничного]
FROM [Запись на прием] as z inner join Пациенты as p on z.[Код пациента] = p.[Код пациента]
							left join Диагнозы as d on z.[Код диагноза] = d.[Код диагноза]
							left join Справки as s on z.[Код справки] = s.[Код справки]	
WHERE z.[Код типа] = 2
						 						  
GO
----------------------------------------------------------
IF OBJECT_ID ('View_Талоны', 'V') IS NOT NULL
DROP VIEW View_Талоны;

GO

CREATE VIEW View_Талоны
AS
SELECT t.[Код талона],p.Фамилия,p.Имя,p.Отчество,k.Номер as Кабинет,t.Дата,t.Время 
FROM Талоны as t inner join [График работы] as g on t.[Код записи графика] = g.[Код записи графика]
				 inner join Персонал as p on g.[Код сотрудника] = p.[Код сотрудника]
				 inner join Кабинеты as k on k.[Код кабинета] = g.[Код кабинета]
			
GO
---------------------------------------------------------------
	 
IF OBJECT_ID ('View_Движение_карты', 'V') IS NOT NULL
DROP VIEW View_Движение_карты;

GO

CREATE VIEW View_Движение_карты
AS				 
SELECT p.Имя, c.[Код карты],p.Фамилия,m.Дата,m.Время,k.Номер as Кабинет
FROM [Движение карты] as m inner join Карты as c on m.[Код карты] = c.[Код карты]
						   inner join Пациенты as p on p.[Код пациента] = c.[Код карты]
						   inner join Кабинеты as k on k.[Код кабинета] = m.[Код кабинета]  
						 
GO
---------------------------------------------------------------
	 
IF OBJECT_ID ('View_пользователи', 'V') IS NOT NULL
DROP VIEW View_пользователи;

GO

CREATE VIEW View_пользователи
AS				 
SELECT * 
FROM sys.database_principals
WHERE  
  [type] <> 'r' and
  [name] not in (
    'dbo',
    'sys',
    'INFORMATION_SCHEMA',
    'guest')

GO
---------------------------------------------------------------
	 
IF OBJECT_ID ('View_пользователи_noAdm', 'V') IS NOT NULL
DROP VIEW View_пользователи_noAdm;

GO

CREATE VIEW View_пользователи_noAdm
AS				 
SELECT * 
FROM sys.database_principals
WHERE  
  [type] <> 'r' and
  [name] not in (
    'dbo',
    'sys',
    'INFORMATION_SCHEMA',
    'guest',
    'admin')

GO
---------------------------------------------------------------
	 
