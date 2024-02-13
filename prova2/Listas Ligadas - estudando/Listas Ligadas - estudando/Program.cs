using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Ligadas___estudando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConjuntoAlunoAntigo c = new ConjuntoAlunoAntigo();


            c.Adicionar(new AlunoAntigo() { Numero = "0001", NomeCompleto = "Salsicha", Curso = AlunoAntigo.CURSO.Artes, DateTime = DateTime.Parse("1996-03-22") });
            c.Adicionar(new AlunoAntigo() { Numero = "0002", NomeCompleto = "Pão", Curso = AlunoAntigo.CURSO.Engenharia, DateTime = DateTime.Parse("1994-07-26") });
            c.Adicionar(new AlunoAntigo() { Numero = "0003", NomeCompleto = "Ketchup", Curso = AlunoAntigo.CURSO.Artes, DateTime = DateTime.Parse("2002-01-14") });
            c.Adicionar(new AlunoAntigo() { Numero = "0004", NomeCompleto = "Mostarda", Curso = AlunoAntigo.CURSO.Artes, DateTime = DateTime.Parse("2002-01-14") });
            c.Adicionar(new AlunoAntigo() { Numero = "0005", NomeCompleto = "Maionese", Curso = AlunoAntigo.CURSO.Artes, DateTime = DateTime.Parse("2002-01-14") });
            //c.Remover(new AlunoAntigo() { Numero = "0002" });

            Console.WriteLine(c);

            Console.WriteLine(c.ConsultarAlunoAntigosCurso(AlunoAntigo.CURSO.Artes));


            AlunoAntigo[] alunos = c.ConsultarAlunoAntigosArray();

            foreach (AlunoAntigo aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            c.Inverter();

            Console.WriteLine(c);
        }
    }
}
