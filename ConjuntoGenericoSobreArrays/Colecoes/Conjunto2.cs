using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    public class Conjunto2<T> : IConjuntov2<T>
    {
        int tam = 5;
        private T[] interno;
        private int proxPosicaoLivre;


        public Conjunto2()
        {
            interno = new T[tam];
            proxPosicaoLivre = 0;
        }


        public bool Existe(T valor)
        {
            for (int i = 0; i < proxPosicaoLivre; i++)
            {
                if (interno[i].Equals(valor))
                    return true;
            } 
            return false;
        }

        public bool Inserir(T novoValor)
        {
            if (!Existe(novoValor))
            {
                if (proxPosicaoLivre <  tam)
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
            }   else return false;
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
            int posicao = -1;
            for (int i = 0; i < proxPosicaoLivre; ++i)
            {
                if (interno[i].Equals(valor))
                    posicao = i;
            }
            if (posicao < 0)
                return false;
            for (int i = posicao; i + 1 < proxPosicaoLivre; i++)
                interno[i] = interno[i + 1];
            proxPosicaoLivre--;
            return true;
        }

        public IConjuntov2<T> Soma(IConjuntov2<T> conjunto)
        {
            T[] internoConjunto = conjunto.ListarTudo();
            Conjunto2<T> novo = new Conjunto2<T>();

            for (int i = 0; i < proxPosicaoLivre; i++)
                novo.Inserir(interno[i]);

            for (int i = 0; i < internoConjunto.Length; i++)
                novo.Inserir(internoConjunto[i]);

            return novo;
        }

    }
}
