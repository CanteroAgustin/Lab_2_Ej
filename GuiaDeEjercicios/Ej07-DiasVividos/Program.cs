using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej07_DiasVividos
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaDeHoy = DateTime.Now;
            DateTime fechaDeNacimiento = new DateTime();
            TimeSpan diasVividos;
            String fechaIngresada;
            Console.WriteLine("Ingrese fecha de nacimiento (dd-mm-yyyy)");
            fechaIngresada = Console.ReadLine();
            while (!DateTime.TryParse(fechaIngresada, out fechaDeNacimiento))
            {
                Console.WriteLine("ERROR, Reingrese fecha (dd-mm-yyyy)");
                fechaIngresada = Console.ReadLine();
            }
            diasVividos = fechaDeHoy.Subtract(fechaDeNacimiento);
            //diasVividos = fechaDeHoy - fechaDeNacimiento;
            Console.WriteLine("Dias vividos: " + diasVividos.Days);
            Console.ReadLine();
        }
    }
}
