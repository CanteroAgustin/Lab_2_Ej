using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Generar un nuevo programa que realice las siguientes acciones:
A. Ingresar 5 números enteros por consola, guardándolos en 5 variables escalares. 
Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
2. Siendo la definición de número primo “un número natural mayor que 1 que tiene únicamente dos divisores distintos: él mismo y el 1.”:
A. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
NOTAS:
Recordar agregar Console.ReadKey(); para detener el curso del programa y ver lo impreso por pantalla.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
namespace Clase01_primos*/
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0, numero, maximo = 0, minimo = 0, acum = 0, prom = 0;
            bool bandera = false;
            string cadena = "";

            //Ejercicio1
            for (int i = 0; i < 5; i++)
            {
                while(!int.TryParse(Console.ReadLine(), out numero));
                if(i==0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                }
                else if (numero < minimo)
                {
                    minimo = numero;
                }
                acum += numero;
            }
            prom = acum/5;

            Console.WriteLine("Ejercicio1: ");
            Console.WriteLine("Maximo ingresado: "+maximo);
            Console.WriteLine("Minimo ingresado: "+minimo);
            Console.WriteLine("Promedio: "+prom);
            Console.WriteLine("");

            //Ejercicio 2
            while (!int.TryParse(Console.ReadLine(), out numeroIngresado)) ;

            Console.WriteLine("Numeros Primos Hasta "+numeroIngresado);

            

            for (int j = 0; j < numeroIngresado;j++ )
            {
                if (j > 2)
                {
                    for (int m = 1; m < numeroIngresado; m++)
                    {
                        if (j / m == 0)
                        {
                            bandera = true;
                            break;
                        }
                    }
                    if (bandera == false)
                    {
                        cadena += j;
                    }
                }
                
            }
            Console.WriteLine(cadena);
            Console.ReadKey();
        }
    }

