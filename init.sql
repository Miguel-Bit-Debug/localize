create database ReceitaWS;
GO

USE ReceitaWS;
GO

create table Pedidos
(
	Id uniqueidentifier,
	CNPJ varchar(14),
	Resultado nvarchar(max)
	
	primary key(Id)
);
GO

create table contas
(
	Id uniqueidentifier,
	[name] varchar(20),
	email varchar(40),
	[password] varchar(100)

	primary key(Id)
)
GO

