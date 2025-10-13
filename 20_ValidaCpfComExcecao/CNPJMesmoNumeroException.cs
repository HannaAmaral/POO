using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCpfComExcecao
{
    internal class CNPJMesmoNumeroException : Exception
    {
        public CNPJMesmoNumeroException() : base("O CNPJ não pode ter todos os números iguais!") { }
    }
}
