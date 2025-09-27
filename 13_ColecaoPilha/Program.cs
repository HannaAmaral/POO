using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ColecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();

            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            pilha.Push(5);

            Console.WriteLine($"Topo da pilha {pilha.Peek()}");
        }
    }
}
