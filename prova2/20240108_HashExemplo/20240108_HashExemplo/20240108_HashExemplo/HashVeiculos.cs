using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _20240108_HashExemplo {
    public class HashVeiculos {
        private ListaVeiculos[] tabela;
        const int tam = 5;

        public HashVeiculos() {
            tabela = new ListaVeiculos[tam];
            for (int i = 0; i < tam; i++)
                tabela[i] = new ListaVeiculos();
        }


        public void InserirVeiculo(Veiculo veiculo) {
            int pos = Hash(veiculo.Matricula);
            tabela[pos].InserirNovoVeiculo(veiculo);    
        }

        public void DeletarVeiculo(Veiculo veiculo) //inserido por mim
        {
            int pos = Hash(veiculo.Matricula);
            tabela[pos].DeletarVeiculo(veiculo);
        }

        public void EditarVeiculo(Veiculo veiculo)
        {
            int pos = Hash(veiculo.Matricula);
            tabela[pos].EditarVeiculo(veiculo);
        }

        private int Hash(string coisa) {
            int soma = 0;
            foreach (char c in coisa) {
                soma += (int)c;
            }
            return soma % tam;
        }

        public override string ToString() {
            StringBuilder res = new StringBuilder();
            for(int i = 0; i < tam; i++) {
                res.AppendLine(string.Format("-------- {0} ----------- ", i));
                res.AppendLine(tabela[i].ToString());
            }
            return res.ToString();
        }
    }
}
