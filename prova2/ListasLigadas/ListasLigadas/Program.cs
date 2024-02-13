using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conjunto();
            ConjuntoOrdenado();
        }

        static void Conjunto()
        {
            ConjuntoAluno conjuntoAlunos = new ConjuntoAluno();

            conjuntoAlunos.Adicionar(new Aluno() { Matricula = "0001", NomeCompleto = "Salsicha", Curso = Aluno.CURSO.Artes, DateTime = DateTime.Parse("1996-03-22") });
            conjuntoAlunos.Adicionar(new Aluno() { Matricula = "0002", NomeCompleto = "Pão", Curso = Aluno.CURSO.Engenharia, DateTime = DateTime.Parse("1994-07-26") });
            conjuntoAlunos.Adicionar(new Aluno() { Matricula = "0003", NomeCompleto = "Ketchup", Curso = Aluno.CURSO.Artes, DateTime = DateTime.Parse("2002-01-14") });


            Console.WriteLine(conjuntoAlunos);
            Console.WriteLine(conjuntoAlunos.ConsultarAlunosCurso(Aluno.CURSO.Artes));

            Aluno[] alunos = conjuntoAlunos.ConsultarAlunosMaiores(Aluno.CURSO.Artes);

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }

        static void ConjuntoOrdenado()
        {
            ConjuntoOrdenado conjuntoOrdenado = new ConjuntoOrdenado();

            conjuntoOrdenado.Adicionar(new Aluno() { Matricula = "0004", NomeCompleto = "Salsicha", Curso = Aluno.CURSO.Artes, DateTime = DateTime.Parse("1996-03-22") });
            conjuntoOrdenado.Adicionar(new Aluno() { Matricula = "0003", NomeCompleto = "Ketchup", Curso = Aluno.CURSO.Artes, DateTime = DateTime.Parse("2012-01-14") });
            conjuntoOrdenado.Adicionar(new Aluno() { Matricula = "0002", NomeCompleto = "Pão", Curso = Aluno.CURSO.Engenharia, DateTime = DateTime.Parse("2010-07-26") });
            conjuntoOrdenado.Adicionar(new Aluno() { Matricula = "0001", NomeCompleto = "Mostarda", Curso = Aluno.CURSO.Direito, DateTime = DateTime.Parse("2002-01-14") });


            Console.WriteLine(conjuntoOrdenado);
            Console.WriteLine(conjuntoOrdenado.ConsultarAlunosCurso(Aluno.CURSO.Artes));

            Aluno[] alunos = conjuntoOrdenado.ConsultarAlunosMaiores(Aluno.CURSO.Artes);

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
