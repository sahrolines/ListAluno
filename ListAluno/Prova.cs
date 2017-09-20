using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAluno
{
    class Prova
    {
        public void Listaprova()
        {
            List<Prova> listaprova = new List<Prova>();
           
            foreach (var itemprova in listaprova)
            {
                Console.WriteLine(itemprova);
            }

            Console.WriteLine("Lista de Provas: " + listaprova.Count());
            Console.ReadLine();

        }
    }
}
