use GestaoAtividadeEscolar



select * from Professor
Select * from Turma
Select * from ProfessorTurma
Select * from Atividade

INSERT INTO Professor (Nome,Usuario,Senha) values ('Dimas Martins', 'Dimas','dimas123')
INSERT INTO Professor (Nome,Usuario,Senha) values ('Andrea Alencar', 'Alencar','alencar123')
INSERT INTO Professor (Nome,Usuario,Senha) values ('Jânia Alves', 'Alves','alves123')


INSERT INTO Turma (Descricao) values ('5º Ano')
INSERT INTO Turma (Descricao) values ('4º Ano')

INSERT INTO ProfessorTurma(IdProfessor,IdTurma) values (1,1)
INSERT INTO ProfessorTurma(IdProfessor,IdTurma) values (2,2)

INSERT INTO Atividade(Descricao,IdTurma) values ('Matemática: Porcentagem',1)
INSERT INTO Atividade(Descricao,IdTurma) values ('Português: Uso do Porque',1)


