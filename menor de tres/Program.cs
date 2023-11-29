using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menor_de_tres {
    class Program {
        static void Main(string[] args) {

            int menor, primeiro, segundo, terceiro;

            Console.Write("Primeiro valor: ");
            primeiro = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            segundo = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            terceiro = int.Parse(Console.ReadLine());

            if (primeiro < segundo && primeiro < terceiro) {
                menor = primeiro;
            }
            else if (segundo < terceiro) {
                menor = segundo;
            }
            else {
                menor = terceiro;
            }

            Console.WriteLine("Menor = " + menor);

        }
    }
}
