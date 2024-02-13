using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20231106_ConjuntoGenericoSobreArrays {
    public class Veiculo {
        private string matricula;
        private int anoConstrucao;

        public string Matricula { get => matricula; set => matricula = value; }
        public int AnoConstrucao { get => anoConstrucao; set => anoConstrucao = value; }

        public Veiculo() { }

        public override string ToString() {
            return string.Format("Veiculo: {0} : {1}", Matricula, AnoConstrucao);
        }

        public override bool Equals(object obj) {
            if (obj != null && obj is Veiculo) {
                return (obj as Veiculo).Matricula.Equals(Matricula);
            } else { return false; }
        }

        public override int GetHashCode()
        {            
            return this.ToString().GetHashCode();
        }
    }
}
