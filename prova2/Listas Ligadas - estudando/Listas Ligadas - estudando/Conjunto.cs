using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Ligadas___estudando
{
    internal class ConjuntoAlunoAntigo
    {
        private Elemento<AlunoAntigo> cabeca;
        private int tam = 0;
        public ConjuntoAlunoAntigo()
        {
            cabeca = null;
        }

        public bool Adicionar(AlunoAntigo novo)
        {
            if (cabeca == null)
            {
                cabeca = new Elemento<AlunoAntigo>() { Valor = novo };
                tam++;
                return true;
            }
            if (Existe(novo)) return false;

            Elemento<AlunoAntigo> i = cabeca;
            while (i.Proximo != null)
            {
                i = i.Proximo;
            }

            i.Proximo = new Elemento<AlunoAntigo>() { Valor = novo };
            tam++;
            return true;
        }

        public AlunoAntigo Encontrar(AlunoAntigo item)
        {
            Elemento<AlunoAntigo> i = cabeca;
            while (i != null)
            {
                if (i.Valor.Equals(item)) return i.Valor;

                i = i.Proximo;

            }
            return default(AlunoAntigo);
        }

        public bool Existe(AlunoAntigo item)
        {
            Elemento<AlunoAntigo> i = cabeca;
            while (i != null)
            {
                if (i.Valor.Equals(item)) return true;

                i = i.Proximo;

            }
            return false;
        }

        public void Remover(AlunoAntigo item)
        {
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
                tam--;
                return;
            }

            Elemento<AlunoAntigo> i = cabeca;
            bool itemEncontrado = false;

            while (i != null && i.Proximo != null)
            {
                if (i.Proximo.Valor.Equals(item))
                {
                    i.Proximo = i.Proximo.Proximo;
                    tam--;
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

            Elemento<AlunoAntigo> prox = cabeca;
            Elemento<AlunoAntigo> ant = null;

            while (prox != null)
            {
                Elemento<AlunoAntigo> aux = prox.Proximo;
                prox.Proximo = ant;
                ant = prox;
                prox = aux;

            }

            cabeca = ant;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.AppendLine("-------------- Início --------------");

            Elemento<AlunoAntigo> i = cabeca;
            while (i != null)
            {
                res.AppendLine(i.ToString());
                i = i.Proximo;
            }

            res.AppendLine("-------------- Fim --------------");
            return res.ToString();
        }

        public string ConsultarAlunoAntigosCurso(AlunoAntigo.CURSO curso)
        {
            StringBuilder res = new StringBuilder();
            res.AppendLine("-------------- AlunoAntigos Curso --------------");

            Elemento<AlunoAntigo> i = cabeca;
            while (i != null)
            {
                if (i.Valor.Curso.Equals(curso))
                {
                    res.AppendLine(i.Valor.NomeCompleto);
                }

                i = i.Proximo;
            }

            res.AppendLine("-------------- x --------------");
            return res.ToString();

        }

        public AlunoAntigo[] ConsultarAlunoAntigosArray()
        {
            List<AlunoAntigo> AlunoAntigos = new List<AlunoAntigo>();


            Elemento<AlunoAntigo> i = cabeca;
            while (i != null)
            {
                if (i.Valor != null )
                {
                    AlunoAntigos.Add(i.Valor);
                }

                i = i.Proximo;
            }

            return AlunoAntigos.ToArray();
        }
    }

}
