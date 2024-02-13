using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20231120_Grupo3 {
    public class Conjunto<T> : IConjunto<T> {
        private Elemento<T> cabeca;
        public Conjunto() {
            cabeca = null;
        }


        public bool AdicionarAoConjunto(T novo) {

            if (cabeca == null) { 
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

        public bool Existe(T item) {
            Elemento<T> i =  cabeca;
            while (i != null)
            {
                if (i.Valor.Equals(item)) return true;

                i = i.Proximo;
                
            }
            return false;

        }


        public T Encontra(T item) {
            Elemento<T> i = cabeca;
            while (i != null)
            {
                if (i.Valor.Equals(item)) return i.Valor;

                i = i.Proximo;

            }
            return default(T); //retorna nulo se for uma referência, 0 para tipo numérico, e uma string vazia, se string.
        }

        public void Remove(T item) {

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

            
            if (cabeca.Valor.Equals(item)) {
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


        public void Inverter() //para comentar várias linhas ctrl + k + ctrl C, e descomentar é ctrl + k e ctrl + u 
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

        //public void Inverter()
        //{

        //    Conjunto<T> reversedList = new Conjunto<T>();

        //    Elemento<T> atual = cabeca;

        //    while (atual != null)
        //    {
        //        reversedList.AddNodeAtStart(atual.Valor);
        //        atual = atual.Proximo;
        //    }

        //    cabeca = reversedList.cabeca;                       
        //}

        //public void AddNodeAtStart(T novo)
        //{
        //    Elemento<T> newNode = new Elemento<T>() { Valor = novo };
        //    newNode.Proximo = cabeca;
        //    cabeca = newNode;
        //}


        public override string ToString() {
            StringBuilder res = new StringBuilder();
            res.AppendLine("---------------- inicio ----------------");
            
            Elemento<T> i = cabeca;
            while (i != null)
            {
                res.AppendLine(i.ToString());
                i = i.Proximo;
            }
           
            res.AppendLine("------------------ fim -----------------");
            return res.ToString();
        }
    }
}
