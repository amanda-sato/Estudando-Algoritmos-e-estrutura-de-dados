using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasLigadas
{
    internal class ConjuntoOrdenado
    {
        private Elemento<Aluno> cabeca;
        private int tam = 0;
        public ConjuntoOrdenado()
        {
            cabeca = null;
        }

        public bool Adicionar(Aluno novo) //add de forma ordenada.
        {
            if (cabeca == null)
            {
                cabeca = new Elemento<Aluno>() { Valor = novo };
                tam++;
                return true;
            }
            
            if (Existe(novo)) return false;

            if (cabeca.Valor.Matricula.CompareTo(novo.Matricula) > 0 )
            {
                cabeca = new Elemento<Aluno> { Valor = novo, Proximo = cabeca};
                return true;

            }

            Elemento<Aluno> i = cabeca;
            while (i.Proximo != null && i.Proximo.Valor.Matricula.CompareTo(novo.Matricula) < 0)
            {
                i = i.Proximo;
            }

           
            i.Proximo = new Elemento<Aluno>() { Valor = novo, Proximo = i.Proximo };
            tam++;
            return true;
        }

        public Aluno Encontrar(Aluno item)
        {
            Elemento<Aluno> i = cabeca;
            while (i != null)
            {
                if (i.Valor.Equals(item)) return i.Valor;

                i = i.Proximo;

            }
            return default(Aluno);
        }

        public bool Existe(Aluno item)
        {
            Elemento<Aluno> i = cabeca;
            while (i != null)
            {
                if (i.Valor.Equals(item)) return true;

                i = i.Proximo;

            }
            return false;
        }

        public void Remover(Aluno item)
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

            Elemento<Aluno> i = cabeca;
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

            Elemento<Aluno> prox = cabeca;
            Elemento<Aluno> ant = null;

            while (prox != null)
            {
                Elemento<Aluno> aux = prox.Proximo;
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

            Elemento<Aluno> i = cabeca;
            while (i != null)
            {
                res.AppendLine(i.ToString());
                i = i.Proximo;
            }

            res.AppendLine("-------------- Fim --------------");
            return res.ToString();
        }

        public string ConsultarAlunosCurso(Aluno.CURSO curso)
        {
            StringBuilder res = new StringBuilder();
            res.AppendLine("-------------- Alunos Curso --------------");

            Elemento<Aluno> i = cabeca;
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

        public Aluno[] ConsultarAlunosMaiores(Aluno.CURSO curso)
        {
            List<Aluno> alunos = new List<Aluno>();


            Elemento<Aluno> i = cabeca;
            while (i != null)
            {
                if (i.Valor.Curso.Equals(curso) && DateTime.Now.Year - i.Valor.DateTime.Year >= 18)
                {
                    alunos.Add(i.Valor);
                }

                i = i.Proximo;
            }

            return alunos.ToArray();
        }
    }
}
