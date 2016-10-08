using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, acum = 0, num, maximo = 0, minimo = 0, promedio, rangoMax=100, rangoMin=-100;
            bool primerIngreso = true;

            for (i=0; i<10; i++)
            {
                while(!int.TryParse(Console.ReadLine(),out num))
                {
                    Console.Write("ERROR, debe ingresar un numero\n");
                }
                if (!Validacion.validar(num, rangoMax, rangoMin))
                {
                    Console.Write("ERROR, Ingrese un numero dentro del rango\n");
                }
                if (primerIngreso)
                {
                    maximo = num;
                    minimo = num;
                    primerIngreso = false;
                }
                else if(num < minimo)
                {
                    minimo = num;
                }
                else if (num > maximo)
                {
                    maximo = num;
                }
                acum += num;
            }
            promedio = acum / i;
            Console.Write("Numero maximo ingresado: " + maximo + "\n");
            Console.Write("Numero minimo ingresado: " + minimo + "\n");
            Console.Write("Promedio entre los numeros ingresados: " + promedio + "\n");
            Console.ReadKey();
        }
    }
}
