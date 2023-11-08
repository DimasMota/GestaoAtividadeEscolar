
--create database GestaoAtividade03

use GestaoAtividade03

create table Professor(
Id int primary key identity,
Nome varchar(150) not null,
Usuario varchar(50) not null,
Senha varchar(30) not null
)

create table Turma(
Id int primary key identity,
Nome varchar (100) not null,
IdProfessor int not null,
)

create table Atividade(
Id int primary key identity,
Nome varchar(300) not null,
IdTurma int not null
)

ALTER TABLE Turma
ADD CONSTRAINT FK_IdProfessorTurma
FOREIGN KEY (IdProfessor) REFERENCES Professor(Id);

ALTER TABLE Atividade
ADD CONSTRAINT FK_IdTurmaAtividade
FOREIGN KEY (IdTurma) REFERENCES Turma(Id);


insert into Professor(Nome, Usuario, Senha) values ('Dimas Martins','Dimas','dimas123')
insert into Professor(Nome, Usuario, Senha) values ('Andrea Alencar','Alencar','alencar123')


insert into Turma(Nome, IdProfessor) values ('5º Ano',1)
insert into Turma(Nome, IdProfessor) values ('6º Ano',2)
insert into Turma(Nome, IdProfessor) values ('4º Ano',2)

insert into Atividade(Nome, IdTurma) values ('Matemática: operação de divisão',1)
insert into Atividade(Nome, IdTurma) values ('Matemática: porcentagem',1)
insert into Atividade(Nome, IdTurma) values ('Ciências: corpo humano',1)