using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej21_Monedas;

namespace Ej21_Moneda
{
    class Dolar
    {
        private double valorD;

        public double valor
        {
            get { return valorD; }
            set { valorD = value; }
        }

        public static Dolar operator +(Dolar d, double value)
        {
            d.valor += value;
            return d;
        }

        public static double operator +(double value, Dolar d)
        {
            value += d.valor;
            return value;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            double dolar;
            dolar = e.valor * Program.valorEuro;
            d.valor += dolar;
            return d;
        }

        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            d1.valor += d2.valor;
            return d1;
        }

        public static Dolar operator -(Dolar d, double value)
        {
            d.valor -= value;
            return d;
        }

        public static double operator -(double value, Dolar d)
        {
            value -= d.valor;
            return value;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            double dolar;
            dolar = e.valor * Program.valorEuro;
            d.valor -= dolar;
            return d;
        }
        public static Dolar operator -(Dolar d1, Dolar d2)
        {
            d1.valor -= d2.valor;
            return d1;
        }

        
    }
}
