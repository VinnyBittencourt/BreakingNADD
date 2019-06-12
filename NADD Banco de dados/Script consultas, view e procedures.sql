SELECT * FROM avaliacao
INNER JOIN disciplina ON disciplina.idDisciplina = avaliacao.idDisciplina
INNER JOIN curso ON curso.idCurso = disciplina.idCurso;

SELECT * FROM avaliacao
INNER JOIN disciplina ON disciplina.idDisciplina = avaliacao.idDisciplina
INNER JOIN questao ON questao.idavaliacao = avaliacao.idavaliacao;

select resultado,COUNT(idquestao) FROM questao GROUP BY resultado HAVING (questao.resultado IS NOT NULL);
select idAvaliacao,AVG(vlProvaExp) FROM avaliacao GROUP BY idAvaliacao HAVING AVG(vlProvaExp) > 5;

select resultado,nomeavaliador,COUNT(idquestao) FROM questao INNER JOIN avaliacao ON questao.idavaliacao = avaliacao.idavaliacao GROUP BY resultado,avaliacao.nomeavaliador ;


-- Subconsulta Simples --  
-- Caso necessário retornar os IDs das avaliações onde o nome do avaliador é diferente do nome do avaliador que avaliou a prova onde a media foi igual a 1, a view abaixo soluciona o problema. -- 
CREATE OR REPLACE FORCE VIEW v_avaliadorcritico 
AS
SELECT
    idavaliacao
    FROM
    avaliacao
    WHERE nomeavaliador <> (SELECT nomeavaliador FROM avaliacao WHERE media = 1);  

-- Subconsulta com cláusula any --
-- Quando preciso retornar o ID das avaliações onde a média e maior que qualquer avaliações em que o somatório do valor de questões é igual a 5 a view abaixo soluciona o problema. --
CREATE OR REPLACE FORCE VIEW v_avaliacao 
AS
SELECT  
    idavaliacao
    FROM
    avaliacao
    WHERE media > any (SELECT media FROM avaliacao WHERE sumvlquest = 5);  

-- Subconsulta complexa --
-- Se for preciso retornar nome dos cursos da área de ciências exatas a view abaixo soluciona o problema. --
CREATE OR REPLACE FORCE VIEW v_nomecursosexatas
AS
SELECT
    nome
    FROM
    curso
    WHERE
    idarea = ( select idarea from area where nome = 'Ciências Exatas');
    
-- Subconsulta utilizando a cláusula all --
-- Se for preciso retornar o nome das disciplinas onde o id da disciplina seja igual a todos os ids das disciplinas com media maior que 7 a view abaixo soluciona o problema. --
CREATE OR REPLACE FORCE VIEW v_discmediamaiorsete
AS
SELECT
    nome
    from
    disciplina
    where
    iddisciplina = all(select iddisciplina from avaliacao where media > 7);

-- cláusula IN --
-- Se for preciso retornar o nome do professor que o id da displicina igual a 1, a view abaixo soluciona o problema. --
CREATE OR REPLACE FORCE VIEW v_profsdehistoria
AS
SELECT
    nome
    from
    professor
    where
    idprofessor in(select idprofessor from professor_disciplina where iddisciplina = 1);

-- Left Join --
-- Se for preciso retornar o nome e id das disciplinas com o nome e id dos professores vinculados a elas (ou não), a view abaixo soluciona o problema. --
CREATE OR REPLACE FORCE VIEW v_discprofs
AS
SELECT d.nome nome_disc, g.nome nome_prof, f.iddisciplina id_disc, f.idprofessor id_prof FROM disciplina d LEFT JOIN professor_disciplina f ON d.iddisciplina = f.iddisciplina JOIN professor g ON f.idprofessor = g.idprofessor;

-- Right Join --
-- Se for preciso retornar o nome de todas as áreas e os cursos vinculadas a ela (ou não) a view abaixo soluciona o problema. --
CREATE OR REPLACE FORCE VIEW v_discprofs
AS
SELECT a.nome nome_area, c.nome nome_curso FROM curso c RIGHT JOIN area a ON c.idarea = a.idarea;

-- Full Outer Join --
-- Se for preciso retornar uma view com todas as informações necessárias para a crição de um relatório sobre cada disciplina e suas avaliações a view abaixo soluciona o problema. --
CREATE OR REPLACE FORCE VIEW v_para_relatorio
AS
SELECT * from disciplina d full outer join avaliacao a on d.iddisciplina = a.iddisciplina; 

--PL/SQL
SET SERVEROUTPUT ON 

-- 1 bloco
DECLARE 
    nome_prof professor.nome%TYPE;
BEGIN
    SELECT nome INTO nome_prof FROM professor WHERE idprofessor = 1;
    DBMS_OUTPUT.PUT_LINE(chr(10) || 'O nome do professor com o ID igual a 1 é: ' || nome_prof); 
    
EXCEPTION
   when NO_DATA_FOUND then
    DBMS_OUTPUT.PUT_LINE(chr(10) || 'Sem nome para o ID selecionado'); 
END;

-- 2 bloco
DECLARE 
    nome_curso curso.nome%TYPE;
BEGIN
    SELECT nome INTO nome_curso FROM curso WHERE idarea = 2;
    DBMS_OUTPUT.PUT_LINE(chr(10) || 'O(s) nome(s) do(s) curso(s) com o ID de area igual a 1 é: ' || nome_curso); 
    
EXCEPTION
    when NO_DATA_FOUND then
        DBMS_OUTPUT.PUT_LINE(chr(10) || 'Sem nome para o ID da area selecionado'); 
    when TOO_MANY_ROWS then
        DBMS_OUTPUT.PUT_LINE(chr(10) || 'A area selecionada só pode ter um curso');
END;
