using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando3___hash___listacolisao
{
    internal class Conjunto<T> // se eu tenho uma lista, preciso de um elemento, pois são os nós da lista
    {
        private Elemento<T> cabeca;

        public Conjunto()
        {
            cabeca = null;
        }

        public bool Adicionar(T novo)
        {
            if (cabeca == null)
            {
                cabeca = new Elemento<T>() { Valor = novo };
            }
            if (Existe(novo)) return false;

            Elemento<T> i = cabeca;
            while (i.Proximo != null)
            {
                i = i.Proximo;
            }

            i.Proximo = new Elemento<T>() { Valor = novo };
            return true;

        }

        public bool Existe(T item)
        {
            Elemento<T> i = cabeca;
            while (i != null)
            {
                if (i.Valor.Equals(item)) return true;

                i = i.Proximo;

            }
            return false;
        }


        public T Encontra(T item)
        {
            Elemento<T> i = cabeca;
            while (i != null)
            {
                if (i.Valor.Equals(item)) return i.Valor;

                i = i.Proximo;

            }
            return default(T); //retorna nulo se for uma referência, 0 para tipo numérico, e uma string vazia, se string.
        }


        public void Remove(T item)
        {

            // Verificar se o item é nulo
            if (item == null)
            {
                Console.WriteLine("O item não pode ser nulo.");
                return;
            }

            // Verificar se a cabeça é nula (lista vazia)
            if (cabeca == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }


            if (cabeca.Valor.Equals(item))
            {
                cabeca = cabeca.Proximo;
                return;
            }

            Elemento<T> i = cabeca;
            bool itemEncontrado = false;

            while (i != null && i.Proximo != null)
            {
                if (i.Proximo.Valor.Equals(item))
                {
                    i.Proximo = i.Proximo.Proximo;
                    return;
                }
                i = i.Proximo;
            }

            if (!itemEncontrado)
            {
                Console.WriteLine("O item não foi encontrado na lista.\n");
                return;
            }


        }

        public void Inverter()
        {
            if (cabeca == null || cabeca.Proximo == null) return;

            Elemento<T> prox = cabeca;
            Elemento<T> ant = null;

            while (prox != null)
            {
                Elemento<T> aux = prox.Proximo;
                prox.Proximo = ant;
                ant = prox;
                prox = aux;

            }

            cabeca = ant;
        }

        public void Editar(T item)
        {

            // Verificar se o item é nulo
            if (item == null)
            {
                Console.WriteLine("O item não pode ser nulo.");
                return;
            }

            // Verificar se a cabeça é nula (lista vazia)
            if (cabeca == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }


            if (cabeca.Valor.Equals(item))
            {
                cabeca.Valor = item;
                return;
            }

            Elemento<T> i = cabeca;
            bool itemEncontrado = false;

            while (i != null && i.Proximo != null)
            {
                if (i.Proximo.Valor.Equals(item))
                {
                    i.Proximo.Valor = item;
                    return;
                }
                i = i.Proximo;
            }

            if (!itemEncontrado)
            {
                Console.WriteLine("O item não foi encontrado na lista.\n");
                return;
            }


        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();


            Elemento<T> i = cabeca;
            while (i != null)
            {
                res.AppendLine(i.ToString());
                i = i.Proximo;
            }


            return res.ToString();
        }





    }
}
