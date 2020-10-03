IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('TGR_��������_�����') AND SYSSTAT & 0XF=8)
DROP TRIGGER TGR_��������_�����

GO

CREATE TRIGGER TGR_��������_����� ON dbo.[�����]
AFTER DELETE
AS
DECLARE @id int
SELECT @id = [��� �����] FROM deleted
print 'Deleted id' 
print @id 
DELETE FROM �������� where ��������.[��� ��������] = @id

GO
--------------------------------------------------------------
IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('TGR_����������_������_�������') AND SYSSTAT & 0XF=8)
DROP TRIGGER TGR_����������_������_�������

GO

CREATE TRIGGER TGR_����������_������_������� ON dbo.[������ ������]
INSTEAD OF INSERT
AS

DECLARE @pers int
DECLARE @timeid int
SELECT @timeid = inserted.[��� ������ �������], @pers = inserted.[��� ����������] FROM inserted

DECLARE @day int
SELECT @day = [����� ������].[��� ���] FROM [����� ������] 
 WHERE [����� ������].[��� ������] = @timeid

print @timeid
print @day

IF EXISTS (SELECT *
		   FROM [������ ������] as g 
		   WHERE g.[��� ������ �������] = @timeid AND g.[��� ����������] = @pers)
BEGIN
 print '������ ������������ ��� ����� ��������'
END 
ELSE 
BEGIN

 IF EXISTS (SELECT *
			FROM [������ ������] as g inner join [����� ������] as t  on g.[��� ������ �������]= t.[��� ������]
			WHERE t.[��� ���] = @day AND g.[��� ����������] = @pers)
 BEGIN
  print '���� ����������� ��� ����� ��������'
 END
 ELSE 
  INSERT INTO [������ ������]
  SELECT inserted.[��� ����������], inserted.[��� ������ �������], inserted.[��� ��������] FROM inserted
END

GO
---------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('TGR_�����������_�����') AND SYSSTAT & 0XF=8)
DROP TRIGGER TGR_�����������_�����

GO

CREATE TRIGGER TGR_�����������_����� ON [������ �� �����]
FOR INSERT
AS 
DECLARE @���_����� int
DECLARE @���_��� int
DECLARE @���� date
DECLARE @����� time
DECLARE @���_��� int
DECLARE @���_���� int
DECLARE @���_���� int

select @���_���� =  inserted.[��� ����], @���_��� = inserted.[��� ������], 
       @���_����� = inserted.[��� ��������]
FROM inserted

IF @���_���� = 1 
BEGIN

SELECT @���� = t.����, @����� = t.�����, @���_��� = g.[��� ��������] FROM ������ as t inner join [������ ������] as g on t.[��� ������ �������] = g.[��� ������ �������]
where t.[��� ������] = @���_���
print @���_�����
print @���_���
print @����
print @�����

INSERT INTO [�������� �����] VALUES (@���_�����,@���_���,@����,@�����)
END

GO
---------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('TGR_����������_��������') AND SYSSTAT & 0XF=8)
DROP TRIGGER TGR_����������_��������

GO

CREATE TRIGGER TGR_����������_�������� ON ��������
INSTEAD OF INSERT
AS
DECLARE @num int
DECLARE @name varchar(200)


SELECT @num = inserted.�����, @name = inserted.�������� FROM inserted
IF EXISTS (SELECT * FROM �������� WHERE ��������.����� = @num)
BEGIN
print '������� ����������' 
END
ELSE
BEGIN
INSERT INTO �������� VALUES(1,@num,@name)
END


GO
---------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('TGR_����������_�������') AND SYSSTAT & 0XF=8)
DROP TRIGGER TGR_����������_�������

GO

CREATE TRIGGER TGR_����������_������� ON �������
FOR INSERT
AS
DECLARE @date1 date
DECLARE @date2 date
SELECT @date1 = inserted.[������ �����������], @date2 = inserted.[����� �����������]
FROM inserted
IF @date2 < @date1
ROLLBACK

GO
---------------------------------------------------------------------

IF EXISTS (SELECT *
FROM SYSOBJECTS
WHERE ID = OBJECT_ID('TGR_���������_�������') AND SYSSTAT & 0XF=8)
DROP TRIGGER TGR_���������_�������

GO

CREATE TRIGGER TGR_���������_������� ON [������ �� �����]
FOR UPDATE
AS
DECLARE @ID int
DECLARE @Type int
DECLARE @dataStart date
DECLARE @dataEnd date
DECLARE @dataReg date
DECLARE @dataTal date

SELECT @ID = inserted.[��� �������], 
	   @Type = inserted.[��� ����],
	   @dataReg = inserted.����
FROM inserted

SELECT @dataStart = �������.[������ �����������],
	   @dataEnd = �������.[����� �����������]
FROM ������� 
WHERE �������.[��� �������]=@ID

IF @dataStart < @dataReg
ROLLBACK

IF @Type = 1
BEGIN
SELECT @dataTal = t.����
FROM ������ as t inner join inserted as i on i.[��� ������] = t.[��� ������]
IF @dataStart < @dataTal
ROLLBACK
END