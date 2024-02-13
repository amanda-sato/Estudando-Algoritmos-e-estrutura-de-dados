using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando3___hash___listacolisao
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Hash<Automovel> a = new Hash<Automovel>();

            a.Inserir(new Automovel { Matricula = "AA-22-33", Marca = "Ford", Modelo = "Sedam", NumQuadros = 2 });
            a.Inserir(new Automovel { Matricula = "BB-22-33", Marca = "Ford", Modelo = "Sedam", NumQuadros = 2 });
            a.Inserir(new Automovel { Matricula = "CC-22-33", Marca = "Ford", Modelo = "Sedam", NumQuadros = 2 });
            a.Inserir(new Automovel { Matricula = "DD-22-33", Marca = "Ford", Modelo = "Sedam", NumQuadros = 2 });
            a.Inserir(new Automovel { Matricula = "EE-22-33", Marca = "Ford", Modelo = "Sedam", NumQuadros = 2 });
            a.Inserir(new Automovel { Matricula = "FF-22-33", Marca = "Ford", Modelo = "Sedam", NumQuadros = 2 });
            a.Inserir(new Automovel { Matricula = "AA-22-33", Marca = "Ford", Modelo = "Sedam", NumQuadros = 2 });
            // a.Remover(new Automovel { Matricula = "DD-22-33" });
            a.Editar(new Automovel { Matricula = "AA-22-33", Marca = "Azure", Modelo = "4x4", NumQuadros = 8 });
            
            
            Console.WriteLine(a.Encontrar(new Automovel { Matricula = "BB-22-33", Marca = "Ford", Modelo = "Sedam", NumQuadros = 2 }));




            Console.WriteLine(a);

        }


    }
}
