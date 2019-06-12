drop table area;
drop table curso;
drop table disciplina;
drop table professor_disciplina ;
drop table professor;
drop table usuario;
drop table questao;
drop table avaliacao;
drop sequence sq_curso;
drop sequence sq_area;
drop sequence sq_disciplina;
drop sequence sq_professor;
drop sequence sq_usuario;
drop sequence sq_questao;
drop sequence sq_avaliacao;

create table area(
    idArea INT not null PRIMARY KEY,
    nome VARCHAR2(50)
);

create table curso(
    idCurso INT not null PRIMARY KEY,
    nome VARCHAR2(50),
    idArea INT NOT NULL,
    FOREIGN KEY(idArea) REFERENCES area(idArea)
);

create table disciplina(
    idDisciplina INT PRIMARY KEY,
    nome VARCHAR2(50),
    idCurso INT NOT NULL,
    FOREIGN KEY(idCurso) REFERENCES curso(idCurso)
);

create table professor(
    idProfessor INT not null PRIMARY KEY,
    nome VARCHAR2(50),
    email VARCHAR2(50),
    telefone VARCHAR2(50),
    cpf VARCHAR2(50)
);

create table professor_disciplina(
    idDisciplina int not null,
    idProfessor int not null,
    FOREIGN KEY(idDisciplina) REFERENCES disciplina(idDisciplina),
    FOREIGN KEY(idProfessor) REFERENCES professor(idProfessor)
);

create table usuario(
    idUser INT not null PRIMARY KEY,
    nome VARCHAR2(50),
    email VARCHAR2(50),
    senha VARCHAR2(50)
);

create table avaliacao(
    idAvaliacao INT not null PRIMARY KEY,
    nomeAvaliador VARCHAR(75),
    email VARCHAR(75),
    horaInicio TIMESTAMP(6),
    horaConclusao TIMESTAMP(6),
    vlProvaExp INT,
    vlQuestExp INT,
    sumVlQuest INT,
    refBibliograficas VARCHAR(500),
    pQuestMultEscDisc VARCHAR(75),
    vlTotal INT,
    eqDistVlQuest VARCHAR(75),
    ppQuestContext VARCHAR(75),
    obs VARCHAR(1000),
    media number(6, 2),
    numeroQuests INT,
    idDisciplina INT NOT NULL,
    FOREIGN KEY (idDisciplina) REFERENCES disciplina(idDisciplina)
);

create table questao(
    idQuestao INT PRIMARY KEY,
    resultado VARCHAR2(150),
    observacao VARCHAR2(1000),
    idAvaliacao INT not null,
    FOREIGN KEY (idAvaliacao) REFERENCES avaliacao(idAvaliacao)
);

create sequence sq_curso;
create sequence sq_area;
create sequence sq_disciplina;
create sequence sq_professor;
create sequence sq_usuario;
create sequence sq_questao;
create sequence sq_avaliacao;
