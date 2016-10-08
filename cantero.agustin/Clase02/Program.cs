using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            String nuevoMensaje;
            Sello.mensaje = "Hola Mundo";
            Sello.color = ConsoleColor.Cyan;
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
            Console.WriteLine(Sello.imprimirEnColor());
            Console.ReadKey();
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
            Console.WriteLine(Sello.armarFormatoMensaje());
            Console.ReadKey();
            Sello.mensaje = "Hola";
            if (Sello.tryParse(Sello.mensaje, out nuevoMensaje))
            {
                Sello.mensaje = nuevoMensaje;
                Console.WriteLine(Sello.Imprimir());
            }
            else
            {
                Sello.mensaje = nuevoMensaje;
                Sello.color = ConsoleColor.Red;
                Console.WriteLine(Sello.imprimirEnColor());
            }
            Console.ReadKey();
           
        }
    }
}
