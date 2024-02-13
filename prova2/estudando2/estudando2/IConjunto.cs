using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudando2
{
    internal interface IConjunto<T> //lembrar de criar como uma interface!!!
    {
        bool AdicionarAoConjunto(T novo);
        T Encontra(T item);
        bool Existe(T item);
        void Remove(T item);

        void Editar(T item);

        //void Inverter();

        // void AddNodeAtStart(int data);
        string ToString();
    }
}
