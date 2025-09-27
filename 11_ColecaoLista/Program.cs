using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ColecaoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> nomes = new List<string>();

            Console.WriteLine("Digite nomes (maximo de 5) ou 'sair' para parar: ");

            while (nomes.Count < 5)
            {
                Console.WriteLine($" Nome {nomes.Count + 1}:");
                string entrada = Console.ReadLine();

                if (entrada == "sair")
                {
                    break;
                }

                if (entrada.Length < 3)
                {
                    Console.WriteLine("O nome deve ter no minimo 3 caracteres.\n");
                    continue;
                }
                nomes.Add(entrada);
            }

            Console.WriteLine("\nLista de nomes: ");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

        }
    }
}
