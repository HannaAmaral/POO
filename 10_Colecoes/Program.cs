using System;
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
