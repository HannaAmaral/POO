using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //<Genéric>
            List<string> nomes = new List<string>();
            nomes.Add("Ana");
            nomes.Add("Hanna");

            List<Aluno> alunos = new List<Aluno>();
            Aluno hanna = new Aluno { id = 1, nome = "Hanna" };
            AlunoEspecial Ana = new AlunoEspecial { id = 2, nome = "Ana", Deficiencia = "Visual" };
            alunos.Add(hanna);
            alunos.Add(Ana);

            nomes.Add(hanna.nome); //Aqui esta puxando o nome do OBJ hanna

            alunos.Add(new Aluno { id = 3, nome = "Benicio" }); //Adicionando um novo Aluno direto na lista

            //Impressao
            Console.WriteLine("Impressão dos Nomes: ");
            foreach (string nome in nomes)
            {
                Console.WriteLine($"Nome: {nome}");
            }

            Console.WriteLine("\nImpressão dos Alunos: ");
            foreach (Aluno aluno in alunos)
            {
                //Console.WriteLine($"Id: {aluno.id}        Nome: {aluno.nome}");
                aluno.ImprimirAluno();
            }

            Dictionary<int, String> dicNomes = new Dictionary<int, string>();
            dicNomes.Add(1, "Hanna");
            dicNomes.Add(2, "Ana");
            dicNomes.Add(3, "Benicio");

            Console.WriteLine("\nImpressao do dicNomes: ");
            for (int i = 1; i <= dicNomes.Count; i++)
            {
                Console.WriteLine(dicNomes[i]);
            }

            Dictionary<int, Aluno> dicAlunos = new Dictionary<int, Aluno>();
            dicAlunos.Add(hanna.id, hanna);
            dicAlunos.Add(Ana.id, Ana);

            Console.WriteLine("\nImpressao do dicAlunos: ");
            //for (int i = 1; i <= dicAlunos.Count; i++)
            //{
            //    dicAlunos[i].ImprimirAluno();
            //}

            foreach (Aluno aluno in dicAlunos.Values)
            {
                aluno.ImprimirAluno();
            }

            Queue filaNomes = new Queue();
            filaNomes.Enqueue("Hanna");
            filaNomes.Enqueue("Ana");
            filaNomes.Enqueue("Benicio");

            Console.WriteLine("Impressão dos FilaNomes: ");
            Console.WriteLine($" 1°){filaNomes.Dequeue()}"); //Remove o primeiro da fila
            foreach (string nome in filaNomes)
            {
                Console.WriteLine($" - {nome}");
            }

            Stack<String> stackNomes = new Stack<string>();
            stackNomes.Push("Hanna");
            stackNomes.Push("Ana");
            stackNomes.Push("Benicio");

            Console.WriteLine("\nImpressão dos StackNomes: ");
            Console.WriteLine($" 1°) {stackNomes.Pop()}");
            foreach (string nome in stackNomes)
            {
                Console.WriteLine($" - {nome}");
            }

            HashSet<string> hashnomes = new HashSet<string>();
            hashnomes.Add("Hanna");
            hashnomes.Add("Ana");
            hashnomes.Add("Benicio");

            hashnomes.Add("Ana"); //Não adiciona valores duplicados

            Console.WriteLine("\nImpressão dos setNomes");
            foreach (String nome in hashnomes)
            {
                Console.WriteLine($"-  {nome}");
            }
        }
        class Aluno
        {
            public int id { get; set; }
            public string nome { get; set; }
            public double[] Notas { get; set; }

            public virtual void ImprimirAluno()
            {
                Console.WriteLine($"Id: {id}        Nome: {nome}");
            }
        }

        class AlunoEspecial : Aluno
        {
            public string Deficiencia { get; set; }

            public override void ImprimirAluno()
            {
                Console.WriteLine($"Id: {id}        Nome: {nome}         Def: {Deficiencia}");
            }
        }
    }

}
