using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class Acidente
    {
        private int ano;
        private string matricula;
        private int numeroAcidentes;

        public int Ano { get =>  ano; set => ano = value;}
        public string Matricula {  get => matricula; set => matricula = value; }
        public int NumeroAcidentes { get => numeroAcidentes; set => numeroAcidentes = value; }

        public Acidente() { }

        public override string ToString()
        {
            return string.Format("Acidente: {0} : {1} : {2}", Ano, Matricula, NumeroAcidentes);
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Acidente)
                return (obj as Acidente).Matricula.Equals(matricula) && (obj as Acidente).Ano.Equals(ano);

            else
                return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

    }
}
