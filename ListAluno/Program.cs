using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAluno
{
    public class Program
    {
        static void Main(string[] args)
        {
            Disciplina disciplina = new Disciplina();
            Disciplina disciplina1 = new Disciplina();
            disciplina.Nome = "POO";

            Turma turma = new Turma();
            Turma turma1 = new Turma();
            turma1.Disciplina = disciplina1;
            turma1.Listaluno = new List<Aluno>();
            Aluno aluno = new Aluno();
            Aluno aluno1 = new Aluno();
            aluno1.NomeAluno = "aluno1";
            aluno1.RA = "12345";

            Aluno aluno2 = new Aluno();
            aluno2.NomeAluno = "aluno2";
            aluno2.RA = "32435341";
            Aluno aluno3 = new Aluno();
            aluno3.NomeAluno = "aluno3";
            aluno3.RA = "6452452";

            turma1.Listaluno.Add(aluno1);
            turma1.Listaluno.Add(aluno2);
            turma1.Listaluno.Add(aluno3);

            Trabalho trabalho = new Trabalho();
            Trabalho trabalho1 = new Trabalho();
            trabalho1.Nota = 5.2;
            trabalho1.Descricao = "Trabalho B1";
            trabalho1.Bimestre = 1;
            trabalho1.Aluno = aluno1;
            Trabalho trabalho2 = new Trabalho();
            trabalho1.Nota = 6.6;
            trabalho1.Descricao = "Trabalho B1";
            trabalho1.Bimestre = 1;
            trabalho1.Aluno = aluno2;
            Trabalho trabalho3 = new Trabalho();
            trabalho1.Nota = 9.0;
            trabalho1.Descricao = "Trabalho B1";
            trabalho1.Bimestre = 1;
            trabalho1.Aluno = aluno3;
            Prova prova = new Prova();
            Prova prova1 = new Prova();
            prova1.Aluno = aluno1;
            prova1.Nota = 6.0;
            prova1.Descricao = "Prova B1";
            prova1.Bimestre = 1;
            Prova prova2 = new Prova();
            prova1.Aluno = aluno2;
            prova1.Nota = 3.0;
            prova1.Descricao = "Prova B1";
            prova1.Bimestre = 1;
            Prova prova3 = new Prova();
            prova1.Aluno = aluno3;
            prova1.Nota = 7.3;
            prova1.Descricao = "Prova B1";
            prova1.Bimestre = 1;

            // disciplina.ExibirDisciplina();
            //turma.Listaturma();
            //aluno.Listaluno();
            //prova.Listaprova();
            //trabalho.Listrabalho();

            foreach (var itemturma in Listaluno)
            {
                Console.WriteLine(Listaluno);
            }

        }
    }
}
