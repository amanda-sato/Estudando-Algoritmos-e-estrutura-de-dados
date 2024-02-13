using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Ligadas___estudando
{
    internal class AlunoAntigo
    {
        public enum CURSO { Direito, Engenharia, Artes, Computacao }


        private string numero;
        private string nomeCompleto;
        private DateTime dataNascimento;
        private CURSO curso;


        public string Numero { get => numero; set => numero = value; }
        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public DateTime DateTime { get => dataNascimento; set => dataNascimento = value; }
        public CURSO Curso { get => curso; set => curso = value; }

        public AlunoAntigo() { }

        public override string ToString()
        {
            return string.Format("Aluno: {0} - {1} - {2} - {3}", Numero, NomeCompleto, DateTime.ToString("yyyy-MM-dd"), Curso);
        }


        public override bool Equals(object obj)
        {
            if (obj != null && obj is AlunoAntigo)
                return (obj as AlunoAntigo).Numero.Equals(numero); // a igualdade é feita pela matrícula, então a remoção com base no Equals é feita pela matrícula;
            return false;

        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }





    }
}
