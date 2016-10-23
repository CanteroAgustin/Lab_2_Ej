using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Jugo))]
    public class Jugo : Producto
    {
        public ESaborJugo _sabor;
        public static bool DeConsumo;

        public enum ESaborJugo { Asqueroso, Pasable, Rico }

        #region Constructores
        public Jugo()
        {

        }
        /// <summary>
        /// Inicializa DeConsumo en true
        /// </summary>
        static Jugo()
        {
            DeConsumo = true;
        }

        /// <summary>
        /// Inicializa el atributo propio e invoca al constructor padre
        /// </summary>
        /// <param name="codigoBarra"></param>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="sabor"></param>
        public Jugo(int codigoBarra,float precio,EMarcaProducto marca, ESaborJugo sabor)
            : base(codigoBarra, marca, precio)
        {
            this._sabor = sabor;    
        }

        #endregion;

        #region Propiedades

        /// <summary>
        /// Devuelve el costo de produccion del jugo
        /// </summary>
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (_precio * 0.4F);
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Devuelve una cadena con toda la informacion del jugo
        /// </summary>
        /// <returns></returns>
        private string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MARCA: ");
            sb.AppendLine((base.Marca).ToString());
            sb.Append("C\u00f3DIGO DE BARRAS: ");
            sb.AppendLine((base._codigoBarra).ToString());
            sb.Append("PRECIO: ");
            sb.AppendLine((base.Precio).ToString());
            sb.Append("SABOR: ");
            sb.AppendLine(this._sabor.ToString());
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// Invoca al metodo MostrarJugo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarJugo();
        }

        /// <summary>
        /// Devuelve la cadena "Bebible"
        /// </summary>
        /// <returns></returns>
        public override string Consumir()
        {
            return "Bebible";
        }

        #endregion

        
    }
}
