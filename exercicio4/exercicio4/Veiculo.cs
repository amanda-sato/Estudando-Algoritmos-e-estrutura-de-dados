using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    public class Veiculo
    {
        private string matricula;
        private int anoConstrucao;
        private string cor;
        private bool estado = true;
        private string nifProprietario;

        public string Matricula { get => matricula; set => matricula = value; }
        public int AnoConstrucao { get => anoConstrucao; set => anoConstrucao = value; }
        public string Cor { get => cor; set => cor = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string NifProprietario { get => nifProprietario; set => nifProprietario = value; }
        


        public Veiculo() { }

        public override string ToString()
        {
            return string.Format("Veiculo: {0} : {1} : {2} : {3} : {4}", Matricula, AnoConstrucao, Cor, Estado ? "Ativo" : "Abatido", NifProprietario);
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Veiculo)
                return (obj as  Veiculo).Matricula.Equals(matricula); 
            
            else 
                return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }



    }
}
