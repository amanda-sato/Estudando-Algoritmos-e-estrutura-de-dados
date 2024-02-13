using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Estudando3___hash___listacolisao
{
    internal class Elemento<T>
    {
        private T valor;
        private Elemento<T> proximo;


        public Elemento() { }

        public Elemento<T> Proximo { get => proximo; set => proximo = value;}
        public T Valor { get => valor; set => valor = value; }

        public override string ToString()
        {
            return valor.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Elemento<T>)
            {
                return ((T)obj).Equals(this);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return valor.ToString().GetHashCode();
        }


    }
}
