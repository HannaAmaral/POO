using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_LeituraArquivoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o caminho e nome do arquivo: ");
            string arquivo = Console.ReadLine();
            try
            {
                string texto = File.ReadAllText(arquivo);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Diretório não encontrado!");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Arquivo não encontrado!");
            }
            catch (Exception ex)
            {   
                Console.WriteLine("Erro na abertura do arquivo!");
            }
        }
    }
}
