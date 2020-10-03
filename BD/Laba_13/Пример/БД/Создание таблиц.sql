USE [Регистратура поликлиники]

GO

CREATE TABLE Адреса
(
[Код адреса] int NOT NULL IDENTITY PRIMARY KEY,
Улица varchar(255) NOT NULL,
Дом int NOT NULL CHECK (Дом > 0),
Квартира int NOT NULL CHECK (Квартира > 0)
)

GO

CREATE TABLE Участки
(
[Код участка] int NOT NULL IDENTITY PRIMARY KEY,
[Номер участка] int NOT NULL CHECK ([Номер участка] > 0)
)

GO

CREATE TABLE [Типы персонала]
(
[Код типа] int NOT NULL IDENTITY PRIMARY KEY,
Название varchar(255) NOT NULL
)

GO

CREATE TABLE [Дни недели]
(
[Код дня] int NOT NULL IDENTITY PRIMARY KEY,
Название varchar(255) NOT NULL
)

GO

CREATE TABLE [Типы записи]
(
[Код типа] int NOT NULL IDENTITY PRIMARY KEY,
Название varchar(255) NOT NULL
)

GO

CREATE TABLE Диагнозы
(
[Код диагноза] int NOT NULL IDENTITY PRIMARY KEY,
Название varchar(255) NOT NULL
)

GO

CREATE TABLE Справки
(
[Код справки] int NOT NULL IDENTITY PRIMARY KEY,
[Начало больничного] date NOT NULL,
[Конец больничного] date NOT NULL
) 

GO

CREATE TABLE [Время работы] 
(
[Код записи] int NOT NULL IDENTITY PRIMARY KEY,
[Код дня] int FOREIGN KEY references [Дни недели]([Код дня]) on delete set null,
[Начало дня] time NOT NULL,
[Конец дня] time NOT NULL
)

GO

CREATE TABLE Персонал
(
[Код сотрудника] int NOT NULL IDENTITY PRIMARY KEY,
[Код типа] int NOT NULL FOREIGN KEY references [Типы персонала]([Код типа]) on delete cascade on update cascade,
Фамилия varchar(255) NOT NULL,
Имя varchar(255) NOT NULL,
Отчество varchar(255) NOT NULL
)

GO

CREATE TABLE Пациенты
(
[Код пациента] int NOT NULL IDENTITY PRIMARY KEY,
[Код адреса] int NOT NULL FOREIGN KEY references Адреса([Код адреса]) on delete cascade,
Фамилия varchar(255) NOT NULL,
Имя varchar(255) NOT NULL,
Отчество varchar(255) NOT NULL
)

GO


CREATE TABLE Карты
(
[Код карты] int NOT NULL UNIQUE FOREIGN KEY references Пациенты([Код пациента]) on delete cascade,
Возраст int NOT NULL CHECK (Возраст > 0 AND Возраст < 200), 
Вес int NOT NULL CHECK (Вес > 0 AND Вес < 300), 
Рост int NOT NULL CHECK (Рост > 0 AND Рост < 300), 
)

GO

CREATE TABLE Кабинеты
(
[Код кабинета] int NOT NULL IDENTITY PRIMARY KEY,
[Код участка] int NOT NULL FOREIGN KEY references Участки([Код участка]) on delete cascade,
Номер int NOT NULL, CHECK (Номер > 0),
Название varchar(255)
)

GO

CREATE TABLE Адреса_Участки
(
ID int NOT NULL IDENTITY PRIMARY KEY,
[Код участка] int NOT NULL FOREIGN KEY references Участки([Код участка]) on delete cascade,
[Код адреса] int NOT NULL FOREIGN KEY references Адреса([Код адреса])on delete cascade,
Имя varchar(255) NOT NULL,
Фамилия varchar(255) NOT NULL,
Отчество varchar(255) NOT NULL
)

GO

CREATE TABLE Участки_Персонал
(
ID int NOT NULL IDENTITY PRIMARY KEY,
[Код участка] int NOT NULL FOREIGN KEY references Участки([Код участка]) on delete cascade,
[Код сотрудника] int NOT NULL FOREIGN KEY references Персонал([Код сотрудника]) on delete cascade,
)

GO

CREATE TABLE [Движение карты]
(
ID int NOT NULL IDENTITY PRIMARY KEY,
[Код карты] int NOT NULL FOREIGN KEY references Карты([Код карты]) on delete cascade,
[Код кабинета] int NOT NULL FOREIGN KEY references Кабинеты([Код кабинета]) on delete cascade,
Дата date NOT NULL,
Время time NOT NULL
)

GO

CREATE TABLE [График работы]
(
[Код записи графика] int NOT NULL IDENTITY PRIMARY KEY,
[Код сотрудника] int NOT NULL FOREIGN KEY references Персонал([Код сотрудника]) on delete cascade,
[Код записи времени] int NOT NULL FOREIGN KEY references [Время работы]([Код записи]) on delete cascade,
[Код кабинета] int NOT NULL FOREIGN KEY references Кабинеты([Код кабинета]) on delete cascade,
)

GO

CREATE TABLE Талоны
(
[Код талона] int NOT NULL IDENTITY PRIMARY KEY,
[Код записи графика] int NOT NULL FOREIGN KEY references [График работы]([Код записи графика]) on delete cascade,
Дата date NOT NULL,
Время time NOT NULL
)

GO

CREATE TABLE  [Запись на прием]
(
[Код записи] int NOT NULL IDENTITY PRIMARY KEY,
[Код пациента] int NOT NULL FOREIGN KEY references Пациенты([Код пациента]) on delete cascade,
[Код типа] int NOT NULL FOREIGN KEY references [Типы записи]([Код типа]) on delete cascade,
Дата date NOT NULL,
Время time NOT NULL,
[Код талона] int FOREIGN KEY references Талоны([Код талона]) on delete set null,
Закончено bit NOT NULL DEFAULT 0,
[Код диагноза] int FOREIGN KEY references Диагнозы([Код диагноза]) on delete set null,
[Код справки] int FOREIGN KEY references Справки([Код справки]) on delete set null
)