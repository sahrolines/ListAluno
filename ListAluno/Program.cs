using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Disciplina disciplina = new Disciplina();
            Turma turma = new Turma();
            Aluno aluno = new Aluno();
            Trabalho trabalho = new Trabalho();
            Prova prova = new Prova();

            disciplina.ExibirDisciplina();
            turma.Listaturma();
            aluno.Listaluno();
            prova.Listaprova();
            trabalho.Listrabalho();
        }
    }
}
