USE [master]
GO
/****** Object:  Database [GestaoAtividadeEscolar]    Script Date: 01/11/2023 21:54:18 ******/
--CREATE DATABASE GestaoAtividade

USE [GestaoAtividade]
GO

/*
CREATE TABLE [dbo].[Atividade](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nome [varchar](300) NOT NULL,
	[IdTurma] [int] NOT NULL,
)
GO
select *from Atividade

CREATE TABLE [dbo].[Professor](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[Usuario] [varchar](100) NOT NULL,
	[Senha] [varchar](50) NOT NULL
)
select * from Professor
CREATE TABLE [dbo].[Turma](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[IdProfessor] INT NOT NULL,
) 
select * from Turma


ALTER TABLE [dbo].[Atividade]  WITH CHECK ADD  CONSTRAINT [fk_TurmaAtividade] FOREIGN KEY([IdTurma])
REFERENCES [dbo].[Turma] ([Id])
GO

ALTER TABLE [dbo].[Turma]  WITH CHECK ADD  CONSTRAINT [fk_Professor] FOREIGN KEY([IdProfessor])
REFERENCES [dbo].[Professor] ([Id])
GO

*/


INSERT INTO Professor (Nome,Usuario,Senha) values ('Dimas Martins', 'Dimas','dimas123')
INSERT INTO Professor (Nome,Usuario,Senha) values ('Andrea Alencar', 'Alencar','alencar123')
INSERT INTO Professor (Nome,Usuario,Senha) values ('Jânia Alves', 'Alves','alves123')


INSERT INTO Turma (Nome,IdProfessor) values ('5º Ano',1)
INSERT INTO Turma (Nome,IdProfessor) values ('4º Ano',2)



INSERT INTO Atividade(Nome,IdTurma) values ('Matemática: Porcentagem',1)
INSERT INTO Atividade(Nome,IdTurma) values ('Português: Uso do Porque',1)

select * from Professor
Select * from Turma
Select * from Atividade