using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearprobing
{
    internal class Automovel
    {
        private string matricula;
        private string marca;
        private string modelo;
        private string numQuadros;

        public Automovel() { }

        public string Matricula {  get =>  matricula; set => matricula = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string NumQuadros { get => numQuadros; set => numQuadros = value; }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Automovel)
            {
                return ((Automovel)obj).Matricula == Matricula;
            } 
            return false;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3})", Matricula, Marca, Modelo, NumQuadros);
        }

        public override int GetHashCode()
        {
            int soma = 0;
            foreach (char c in Matricula.ToString()) //nesse caso não precisaria pq matricula já é uma string.
            {
                soma += (int)c;
            }
            return soma;
        }


    }
}
