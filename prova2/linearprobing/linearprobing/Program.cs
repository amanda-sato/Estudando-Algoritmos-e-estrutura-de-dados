using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearprobing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Hash tabela = new Hash();
            Automovel[] automovels = new Automovel[]
            {
                new Automovel() { Marca = "Ford", Matricula = "66-44-s4", Modelo = "sedan", NumQuadros = "4"},
                new Automovel() { Marca = "Xaomi", Matricula = "88-94-4s", Modelo = "4x4", NumQuadros = "8"},
                new Automovel() { Marca = "Tesla", Matricula = "96-45-sh", Modelo = "descapotável", NumQuadros = "1"},
                new Automovel() { Marca = "Xaomi", Matricula = "59-26-62", Modelo = "sedan", NumQuadros = "1"},
                new Automovel() { Marca = "Ford", Matricula = "75-83-01", Modelo = "descapotável", NumQuadros = "1"},
                new Automovel() { Marca = "Xaomi", Matricula = "as-59-ad", Modelo = "sedan", NumQuadros = "1"},
                new Automovel() { Marca = "Tesla", Matricula = "we-95-fr", Modelo = "sedan", NumQuadros = "1"},
                new Automovel() { Marca = "Xaomi", Matricula = "fd-95-95", Modelo = "descapotável", NumQuadros = "1"},
                new Automovel() { Marca = "Ford", Matricula = "df-fg-ty", Modelo = "4x4", NumQuadros = "1"},


            };


            foreach (Automovel a in automovels)
            {                
                int ondeInseriu = tabela.Inserir(a);
                Console.WriteLine("Inserir {0,-20} : {1}", a, ondeInseriu >= 0 
                    ? string.Format("sim {0}", ondeInseriu) 
                    : "Cheio");
            }

            Console.WriteLine(tabela);

            Console.WriteLine(tabela.Procurar("75-83-01"));

            tabela.Remover("96-45-sh");
            Console.WriteLine(tabela);

            tabela.Inserir(new Automovel() { Marca = "Ford", Matricula = "df-fg-ty", Modelo = "4x4", NumQuadros = "1" });
            Console.WriteLine(tabela);
        }
    }
}
