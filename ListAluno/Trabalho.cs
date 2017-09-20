using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAluno
{
    public class Trabalho
    {
        
        public double nota { get; set; }
        public string descricao { get; set; }
        public int bimestre { get; set; }

        public Aluno Aluno { get; set; }

    
    }
}
