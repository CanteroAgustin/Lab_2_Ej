using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13_Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDecimal = 10;
            string numeroBinario = "11010011";
            string nuevoBinario = Conversor.DecimalBinario(numeroDecimal); 
            double nuevoDecimal = Conversor.BinarioDecimal(numeroBinario);  
            
            Console.WriteLine(numeroDecimal+" en binario es: "+nuevoBinario);
            Console.WriteLine(numeroBinario+" en decimal es: "+nuevoDecimal);
            Console.ReadKey();
        }
    }
}
