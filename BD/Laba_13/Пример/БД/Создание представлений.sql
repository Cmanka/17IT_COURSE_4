IF OBJECT_ID ('View_�����', 'V') IS NOT NULL
DROP VIEW View_�����;

GO

CREATE VIEW View_�����
AS
SELECT a.[��� ��������]  as ID, a.���, a.�������, a.��������, b.�����, b.���, b.��������, c.�������, c.���, c.����
FROM �������� as a inner join ������ as b on a.[��� ������] = b.[��� ������] 
				   inner join ����� as c on a.[��� ��������] = c.[��� �����]

GO
------------------------------------------------------------------------------------

IF OBJECT_ID ('View_������_������', 'V') IS NOT NULL
DROP VIEW View_������_������;

GO

CREATE VIEW View_������_������
AS
SELECT gw.[��� ������ �������] as ID, p.[��� ����������], p.�������, p.���, p.��������, tp.�������� as �������������, d.�������� as [���� ������], gt.[������ ���], gt.[����� ���], kab.[�����] as �������
FROM [������ ������] as gw inner join [����� ������] as gt on gw.[��� ������ �������]= gt.[��� ������] 
						   inner join [��� ������] as d on gt.[��� ���] = d.[��� ���]
						   inner join �������� as kab on gw.[��� ��������] = kab.[��� ��������]
						   Inner join �������� as p on p.[��� ����������] = gw.[��� ����������]
						   Inner join [���� ���������] as tp on p.[��� ����] = tp.[��� ����]
						   
GO
----------------------------------------------------------
						 
IF OBJECT_ID ('View_����������', 'V') IS NOT NULL
DROP VIEW View_����������;

GO

CREATE VIEW View_����������
AS
SELECT per.[��� ����������] as ID, per.�������,per.���,per.��������,sp.�������� as �������������
FROM �������� as per inner join [���� ���������] as sp on per.[��� ����] = sp.[��� ����]

GO
----------------------------------------------------------

IF OBJECT_ID ('View_������_������_����������', 'V') IS NOT NULL
DROP VIEW View_������_������_����������;

GO

CREATE VIEW View_������_������_����������
AS
SELECT gw.[��� ������ �������] as ID, p.[��� ����������], d.�������� as [���� ������], gt.[������ ���], gt.[����� ���], kab.[�����] as �������
FROM [������ ������] as gw inner join [����� ������] as gt on gw.[��� ������ �������]= gt.[��� ������] 
						   inner join [��� ������] as d on gt.[��� ���] = d.[��� ���]
						   inner join �������� as kab on gw.[��� ��������] = kab.[��� ��������]
						   Inner join �������� as p on p.[��� ����������] = gw.[��� ����������]
						   
GO
----------------------------------------------------------

IF OBJECT_ID ('View_������_��_������', 'V') IS NOT NULL
DROP VIEW View_������_��_������;

GO

CREATE VIEW View_������_��_������
AS
SELECT p.�������, z.[��� ������] as ID, p.���, z.���� as [���� ������], 
	   z.����� as [����� ������], tal.[��� ������], z.���������, d.�������� as �������, s.[������ �����������],s.[����� �����������]
FROM [������ �� �����] as z inner join �������� as p on z.[��� ��������] = p.[��� ��������]
							left join ������ as tal on z.[��� ������] = tal.[��� ������]
							left join �������� as d on z.[��� ��������] = d.[��� ��������]
							left join ������� as s on z.[��� �������] = s.[��� �������]
WHERE z.[��� ����] = 1
						  
GO
----------------------------------------------------------

IF OBJECT_ID ('View_������_��_���', 'V') IS NOT NULL
DROP VIEW View_������_��_���;

GO

CREATE VIEW View_������_��_���
AS
SELECT p.�������, z.[��� ������] as ID, p.���, z.���� as [���� ������], 
	   z.����� as [����� ������], z.���������, d.�������� as �������, s.[������ �����������],
	   s.[����� �����������]
FROM [������ �� �����] as z inner join �������� as p on z.[��� ��������] = p.[��� ��������]
							left join �������� as d on z.[��� ��������] = d.[��� ��������]
							left join ������� as s on z.[��� �������] = s.[��� �������]	
WHERE z.[��� ����] = 2
						 						  
GO
----------------------------------------------------------
IF OBJECT_ID ('View_������', 'V') IS NOT NULL
DROP VIEW View_������;

GO

CREATE VIEW View_������
AS
SELECT t.[��� ������],p.�������,p.���,p.��������,k.����� as �������,t.����,t.����� 
FROM ������ as t inner join [������ ������] as g on t.[��� ������ �������] = g.[��� ������ �������]
				 inner join �������� as p on g.[��� ����������] = p.[��� ����������]
				 inner join �������� as k on k.[��� ��������] = g.[��� ��������]
			
GO
---------------------------------------------------------------
	 
IF OBJECT_ID ('View_��������_�����', 'V') IS NOT NULL
DROP VIEW View_��������_�����;

GO

CREATE VIEW View_��������_�����
AS				 
SELECT p.���, c.[��� �����],p.�������,m.����,m.�����,k.����� as �������
FROM [�������� �����] as m inner join ����� as c on m.[��� �����] = c.[��� �����]
						   inner join �������� as p on p.[��� ��������] = c.[��� �����]
						   inner join �������� as k on k.[��� ��������] = m.[��� ��������]  
						 
GO
---------------------------------------------------------------
	 
IF OBJECT_ID ('View_������������', 'V') IS NOT NULL
DROP VIEW View_������������;

GO

CREATE VIEW View_������������
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
	 
IF OBJECT_ID ('View_������������_noAdm', 'V') IS NOT NULL
DROP VIEW View_������������_noAdm;

GO

CREATE VIEW View_������������_noAdm
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
	 
