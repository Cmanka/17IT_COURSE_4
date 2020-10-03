IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('TGR_удаление_карты') AND SYSSTAT & 0XF=8)
DROP TRIGGER TGR_удаление_карты

GO

CREATE TRIGGER TGR_удаление_карты ON dbo.[Карты]
AFTER DELETE
AS
DECLARE @id int
SELECT @id = [Код карты] FROM deleted
print 'Deleted id' 
print @id 
DELETE FROM Пациенты where Пациенты.[Код пациента] = @id

GO
--------------------------------------------------------------
IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('TGR_добавление_записи_графика') AND SYSSTAT & 0XF=8)
DROP TRIGGER TGR_добавление_записи_графика

GO

CREATE TRIGGER TGR_добавление_записи_графика ON dbo.[График работы]
INSTEAD OF INSERT
AS

DECLARE @pers int
DECLARE @timeid int
SELECT @timeid = inserted.[Код записи времени], @pers = inserted.[Код сотрудника] FROM inserted

DECLARE @day int
SELECT @day = [Время работы].[Код дня] FROM [Время работы] 
 WHERE [Время работы].[код записи] = @timeid

print @timeid
print @day

IF EXISTS (SELECT *
		   FROM [График работы] as g 
		   WHERE g.[код записи времени] = @timeid AND g.[Код сотрудника] = @pers)
BEGIN
 print 'Запись использована для этого человека'
END 
ELSE 
BEGIN

 IF EXISTS (SELECT *
			FROM [График работы] as g inner join [Время работы] as t  on g.[Код записи времени]= t.[Код записи]
			WHERE t.[Код дня] = @day AND g.[Код сотрудника] = @pers)
 BEGIN
  print 'День использован для этого человека'
 END
 ELSE 
  INSERT INTO [График работы]
  SELECT inserted.[код сотрудника], inserted.[Код записи времени], inserted.[Код кабинета] FROM inserted
END

GO
---------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('TGR_перемещение_карты') AND SYSSTAT & 0XF=8)
DROP TRIGGER TGR_перемещение_карты

GO

CREATE TRIGGER TGR_перемещение_карты ON [Запись на прием]
FOR INSERT
AS 
DECLARE @код_карты int
DECLARE @код_каб int
DECLARE @дата date
DECLARE @время time
DECLARE @код_зап int
DECLARE @код_граф int
DECLARE @код_типа int

select @код_типа =  inserted.[Код типа], @код_зап = inserted.[Код талона], 
       @код_карты = inserted.[Код пациента]
FROM inserted

IF @код_типа = 1 
BEGIN

SELECT @дата = t.Дата, @время = t.Время, @код_каб = g.[Код кабинета] FROM Талоны as t inner join [График работы] as g on t.[Код записи графика] = g.[Код записи графика]
where t.[Код талона] = @код_зап
print @код_карты
print @код_каб
print @дата
print @время

INSERT INTO [Движение карты] VALUES (@код_карты,@код_каб,@дата,@время)
END

GO
---------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('TGR_добавление_кабинета') AND SYSSTAT & 0XF=8)
DROP TRIGGER TGR_добавление_кабинета

GO

CREATE TRIGGER TGR_добавление_кабинета ON Кабинеты
INSTEAD OF INSERT
AS
DECLARE @num int
DECLARE @name varchar(200)


SELECT @num = inserted.Номер, @name = inserted.Название FROM inserted
IF EXISTS (SELECT * FROM Кабинеты WHERE Кабинеты.Номер = @num)
BEGIN
print 'Кабинет существует' 
END
ELSE
BEGIN
INSERT INTO Кабинеты VALUES(1,@num,@name)
END


GO
---------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('TGR_добавление_справки') AND SYSSTAT & 0XF=8)
DROP TRIGGER TGR_добавление_справки

GO

CREATE TRIGGER TGR_добавление_справки ON Справки
FOR INSERT
AS
DECLARE @date1 date
DECLARE @date2 date
SELECT @date1 = inserted.[Начало больничного], @date2 = inserted.[Конец больничного]
FROM inserted
IF @date2 < @date1
ROLLBACK

GO
---------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('TGR_изменение_справки') AND SYSSTAT & 0XF=8)
DROP TRIGGER TGR_изменение_справки

GO

CREATE TRIGGER TGR_изменение_справки ON [Запись на прием]
FOR UPDATE
AS
DECLARE @ID int
DECLARE @Type int
DECLARE @dataStart date
DECLARE @dataEnd date
DECLARE @dataReg date
DECLARE @dataTal date

SELECT @ID = inserted.[Код справки], 
	   @Type = inserted.[Код типа],
	   @dataReg = inserted.Дата
FROM inserted

SELECT @dataStart = Справки.[Начало больничного],
	   @dataEnd = Справки.[Конец больничного]
FROM Справки 
WHERE Справки.[Код справки]=@ID

IF @dataStart < @dataReg
ROLLBACK

IF @Type = 1
BEGIN
SELECT @dataTal = t.Дата
FROM Талоны as t inner join inserted as i on i.[Код талона] = t.[Код талона]
IF @dataStart < @dataTal
ROLLBACK
END