using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudando2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            agenda.InserirContacto("Zeferino", 1);
            agenda.InserirContacto("Vicente", 2);
            agenda.InserirContacto("Serafim", 3);
            agenda.InserirContacto("Sera", 4);
            agenda.InserirContacto("Sara", 5);
            agenda.AtualizaNome("SaraJones", 5);
            agenda.InserirContacto("carambola", 8);
            agenda.InserirContacto("castanha", 11);

            agenda.EliminarContacto(7);
            Console.WriteLine(agenda.EncontrarContacto(2));
            Console.WriteLine(agenda);

            //agenda.InverterContacto();

          //  Console.WriteLine(agenda);

           // agenda.InserirContacto("Ana", 6);
           // Console.WriteLine(agenda);
           // agenda.InverterContacto();
           // Console.WriteLine(agenda);
        }
    }
}
