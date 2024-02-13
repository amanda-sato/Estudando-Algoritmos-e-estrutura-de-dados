using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudando2
{
    internal class Contacto
    {
        private string nomeCompleto;
        private DateTime dataNascimento;
        private long numTelefone;

        public Contacto() { }

        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public long NumTelefone { get => numTelefone; set => numTelefone = value; }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Contacto)
            {
                return ((Contacto)obj).NumTelefone == NumTelefone;
            }
            else { return false; }
        }

        public override string ToString()
        {
            return string.Format("{0, 12} : {1, -20}", numTelefone, NomeCompleto); // esse - serve para alinhar à esquerda
        }

        public override int GetHashCode()
        {
            int soma = 0;
            foreach (char c in NumTelefone.ToString())
            {
                soma += (int)c;
            }
            return soma;
                       
        }
    }
}
