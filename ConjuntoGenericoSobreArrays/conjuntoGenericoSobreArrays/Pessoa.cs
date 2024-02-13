using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20231106_ConjuntoGenericoSobreArrays {
    public class Pessoa {
        private int nif;
        private string nome;

        public int NIF { get => nif; set => nif = Math.Abs(value); }
        public string Nome { get => nome; set => nome = value; }

        public Pessoa() { }

        public override string ToString() {
            return string.Format("{0,12} : {1,-30}", NIF, Nome);
        }

        public override bool Equals(object obj) {
            if (obj != null && obj is Pessoa) {
                return (obj as Pessoa).NIF == NIF;
            }
            return false;
        }

        public override int GetHashCode() {
            //return NIF.GetHashCode();
            return this.ToString().GetHashCode();
        }
    }
}
