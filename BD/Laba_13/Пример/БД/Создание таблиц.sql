USE [������������ �����������]

GO

CREATE TABLE ������
(
[��� ������] int NOT NULL IDENTITY PRIMARY KEY,
����� varchar(255) NOT NULL,
��� int NOT NULL CHECK (��� > 0),
�������� int NOT NULL CHECK (�������� > 0)
)

GO

CREATE TABLE �������
(
[��� �������] int NOT NULL IDENTITY PRIMARY KEY,
[����� �������] int NOT NULL CHECK ([����� �������] > 0)
)

GO

CREATE TABLE [���� ���������]
(
[��� ����] int NOT NULL IDENTITY PRIMARY KEY,
�������� varchar(255) NOT NULL
)

GO

CREATE TABLE [��� ������]
(
[��� ���] int NOT NULL IDENTITY PRIMARY KEY,
�������� varchar(255) NOT NULL
)

GO

CREATE TABLE [���� ������]
(
[��� ����] int NOT NULL IDENTITY PRIMARY KEY,
�������� varchar(255) NOT NULL
)

GO

CREATE TABLE ��������
(
[��� ��������] int NOT NULL IDENTITY PRIMARY KEY,
�������� varchar(255) NOT NULL
)

GO

CREATE TABLE �������
(
[��� �������] int NOT NULL IDENTITY PRIMARY KEY,
[������ �����������] date NOT NULL,
[����� �����������] date NOT NULL
) 

GO

CREATE TABLE [����� ������] 
(
[��� ������] int NOT NULL IDENTITY PRIMARY KEY,
[��� ���] int FOREIGN KEY references [��� ������]([��� ���]) on delete set null,
[������ ���] time NOT NULL,
[����� ���] time NOT NULL
)

GO

CREATE TABLE ��������
(
[��� ����������] int NOT NULL IDENTITY PRIMARY KEY,
[��� ����] int NOT NULL FOREIGN KEY references [���� ���������]([��� ����]) on delete cascade on update cascade,
������� varchar(255) NOT NULL,
��� varchar(255) NOT NULL,
�������� varchar(255) NOT NULL
)

GO

CREATE TABLE ��������
(
[��� ��������] int NOT NULL IDENTITY PRIMARY KEY,
[��� ������] int NOT NULL FOREIGN KEY references ������([��� ������]) on delete cascade,
������� varchar(255) NOT NULL,
��� varchar(255) NOT NULL,
�������� varchar(255) NOT NULL
)

GO


CREATE TABLE �����
(
[��� �����] int NOT NULL UNIQUE FOREIGN KEY references ��������([��� ��������]) on delete cascade,
������� int NOT NULL CHECK (������� > 0 AND ������� < 200), 
��� int NOT NULL CHECK (��� > 0 AND ��� < 300), 
���� int NOT NULL CHECK (���� > 0 AND ���� < 300), 
)

GO

CREATE TABLE ��������
(
[��� ��������] int NOT NULL IDENTITY PRIMARY KEY,
[��� �������] int NOT NULL FOREIGN KEY references �������([��� �������]) on delete cascade,
����� int NOT NULL, CHECK (����� > 0),
�������� varchar(255)
)

GO

CREATE TABLE ������_�������
(
ID int NOT NULL IDENTITY PRIMARY KEY,
[��� �������] int NOT NULL FOREIGN KEY references �������([��� �������]) on delete cascade,
[��� ������] int NOT NULL FOREIGN KEY references ������([��� ������])on delete cascade,
��� varchar(255) NOT NULL,
������� varchar(255) NOT NULL,
�������� varchar(255) NOT NULL
)

GO

CREATE TABLE �������_��������
(
ID int NOT NULL IDENTITY PRIMARY KEY,
[��� �������] int NOT NULL FOREIGN KEY references �������([��� �������]) on delete cascade,
[��� ����������] int NOT NULL FOREIGN KEY references ��������([��� ����������]) on delete cascade,
)

GO

CREATE TABLE [�������� �����]
(
ID int NOT NULL IDENTITY PRIMARY KEY,
[��� �����] int NOT NULL FOREIGN KEY references �����([��� �����]) on delete cascade,
[��� ��������] int NOT NULL FOREIGN KEY references ��������([��� ��������]) on delete cascade,
���� date NOT NULL,
����� time NOT NULL
)

GO

CREATE TABLE [������ ������]
(
[��� ������ �������] int NOT NULL IDENTITY PRIMARY KEY,
[��� ����������] int NOT NULL FOREIGN KEY references ��������([��� ����������]) on delete cascade,
[��� ������ �������] int NOT NULL FOREIGN KEY references [����� ������]([��� ������]) on delete cascade,
[��� ��������] int NOT NULL FOREIGN KEY references ��������([��� ��������]) on delete cascade,
)

GO

CREATE TABLE ������
(
[��� ������] int NOT NULL IDENTITY PRIMARY KEY,
[��� ������ �������] int NOT NULL FOREIGN KEY references [������ ������]([��� ������ �������]) on delete cascade,
���� date NOT NULL,
����� time NOT NULL
)

GO

CREATE TABLE  [������ �� �����]
(
[��� ������] int NOT NULL IDENTITY PRIMARY KEY,
[��� ��������] int NOT NULL FOREIGN KEY references ��������([��� ��������]) on delete cascade,
[��� ����] int NOT NULL FOREIGN KEY references [���� ������]([��� ����]) on delete cascade,
���� date NOT NULL,
����� time NOT NULL,
[��� ������] int FOREIGN KEY references ������([��� ������]) on delete set null,
��������� bit NOT NULL DEFAULT 0,
[��� ��������] int FOREIGN KEY references ��������([��� ��������]) on delete set null,
[��� �������] int FOREIGN KEY references �������([��� �������]) on delete set null
)