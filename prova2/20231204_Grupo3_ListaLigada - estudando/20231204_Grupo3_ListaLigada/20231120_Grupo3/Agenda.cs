using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231120_Grupo3 {
    public class Agenda {
        private IConjunto<Contacto> tabela;
        public Agenda() {
            tabela = new Conjunto<Contacto>();
        }

        public void InserirContacto(string nome, long telefone) {
            tabela.AdicionarAoConjunto(new Contacto {
                NumTelefone = telefone,
                NomeCompleto = nome
            });
        }

        public Contacto EncontrarContacto(long telefone)
        {
            return tabela.Encontra(new Contacto
            {
                NumTelefone = telefone
            });

        }

        public void AtualizaNumero(long numAtual, long numNovo) {
            Contacto aAtualizar = tabela.Encontra(new Contacto { NumTelefone = numAtual });
            if (aAtualizar != null) {
                aAtualizar.NumTelefone = numNovo;
            }
        }

        public void EliminarContacto(long telefone) {
            tabela.Remove(new Contacto { NumTelefone = telefone });
        }

        public void InverterContacto()
        {
            tabela.Inverter();
        }


        public override string ToString() {
            return tabela.ToString();
        }
    }
}
