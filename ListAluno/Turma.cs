using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAluno
{
    public class Turma
    {
        public Disciplina disciplina { get; set;}

        public void Listaturma()
        {
            List<Aluno> listaluno = new List<Aluno>();

            foreach (var itemaluno in listaluno)
            {
                Console.WriteLine(itemaluno);
            }

            Console.WriteLine("Lista de Alunos: " + listaluno.Count());
            Console.Read();
        }
    }
}
