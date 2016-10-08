using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05_CentroNumerico
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, numeroIngresado = 0, subLista1=0, subLista2=0;
            string centroNumerico = "";

            if (!int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                Console.WriteLine("ERROR, Reingrese numero");
            }
            for (i = 1; i < numeroIngresado;i++)
            {
                for (j = 1; j < i; j++)
                {
                    subLista1 += j;
                }
                for (k = i+1; k < numeroIngresado; k++)
                {
                    subLista2 += k;
                    if (subLista1 == subLista2)
                    {
                        centroNumerico += i + "-";
                    }
                }
                
                subLista1 = 0;
                subLista2 = 0;
            }
            Console.WriteLine("Los centros numericos entre 1 y "+numeroIngresado+" son:");
            if (centroNumerico == "")
            {
                Console.WriteLine("No hay centros numericos en el rango especificado");
            }
            Console.WriteLine(centroNumerico);
            Console.ReadKey();
        }
    }
}
