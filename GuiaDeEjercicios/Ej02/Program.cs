using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            double cuadrado, cubo;
            bool parsed = int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (!parsed || numeroIngresado<1)
            {
                Console.WriteLine("ERROR. Reingresar numero!!!");
                parsed = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            cuadrado = Math.Pow(numeroIngresado,2);
            cubo = Math.Pow(numeroIngresado,3);

            Console.WriteLine(numeroIngresado+"^2= "+cuadrado);
            Console.WriteLine(numeroIngresado + "^3= " + cubo);
            Console.ReadKey();
        }
    }
}
