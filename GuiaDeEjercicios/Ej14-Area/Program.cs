using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej14_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado = 3;
            double basex = 2;
            double altura = 5;
            double radio = 2.5;

            Console.WriteLine("El area del Cuadrado es: "+CalculoDeArea.CalcularCuadrado(lado));
            Console.WriteLine("El area del Triangulo es: " + CalculoDeArea.CalcularTriangulo(basex, altura));
            Console.WriteLine("El area del Circulo es: " + CalculoDeArea.CalcularCirculo(radio));

            Console.ReadKey();
        }
    }
}
