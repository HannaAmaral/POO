using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            Console.WriteLine($"Digite nomes para adicionar a fila (Digite 'sair' para parar)\n");

            while (true)
            {
               
                Console.WriteLine($"Posição da fila {fila.Count + 1}°: ");
                string entrada = Console.ReadLine();
                
                if (entrada == "sair")
                {
                   break;
                }

                if (entrada.Length < 3)
                {
                   Console.WriteLine("O nome deve ter pelomenos 3 caracteres\n");
                   continue;
                }
 

                fila.Enqueue(entrada);
            }
              
            Console.WriteLine("\n ---Atendimento--- ");

            for (int i = 1; i <= 10 && fila.Count > 0; i++)
            {
                Console.WriteLine($"{i}º atendido: {fila.Dequeue()}");

            }

            if (fila.Count > 0)
            {
                Console.WriteLine("\nAinda aguardam na fila:");
                foreach (string nome in fila)
                {
                    Console.WriteLine(nome);
                }
            }
            else
            {
                Console.WriteLine("\nNão há mais pessoas na fila.");
            }
        }
    }
}
