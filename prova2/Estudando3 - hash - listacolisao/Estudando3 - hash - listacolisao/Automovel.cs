using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando3___hash___listacolisao
{
    internal class Automovel
    {
        private string matricula;
        private string marca;
        private string modelo;
        private int numQuadros;


        public string Matricula { get => matricula; set => matricula = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int NumQuadros { get => numQuadros; set => numQuadros = value; }

        public Automovel() { }

        public override bool Equals(object obj)
        {
            if (obj != null & obj is Automovel)
            {
                return ((Automovel)obj).Matricula == Matricula;
            }
            return false;
        }


        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", Matricula, Marca, Modelo, NumQuadros);
        }


        public override int GetHashCode()
        {
            int soma = 0;
            foreach (char c in Matricula.ToString())
            {
                soma += (int)c;
            }

            return soma;
        }

    }
}
