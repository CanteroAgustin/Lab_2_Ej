using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2, j, cont = 0, primos = 0;
            string perfectos="";
            Console.WriteLine("Los primeros 4 numeros perfectos son: ");
            while(cont<4)
            {
                i++;
                primos = 0;
                for (j=1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primos += j;
                    }
                }
                    
                if (primos == i)
                {
                    cont++;
                    perfectos += i+"-";
                }
                if (cont == 4)
                    break;
            }

            Console.WriteLine(perfectos);
            Console.ReadKey();

        }
    }
}
