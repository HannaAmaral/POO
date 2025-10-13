using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o dividendo: ");
            int dividento = int.Parse( Console.ReadLine() );

            Console.Write("Informe o divisor: ");
            int divisor = int.Parse( Console.ReadLine() );

            try
            {
                int quociente = dividento / divisor;
                Console.WriteLine($"Resultado: {quociente}");
            }
            catch (DivideByZeroException ex)
            { 
                Console.WriteLine("O divisor não pode ser zero!");
            }
        }
    }
}
