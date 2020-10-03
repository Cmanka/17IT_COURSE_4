USE master
GO
IF EXISTS (SELECT *
FROM sys.databases
WHERE name = 'Регистратура поликлиники')
DROP DATABASE [Регистратура поликлиники]
GO
CREATE DATABASE [Регистратура поликлиники]

