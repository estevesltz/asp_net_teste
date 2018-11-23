using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica ps1 = new PessoaFisica("Fabiano");
            //ps1.Nome = "Fabiano";
            ps1.Telefone = "8383-4444";
            ps1.Endereco = "São Sebastião";
            ps1.CPF = "051.711.687-71";

            PessoaJuridica pj1 = new PessoaJuridica("LogusTI");
            pj1.Nome = "LogusTI";
            pj1.Telefone = "(61) 30211-5899";
            pj1.Endereco = "Avenida dos crackudo";
            pj1.CNPJ = "435.587.00001/04";

            PessoaFisica p = new PessoaFisica("Juliano");
            p.Registrar("123456789");
            Console.WriteLine(p.CPF);
            p.morrer();

            Console.Read();




        }
    }
}
