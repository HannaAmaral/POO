using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCpfComExcecao
{
    internal class CPFQtdeDigitosException : Exception
    {
        public CPFQtdeDigitosException() : base("O CPF deve ter 11 dígitos!") { }
    }
}
