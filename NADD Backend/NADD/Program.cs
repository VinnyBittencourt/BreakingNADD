using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NADD.Usuario;

namespace NADD
{
    class Program
    {
        static void Main(string[] args)
        {
            Area Exatas = new Area(1, "Exatas");
            Curso SI = new Curso(1, "Sistemas de Informação", Exatas);
            Disciplina POO = new Disciplina(1, "Programação Orientada a Objetos", SI);
            Professor Rosen = new Professor(1, "Rosen", "Rosencler@gmail.com", "33201526", "167.128.067.59");
            UProfessor roselia = new UProfessor(1,"roro","roro@gmail.com","123@");
            UNADD carmem = new UNADD(2,"caca","carminha@gmail.com","amoMeuCachorro@123");
            Reitoria japa = new Reitoria(3,"Japa", "japa@unifoa.edu.br", "Hj3$2Kj$%");
            Avaliacao av1 = new Avaliacao();
            av1.NovaQuestao(10, "discursiva", "péssima!");
            av1.NovaQuestao(3, "objetiva", "muito boa mesmo!!!");
            av1.NovaQuestao(4, "discursiva", "Topper Quest");
            av1.NovaQuestao(5, "objetiva", "muito boa mesmo e reflexiva essa questão");
            av1.NovaQuestao(8, "discursiva", "não entendi!");

            //Polimorfismo de Sobrescrita
            //roselia.cadastrarArea();
            //carmem.cadastrarArea();
            //japa.cadastrarArea();
            //Polimorfismo de Sobrescrita
            //Polimorfismo de Sobrecarga
            //Console.WriteLine(av1.calculaMediaGeral(5, 75));
            //Console.WriteLine(av1.calculaMediaGeral(5, 74.2));
            //Polimorfismo de Sobrecarga
            // Interface //
            //Console.WriteLine(roselia.alertaNovaAvalicao());
            //Interface // 

            Console.WriteLine(Rosen.IdProfessor);
            Console.WriteLine("{0} {1}",Exatas.IdArea,Exatas.NomeArea);
            Console.WriteLine("{0} {1} {2}",SI.IdArea.IdArea, SI.IdCurso, SI.NomeCurso);
            Console.WriteLine("{0} {1} {2}", POO.IdDisciplina, POO.NomeDisciplina, POO.Curso.IdCurso);
            Console.WriteLine("{0} {1} {2} {3}",Rosen.IdProfessor, Rosen.EmailProfessor, Rosen.TelProfessor, Rosen.CpfProfessor );

            

            Console.WriteLine(av1.Media);
            Console.WriteLine(av1.VetQuest[i].Observacao)
            Console.Read();
        }
    }
}

