using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03Pratica
{
   abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public int Matricula { get; set; }
        public long CPF { get; set; }
    }
}
