using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAluno
{
    class Trabalho
    {
        public void Listrabalho()
        {
            List<Trabalho> listrabalho = new List<Trabalho>();

            foreach (var itemtrabalho in listrabalho)
            {
                Console.WriteLine(itemtrabalho);
            }

            Console.WriteLine("Lista de Trabalhos: " + listrabalho.Count());
            Console.ReadLine();

        }
    }
}
