using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.mensaje;
        }

        public static void Borrar()
        {
            Sello.mensaje="Fran Gato";
        }

        public static string imprimirEnColor(){
            Console.ForegroundColor = Sello.color;
            return Sello.mensaje;
        }

        public static string armarFormatoMensaje()
        {
            string nuevoMensaje="";
            StringBuilder sb = new StringBuilder();
            int largo = Sello.mensaje.Length;
            for (int i = 0; i <= largo + 1; i++)
            {
                sb.Append("*");
            }
            sb.Append("\n*");
            sb.Append(Sello.mensaje);
            sb.Append("*\n");
            for (int i = 0; i <= largo + 1; i++)
            {
                sb.Append("*");
            }
            nuevoMensaje = sb.ToString();
                return nuevoMensaje;
        }

        public static Boolean tryParse(string mensaje, out string mensajeSalida){
        
            bool retorno = false;
            int largo = mensaje.Length;
            mensajeSalida = "Debe ingresar alguna letra";
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(mensaje))
            {   
                for (int i = 0; i <= largo+1; i++)
                {
                    sb.Append("*");
                }
                sb.Append("\n*");
                sb.Append(Sello.mensaje);
                sb.Append("*\n");
                for (int i = 0; i <= largo+1; i++)
                {
                    sb.Append("*");
                }
                mensajeSalida = sb.ToString();
                retorno = true;
            }         
            return retorno;
        }
    }
}
