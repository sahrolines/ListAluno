using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAluno
{
    class Aluno
    {
        public void Listaluno()
        {
            List<Aluno> listaluno = new List<Aluno>();

            
            foreach (var itemaluno in listaluno)
            {
                Console.WriteLine(itemaluno);
            }

            Console.WriteLine("Lista de Alunos: " + listaluno.Count());
            Console.ReadLine();

        }
    }
}
