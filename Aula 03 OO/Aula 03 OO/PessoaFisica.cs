using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_OO
{
    sealed class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome)
            :base(nome)
        {
        }

        public PessoaFisica(string nome, string telefone)
            :base(nome,telefone)
        {
        }

        public String CPF { get; set; }

        public override void Registrar(string documento)
        {
            this.CPF = documento;
        }
        public override void morrer()
        {
            Console.WriteLine("Morre mas pode viver");
        }
    }
}
