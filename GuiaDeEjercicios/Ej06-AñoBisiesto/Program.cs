using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej06_AñoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Los años bisiestos hasta la fecha son: ");
            for (i = 0; i <= DateTime.Now.Year;i++)
            {
                if (i % 4 == 0 && i%100!=0 || i%400==0)
                {
                    Console.WriteLine("-"+i);
                }
            }
            Console.ReadKey();
        }
    }
}
