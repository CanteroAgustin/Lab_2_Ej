using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12_Validacion2
{
    class ValidarRespuesta
    {

        public static bool ValidaS_N()
        {
            bool retorno = false;

            while (Program.respuesta != 'n' && Program.respuesta != 's')
            {
                Console.WriteLine("ERROR, Ingrese opcion valida");
                Program.respuesta = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
            }
            if (Program.respuesta == 's')
            {
                retorno = true;
            }


            return retorno;
        }
    }
}
