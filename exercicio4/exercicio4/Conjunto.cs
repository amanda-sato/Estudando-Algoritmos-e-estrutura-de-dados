using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class Conjunto<T> : IConjunto<T>
    {

        int tam = 5;
        private T[] interno;
        private int proxPosicaoLivre;

        public Conjunto() 
        {
            interno = new T[tam];
            proxPosicaoLivre = 0;
        }


        public bool Existe(T valor)
        {
            return PosicaoDe(valor) >= 0;
        }

        public bool Inserir(T novoValor)
        {
            if (!Existe(novoValor))
            {
                if (proxPosicaoLivre < tam)
                    interno[proxPosicaoLivre++] = novoValor;
                else
                {
                    tam += 5;
                    T[] novo = new T[tam];
                    for (int i = 0; i < proxPosicaoLivre; i++)
                        novo[i] = interno[i];
                    interno = novo;
                    interno[proxPosicaoLivre++]= novoValor; // nesse ++ acontece 2 coisas
                }                                           // ele atribui a proxima posiLivre
                                                  //e apenas após a atribuição é q o valor +1 é 
                                                  //incrementado em proxP.
            //obs: se o ++ fosse antes do ProxP, ele incrementaria antes de atribuir.

                return true;
            } else return false;
        }

        public T[] ListarTudo()
        {
            T[] replica = new T[proxPosicaoLivre];
            for (int i = 0; i < proxPosicaoLivre; i++)
                replica[i] = interno[i];
            return replica;
        }

        public bool Remover(T valor)
        {
            int posicao = PosicaoDe(valor); 
      
            if (posicao < 0)
            {
                return false;
            }
            for (int i = posicao; i + 1 < proxPosicaoLivre; i++)
                interno[i] = interno[i + 1];
            proxPosicaoLivre--;
            return true;
        }

        public bool Editar(T valor)
        {
            int posicao = PosicaoDe(valor);
            if (posicao < 0)
            {
                return false;
            }
            interno[posicao] = valor;

            return true;
        }

        public int PosicaoDe(T valor)
        {
            int posicao = -1;
            for (int i = 0; i < proxPosicaoLivre; i++)
            {
                if (interno[i].Equals(valor))
                    posicao = i;
            } 
            return posicao;
        }

        public T[] ReverterOrdem() // inverte a ordem do array
        {            
            T[] lista = new T[proxPosicaoLivre];

            for (int i = 0; i < proxPosicaoLivre; i++)
            {
                lista[i] = interno[i];
            }

            for (int i = 0; i < lista.Length / 2; i++)
            {
                int j = lista.Length - i - 1;
                T aux = lista[i];
                lista[i] = lista[j];
                lista[j] = aux;
            }
                               
            return lista;
        }
    }
}
