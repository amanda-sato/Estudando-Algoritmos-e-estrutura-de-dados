using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240108_HashExemplo {
    public class Veiculo {
        private string matricula;
        private string marca;
        private int anoFabr;

        public Veiculo() { }
        public string Matricula { get => matricula; set => matricula = value; }
        public int AnoFabr { get => anoFabr; set => anoFabr = value; }
        public string Marca { get => marca; set => marca = value; }

        public override string ToString() {
            return string.Format("{0:-10} : {1,20}, {2}", Matricula, Marca, AnoFabr);
        }

        public override bool Equals(object obj) {
            if(obj != null && obj is Veiculo) {
                return ((Veiculo)obj).Matricula == this.Matricula;
            } else { return false; }
        }
    }
}
