using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    
    public abstract class Producto
    {
        public int _codigoBarra;
        public EMarcaProducto _marca;
        public float _precio;

        public enum EMarcaProducto { Manaos, Pitusas, Naranj\u00fa, Diversi\u00f3n, Swift, Favorita }
        public enum ETipoProducto { Galletita, Gaseosa, Jugo, Todos }

        #region Constructores

        public Producto()
        {

        }

        /// <summary>
        /// Inicializa el producto con los parametros recibidos
        /// </summary>
        /// <param name="codigoBarra"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }

        #endregion

        #region Propiedades

        public abstract float CalcularCostoDeProduccion{get;}

        /// <summary>
        /// Devuelve el valor asociado a _marca
        /// </summary>
        public EMarcaProducto Marca
        {
          get { return _marca; }
        }

        /// <summary>
        /// Devuelve el valor asociado a _precio
        /// </summary>
        public float Precio
        {
            get { return _precio; }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Devuelve una cadena con todos los datos del producto
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MARCA: ");
            sb.AppendLine((p.Marca).ToString());
            sb.Append("C\u00f3DIGO DE BARRAS: ");
            sb.AppendLine((p._codigoBarra).ToString());
            sb.Append("PRECIO: ");
            sb.AppendLine((p.Precio).ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Devuelve la cadena "Parte de una mezcla."
        /// </summary>
        /// <returns></returns>
        public virtual string Consumir()
        {
            return "Parte de una mezcla.";
        }

        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Compara si dos productos son iguales
        /// </summary>
        /// <param name="prodUno"></param>
        /// <param name="prodDos"></param>
        /// <returns>true si son iguales, false si no</returns>
        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            bool retorno = false;
            if (prodUno.Equals(prodDos) && prodUno.Marca.Equals(prodDos._marca) && prodUno._codigoBarra == prodDos._codigoBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }

        /// <summary>
        /// evalua si la marca de un producto es igual a la recibida por parametro
        /// </summary>
        /// <param name="prodUno"></param>
        /// <param name="marca"></param>
        /// <returns>true si son iguales, false si no</returns>
        public static bool operator ==(Producto prodUno, EMarcaProducto marca)
        {
            bool retorno = false;
            if (prodUno.Marca.Equals(marca))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno == marca);
        }

        /// <summary>
        /// Devuelve el codigo del producto
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static explicit operator int(Producto prod)
        {
            return prod._codigoBarra;
        }

        public static implicit operator string(Producto prod)
        {
            return Producto.MostrarProducto(prod);
        }

        /// <summary>
        /// Evalua si los objetos son iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (obj.GetType() == this.GetType());
        }

        /// <summary>
        /// Invoca al metodo padre
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
        
    }

}
