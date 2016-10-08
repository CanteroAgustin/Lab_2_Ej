using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] numeroIngresado = new int[5];
            int i, max=0, min=0, accum=0, average;
            bool isFirstEntry=true, parsed = false;
            

            for (i = 0; i < 5; i++)
            {
                parsed = int.TryParse(Console.ReadLine(), out numeroIngresado[i]);
                if (!parsed)
                {
                    parsed = int.TryParse(Console.ReadLine(), out numeroIngresado[i]);
                }
                
                if(isFirstEntry)
                {
                    max = numeroIngresado[i];
                    min = numeroIngresado[i];
                }

                if (i == 0)
                {
                    isFirstEntry = false;
                }
                else if(numeroIngresado[i]>max)
                {
                    max = numeroIngresado[i];
                }
                else if(numeroIngresado[i]<min){
                    min = numeroIngresado[i];
                }
                accum += numeroIngresado[i];
            }

            average = accum / 5;

            Console.Write("Mayor numero ingresado: "+ max +"\n");
            Console.Write("Menor numero ingresado: " + min + "\n");
            Console.Write("Promedio entre los numeros ingresados: " + average + "\n");
            Console.ReadKey();

        }
    }
}
