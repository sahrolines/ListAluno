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
            

            Trabalho trabalho = new Trabalho();

            Prova prova = new Prova();

            // disciplina.ExibirDisciplina();
            //turma.Listaturma();
            //aluno.Listaluno();
            //prova.Listaprova();
            //trabalho.Listrabalho();


            
        }
    }
}
