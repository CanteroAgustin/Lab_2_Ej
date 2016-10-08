using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08
{
    class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;

        public string marca
        {
            get {
                if (!object.Equals(this, null))
                {
                    return _marca;
                }
                return "";
                 }
            set { _marca = value; }
        }
        

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }

        private string Mostrar()
        {
            string retorno = "Marca: " + _marca + "\nColor: " + _color + "\nCantidad:"+ _cantidad;

            return retorno;
        }

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            bool retorno = false;

            if (t1._color == t2._color && t1._marca == t2._marca)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            Tempera t3 = new Tempera(t1._color, t1._marca, t1._cantidad);
            if (t1 == t2)
            {
                t3._cantidad = t1._cantidad + t2._cantidad;
                return t3;
            }

            return t1; 
        }

        public static Tempera operator +(Tempera t1, double n)
        {
            Tempera t3 = new Tempera(t1._color, t1._marca, t1._cantidad);
            t3._cantidad = t1._cantidad + (int)n;
            return t3;
        }
        public static implicit operator string(Tempera t)
        {
            return t.Mostrar();
        }




    }
}
