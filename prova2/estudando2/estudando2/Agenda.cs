using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudando2
{
    internal class Agenda
    {
        private Hash<Contacto> tabela;
        public Agenda()
        {
            tabela = new Hash<Contacto>();
        }

        public void InserirContacto(string nome, long telefone)
        {
            tabela.Inserir(new Contacto
            {
                NumTelefone = telefone,
                NomeCompleto = nome
            });
        }

        public Contacto EncontrarContacto(long telefone)
        {
            return tabela.Encontrar(new Contacto
            {
                NumTelefone = telefone
            });

        }

        //public void AtualizaNumero(long numAtual, long numNovo)
        //{
        //    Contacto aAtualizar = tabela.Encontra(new Contacto { NumTelefone = numAtual });
        //    if (aAtualizar != null)
        //    {
        //        aAtualizar.NumTelefone = numNovo;
        //    }
        //}

        public void AtualizaNome(string novoNome, long telefone)
        {
            tabela.Editar(new Contacto { NomeCompleto = novoNome, NumTelefone = telefone});
        }

        public void EliminarContacto(long telefone)
        {
            tabela.Remover(new Contacto { NumTelefone = telefone });
        }

        //public void InverterContacto()
        //{
        //    tabela.Inverter();
        //}


        public override string ToString()
        {
            return tabela.ToString();
        }
    }



}

