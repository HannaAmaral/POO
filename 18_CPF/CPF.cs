using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18_CPF
{
    public class CPF : IDocumento
    {
        public string Numero { get; private set; }

        public CPF(string numero)
        {
            // Remove caracteres não numéricos
            Numero = new string(numero.Where(char.IsDigit).ToArray());
        }

        public bool Validar()
        {
            string cpf = this.Numero;

            cpf = Regex.Replace(cpf, "[^0-9]", "");

            // 2 - Validar se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // 3 - Validar CPFs com todos os números iguais
            if (cpf.Distinct().Count() == 1)
                return false;

            int digX = CalculaDV(cpf, 9, 10);
            int digY = CalculaDV(cpf, 10, 11);

            // 6 - Comparar os dígitos verificadores
            if (int.Parse(cpf[9].ToString()) == digX &&
                int.Parse(cpf[10].ToString()) == digY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int CalculaDV(string cpf, int tamanho, int multiplicadorInicial)
        {
            int soma = 0;
            for (int i = 0; i < tamanho; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (multiplicadorInicial - i);
            }

            int resto = soma % 11;
            return resto < 2 ? 0 : 11 - resto;
        }
    }
}
