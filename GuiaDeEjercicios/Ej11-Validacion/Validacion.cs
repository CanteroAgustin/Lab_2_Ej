using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11_Validacion
{
    class Validacion
    {
        public static bool validar(int num, int max, int min)
        {
            bool retorno = false;
            if (num >= min && num <= max)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
