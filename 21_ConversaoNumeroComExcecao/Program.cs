using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ConversaoNumeroComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe um número inteiro");
            try
            {
                int numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Informe apenas números inteiros");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Não pode ser informados valores nulos!");
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("Número muito grande");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro!");
            }
        }
    }
}
