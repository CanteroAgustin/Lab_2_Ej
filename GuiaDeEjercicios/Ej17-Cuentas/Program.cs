using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej17_Cuentas
{
    class Program
    {

        static void Main(string[] args)
        {
            long auxNroCuenta;
            string auxNombre;
            double auxSaldo;

            Cuenta cuenta = new Cuenta();

            cuenta.setNombre("agustin");
            cuenta.setNroCuenta(-012342);
            cuenta.setSaldo(-100.5);

            auxNombre = cuenta.getNombre();
            auxNroCuenta = cuenta.getNroCuenta();
            auxSaldo = cuenta.getSaldo();

            Console.WriteLine("Nombre: "+ cuenta.getNombre());
            Console.Write("NroCuenta: ");
            Console.WriteLine((auxNroCuenta == -1) ? "ERROR" : auxNroCuenta.ToString());
            Console.Write("Saldo: ");
            Console.WriteLine((auxSaldo == -1) ? "ERROR" : auxSaldo.ToString());
            Console.ReadKey();
        }
    }
}
