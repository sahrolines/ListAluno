using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAluno
{
    public class Turma
    {
        public void Listaturma()
        {
            List<Turma> listaturma = new List<Turma>();
            
            foreach (var itemturma in listaturma)
            {
                Console.WriteLine(itemturma);
            }

            Console.WriteLine("Lista de Turmas: " + listaturma.Count());
            Console.ReadLine();

        }
    }
}
