using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>();

            string continuar = "a";

            while (continuar == "a")
            { 

                Console.Write("Digite o RA do aluno: ");
                int ra = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do aluno (mínimo 3 caracteres): ");
                string nome = Console.ReadLine();

                while (nome.Length < 3)
                {
                    Console.Write("Nome muito curto. Digite novamente: ");
                    nome = Console.ReadLine();
                }

                alunos.Add(ra, nome);

                Console.Write("Deseja adicionar outro aluno? (s/n): ");
                continuar = Console.ReadLine();

                Console.WriteLine("\nLista de alunos:");

                foreach (var aluno in alunos)
                {                                                                              //                  Predefinidos
                    Console.WriteLine($"RA: {aluno.Key}, Nome: {aluno.Value}");                //       Key = Id                 Value= Nome
                }
            }

           
        }
    }
}
