insert into area values (sq_area.NEXTVAL, 'Ciências Humanas');
insert into area values (sq_area.NEXTVAL, 'Ciências Exatas');
insert into area values (sq_area.NEXTVAL, 'Saúde');

insert into curso values(sq_curso.NEXTVAL, 'Direito', 1);
insert into curso values(sq_curso.NEXTVAL, 'Design', 2);
insert into curso values(sq_curso.NEXTVAL, 'Medicina', 3);
insert into curso values(sq_curso.NEXTVAL, 'SI', 2);

insert into professor values (sq_professor.NEXTVAL, 'Vinny','vinny@hcvr.com', '24999954782', '12345678912');
insert into professor values (sq_professor.NEXTVAL, 'Vinny Filho', 'vinnyF@hcvr.com', '24999968782', '12631678912');

insert into disciplina values(sq_disciplina.NEXTVAL,'História dos Historiadores', 1);
insert into disciplina values(sq_disciplina.NEXTVAL,'Matemagica', 2);

insert into usuario values(sq_usuario.NEXTVAL, 'Preula', 'prepre@la.com', 'preulinha123');
insert into usuario values(sq_usuario.NEXTVAL, 'Voltorb', 'voltorb@eletric.com', 'voltidaumchoque');

insert into avaliacao values(sq_avaliacao.NEXTVAL, 'ava_1', 'aaa@aaa.com', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 10, 10, 10, 'aaa', 'aaa', 10, 'aaaa', 'aaaa', 'aaaaa', 1, 10, 1);
insert into avaliacao values(sq_avaliacao.NEXTVAL, 'ava_2', 'bbb@bbb.com', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 5, 5, 5, 'bbb', 'bbb', 10, 'bbbb', 'bbbb', 'bbbb', 6, 10, 1);
insert into avaliacao values(sq_avaliacao.NEXTVAL, 'ava_3', 'aaa@aaa.com', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 10, 10, 10, 'aaa', 'aaa', 10, 'aaaa', 'aaaa', 'aaaaa', 5, 10, 1);
insert into avaliacao values(sq_avaliacao.NEXTVAL, 'ava_4', 'bbb@bbb.com', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 10, 9, 5, 'bbb', 'bbb', 10, 'bbbb', 'bbbb', 'bbbb', 10, 10, 1);
insert into area values(4, 'Balbúrdia');
insert into professor_disciplina values(1, 1);
insert into professor_disciplina values(1, 2);

insert into questao values(sq_questao.NEXTVAL, 'bom', 'observei que a prova tava bacana', 1);
insert into questao values(sq_questao.NEXTVAL, 'mal', 'observei que a prova tava ruim', 2);
insert into questao values(sq_questao.NEXTVAL, 'bom', 'observei que a prova tava bacana', 1);
insert into questao values(sq_questao.NEXTVAL, 'mal', 'observei que a prova tava ruim', 2);
insert into questao values(sq_questao.NEXTVAL, 'mal', 'observei que a prova tava ruim', 1);

