using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearprobing
{
    internal class Hash
    {
        private Automovel[] tabela;

        private int tam = 7;

        public Hash()
        {
            tabela = new Automovel[tam];
            for (int i = 0; i < tam; i++)
            {
                tabela[i] = null;
            }
        }

        private int GetHash(Automovel automovel)
        {
            return automovel.GetHashCode() % tam; // a soma já está em automóvel
        }

        public int? Procurar(string matricula) // o ? quer dizer que o retorno pode ser nulo
        {
            Automovel automovel = new Automovel() { Matricula = matricula};

            int pos = GetHash(automovel);

            if (tabela[pos].Equals(automovel))
            {
                return pos;
            }

            int posInicial = pos;
            pos = (pos + 1) % tam;

            while (!tabela[pos].Equals(automovel) && (pos != posInicial))
            {
                pos = (pos + 1) % tam;
            }

            if (tabela[pos].Equals(automovel))
                return pos;

            return null;
        }

        public int Inserir(Automovel automovel)
        { //retornar -1 se cheio.
            int pos = GetHash(automovel);

            if (tabela[pos] == null)
            {
                tabela[pos] = automovel;
                return pos;
            }

            int posInicial = pos;
            pos = (pos + 1) % tam;

            while (pos != posInicial && tabela[pos] != null)
            {
                pos = (pos + 1) % tam;
            }

            if (tabela[pos] == null)
            {
                tabela[pos] = automovel;
                return pos;
            }

            return -1; // cheio

        }


        public int Remover(string matricula)
        {
            Automovel automovel = new Automovel() { Matricula = matricula };

            int pos = GetHash(automovel);

            if (tabela[pos].Equals(automovel))
            {
                tabela[pos] = null;
                return pos;
            }

            int posInicial = pos;
            pos = (pos + 1) % tam;

            while (!tabela[pos].Equals(automovel) && (pos != posInicial))
            {
                pos = (pos + 1) % tam;
            }

            if (tabela[pos].Equals(automovel))
            {
                tabela[pos] = null;
                return pos;
            }

            return -1;
        }


        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < tam; i++)
            {
                res.AppendLine(string.Format("{0,2} = {1}", i, tabela[i] != null ? tabela[i].ToString() : "-- vazia --"));
            }
            return res.ToString();
        }




    }
}
