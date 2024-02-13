using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conjunto<Proprietario> proprietario = new Conjunto<Proprietario>();
            Conjunto<Veiculo> veiculos = new Conjunto<Veiculo>();
            Conjunto<Acidente> acidentes = new Conjunto<Acidente>();

            proprietario.Inserir(new Proprietario { NIF = "111", Nome = "Zeferino" });
            proprietario.Inserir(new Proprietario { NIF = "222", Nome = "Vicente" });
            proprietario.Inserir(new Proprietario { NIF = "111", Nome = "Repetido" });
            proprietario.Inserir(new Proprietario { NIF = "555", Nome = "Ana" });
            proprietario.Inserir(new Proprietario { NIF = "556", Nome = "Mel" });
            proprietario.Remover(new Proprietario { NIF = "222", Nome = "Vicente" });
            //proprietario.Remover(new Proprietario { NIF = "556", Nome = "Mel" });
            proprietario.Inserir(new Proprietario { NIF = "556", Nome = "Melanie" });
            proprietario.Inserir(new Proprietario { NIF = "752", Nome = "Bruno" });
            proprietario.Inserir(new Proprietario { NIF = "112", Nome = "Daniel" });

            veiculos.Inserir(new Veiculo { Matricula = "AA-11-21", AnoConstrucao = 2010, Cor = "preto", Estado = Veiculo.ESTADO.abatido, NifProprietario = "556" });
            veiculos.Inserir(new Veiculo { Matricula = "BB-22-33", AnoConstrucao = 2021, Cor = "vermelho", Estado = Veiculo.ESTADO.ativo, NifProprietario = "556" });
            veiculos.Inserir(new Veiculo { Matricula = "AA-11-22", AnoConstrucao = 2010, Cor = "branco", Estado = Veiculo.ESTADO.ativo, NifProprietario = "111" });
            veiculos.Inserir(new Veiculo { Matricula = "AA-11-29", AnoConstrucao = 2012, Cor = "branco", Estado = Veiculo.ESTADO.ativo, NifProprietario = "111" });
            veiculos.Inserir(new Veiculo { Matricula = "AA-25-29", AnoConstrucao = 1952, Cor = "amarelo", Estado = Veiculo.ESTADO.abatido, NifProprietario = "111" });


            acidentes.Inserir(new Acidente { AnoAcidente = 2011, Matricula = "AA-11-21", NumeroAcidentes = 2 });
            acidentes.Inserir(new Acidente { AnoAcidente = 2023, Matricula = "BB-22-33", NumeroAcidentes = 1 });
            acidentes.Inserir(new Acidente { AnoAcidente = 2018, Matricula = "AA-11-21", NumeroAcidentes = 1 });
            acidentes.Inserir(new Acidente { AnoAcidente = 2009, Matricula = "AA-25-29", NumeroAcidentes = 2 });
            acidentes.Inserir(new Acidente { AnoAcidente = 2018, Matricula = "AA-25-29", NumeroAcidentes = 5 });

            ImprimeProprietarios(proprietario);
            ImprimeVeiculos(veiculos);
            ProprietarioMaisDeUmCarro(veiculos, proprietario);
            SortNomeProprietario(proprietario);
            SortNomeProprietarioReverso(proprietario);
            ProprietarioListaOrdemInversa(proprietario);
            CarroAtivoOuAbatido(veiculos);
            CoresCarrosComMaisDeDoisAcidentes(veiculos, acidentes);
            SortAnoVeiculo(veiculos);

        }



        public static void ImprimeProprietarios(IConjunto<Proprietario> c)
        {
            Console.WriteLine("\nLista de Proprietários:");

            foreach (Proprietario p in c.ListarTudo())
                Console.WriteLine(p);
        }

        public static void ImprimeVeiculos(IConjunto<Veiculo> c)
        {
            Console.WriteLine("\nLista de Veículos:´");

            foreach (Veiculo v in c.ListarTudo())
                Console.WriteLine(v);
        }


        public static void ProprietarioMaisDeUmCarro(IConjunto<Veiculo> veiculos, IConjunto<Proprietario> proprietarios)
        {

            Console.WriteLine("\nProprietários com mais de um carro: ");

            foreach (Proprietario p in proprietarios.ListarTudo())
            {
                int contador = 0;

                foreach (Veiculo v in veiculos.ListarTudo())
                {
                    if (p.NIF == v.NifProprietario)                    
                        contador++;                    
                }

                if (contador > 1)                
                    Console.WriteLine(p);
                
            }
        }

        public static void CarroAtivoOuAbatido(IConjunto<Veiculo> veiculos)
        {
            Console.WriteLine("\nLista de Veículos ativos: ");

            foreach (Veiculo v in veiculos.ListarTudo())
            {
                if (v.Estado == Veiculo.ESTADO.ativo)
                    Console.WriteLine(v);
            }

            Console.WriteLine("\nLista de Veículos Abatidos: ");

            foreach (Veiculo v in veiculos.ListarTudo())
            {
                if (v.Estado == Veiculo.ESTADO.abatido)
                    Console.WriteLine(v);
            }
        }

        public static void CoresCarrosComMaisDeDoisAcidentes(IConjunto<Veiculo> veiculos, IConjunto<Acidente> acidentes)
        {
            Console.WriteLine("\nCores dos carros com mais de 2 Acidentes: ");
            foreach (Veiculo v in veiculos.ListarTudo())
            {
                foreach (Acidente a in acidentes.ListarTudo())
                {
                    if (a.Matricula == v.Matricula && a.NumeroAcidentes > 2)
                    {
                        Console.WriteLine(v.Cor);
                    }

                }
            }
        }

        public static Proprietario[] SortNomeProprietario(IConjunto<Proprietario> proprietarios)
        {
            Console.WriteLine("\nLista de Proprietários Por Ordem Alfabética: ");

            Proprietario[] lista = proprietarios.ListarTudo();

            for (int i = 0; i < lista.Length; i++)
            {
                Proprietario aux = lista[i];
                int j = i;
                while (j > 0 && aux.Nome.CompareTo(lista[j - 1].Nome) < 0)
                {
                    lista[j] = lista[j - 1];
                    j--;
                }

                lista[j] = aux;
            }
            foreach (Proprietario p in lista)
            {
                Console.WriteLine(p);
            }

            return lista;

        }

        public static Proprietario[] SortNomeProprietarioReverso(IConjunto<Proprietario> proprietarios)
        {
            Console.WriteLine("\nLista de Proprietários Por Ordem Alfabética Reversa: ");

            Proprietario[] lista = proprietarios.ListarTudo();

            for (int i = 0; i < lista.Length; i++)
            {
                Proprietario aux = lista[i];
                int j = i;
                while (j > 0 && aux.Nome.CompareTo(lista[j - 1].Nome) > 0) // inverte o sinal
                {
                    lista[j] = lista[j - 1];
                    j--;
                }

                lista[j] = aux;
            }
            foreach (Proprietario p in lista)
            {
                Console.WriteLine(p);
            }

            return lista;

        }

        public static Proprietario[] ProprietarioListaOrdemInversa(IConjunto<Proprietario> proprietarios)
        {
            Console.WriteLine("\nLista de Proprietários Por Ordem Reversa: ");

            proprietarios.InverterOrdem();
            Proprietario[] lista = proprietarios.InverterOrdem();
            foreach (Proprietario p in lista)
            {
                Console.WriteLine(p);
            }

            return lista;
        }



        public static Veiculo[] SortAnoVeiculo(IConjunto<Veiculo> veiculo)
        {
            Console.WriteLine("\nLista de Veículos por ano (do mais antigo para o mais novo): ");

            Veiculo[] lista = veiculo.ListarTudo();

            for (int i = 0; i < lista.Length; i++)
            {
                Veiculo aux = lista[i];
                int j = i;
                while (j > 0 && aux.AnoConstrucao.CompareTo(lista[j - 1].AnoConstrucao) < 0)
                {
                    lista[j] = lista[j - 1];
                    j--;
                }

                lista[j] = aux;
            }
            foreach (Veiculo v in lista)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("");

            return lista;


        }

    }
}
