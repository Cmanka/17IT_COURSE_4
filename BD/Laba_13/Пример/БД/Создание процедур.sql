IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_Добавление_пациента') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_Добавление_пациента

GO

CREATE PROCEDURE PR_Добавление_пациента(
@имя varchar(255), @фамилия varchar(255), @отчество varchar(255),
@улица varchar(255), @дом int, @квартира int, 
@вес int, @рост int, @возраст int)
 AS
DECLARE @id_table table (id int)
DECLARE @id_tableAd table (id int)
DECLARE @id int
DECLARE @адрес int

IF EXISTS(SELECT * FROM Адреса 
WHERE Адреса.Улица = @улица and Адреса.Дом = @дом and Адреса.Квартира = @квартира)
BEGIN
SELECT @адрес = Адреса.[Код адреса] FROM Адреса 
WHERE Адреса.Улица = @улица and Адреса.Дом = @дом and Адреса.Квартира = @квартира
print @адрес
END ELSE 
BEGIN
INSERT Адреса
OUTPUT inserted.[Код адреса] INTO @id_tableAd
VALUES (@улица,@дом,@квартира)
SELECT @адрес = id
from @id_tableAd
END

INSERT Пациенты
OUTPUT inserted.[Код пациента] INTO @id_table
VALUES (@адрес,@фамилия,@имя,@отчество)

SELECT @id = id
from @id_table

print 'inserted id'
print @id

INSERT INTO Карты VALUES(@id,@возраст,@вес,@рост)

GO
----------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_Добавление_талона') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_Добавление_талона

GO

CREATE PROCEDURE PR_Добавление_талона(
@дата date, @время time)
AS
DECLARE @timeid int
DECLARE @timeidout int
DECLARE @day int
SELECT @day = DATEPART(dw,@дата)
SELECT @timeidout = -1

DECLARE cur CURSOR LOCAL FOR
SELECT g.[Код записи графика] as id
FROM [График работы] as g inner join [Время работы] as t on g.[Код записи времени]= t.[Код записи]
WHERE t.[код дня] = @day and t.[Начало дня] < @время and  t.[Конец дня] > @время

OPEN cur
FETCH NEXT FROM cur INTO @timeid
WHILE @@FETCH_STATUS=0
BEGIN
    IF NOT EXISTS (
     SELECT *
	 FROM Талоны as tal inner join [График работы] as gr on gr.[Код записи графика] = tal.[Код записи графика]
	 WHERE tal.Дата = @дата and tal.Время = @время and gr.[Код записи графика] = @timeid)
	BEGIN
	 print 'Найдена свободная запись'
	 SELECT @timeidout = @timeid
	 FETCH NEXT FROM cur 
      INTO @timeid
	END
	ELSE
    FETCH NEXT FROM cur 
      INTO @timeid
      
END
CLOSE cur
DEALLOCATE cur

DECLARE @id_table table (id int)
DECLARE @id_ins int 

print @timeidout 
IF @timeidout != -1
INSERT Талоны
OUTPUT inserted.[Код талона] INTO @id_table
VALUES(@timeidout,@дата,@время)
else
print 'Талон на данные дату и время недоступен'

GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_Запись_на_прием_талон') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_Запись_на_прием_талон

GO

CREATE PROCEDURE PR_Запись_на_прием_талон(
@код_пац int, @дата_зап date, 
@время_зап time, 
@дата date, @время time, 
@код_спец int)
 AS
IF @дата > @дата_зап or  (@дата = @дата_зап and @время > @время_зап)
BEGIN
DECLARE @timeid int
DECLARE @timeidout int
DECLARE @day int
SELECT @day = DATEPART(dw,@дата)
SELECT @timeidout = -1

DECLARE cur CURSOR LOCAL FOR
SELECT g.[Код записи графика] as id
FROM [График работы] as g inner join [Время работы] as t on g.[Код записи времени]= t.[Код записи]
						  inner join Персонал as per on per.[Код сотрудника] = g.[Код сотрудника]
WHERE t.[код дня] = @day and t.[Начало дня] < @время and  t.[Конец дня] > @время and @код_спец = per.[Код типа]
OPEN cur
FETCH NEXT FROM cur INTO @timeid
WHILE @@FETCH_STATUS=0
BEGIN
    IF NOT EXISTS (
     SELECT *
	 FROM Талоны as tal inner join [График работы] as gr on gr.[Код записи графика] = tal.[Код записи графика]
						
	 WHERE tal.Дата = @дата and 
	 DATEADD(MINUTE,DATEPART(MINUTE,'00:30'),tal.Время) > DATEADD(MINUTE,DATEPART(MINUTE,'00:00'),@время)
	  and tal.Время <= @время and gr.[Код записи графика] = @timeid)
	BEGIN
	 print 'Найдена свободная запись'
	 SELECT @timeidout = @timeid
	 FETCH NEXT FROM cur 
      INTO @timeid
	END
	ELSE
	BEGIN
    FETCH NEXT FROM cur 
      INTO @timeid
    END
END
CLOSE cur
DEALLOCATE cur

print @timeidout 
IF @timeidout != -1
BEGIN
 DECLARE @id_table table (id int)
 DECLARE @id_ins int 
 INSERT Талоны
  OUTPUT inserted.[Код талона] INTO @id_table
  VALUES(@timeidout,@дата,@время)
 SELECT @id_ins = id
  from @id_table
 print 'inserted id'
 print @id_ins
 INSERT INTO [Запись на прием] VALUES(@код_пац,1,@дата_зап,@время_зап,@id_ins,0,null,null)
END
else
RAISERROR ( 'Талон на данные дату и время недоступен',-1,-1)
END
ELSE
RAISERROR ( 'Дата приема не может быть раньше даты записи',-1,-1) 

GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_Добавление_записи_графика') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_Добавление_записи_графика

GO

CREATE PROCEDURE PR_Добавление_записи_графика(
@код_сотр int,
@код_дня int,
@время_нач time,
@время_кон time,
@код_кабинета int
)
AS
DECLARE @запись_времени int
DECLARE @id_tableTime table (id int)

IF EXISTS(SELECT * FROM [Время работы] 
WHERE [Время работы].[Код дня] = @код_дня and [Время работы].[Начало дня] = @время_нач 
  and [Время работы].[Конец дня] = @время_кон)
BEGIN
 SELECT @запись_времени = [Время работы].[Код записи] FROM [Время работы] 
 WHERE [Время работы].[Код дня] = @код_дня and [Время работы].[Начало дня] = @время_нач 
  and [Время работы].[Конец дня] = @время_кон
 print @запись_времени
END ELSE 
BEGIN
 print 'Вставка'
 INSERT [Время работы]
 OUTPUT inserted.[Код записи] INTO @id_tableTime
 VALUES (@код_дня,@время_нач,@время_кон)
 SELECT @запись_времени = id
 from @id_tableTime
END

INSERT INTO [График работы]
VALUES (@код_сотр,@запись_времени,@код_кабинета)

GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_Очистка_неиспользуемого_времени') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_Очистка_неиспользуемого_времени

GO

CREATE PROCEDURE PR_Очистка_неиспользуемого_времени
AS
DECLARE @timeid int
DECLARE cur CURSOR LOCAL FOR
 SELECT t.[Код записи] as id
 FROM [Время работы] as t
OPEN cur
FETCH NEXT FROM cur INTO @timeid
WHILE @@FETCH_STATUS=0
BEGIN
    IF NOT EXISTS (
     SELECT *
	 FROM [График работы] as g					
	 WHERE g.[Код записи времени] = @timeid 
	 )
	BEGIN
	 print 'Найдена неиспользуемая запись'
	 DELETE FROM [Время работы] WHERE [Время работы].[Код записи] = @timeid
	 FETCH NEXT FROM cur INTO @timeid
	END
	ELSE
	BEGIN
    FETCH NEXT FROM cur INTO @timeid
    END
END
CLOSE cur
DEALLOCATE cur

GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_Очистка_неиспользуемых_адресов') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_Очистка_неиспользуемых_адресов

GO

CREATE PROCEDURE PR_Очистка_неиспользуемых_адресов
AS
DECLARE @timeid int
DECLARE cur CURSOR LOCAL FOR
 SELECT a.[Код адреса] as id
 FROM Адреса as a
OPEN cur
FETCH NEXT FROM cur INTO @timeid
WHILE @@FETCH_STATUS=0
BEGIN
    IF NOT EXISTS (
     SELECT *
	 FROM Пациенты as p					
	 WHERE p.[Код адреса] = @timeid 
	 )
	BEGIN
	 print 'Найдена неиспользуемая запись'
	 DELETE FROM Адреса WHERE Адреса.[Код адреса] = @timeid
	 FETCH NEXT FROM cur INTO @timeid
	END
	ELSE
	BEGIN
    FETCH NEXT FROM cur INTO @timeid
    END
END
CLOSE cur
DEALLOCATE cur

GO
-------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_Обновление_справки') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_Обновление_справки

GO

CREATE PROCEDURE PR_Обновление_справки(
@код_записи int,
@время_нач date,
@время_кон date
)
AS
DECLARE @код_справки int
DECLARE @id_tableS table (id int)

IF EXISTS(SELECT * FROM Справки 
WHERE Справки.[Начало больничного] = @время_нач and Справки.[Конец больничного] = @время_кон )
BEGIN
 SELECT @код_справки = Справки.[Код справки] FROM Справки 
 WHERE Справки.[Начало больничного] = @время_нач and Справки.[Конец больничного] = @время_кон 
 print @код_справки
END ELSE 
BEGIN
 print 'Вставка'
 INSERT Справки
 OUTPUT inserted.[Код справки] INTO @id_tableS
 VALUES (@время_нач,@время_кон)
 SELECT @код_справки = id
 from @id_tableS
END

UPDATE [Запись на прием] SET [Запись на прием].[Код справки] = @код_справки, [Запись на прием].Закончено = 1
WHERE [Запись на прием].[Код записи] = @код_записи

GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_Очистка_неиспользуемых_справок') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_Очистка_неиспользуемых_справок

GO

CREATE PROCEDURE PR_Очистка_неиспользуемых_справок
AS
DECLARE @timeid int
DECLARE cur CURSOR LOCAL FOR
 SELECT s.[Код справки] as id
 FROM Справки as s
OPEN cur
FETCH NEXT FROM cur INTO @timeid
WHILE @@FETCH_STATUS=0
BEGIN
    IF NOT EXISTS (
     SELECT *
	 FROM [Запись на прием] as z					
	 WHERE z.[Код справки] = @timeid 
	 )
	BEGIN
	 print 'Найдена неиспользуемая запись'
	 DELETE FROM Справки WHERE Справки.[Код справки] = @timeid
	 FETCH NEXT FROM cur INTO @timeid
	END
	ELSE
	BEGIN
    FETCH NEXT FROM cur INTO @timeid
    END
END
CLOSE cur
DEALLOCATE cur

GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_Добавить_Пользователя') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_Добавить_Пользователя

GO

CREATE PROCEDURE PR_Добавить_Пользователя
(
@login varchar(16),
@pass varchar(16)
)
AS
EXEC sp_addlogin @login,@pass, 'Регистратура поликлиники'
EXEC sp_adduser @login,@login
GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_Удалить_Пользователя') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_Удалить_Пользователя

GO

CREATE PROCEDURE PR_Удалить_Пользователя
(
@login varchar(50)
)
AS
EXEC sp_dropuser @login
EXEC sp_droplogin @login



GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_Редактировать_Права') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_Редактировать_Права

GO

CREATE PROCEDURE PR_Редактировать_Права (
@GrOrRe varchar(50),
@act varchar(50),
@username varchar(50)
)
AS
DECLARE @tableName varchar(100)
DECLARE @procName varchar(100)
DECLARE @SQLString nvarchar(250)
IF (@act = 'EXECUTE')
BEGIN
 DECLARE cur CURSOR LOCAL FOR
  SELECT name 
  FROM sysobjects
  WHERE type = 'P'
 OPEN cur
 FETCH NEXT FROM cur INTO @procName
 WHILE @@FETCH_STATUS=0
 BEGIN	
	SET @SQLString = CAST(@GrOrRe+' '+@act+' ON OBJECT::['+@procName+'] TO '+@username AS NVARCHAR(250) )
	EXECUTE sp_executesql @SQLString
	FETCH NEXT FROM cur INTO @procName
 END
END
ELSE
BEGIN
 DECLARE cur CURSOR LOCAL FOR
  SELECT name
  FROM sysobjects
  WHERE type = 'U' or type = 'V'
 OPEN cur
 FETCH NEXT FROM cur INTO @tableName
 WHILE @@FETCH_STATUS=0
 BEGIN
	SET @SQLString = CAST(@GrOrRe+' '+@act+' ON OBJECT::['+@tableName+'] TO '+@username AS NVARCHAR(250) )
	EXECUTE sp_executesql @SQLString
	FETCH NEXT FROM cur INTO @tableName
 END
END