-- create database ReceitaWS;

create table Pedidos
(
	Id uniqueidentifier,
	CNPJ varchar(14),
	Resultado nvarchar(max)
	
	primary key(Id)
);