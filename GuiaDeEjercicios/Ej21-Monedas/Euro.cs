using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej21_Monedas;

namespace Ej21_Moneda
{
    class Euro
    {
        private double valorE;

        public double valor
        {
            get { return valorE; }
            set { valorE = value; }
        }

        public static Euro operator +(Euro e, double value)
        {
            e.valor += value;
            return e;
        }

        public static double operator +(double value, Euro e)
        {
            value += e.valor;
            return value;
        }

        public static Euro operator +(Euro e, Dolar d){
            double euro;
            euro = d.valor / Program.valorEuro;
            e.valor += euro;
            return e; 
        }

        public static Euro operator +(Euro e1, Euro e2)
        {
            e1.valor += e2.valor;
            return e1;
        }

        public static Euro operator -(Euro e, double value)
        {
            e.valor -= value;
            return e;
        }

        public static double operator -(double value, Euro e)
        {
            value -= e.valor;
            return value;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            double euro;
            euro = d.valor / Program.valorEuro;
            e.valor -= euro;
            return e;
        }
        public static Euro operator -(Euro e1, Euro e2)
        {
            e1.valor -= e2.valor;
            return e1;
        }
    }
}
