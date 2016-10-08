using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ReciboBO
    {
        public const int descuento = 13;
        public const int valorAñoAntiguedad = 150;
        float valorHora;
        string nombre;
        int antiguedad, horasTrabajadasEnElMes;
    
        public Recibo ingresarPersona()
        {
            Recibo recibo = new Recibo();
            
                Console.WriteLine("\nIngrese el nombre del empleado: ");
                nombre = Console.ReadLine();
                while (nombre == "")
                {
                    Console.WriteLine("\nERROR, El nombre no puede quedar vacio. Por favor reingrese el nombre");
                    nombre = Console.ReadLine();
                }
                recibo.Nombre = nombre;

                Console.WriteLine("\nIngrese el valor de la hora: ");
                while (!float.TryParse(Console.ReadLine(), out valorHora))
                {
                    Console.WriteLine("\nERROR, no se pudo convertir el numero ingresado. Por favor reingrese el valor");
                }
                recibo.ValorHora = valorHora;

                Console.WriteLine("\nIngrese la cantidad de horas trabajadas en el mes: ");
                while (!int.TryParse(Console.ReadLine(), out horasTrabajadasEnElMes))
                {
                    Console.WriteLine("\nERROR, no se pudo convertir el numero ingresado. Por favor reingrese el valor");
                }
                recibo.HorasTrabajadasEnElMes = horasTrabajadasEnElMes;

                Console.WriteLine("\nIngrese la antiguedad del empleado (años): ");
                while (!int.TryParse(Console.ReadLine(), out antiguedad))
                {
                    Console.WriteLine("\nERROR, no se pudo convertir el numero ingresado. Por favor reingrese el valor");
                }
                recibo.Antiguedad = antiguedad;

                return recibo;

        }

        public void generarRecibo(Recibo recibo)
        {
            float importeACobrarSinDescuentos;
            float descuentos;
            float total;

            importeACobrarSinDescuentos = calcularImporteACobrarSinDescuentos(recibo.ValorHora, recibo.HorasTrabajadasEnElMes, recibo.Antiguedad);
            descuentos = calcularDescuentos(importeACobrarSinDescuentos);
            total = importeACobrarSinDescuentos - descuentos;

            recibo.TotalDescuentos = descuentos;
            recibo.ImporteACobrarBruto = importeACobrarSinDescuentos;
            recibo.ImporteACobrarNeto = total;

        }

        public float calcularImporteACobrarSinDescuentos(float valorHora, int cantHoras, int antiguedad)
        {
            float totalHoras;
            float premioPorAntiguedad;
            float subTotalSinDescuentos;
 
            totalHoras = cantHoras * valorHora;
            premioPorAntiguedad = antiguedad * valorAñoAntiguedad;
            subTotalSinDescuentos = totalHoras + premioPorAntiguedad;

            return subTotalSinDescuentos;
        }

        public float calcularDescuentos(float subTotal)
        {
            float descuentos;
            descuentos = subTotal * descuento / 100;

            return descuentos;
        }
        public void imprimirRecibo(Recibo recibo)
        {
            StringBuilder sb = new StringBuilder();
            
            
            sb.AppendLine("");
            sb.Append('*', 46);
            sb.AppendLine("");
            sb.AppendLine("*              RECIBO DE SUELDO              *");
            sb.Append('*', 46);
            sb.AppendLine("");
            sb.Append(" NOMBRE: ");
            sb.AppendFormat("{0,-36}", recibo.Nombre);
            sb.AppendLine("");
            sb.Append(" VALOR HORA: $");
            sb.AppendFormat("{0,-31}", recibo.ValorHora);
            sb.AppendLine("");
            sb.Append(" ANTIGUEDAD: ");
            sb.Append(recibo.Antiguedad);
            sb.AppendFormat("{0,-31}", " años");
            sb.AppendLine("");
            sb.AppendLine(" --------------------------------------------");
            sb.AppendLine("");
            sb.Append(" TOTAL BRUTO: ");
            sb.AppendFormat("{0,24}", "$ ");
            sb.Append(recibo.ImporteACobrarBruto);
            sb.AppendLine("");
            sb.Append(" TOTAL DESCUENTOS: ");
            sb.AppendFormat("{0,20}", "-$ ");
            sb.Append(recibo.TotalDescuentos);
            sb.AppendLine("");
            sb.AppendLine(" --------------------------------------------");
            sb.Append(" TOTAL NETO: ");
            sb.AppendFormat("{0,25}", "$ ");
            sb.Append(recibo.ImporteACobrarNeto);
            sb.AppendLine("");
            sb.Append('*', 46);
            Console.WriteLine(sb);

        }
    }
}
