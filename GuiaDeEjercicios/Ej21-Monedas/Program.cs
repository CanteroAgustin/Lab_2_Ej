using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej21_Moneda;

namespace Ej21_Monedas
{
    class Program
    {
        public const double valorEuro = 1.3642;
        
        static void Main(string[] args)
        {
            Euro euro = new Euro();
            Dolar dolar = new Dolar();
            double valor;

            dolar.valor = 1;
            euro.valor = 1;
            valor = 1.5;

            euro.valor -= valor;

            Console.WriteLine(euro.valor);
            Console.ReadKey();
        }
    }
}
