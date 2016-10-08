using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej18_Computadora1;
using Ej18_Computadora2;
using Ej18_Computadora3;

namespace Ej18_Computadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Computadora compu = new Computadora(true,EMarca.Apple, 145,EProcesador.Intel_Core_I7);
            Console.ReadKey();
        }
    }
}
