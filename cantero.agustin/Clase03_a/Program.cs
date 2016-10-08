using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03_a
{
    class Program
    {
        public static char respuesta;

        static void Main(string[] args)
        {
            int num, sum=0;
            do
            {
                Console.Write("Ingrese Numero\n");
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("ERROR, Reingrese el numero.");
                }
                sum += num;
                Console.WriteLine("Quiere seguir?.");
                respuesta = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
            }
            while(ValidarRespuesta.ValidaS_N());
            Console.WriteLine("La suma de los numeros ingresados es: "+sum);
            Console.ReadKey();
        }
    }
}
