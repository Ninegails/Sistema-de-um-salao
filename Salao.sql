--create database Salao;

--use Salao;

create table Cliente(
	Codigo int not null identity primary key,
	Nome varchar (255),
	Email varchar (255),
	Telefone varchar (20),
	Senha varchar (20),
	);

--select * from Cliente;
--drop table Cliente;
--truncate table Cliente;

create table Agenda(
	Codigo int NOT NULL IDENTITY primary key,
	Dia date,
	Nome varchar (255),
	Horarios_Indisponiveis varchar (10),
	Telefone varchar (20),
	Descrição varchar (255)
	);

--select * from Agenda;

--drop table Agenda;

--truncate table Agenda;

--update Cliente set Email = '100' where Email = '1';

--SET NOCOUNT Off;
--SET NOCOUNT On;

create table Cadastro_ADM(
	Codigo int not null identity primary key,
	Nome_Salao varchar(55),
	Senha varchar(20),
	);

--select * from Cadastro_ADM;
--select count (*) from Cadastro_ADM;
--insert into Cadastro_ADM (Nome_salao , Senha) values (1 , 1);
--truncate table Cadastro_ADM;
--drop table Cadastro_ADM;
--select count(Senha) as total from Cadastro_ADM;