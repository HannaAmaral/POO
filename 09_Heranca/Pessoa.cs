using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome;
        public string Telefone;

        public abstract string getDocumento();

        public void Imprimir()
        {
            Console.WriteLine($"Lista de Pessoas \n\nNome: {this.Nome} Documento: {this.getDocumento()} Telefone: {this.Telefone}");
        }
        
        public override string ToString()
        {
            return $"<ToString> Nome: {this.Nome} Documento: {getDocumento()} Telefone: {this.Telefone}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            //Cast=> Conversão de objeto
            //((Pessoa) obj)=> Converte o obj para o tipo Pessoa
            return this.Id == ((Pessoa)obj).Id;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
