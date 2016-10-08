using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        public Producto(int codigo, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }

        public float Precio
        {
            get { return this._precio; }
        }

        public EMarcaProducto Marca
        {
            get { return this._marca; }
        }

        public static bool operator ==(Producto prodUno, EMarcaProducto marca)
        {
            bool retorno = false;
            if (prodUno._marca.Equals(marca))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno == marca);
        }
        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            bool retorno = false;
            if (prodUno._marca.Equals(prodDos._marca) && prodUno._codigoBarra==prodDos._codigoBarra)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }

        public static explicit operator int(Producto prod)
        {
            return prod._codigoBarra;
        }

        protected static string MostrarProducto(Producto prod)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(prod._codigoBarra);
            sb.Append("-");
            sb.Append(prod.Marca);
            sb.Append("-");
            sb.Append(prod.Precio);
            return sb.ToString();
        }
    }
}
