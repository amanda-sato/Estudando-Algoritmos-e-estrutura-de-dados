using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    public interface IConjuntov2<T> // O T é qqlr tipo
    {
        bool Existe(T valor);
        bool Inserir(T novoValor);
        T[] ListarTudo();
        bool Remover(T valor);
        IConjuntov2<T> Soma(IConjuntov2<T> conjunto);
                
    }
}
