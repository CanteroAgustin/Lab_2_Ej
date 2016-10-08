using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej19_BoligrafosB;

namespace Ej19_BoligrafosA
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boliAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boliRojo = new Boligrafo(ConsoleColor.Red, 50);


            Console.WriteLine("Tinta inicial boliAzul: " + boliAzul.getTinta());
            Console.WriteLine("Tinta inicial boliRojo: " + boliRojo.getTinta());

            boliAzul.Pintar(50);
            boliRojo.Pintar(25);

            Console.WriteLine("Tinta luego de pintar con azul: " + boliAzul.getTinta());
            Console.WriteLine("Tinta luego de pintar con rojo: " + boliRojo.getTinta());

            boliAzul.recargar();
            boliRojo.recargar();

            Console.WriteLine("Tinta azul luego de recargar: " + boliAzul.getTinta());
            Console.WriteLine("Tinta roja luego de recargar: " + boliRojo.getTinta());

            Console.ReadKey();
        }
    }
}
