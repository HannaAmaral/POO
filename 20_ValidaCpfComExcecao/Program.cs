using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCpfComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string cpf =  Console.ReadLine();
            //CPF objCPF = new CPF( cpf );

            IDocumento documento;
            while (true)
            {
                Console.Write("Digite o CPF: ");
                try
                {
                    documento = new CPF(Console.ReadLine());
                    break;
                }
                catch (CPFQtdeDigitosException ex)
                {
                    Console.WriteLine($"CPF inválido: {ex.ToString()}");
                }
                catch (CPFMesmoNumeroException ex)
                {
                    Console.WriteLine($"CPF mesmo numero Invalido: {ex.ToString()}");
                }
            }

            if (documento.Validar())
                Console.WriteLine("Documento válido!");
            else
                Console.WriteLine("Documento inválido!");

            
           

            while (true)
            {
                Console.Write("Digite o CNPJ: ");

                try
                {
                    documento = new CNPJ(Console.ReadLine());
                    break;
                }
                catch (CNPJQtdeDigitosException ex)
                {
                    Console.WriteLine($"CNPJ inválido: {ex.ToString()}");
                }

            }
            if (documento.Validar())
                Console.WriteLine("Documento válido!");
            else
                Console.WriteLine("Documento inválido!");
        }
    }
}
