using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13_Conversor
{
    class Conversor
    {
        public static string DecimalBinario(double num)
        {
            int numDecimal = (int)num;
            string binario = "";
            
            binario = Convert.ToString(numDecimal, 2);

            return binario;
        }

        public static double BinarioDecimal(string num)
        {
            string numero = num;

            double resultado = Convert.ToInt32(numero, 2);

            return resultado;
        }
    }
}
