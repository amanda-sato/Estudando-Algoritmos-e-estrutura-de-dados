using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudando
{
    internal class Proprietario
    {
        private string nif;
        private string nome;

        public string NIF { get => nif; set => nif = value; }
        public string Nome {  get => nome; set => nome = value; }

        public Proprietario() { }

        public override string ToString()
        {
            return string.Format("{0, 12} : {1, -30}", NIF, Nome);
        }

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
