using System;
using System.Linq;
using System.Text.RegularExpressions;
using _18_CPF;

namespace _18_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            IDocumento documento = new CPF(cpf);
            bool valido = documento.Validar();

            if (valido)
                Console.WriteLine("CPF VÁLIDO!");
            else
                Console.WriteLine("CPF INVÁLIDO!");
        }
    }
}
