using System;
namespace _08_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Aluno aluno = new Aluno(nome);

            Console.Write("Digite a idade do aluno: ");
            aluno.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite a primeira nota: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Idade: {aluno.Idade}");
            Console.WriteLine($"Média: {aluno.Media}");
            Console.WriteLine($"Situação: {aluno.Situacao}");
            Console.ReadKey();

        }

        public class Aluno
        {
            private string nome;
            public string Nome
            {
                get { return nome; }
            }

            private int idade;
            public int Idade{
                get { return idade; }
                set
                {
                    if (value >= idade)
                        idade = value;
                    else
                        Console.WriteLine("Idade inválida");     
                }
}

            public double Nota1 { get; set; }
            public double Nota2 { get; set; }

            public double Media
            {
                get { return (Nota1 + Nota2) / 2; }
            }

            public string Situacao
            {
                get
                {
                    return (Media >= 6) ? "Aprovado" : "Reprovado";
                }
            }

            public Aluno(string nome)
            {
                this.nome = nome;
            }
        }
    }
}
