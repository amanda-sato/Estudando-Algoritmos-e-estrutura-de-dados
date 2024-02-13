using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240108_HashExemplo {
    public class ListaVeiculos {
        private Elemento cabeca;

        public ListaVeiculos() {
            cabeca = null;
        }

        public void InserirNovoVeiculo(Veiculo veiculo) {
            Elemento novo = new Elemento { Valor = veiculo, Proximo = null };
            if (cabeca == null)
                cabeca = novo;
            else {
                Elemento aux = cabeca;
                while (aux.Proximo != null) {
                    if (aux.Valor.Equals(veiculo)) return;
                    else aux = aux.Proximo;
                }
                if(/*aux != null &&*/ !aux.Valor.Equals(veiculo))
                    aux.Proximo = novo;
            }
        }

        public void DeletarVeiculo(Veiculo veiculo)
        {
            if (cabeca != null)
            {
                if (cabeca.Valor.Equals(veiculo)) 
                    cabeca = cabeca.Proximo;
                else
                {
                    Elemento ant = cabeca;
                    Elemento aux = cabeca.Proximo;

                    while (aux != null && !aux.Valor.Equals(veiculo))
                    {
                        ant = aux;
                        aux = aux.Proximo;
                    }

                    if (aux != null)
                    {
                        ant.Proximo = aux.Proximo;
                    }
                }
                
            }
        }

        public void EditarVeiculo(Veiculo veiculo)
        {
            if (cabeca == null)
            {
                // A tabela está vazia, não há nada para editar
                return;
            }

            if (cabeca.Valor.Equals(veiculo))
                cabeca.Valor = veiculo;
            else
            {
                Elemento ant = cabeca;
                Elemento aux = cabeca.Proximo;

                while (aux != null && !aux.Valor.Equals(veiculo))
                {
                    ant = aux;
                    aux = aux.Proximo;
                }

                if (aux != null)
                {
                    aux.Valor = veiculo;
                }
            }
        }

        public override string ToString() {
            StringBuilder res = new StringBuilder();
            //res.AppendLine("---------- inicio ----------- ");
            Elemento aux = cabeca;
            while(aux != null) {
                res.AppendLine(aux.ToString());
                aux = aux.Proximo;
            }
            //res.AppendLine("---------- fim ----------- ");
            return res.ToString();
        }
    }
}
