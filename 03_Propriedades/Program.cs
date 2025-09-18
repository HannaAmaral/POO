using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _03_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta("999-88");
            conta.Nome = "Hanna";

            Console.WriteLine($"Nome da Conta: {conta.Nome}");
            Console.WriteLine($"Número da Conta: {conta.}");

            //conta.saldo = -1000.00m;
            conta.Depositar(1000.00m);

            //Utilizando o metodo acessador
            conta.setSaldo(1000.00m);
            // Console.WriteLine($"Saldo Atual: {Saldo:C2}");
            conta.ImprimirSaldo();

            while (true)
            {
                Console.WriteLine("Informe a Operação: [D]-Depositar, [S]-Sacar ou [E]-Sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor para depósito");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Informe o valor para saque");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                   
                }
                else if (operacao.ToUpper() == "E")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Informe apenas as letras [D] para depositar, [S] para Sacar e [E] para Sair");
                }
            }
        }
    }
    public class Conta
    {
        //public string Numero;
        private string numero;
        public string Nome;

        //Transformar o saldo em privado e por com letra minuscula
        private decimal saldo;

        //metodos acessadores

        //construtor
        public Conta(string numero)
        {
            this.numero = numero;
        }

        public decimal getSaldo()
        {
            return saldo;
        }
        public void setSaldo(decimal valor)
        {
            this.Depositar(saldo);
        }

        public void Depositar (decimal valor)
        {
            if (valor > 0)
                saldo += valor;
            else
                Console.WriteLine("Valor do depósito incorreto, deve ser maior que zero!");

        }
        public void Sacar (decimal valor)
        {
            if(valor < saldo)
               saldo -= valor;
            else
                Console.WriteLine("Saldo insuficiente para saque!");
        }

        public void ImprimirSaldo()
        {
            Console.WriteLine($"Saldo Atual: {saldo:C2}");
        }

        public string getNumero()
        {
            return numero;
        }
    }
}
