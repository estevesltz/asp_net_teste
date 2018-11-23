using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_OO
{
    //[modificador] [partial] [abstract| sealed] [partial] [class nome]
    abstract class Pessoa : IRegistro
    {
        public Pessoa()
        {

        }
        public Pessoa(String nome)
        {
            this.Nome = nome;
        }
        public Pessoa(string nome, string telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;
        }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public abstract void Registrar(string documento);

        public virtual void morrer()
        {
            Console.WriteLine("Pessoa mortinha da silva");
        }
    }
}
