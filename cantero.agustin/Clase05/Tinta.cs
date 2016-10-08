using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        public Tinta()
        {
            this._color = ConsoleColor.Black;
            this._tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color):this()
        {
            this._color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo):this(color)
        {
            this._tipo = tipo;
        }

        private string Mostrar()
        {
            
            return _color.ToString()+" "+_tipo.ToString();
        }

        public static string Mostrar(Tinta tinta)
        {
            Console.ForegroundColor = tinta._color;
            return tinta.Mostrar();
        }

        public static bool operator ==(Tinta t1, Tinta t2)
        {
            bool retorno = false;

            if (t1._color == t2._color && t1._tipo == t2._tipo )
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }

        public static implicit operator string(Tinta t)
        {
            return Tinta.Mostrar(t);
        }
    }
}
