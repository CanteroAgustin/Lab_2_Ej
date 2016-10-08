using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i, j, cont = 0, numeroIngresado = 0;
            Boolean esNumeroValido;
            esNumeroValido = int.TryParse(Console.ReadLine(), out numeroIngresado);
            cont = numeroIngresado;
            while(!esNumeroValido)
            {
                Console.WriteLine("Ingrese un numero valido.");
                esNumeroValido = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            Console.WriteLine("Numeros primos de " + numeroIngresado + ":\n");
            for (i = 2; i < numeroIngresado; i++)
            {
                for (j = 3; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        cont++;
                    }
                    
                }
                if (cont == 0)
                {
                    Console.WriteLine(i + "-");
                }
            }
            Console.ReadKey();
        }
    }
}
