using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudando
{
    internal class Acidente
    {
        private int anoAcidente;
        private string matricula;
        private int numeroAcidentes;


        public int AnoAcidente { get =>  anoAcidente; set => anoAcidente = value; }
        public string Matricula {  get => matricula; set => matricula = value; }
        public int NumeroAcidentes {  get => numeroAcidentes; set  => numeroAcidentes = value; }

        public Acidente() { }

        public override string ToString()
        {
            return string.Format("Acidente: {0} : {1} : {2}", AnoAcidente, Matricula, NumeroAcidentes);
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Acidente)
                return (obj as Acidente).Matricula.Equals(matricula) && (obj as Acidente).AnoAcidente.Equals(anoAcidente); 
            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
