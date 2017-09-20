using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAluno
{
    public class Prova
    {
        public double Nota { get; set; }
        public string Descricao { get; set; }
        public int Bimestre { get; set; }

        public Aluno Aluno { get; set; }
    }

}
