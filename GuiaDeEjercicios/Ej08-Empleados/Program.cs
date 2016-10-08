using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static void Main(string[] args)
        {
            char respuesta;
            bool seguir = true;

            ReciboBO reciboBO = new ReciboBO();
            Recibo recibo = new Recibo();

            StringBuilder sb = new StringBuilder();
            
            sb.Append("**************************\n");
            sb.Append("* CALCULADORA DE SUELDOS *\n");
            sb.Append("**************************\n");
            sb.Append("\n");
            sb.Append("*Obteniendo datos...\n");
            sb.Append("\n");
            Console.WriteLine(sb);
            
            
            do
            {
            Console.Clear();
            recibo = reciboBO.ingresarPersona();

            Console.WriteLine("\n*Finalizo correctamente la carga de datos, presione una tecla para ver el recibo...");
            Console.ReadKey();

            reciboBO.generarRecibo(recibo);
            Console.Clear();
            reciboBO.imprimirRecibo(recibo);
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\nQuiere ingresar otro empleado? (S/N)");
            
            respuesta = Console.ReadKey().KeyChar;

                if (respuesta == 'n' || respuesta == 'N')
                {
                    seguir = false;
                }

            } while (seguir);
        }
    }
}
