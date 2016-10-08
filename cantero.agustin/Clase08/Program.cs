using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera temp = new Tempera(ConsoleColor.Cyan, "Colorin", 20);
            Tempera temp1 = new Tempera(ConsoleColor.Cyan, "Colorin", 10);
            Tempera temp2 = new Tempera(ConsoleColor.Black, "ColorOtro", 10);

            Paleta p = 5;
            p += temp;
            p += temp1;
            p += temp2;
            
            Console.Write((string)p);

            for (int i = 0; i < p.cantidadMaxColores; i++)
            {
                if(!Object.Equals(p[i],null)){
                    p[i].marca = "";
                }
                
                
                    
                
                p[i] = new Tempera(ConsoleColor.DarkMagenta, "ColorOtro", 10);
                Console.Write(p[i]);
            }

                Console.ReadKey();
        }
    }
}
