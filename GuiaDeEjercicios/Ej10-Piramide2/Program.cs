using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10_Piramide2
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            Piramide piramide = new Piramide();

            Console.WriteLine("Ingrese la altura de la piramide(n>1)");
            while (!int.TryParse(Console.ReadLine(), out altura) || altura < 1)
            {
                Console.WriteLine("ERROR. El numero no se pudo convertir o es menor a 1, reingrese.");
            }

            piramide.dibujarPiramide(altura);

            Console.ReadKey();
        }
    }
}
