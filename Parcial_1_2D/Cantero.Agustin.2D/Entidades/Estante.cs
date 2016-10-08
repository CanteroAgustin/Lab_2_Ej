using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        private Estante()
        {
            _productos = new List<Producto>();
        }

        public Estante(sbyte capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProductos()
        {
            return _productos;
        }

        public string MostrarEstante()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }

        

        public static bool operator == (Estante est, Producto prod)
        {
            bool retorno = false;
            foreach (Producto p in est._productos)
            {
                if (p == prod)
                {
                    retorno = true;
                    break;
                }
            }
            
            return retorno;
        }
        public static bool operator !=(Estante est, Producto prod)
        {
            return !(est == prod);
        }

        public static bool operator +(Estante est, Producto prod)
        {
            bool retorno = false;
            foreach (Producto p in est._productos)
            {
                
            }
            return retorno;
        }
    }
}
