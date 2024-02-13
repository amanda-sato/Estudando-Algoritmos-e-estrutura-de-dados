using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudando2
{
    internal class Elemento<T>
    {
        private T valor;
        private Elemento<T> proximo;


        public Elemento() { }

        public Elemento<T> Proximo { get => proximo; set => proximo = value; }
        public T Valor { get => valor; set => valor = value; }

        public override string ToString()
        {
            return valor.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Elemento<T>) 
                return ((T)obj).Equals(this);
            return false;
        }

        public override int GetHashCode()
        {
            return valor.ToString().GetHashCode();
        }




    }
}
