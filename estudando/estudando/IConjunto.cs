using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudando
{
    internal interface IConjunto<T>
    {
        bool Existe(T valor);
        bool Inserir(T valor);
        T[] ListarTudo();
        bool Remover(T valor);
        bool Editar(T valor);
        int PosicaoDe(T valor);
        T[] InverterOrdem();

    }
}
