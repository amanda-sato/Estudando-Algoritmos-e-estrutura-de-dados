using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240108_HashExemplo {
    public class Elemento {
        private Veiculo valor;
        private Elemento proximo;

        internal Veiculo Valor { get => valor; set => valor = value; }
        internal Elemento Proximo { get => proximo; set => proximo = value; }

        public override string ToString() {
            return valor.ToString();
        }
    }
}
