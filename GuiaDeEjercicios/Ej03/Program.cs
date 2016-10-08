using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, numeroIngresado, cont;
            string primos = "";
            bool parseSuccessfull;
            parseSuccessfull = int.TryParse(Console.ReadLine(), out numeroIngresado);
            if (!parseSuccessfull)
            {
                Console.WriteLine("ERROR, Reingrese numero.");
            }
            Console.WriteLine("Numeros primos entre 1 y "+numeroIngresado);
            for(i=2;i<numeroIngresado;i++)
            {
                cont = 0;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        cont++;
                        break;
                    }
                }
                if (cont == 0)
                    primos += i + "-";
                
            }
            Console.WriteLine(primos);
            Console.ReadKey();

        }
    }
}
