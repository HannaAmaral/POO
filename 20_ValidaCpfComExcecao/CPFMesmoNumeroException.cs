using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCpfComExcecao
{
    internal class CPFMesmoNumeroException : Exception
    {
        public CPFMesmoNumeroException() : base("O CPF não pode ter todos os números iguais!") { }
    }
}
