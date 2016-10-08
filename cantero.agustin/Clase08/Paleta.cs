using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08
{
    class Paleta
    {
        private int _cantidadMaxColores;
        private Tempera[] _temperas;

        public int cantidadMaxColores
        {
            get { return _cantidadMaxColores; }
        }

        private String verPaleta
        {
            get { return (string)this; }
        }
  
        private Paleta():this(5)
        {
        }

        public Paleta(int cantidadMaxColores)
        {
            this._cantidadMaxColores = cantidadMaxColores;
            this._temperas = new Tempera[this._cantidadMaxColores];
        }

        private static string Mostrar(Paleta paleta)
        {
            string retorno = "Cantidad maxima de colores: " + paleta._cantidadMaxColores;
            for(int i=0;i<paleta._cantidadMaxColores;i++){
                if (paleta._temperas.GetValue(i) != null)
                {
                    retorno += "\n" + paleta._temperas[i];
                }
                
            }
            return retorno;
        }

        public static explicit operator string(Paleta paleta)
        {
            return Paleta.Mostrar(paleta);
        }

        public static bool operator ==(Paleta p, Tempera t)
        {
            bool retorno = false;

            for (int i = 0; i < p._cantidadMaxColores; i++)
            {
                if (p._temperas.GetValue(i) != null && p._temperas[i] == t)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }

        public static int operator == (Tempera t, Paleta p)
        {
            int retorno = -1;

            for (int i = 0; i < p._cantidadMaxColores; i++)
            {
                if (p._temperas.GetValue(i) == null)
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }

        public static int operator !=(Tempera t, Paleta p)
        {
            return (t == p);
        }

        public static Paleta operator +(Paleta p, Tempera t)
        {
            int posicion = (t == p);
             
            if (p != t && posicion!=-1)
            {
                p._temperas[posicion] = t;
            }

            return p;
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        public Tempera this[int index]
        {
            get { return this._temperas[index]; }
            set { this._temperas[index] = value; }
        }
    }
}
