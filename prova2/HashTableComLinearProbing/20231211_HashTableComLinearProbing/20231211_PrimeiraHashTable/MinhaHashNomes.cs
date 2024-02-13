//#define tam_e_primo

using System;
using System.Text;

namespace _20231204_PrimeiraHashTable {
    public class MinhaHashNomes {
        private string[] tabela;
#if tam_e_primo
        private int tam = 7; 
#else
        private int tam = 10;
#endif
        public MinhaHashNomes() {
            tabela = new string[tam];
            for (int i = 0; i < tam; i++) {
                tabela[i] = null;
            }
        }
#if tam_e_primo
        // h(x) = x % tam <- usar apenas se tamanho da tabela for 
        // um nº primo
        private int Hash(string nome) {
            int soma = 0;
            foreach (char c in nome) {
                soma += (int)c;
            }
            return soma % tam;
        }
#else
        /* Se o tamanho não é primo, exemplo acima, é 10, 
         * um p primo maior 10 será, por exemplo 11
         */
        private int Hash(string nome) {
            int soma = 0;
            int p = 11; // primo maior que 10 (podia ser outro)
            foreach (char c in nome) {
                soma += (int)c;
            }
            return (soma % p) % tam;
        }
#endif
        //public int? Procura(string nome) {
        //    int pos = Hash(nome);
        //    int posicaoInical = pos;
        //    while (/* enquanto não encontrei e não voltei à inicial*/) {
        //        pos = Incrementar(pos, tam);
        //    }
        //    if (/* se encontrei */)
        //        return pos;
        //    else
        //        return null;
        //}

        public bool InserirValor(string nome, out int? ondeInseriu) {
            ondeInseriu = null;
            int pos = Hash(nome);
            if (tabela[pos] == null) {
                ondeInseriu = pos;
                tabela[pos] = nome;
                return true;
            } else {
                int posicaoInicial = pos;
                // enquanto: não voltei à posição inicial e não estiver livre
                pos = Incrementar(pos, tam);
                while (pos != posicaoInicial && tabela[pos] != null) {
                    pos = Incrementar(pos, tam);
                }
                // se em posição, quando saiu, estava livre
                // ou se pos != posicaoInicial, é porque estava livre
                if (tabela[pos] == null) {
                    ondeInseriu = pos;
                    tabela[pos] = nome;
                    return true;
                } else
                    return false; // cheio
            }
        }

        private int Incrementar(int pos, int tam) {
            if (pos < tam - 1)
                return pos + 1;
            else
                return 0;
        }

        public override string ToString() {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < tam; i++) {
                res.AppendLine(string.Format("{0,2} = {1}", i, tabela[i] != null ? tabela[i].ToString() : "-- vazia --"));
            }
            return res.ToString();
        }
    }
}
