using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*15. Realizar un programa que permita realizar operaciones matemáticas
simples (suma, resta, multiplicación y división).
Para ello se le debe pedir al usuario que ingrese dos números y
la operación que desea realizar (pulsando el caracter +, -, * ó
/).
El usuario decidirá cuando finalizar el programa.
Crear una clase llamada Calculadora que posea tres métodos
estáticos (de clase):
Calcular (público): Recibirá tres parámetros, el primer
número, el segundo número y la operación matemática. El
método devolverá el resultado de la operación.
Validar (Privado): Recibirá como parámetro el segundo
número. Este método se debe utilizar sólo cuando la
operación elegida sea la DIVISION. Este método devolverá
TRUE si el número es distinto de CERO.
Mostrar (público): Este método recibe como parámetro el
resultado de la operación y lo muestra por pantalla.
No posee valor de retorno.
*/
namespace EJ15_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            char salir = 's';
            double primerOperando;
            double segundoOperando;
            char operacion;
            double resultado;

            Calculadora calculadora = new Calculadora();

            while (salir != 'n' || salir == 'N')
            {
                Console.WriteLine("\nIngrese el Primer operando...");
                while (!double.TryParse(Console.ReadLine(), out primerOperando))
                {
                    Console.WriteLine("\nERROR, Debe ingresar un numero.");
                }

                Console.WriteLine("\nIngrese el Segundo operando...");
                while(!double.TryParse(Console.ReadLine(), out segundoOperando))
                {
                    Console.WriteLine("\nERROR, Debe ingresar un numero.");
                }

                Console.WriteLine("\nIngrese la operacion...");
                operacion = Console.ReadKey().KeyChar;
                while (operacion != '+' && operacion != '-' && operacion != '/' && operacion != '*')
                {
                    Console.WriteLine("\nERROR, Debe ingresar una operacion valida.");
                    operacion = Console.ReadKey().KeyChar;
                }

                resultado = calculadora.Calcular(primerOperando,segundoOperando,operacion);
                calculadora.Mostrar(resultado);
                Console.ReadKey();

                Console.WriteLine("\n¿Quiere realizar otra operacion?");
                salir = Console.ReadKey().KeyChar;
            }
        }
    }
}
