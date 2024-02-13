using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    public class Proprietario
    {
        private string nif;
        private string nome;

        public string NIF { get => nif; set => nif = value; }
        public string Nome { get => nome; set => nome = value; }

        public Proprietario() { }

        public override string ToString()
        {
            return string.Format("{0,12} : {1,-30}", NIF, Nome); // O Corresponde ao nif e o 1 ao nome (posição)
        } // diz o nº de casas que ele pode ter 

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Proprietario)
                return (obj as Proprietario).NIF == NIF;

            return false;
            
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

    }
}
