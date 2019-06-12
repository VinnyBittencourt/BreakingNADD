# Breaking_NADD - Plataforma de avaliação de provas
 Repositório oficial para trabalhar e atualizar o trabalho do NADD, para o grupo: Guilherme Moura, Frederico Sampaio, Vinicius Marcelo e Vinícius Ataides.

OBS.: Diagramas e relatório técnico se encontram no perfil do Trello do grupo<br>

Feito:

Banco de dados:
- Script criação banco de dados;
- Script população banco de dados;
- Script com selects, views e procedures.

Implementação das classes:
Código C#
- Classe Area;
- Classe Avaliação;
- Classe Curso;
- Classe Disciplina;
- Classe Discursiva;
- Classe FabricaQuestoes;
- Classe Ialerta;
- Classe Iquestao;
- Classe Objetiva;
- Classe Professor;
- Classe Questoes;
- Classe Reitoria;
- Classe UNADD;
- Classe Uprofessor;
- Classe Usuario;


O trabalho realizado considera os seguintes pontos em seu desenvolvimento:

Utilização de:
 - Classe abstrata;
 - Interface;
 - Polimorfismo de sobrecarga;
 - Polimorfismo de sobrescrita;
 - Padrão de projeto abstract factory (utilizado para fabricar questões);
 
 Criação em banco de dados:
  - População banco de dados;
  - Views com:
   - Subconsulta simples;
   - Subconsulta complexa;
   - Subconsulta utilizando a cláusula "ALL";
   - Subconsulta utilizando a cláusula "ANY";
   - Subconsulta utilizando a cláusula "IN";
   - Consulta utilizando Left Join;
   - Consulta utilizando Right Join;
   - Consulta utilizando Full Outer Join;
   - 2 blocos PL/SQL com uso da cláusula "%TYPE" e tratamento de exeption.
