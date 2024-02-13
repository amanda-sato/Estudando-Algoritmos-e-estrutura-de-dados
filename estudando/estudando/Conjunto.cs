using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudando
{
    internal class Conjunto<T> : IConjunto<T>
    {
        //criação do array "interno".
        int tam = 5;
        private T[] interno;
        private int proxPosicaoLivre;

        public Conjunto()
        {
            interno = new T[tam];
            proxPosicaoLivre = 0;
        }


        public bool Editar(T valor)
        {
            int posicao = PosicaoDe(valor);

            if (posicao < 0)
                return false;

            interno[posicao] = valor;
            
            return true;
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
                    interno[proxPosicaoLivre++] = novoValor;
                }
                return true;
            } 
            else 
                return false; 
            
        }

        public T[] InverterOrdem()
        {
            T[] lista = new T[proxPosicaoLivre];

            for (int i = 0; i < proxPosicaoLivre; i ++)
                lista[i] = interno[i];

            for (int i = 0; i < lista.Length /2; i ++)
            {
                int j = lista.Length - i - 1;
                T aux = lista[i];
                lista[i] = lista[j];
                lista[j] = aux;
            }

            return lista;

        }

        public T[] ListarTudo()
        {
            T[] replica = new T[proxPosicaoLivre];
            
            for (int i = 0; i < proxPosicaoLivre; i++)
                replica[i] = interno[i];
            
            return replica;
        }

        public int PosicaoDe(T valor) // o primeiro
        {
            int posicao = -1;
            for (int i = 0; i < proxPosicaoLivre; i++)
                if (interno[i].Equals(valor)) //é usado para comparar se dois objetos são iguais
                    posicao = i;
            
            return posicao;

        }

        public bool Remover(T valor)
        {
            int posicao = PosicaoDe(valor);

            if (posicao < 0)
                return false;

            for (int i = posicao; i + 1 < proxPosicaoLivre; i++)
                interno[i] = interno[i + 1];

            proxPosicaoLivre--;

            return true;
        }
    }
}
