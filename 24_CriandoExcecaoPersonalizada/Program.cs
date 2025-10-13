using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _24_CriandoExcecaoPersonalizada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a nota: ");
            int nota = int.Parse(Console.ReadLine());
            try
            {
                if (nota < 0 || nota > 10)
                    throw new NotaInvalidaException();
                else if (nota <= 5)
                    Console.WriteLine("Aluno Reprovado!");
                else
                    Console.WriteLine("Aluno Aprovado!");
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); }
        }
    }

    public class NotaInvalidaException: Exception
    {
        public NotaInvalidaException() :base("Erro: valor de nota inválido! A nota deve estar entre 0 e 10.") { }
    }
}
