using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Harina))]
    [XmlInclude(typeof(Galletita))]
    [XmlInclude(typeof(Jugo))]
    [XmlInclude(typeof(Gaseosa))]
    public class Estante
    {
        public sbyte _capacidad;
        public List<Producto> _productos;

    #region Constructores
        
        /// <summary>
        /// Inicializa la lista de productos
        /// </summary>
        private Estante()
        {
            _productos = new List<Producto>();
        }

        /// <summary>
        /// Inicializa El estante con la capacidad recibida por parametro
        /// </summary>
        /// <param name="capacidad"></param>
        public Estante(sbyte capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }

        #endregion

    #region Propiedades
        
        /// <summary>
        /// Devuelve el valor total del estante
        /// </summary>
        public float ValorEstanteTotal
        {
            get
            {
                return GetValorEstante();
            }
        }
        
        #endregion

    #region Metodos

        /// <summary>
        /// Devuelve la lista de productos
        /// </summary>
        /// <returns></returns>
        public List<Producto> GetProductos()
        {
            return _productos;
        }

        public static void SerializarEstante(string filePath, Estante e){
            XmlSerializer ser = new XmlSerializer(typeof(Estante));
            Stream stream = new FileStream(filePath, FileMode.Create);
            ser.Serialize(stream, e);
            stream.Close(); 
        }

        /// <summary>
        /// Muestra la informacion del estante recibido por parametro
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CAPACIDAD: ");
            sb.AppendLine(e._capacidad.ToString());
            foreach (Producto p in e._productos)
            {
                if (p is Harina)
                {
                    sb.Append(p.ToString());
                }
                else if (p is Jugo)
                {
                    sb.Append(p.ToString());
                }
                else if(p is Gaseosa)
                {
                    sb.Append(p.ToString());
                }
                else if (p is Galletita)
                {
                    sb.Append(p.ToString());
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Devuelve el valor total del tipo de producto recibido por parametro
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public float GetValorEstante(Producto.ETipoProducto tipo)
        {
            float total = 0;
            for (int i = 0; i < this._productos.Count; i++)
            {
                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (this._productos[i] is Galletita)
                        {
                            total += this._productos[i].Precio;
                        }
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (this._productos[i] is Galletita)
                        {
                            total += this._productos[i].Precio;
                        }
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (this._productos[i] is Galletita)
                        {
                            total += this._productos[i].Precio;
                        }
                        break;
                    case Producto.ETipoProducto.Todos:
                        total += this._productos[i].Precio;
                        break;
                }
            }
                
            return total;
        }

        /// <summary>
        /// Devuelve el valor total de todos los productos
        /// </summary>
        /// <returns></returns>
        private float GetValorEstante() 
        {
            return GetValorEstante(Producto.ETipoProducto.Todos);
        }

        #endregion

    #region Sobrecargas

        /// <summary>
        /// Verifica si el producto esta en el estante
        /// </summary>
        /// <param name="est"></param>
        /// <param name="prod"></param>
        /// <returns>true si el producto esta en el estante, de lo contrario false</returns>
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

        /// <summary>
        /// Verifica si el producto esta en el estante, si no es asi lo agrega
        /// </summary>
        /// <param name="est"></param>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static bool operator +(Estante est, Producto prod)
        {
            bool retorno = false;
            if (est != prod )
            {
                //est._capacidad = (sbyte)(est._capacidad - 1);
                est._productos.Add(prod);
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Verifica si el producto esta en el estante, si es asi lo remueve
        /// </summary>
        /// <param name="est"></param>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static Estante operator -(Estante est, Producto prod)
        {
            if (est == prod)
            {
               // est._capacidad = (sbyte)(est._capacidad + 1);
                est._productos.Remove(prod);
            }
            else
            {
                Console.WriteLine("No se pudo remover el producto del estante.");
            }
            return est;
        }

        /// <summary>
        /// devuelve un nuevo estante sin los productos que coinciden con el tipo recibido por parametro
        /// </summary>
        /// <param name="e"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static Estante operator -(Estante e, Producto.ETipoProducto tipo)
        {
            Estante e1 = e;

            for(int i = 0; i < e._productos.Count; i++)
            {
                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (e1._productos[i] is Galletita)
                        {
                            e1 -= e1._productos[i];
                            i--;
                        }
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (e1._productos[i] is Gaseosa)
                        {
                            e1 -= e1._productos[i];
                            i--;
                        }
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (e1._productos[i] is Jugo)
                        {
                            e1 -= e1._productos[i];
                            i--;
                        }
                        break;
                    case Producto.ETipoProducto.Todos:
                        if(e._productos.Count>0)
                        {
                            e1 -= e1._productos[i];
                            i--;
                        }
                        break;
                }
            }
                
            
            return e1;
        }

        /// <summary>
        /// Sobreescribe el metodo padre, evalua si los objetos son del mismo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj) { return ReferenceEquals(this, obj); }

        /// <summary>
        /// Invoca al metodo de la clase padre
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    #endregion
    }

}
