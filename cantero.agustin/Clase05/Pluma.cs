using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Pluma
    {
        private string _marca;
        private Tinta _tinta;

        public Pluma()
        {
            this._marca = "sin marca";
            this._tinta = null;
        }
        public Pluma(string marca):this()
        {
            this._marca = marca;
        }
        public Pluma(string marca, Tinta tinta): this(marca)
        {
            this._tinta = tinta;
        }

        private string Mostrar()
        {
            string retorno = "La pluma es: "+_marca+" y la tinta es: "+Tinta.Mostrar(_tinta);

            return retorno;
        }

        public static string Mostrar(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator ==(Pluma p, Tinta t)
        {
            bool retorno = false;

            if (p._tinta == t  )
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Pluma p, Tinta t)
        {
            return !(p == t);
        }

        public static Pluma operator +(Pluma p, Tinta t)
        {

            if (object.Equals(p._tinta ,null))
            {
                Console.WriteLine("ERROR, La tinta es null");
            }
            else if (p == t)
            {
                Console.WriteLine("La tinta es compatible");
            }
            else
            {
                Console.WriteLine("La tinta no es compatible");
            }

            return p;
        }

        public static explicit operator String(Pluma p)
        {
            return Pluma.Mostrar(p);
        }

        
    }
}
