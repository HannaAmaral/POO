using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sem utilizador Enum");
            //List<int> diasSemEnum = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
            List<int> diasSemEnum = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            foreach (var item in diasSemEnum)
            {
                if(item == 1) Console.WriteLine("Domingo - Número: 1");
                else if (item == 2) Console.WriteLine("Segunda - Número: 2");
                else if (item == 3) Console.WriteLine("Terça - Número: 3");
                else if (item == 4) Console.WriteLine("Quarta - Número: 4");
                else if (item == 5) Console.WriteLine("Quinta - Número: 5");
                else if (item == 6) Console.WriteLine("Sexta - Número: 6");
                else if (item == 7) Console.WriteLine("Sábado - Número: 7");
            }

            Console.WriteLine("\n\n Com utilização de Enum");
            List<DiaDaSemana> diasComEnum = new List<DiaDaSemana>()             { DiaDaSemana.Domingo, DiaDaSemana.Segunda,
                                                                                  DiaDaSemana.Terça, DiaDaSemana.Quarta, 
                                                                                  DiaDaSemana.Quinta, DiaDaSemana.Sexta, DiaDaSemana.Sabado };

            foreach (var item in diasComEnum)
            {
                Console.WriteLine($"{item} - Numero: { (int)item}");
            }
        }
        public enum DiaDaSemana
        {
            Domingo = 1,
            Segunda,
            Terça,
            Quarta,
            Quinta,
            Sexta,
            Sabado
        }
    }
}
