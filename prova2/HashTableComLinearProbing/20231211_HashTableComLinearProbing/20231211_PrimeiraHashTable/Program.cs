using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231204_PrimeiraHashTable {
    internal class Program {
        static void Main(string[] args) {
            MinhaHashNomes h = new MinhaHashNomes();

            string[] nomes = {
            "Vicente",
            "Zeferino",
            "Saraiva",
            "Josefina",
            "Vilaça",
            "Armando",
            "Xavier",
            "Zulmira",
            "Tinoco",
            "Margarida",
            "Extra",
            "Leo"};

            foreach (string s in nomes) {
                int? ondeInseriu;
                bool sucesso = h.InserirValor(s, out ondeInseriu);
                Console.WriteLine("Inserir {0,-20} : {1}", s, sucesso ? 
                    string.Format("sim {0}", ondeInseriu) :
                    "Cheio");
            }

            Console.WriteLine(h);
        }
    }
}
