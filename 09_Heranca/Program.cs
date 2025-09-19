using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa obj = new Pessoa();   não pode instanciar uma classe abstrata
            Pessoa[] pessoas = new Pessoa[2];

            PessoaFisica pessoaFisica= new PessoaFisica();
            pessoas[0] = pessoaFisica;
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.CPF = "999.999.999-99";
            pessoaFisica.Telefone = "(99) 99999-9999";  
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoas[1] = pessoaJuridica;
            pessoaJuridica.Nome = "Senac Marília";
            pessoaJuridica.CNPJ = "99.999.999-99 / 9999-99";
            pessoaJuridica.Telefone = "(99) 99999-9999";
            pessoaJuridica.Imprimir();

            Console.WriteLine(pessoaFisica);
            Console.WriteLine(pessoaJuridica);

            if (pessoaFisica.Equals(pessoaJuridica))
                Console.WriteLine("É a mesma pessoa.");
            else
                Console.WriteLine("Não é a mesma pessoa.");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
