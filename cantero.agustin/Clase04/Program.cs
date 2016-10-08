using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new Producto();
            Producto producto1 = new Producto("Agustin");
            Producto producto2 = new Producto("Agustin", 07);
            Producto producto3 = new Producto("Agustin", 07, 5.505F);
            Producto producto4 = new Producto("Agustin", 07, 5.505F);
            Producto producto5 = new Producto("Agustin", 07, 5.505F);

            producto.Mostrar();
            producto1.Mostrar(ConsoleColor.DarkYellow);
            producto2.Mostrar(ConsoleColor.Magenta);
            producto3.Mostrar(ConsoleColor.DarkCyan, ConsoleColor.White);
            producto4.Mostrar();
            
            Console.ReadKey();
        }

    }
}
