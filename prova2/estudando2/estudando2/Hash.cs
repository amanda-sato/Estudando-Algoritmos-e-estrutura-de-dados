using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudando2
{
    internal class Hash<T>
    {
        private Conjunto<T>[] tabela;
        const int tam = 5;

        public Hash() {
            tabela = new Conjunto<T>[tam];
            for (int i = 0; i < tam; i++)
                tabela[i] = new Conjunto<T>();
        }


        public void Inserir(T valor)
        {
            int pos = GetHash(valor);
           
            tabela[pos].AdicionarAoConjunto(valor);
        }

        public void Remover(T valor) //inserido por mim
        {
            int pos = GetHash(valor);
            tabela[pos].Remove(valor);
        }

        public void Editar(T valor)
        {
            int pos = GetHash(valor);
            tabela[pos].Editar(valor);
        }

        public T Encontrar(T valor)
        {
            int pos = GetHash(valor);
            return tabela[pos].Encontra(valor);
            
        }

        private int GetHash(T valor)
        {
            
            return valor.GetHashCode() % tam;

        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < tam; i++)
            {
                res.AppendLine(string.Format("-------- {0} ----------- ", i));
                res.AppendLine(tabela[i].ToString());
            }
            return res.ToString();
        }
    }
}
