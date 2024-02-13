using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240108_HashExemplo {
    internal class Program {


        static void Main(string[] args) {
            HashVeiculos h = new HashVeiculos();
            h.InserirVeiculo(new Veiculo { Matricula = "AA-11-22", Marca = "Primeiro", AnoFabr = 2021});
            h.InserirVeiculo(new Veiculo { Matricula = "BB-11-22", Marca = "Segundo", AnoFabr = 2022});
            h.InserirVeiculo(new Veiculo { Matricula = "CC-11-22", Marca = "Terceiro", AnoFabr = 2023});
            h.InserirVeiculo(new Veiculo { Matricula = "DD-11-22", Marca = "Quarto", AnoFabr = 2024});
            h.InserirVeiculo(new Veiculo { Matricula = "11-ZZ-22", Marca = "Quinto", AnoFabr = 2024});
            h.EditarVeiculo(new Veiculo { Matricula = "DD-11-22", Marca = "Quarto", AnoFabr = 1800});

            Console.WriteLine(h);
        }
    }
}
