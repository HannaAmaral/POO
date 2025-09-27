using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ColecaoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> colecao = new HashSet<int>();

            colecao.Add(1);
            colecao.Add(2);
            colecao.Add(3);
            colecao.Add(4);
            colecao.Add(5);
            colecao.Add(6);
            colecao.Add(7);
            colecao.Add(8);
            colecao.Add(9);
            colecao.Add(10);

            colecao.Add(8); 
            colecao.Add(10); 
            colecao.Add(3);

            Console.WriteLine("Numeros Existentes (Sem Duplicatas): ");

            foreach (int numeros in colecao)
            {
                Console.WriteLine(numeros);
            }
        }
    }
}
