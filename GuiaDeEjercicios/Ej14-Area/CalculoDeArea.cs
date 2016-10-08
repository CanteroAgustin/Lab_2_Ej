using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej14_Area
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double area = 0;
            area = Math.Pow(lado, 2);
            return Math.Round(area, 2);
        }
        public static double CalcularTriangulo(double basex, double altura)
        {
            double area = 0;
            area = (basex * altura) / 2;
            return Math.Round(area, 2);
        }
        public static double CalcularCirculo(double radio)
        {
            double area = 0;
            area = Math.PI * Math.Pow(radio,2);
            return Math.Round(area,2);
        }
    }
}
