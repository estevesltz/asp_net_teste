using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_OO
{
    class PessoaJuridica: Pessoa 
    {
        public PessoaJuridica(string nome) 
            :base(nome)
        {
        }

        public PessoaJuridica(string nome, string telefone)
            : base(nome, telefone)
        {
        }
        public string CNPJ { get; set; }

        public override void Registrar(string documento)
        {
            this.CNPJ = documento;
        }
        public override void morrer()
        {
            Console.WriteLine("Morreu,acabou");
        }
    }
}
