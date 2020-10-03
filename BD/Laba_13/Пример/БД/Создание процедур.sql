IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_����������_��������') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_����������_��������

GO

CREATE PROCEDURE PR_����������_��������(
@��� varchar(255), @������� varchar(255), @�������� varchar(255),
@����� varchar(255), @��� int, @�������� int, 
@��� int, @���� int, @������� int)
 AS
DECLARE @id_table table (id int)
DECLARE @id_tableAd table (id int)
DECLARE @id int
DECLARE @����� int

IF EXISTS(SELECT * FROM ������ 
WHERE ������.����� = @����� and ������.��� = @��� and ������.�������� = @��������)
BEGIN
SELECT @����� = ������.[��� ������] FROM ������ 
WHERE ������.����� = @����� and ������.��� = @��� and ������.�������� = @��������
print @�����
END ELSE 
BEGIN
INSERT ������
OUTPUT inserted.[��� ������] INTO @id_tableAd
VALUES (@�����,@���,@��������)
SELECT @����� = id
from @id_tableAd
END

INSERT ��������
OUTPUT inserted.[��� ��������] INTO @id_table
VALUES (@�����,@�������,@���,@��������)

SELECT @id = id
from @id_table

print 'inserted id'
print @id

INSERT INTO ����� VALUES(@id,@�������,@���,@����)

GO
----------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_����������_������') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_����������_������

GO

CREATE PROCEDURE PR_����������_������(
@���� date, @����� time)
AS
DECLARE @timeid int
DECLARE @timeidout int
DECLARE @day int
SELECT @day = DATEPART(dw,@����)
SELECT @timeidout = -1

DECLARE cur CURSOR LOCAL FOR
SELECT g.[��� ������ �������] as id
FROM [������ ������] as g inner join [����� ������] as t on g.[��� ������ �������]= t.[��� ������]
WHERE t.[��� ���] = @day and t.[������ ���] < @����� and  t.[����� ���] > @�����

OPEN cur
FETCH NEXT FROM cur INTO @timeid
WHILE @@FETCH_STATUS=0
BEGIN
    IF NOT EXISTS (
     SELECT *
	 FROM ������ as tal inner join [������ ������] as gr on gr.[��� ������ �������] = tal.[��� ������ �������]
	 WHERE tal.���� = @���� and tal.����� = @����� and gr.[��� ������ �������] = @timeid)
	BEGIN
	 print '������� ��������� ������'
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
INSERT ������
OUTPUT inserted.[��� ������] INTO @id_table
VALUES(@timeidout,@����,@�����)
else
print '����� �� ������ ���� � ����� ����������'

GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_������_��_�����_�����') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_������_��_�����_�����

GO

CREATE PROCEDURE PR_������_��_�����_�����(
@���_��� int, @����_��� date, 
@�����_��� time, 
@���� date, @����� time, 
@���_���� int)
 AS
IF @���� > @����_��� or  (@���� = @����_��� and @����� > @�����_���)
BEGIN
DECLARE @timeid int
DECLARE @timeidout int
DECLARE @day int
SELECT @day = DATEPART(dw,@����)
SELECT @timeidout = -1

DECLARE cur CURSOR LOCAL FOR
SELECT g.[��� ������ �������] as id
FROM [������ ������] as g inner join [����� ������] as t on g.[��� ������ �������]= t.[��� ������]
						  inner join �������� as per on per.[��� ����������] = g.[��� ����������]
WHERE t.[��� ���] = @day and t.[������ ���] < @����� and  t.[����� ���] > @����� and @���_���� = per.[��� ����]
OPEN cur
FETCH NEXT FROM cur INTO @timeid
WHILE @@FETCH_STATUS=0
BEGIN
    IF NOT EXISTS (
     SELECT *
	 FROM ������ as tal inner join [������ ������] as gr on gr.[��� ������ �������] = tal.[��� ������ �������]
						
	 WHERE tal.���� = @���� and 
	 DATEADD(MINUTE,DATEPART(MINUTE,'00:30'),tal.�����) > DATEADD(MINUTE,DATEPART(MINUTE,'00:00'),@�����)
	  and tal.����� <= @����� and gr.[��� ������ �������] = @timeid)
	BEGIN
	 print '������� ��������� ������'
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
 INSERT ������
  OUTPUT inserted.[��� ������] INTO @id_table
  VALUES(@timeidout,@����,@�����)
 SELECT @id_ins = id
  from @id_table
 print 'inserted id'
 print @id_ins
 INSERT INTO [������ �� �����] VALUES(@���_���,1,@����_���,@�����_���,@id_ins,0,null,null)
END
else
RAISERROR ( '����� �� ������ ���� � ����� ����������',-1,-1)
END
ELSE
RAISERROR ( '���� ������ �� ����� ���� ������ ���� ������',-1,-1) 

GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_����������_������_�������') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_����������_������_�������

GO

CREATE PROCEDURE PR_����������_������_�������(
@���_���� int,
@���_��� int,
@�����_��� time,
@�����_��� time,
@���_�������� int
)
AS
DECLARE @������_������� int
DECLARE @id_tableTime table (id int)

IF EXISTS(SELECT * FROM [����� ������] 
WHERE [����� ������].[��� ���] = @���_��� and [����� ������].[������ ���] = @�����_��� 
  and [����� ������].[����� ���] = @�����_���)
BEGIN
 SELECT @������_������� = [����� ������].[��� ������] FROM [����� ������] 
 WHERE [����� ������].[��� ���] = @���_��� and [����� ������].[������ ���] = @�����_��� 
  and [����� ������].[����� ���] = @�����_���
 print @������_�������
END ELSE 
BEGIN
 print '�������'
 INSERT [����� ������]
 OUTPUT inserted.[��� ������] INTO @id_tableTime
 VALUES (@���_���,@�����_���,@�����_���)
 SELECT @������_������� = id
 from @id_tableTime
END

INSERT INTO [������ ������]
VALUES (@���_����,@������_�������,@���_��������)

GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_�������_���������������_�������') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_�������_���������������_�������

GO

CREATE PROCEDURE PR_�������_���������������_�������
AS
DECLARE @timeid int
DECLARE cur CURSOR LOCAL FOR
 SELECT t.[��� ������] as id
 FROM [����� ������] as t
OPEN cur
FETCH NEXT FROM cur INTO @timeid
WHILE @@FETCH_STATUS=0
BEGIN
    IF NOT EXISTS (
     SELECT *
	 FROM [������ ������] as g					
	 WHERE g.[��� ������ �������] = @timeid 
	 )
	BEGIN
	 print '������� �������������� ������'
	 DELETE FROM [����� ������] WHERE [����� ������].[��� ������] = @timeid
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
WHERE ID = OBJECT_ID('PR_�������_��������������_�������') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_�������_��������������_�������

GO

CREATE PROCEDURE PR_�������_��������������_�������
AS
DECLARE @timeid int
DECLARE cur CURSOR LOCAL FOR
 SELECT a.[��� ������] as id
 FROM ������ as a
OPEN cur
FETCH NEXT FROM cur INTO @timeid
WHILE @@FETCH_STATUS=0
BEGIN
    IF NOT EXISTS (
     SELECT *
	 FROM �������� as p					
	 WHERE p.[��� ������] = @timeid 
	 )
	BEGIN
	 print '������� �������������� ������'
	 DELETE FROM ������ WHERE ������.[��� ������] = @timeid
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
WHERE ID = OBJECT_ID('PR_����������_�������') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_����������_�������

GO

CREATE PROCEDURE PR_����������_�������(
@���_������ int,
@�����_��� date,
@�����_��� date
)
AS
DECLARE @���_������� int
DECLARE @id_tableS table (id int)

IF EXISTS(SELECT * FROM ������� 
WHERE �������.[������ �����������] = @�����_��� and �������.[����� �����������] = @�����_��� )
BEGIN
 SELECT @���_������� = �������.[��� �������] FROM ������� 
 WHERE �������.[������ �����������] = @�����_��� and �������.[����� �����������] = @�����_��� 
 print @���_�������
END ELSE 
BEGIN
 print '�������'
 INSERT �������
 OUTPUT inserted.[��� �������] INTO @id_tableS
 VALUES (@�����_���,@�����_���)
 SELECT @���_������� = id
 from @id_tableS
END

UPDATE [������ �� �����] SET [������ �� �����].[��� �������] = @���_�������, [������ �� �����].��������� = 1
WHERE [������ �� �����].[��� ������] = @���_������

GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_�������_��������������_�������') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_�������_��������������_�������

GO

CREATE PROCEDURE PR_�������_��������������_�������
AS
DECLARE @timeid int
DECLARE cur CURSOR LOCAL FOR
 SELECT s.[��� �������] as id
 FROM ������� as s
OPEN cur
FETCH NEXT FROM cur INTO @timeid
WHILE @@FETCH_STATUS=0
BEGIN
    IF NOT EXISTS (
     SELECT *
	 FROM [������ �� �����] as z					
	 WHERE z.[��� �������] = @timeid 
	 )
	BEGIN
	 print '������� �������������� ������'
	 DELETE FROM ������� WHERE �������.[��� �������] = @timeid
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
WHERE ID = OBJECT_ID('PR_��������_������������') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_��������_������������

GO

CREATE PROCEDURE PR_��������_������������
(
@login varchar(16),
@pass varchar(16)
)
AS
EXEC sp_addlogin @login,@pass, '������������ �����������'
EXEC sp_adduser @login,@login
GO

--------------------------------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('PR_�������_������������') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_�������_������������

GO

CREATE PROCEDURE PR_�������_������������
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
WHERE ID = OBJECT_ID('PR_�������������_�����') AND SYSSTAT & 0XF=4)
DROP PROCEDURE PR_�������������_�����

GO

CREATE PROCEDURE PR_�������������_����� (
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