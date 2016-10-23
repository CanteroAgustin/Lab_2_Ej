using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Gaseosa))]
    public class Gaseosa : Producto 
    {
        public float _litros;
        public static bool DeConsumo;

        #region Constructores
        public Gaseosa()
        {
            
        }
        /// <summary>
        /// Inicializa DeConsumo en true
        /// </summary>
        static Gaseosa()
        {
            DeConsumo = true;
        }

        /// <summary>
        /// Inicializa el atributo propio e invoca al constructor padre
        /// </summary>
        /// <param name="codigoBarra"></param>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="litros"></param>
        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros)
            : base(codigoBarra, marca, precio)
        {
            this._litros = litros;
        }

        /// <summary>
        /// Invoca al constructor de Gaseosa pasandole los datos del objeto recibido
        /// </summary>
        /// <param name="p"></param>
        /// <param name="litros"></param>
        public Gaseosa(Producto p, float litros)
            : this((int)p, p.Precio, p.Marca, litros)
        {

        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Calcula el costo de produccion de la gaseosa
        /// </summary>
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (_precio * 0.42F);
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Devuelve una cadena con los datos de la gaseosa
        /// </summary>
        /// <returns></returns>
        private string MostrarGaseosa()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MARCA: ");
            sb.AppendLine((base.Marca).ToString());
            sb.Append("C\u00f3DIGO DE BARRAS: ");
            sb.AppendLine((base._codigoBarra).ToString());
            sb.Append("PRECIO: ");
            sb.AppendLine((base.Precio).ToString());
            sb.Append("LITROS: ");
            sb.AppendLine((this._litros).ToString());
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// Invoca al metodo MostrarGaseosa
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarGaseosa();
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
