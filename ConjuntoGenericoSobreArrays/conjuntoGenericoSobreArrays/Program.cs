using Colecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20231106_ConjuntoGenericoSobreArrays {
    internal class Program {
        static void Main(string[] args) {
            Conjunto<Pessoa> pessoas = new Conjunto<Pessoa>();
            Conjunto<Veiculo> veiculos = new Conjunto<Veiculo>();
            Conjunto<Pessoa> novoConjunto = new Conjunto<Pessoa>();
            Conjunto<Veiculo> veiculos2 = new Conjunto<Veiculo>();

            pessoas.Inserir(new Pessoa { NIF = 111, Nome = "Zeferino"});
            pessoas.Inserir(new Pessoa { NIF = 222, Nome = "Vicente"});
            pessoas.Inserir(new Pessoa { NIF = 111, Nome = "Repetido"});
            pessoas.Inserir(new Pessoa { NIF = 555, Nome = "Ana" });
            pessoas.Inserir(new Pessoa { NIF = 556, Nome = "Mel" });
            pessoas.Remover(new Pessoa { NIF = 222, Nome = "Vicente" });
            pessoas.Remover(new Pessoa { NIF = 556, Nome = "Mel" });


            
            novoConjunto.Inserir(new Pessoa { NIF = 112, Nome = "Abudab" });
            novoConjunto.Inserir(new Pessoa { NIF = 224, Nome = "Vangogh" });
            novoConjunto.Inserir(new Pessoa { NIF = 165, Nome = "Repetiliano" });
            novoConjunto.Inserir(new Pessoa { NIF = 595, Nome = "Anaconda" });
            novoConjunto.Inserir(new Pessoa { NIF = 548, Nome = "Melado" });


            ImprimePessoas(pessoas);
            ImprimePessoas(pessoas.Soma(novoConjunto));// imprime 1º pessoas, depois novoConjunto.
            ImprimePessoas(novoConjunto.Soma(pessoas)); // imprime 1º o novoConjunto, depois pessoas.

            veiculos.Inserir(new Veiculo { Matricula = "AA-11-22", AnoConstrucao = 2010});
            veiculos.Inserir(new Veiculo { Matricula = "BB-22-33", AnoConstrucao = 2021});
            veiculos.Inserir(new Veiculo { Matricula = "AA-11-22", AnoConstrucao = 2010});

            veiculos2.Inserir(new Veiculo { Matricula = "AA-11-12", AnoConstrucao = 2014 });
            veiculos2.Inserir(new Veiculo { Matricula = "BB-22-13", AnoConstrucao = 2020 });
            veiculos2.Inserir(new Veiculo { Matricula = "CC-11-12", AnoConstrucao = 2018 });

            ImprimeVeiculos(veiculos);
            ImprimeVeiculos(veiculos.Soma(veiculos2));
            ImprimeVeiculos(veiculos2.Soma(veiculos));
        }

        public static void ImprimePessoas(IConjunto<Pessoa> c) {
            foreach(Pessoa p in c.ListarTudo()) {
                Console.WriteLine(p);
            }
            Console.WriteLine("");
        }

        public static void ImprimeVeiculos(IConjunto<Veiculo> c) {
            foreach(Veiculo p in c.ListarTudo()) {
                Console.WriteLine(p);
            }
            Console.WriteLine("");
        }
    }
}
