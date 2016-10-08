using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ15_Calculadora
{
    class Calculadora
    {
        public double Calcular(double operando1, double operando2, char operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = operando1 + operando2;
                    
                    break;
                case '-':
                    resultado = operando1 - operando2;
                    break;
                case '/':
                    bool validado = false;
                    validado = this.Validar(operando2);
                    if (!validado)
                    {
                        Console.WriteLine("ERROR, No se puede dividir por 0");
                    }
                    else
                    {
                        resultado = operando1 / operando2;
                    }
                    break;
                case '*':
                    resultado = operando1 * operando2;
                    break;
            }
            return resultado;
        }

        private bool Validar(double operando2)
        {
            bool respuesta = false;
            
            if (operando2 != 0)
            {
                respuesta = true;
            }

            return respuesta;
        }

        public void Mostrar(double resultado)
        {
            Console.WriteLine("\nEl resultado de la operacion es: " + resultado);
        }
    }
}
