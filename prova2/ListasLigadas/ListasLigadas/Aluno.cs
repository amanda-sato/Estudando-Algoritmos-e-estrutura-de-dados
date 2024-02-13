using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ListasLigadas
{
    internal class Aluno
    {
        public enum CURSO { Direito, Engenharia, Artes, Computacao }

        private string matricula;
        private string nomeCompleto;
        private DateTime dataNascimento;
        private CURSO curso;
        
        public string Matricula { get =>  matricula; set => matricula = value; }
        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public DateTime DateTime { get => dataNascimento; set => dataNascimento = value; }
        public CURSO Curso { get => curso; set => curso = value; }

        public Aluno() { }

        public override string ToString()
        {
            return string.Format("Aluno: {0} - {1} - {2} - {3}", Matricula, NomeCompleto, DateTime.ToString("yyyy-MM-dd"), Curso);
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Aluno)
                return (obj as Aluno).Matricula.Equals(matricula); // a igualdade é feita pela matrícula, então a remoção com base no Equals é feita pela matrícula;
            return false;
            
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }



    }
}
