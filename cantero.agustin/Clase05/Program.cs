using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta = new Tinta(ConsoleColor.Cyan, ETipoTinta.ConBrillito);
            Tinta tinta1 = new Tinta(ConsoleColor.Blue);
            Tinta tinta2 = new Tinta(ConsoleColor.Green);
            Pluma pluma = new Pluma("Bic", tinta);
            Pluma pluma1 = new Pluma("Bic", tinta2);
            //Pluma pluma2 = pluma + tinta2;
            //Console.WriteLine("Tipo de tinta: " + Tinta.Mostrar(tinta));
            //Console.WriteLine("Tipo de tinta: " + Tinta.Mostrar(tinta1));
            //Console.WriteLine("Tipo de tinta: " + Tinta.Mostrar(tinta2));
            //Console.ForegroundColor = ConsoleColor.Gray;
            
            //if (tinta==tinta2)
            //{
              //  Console.WriteLine("Son iguales");
            //}
            //else
            //{
              //  Console.WriteLine("Son distintas");
            //}

            //Console.WriteLine(Pluma.Mostrar(pluma));
            //Console.WriteLine(Pluma.Mostrar(pluma1));
            //Console.WriteLine(Pluma.Mostrar(pluma2));
            //Console.ForegroundColor = ConsoleColor.Gray;
            //if (pluma == tinta)
            //{
              //  Console.WriteLine("Son iguales");
            //}
            //else
            //{
              //  Console.WriteLine("Son distintas");
            //}
            Console.Write(tinta);
            Console.WriteLine("");
            Console.Write((string)pluma);
            Console.ReadKey();
        }
    }
}
