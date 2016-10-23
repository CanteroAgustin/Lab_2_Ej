using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    
    [XmlInclude(typeof(Harina))]

    public class Harina : Producto
    {
        public ETipoHarina _tipo;
        public static bool DeConsumo;

        public static bool DeConsumo1
        {
            get { return Harina.DeConsumo; }
        }

        public enum ETipoHarina { CuatroCeros, Integral }

        #region Constructores

        public Harina()
        {

        }
        /// <summary>
        /// Inicializa DeConsumo en false
        /// </summary>
        //static Harina()
        //{
          //  DeConsumo = false;
        //}

        /// <summary>
        /// Inicializa el atributo propio e invoca al constructor padre
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="tipo"></param>
        public Harina(int codigo, float precio, EMarcaProducto marca, ETipoHarina tipo)
            : base(codigo, marca, precio)
        {
            this._tipo = tipo;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Calcula el costo de produccion de la harina
        /// </summary>
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (_precio * 0.6F);
            }
        }

        public ETipoHarina Tipo
        {
            get { return _tipo; }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Devuelve una cadena con la informacion de la harina
        /// </summary>
        /// <returns></returns>
        private string MostrarHarina()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MARCA: ");
            sb.AppendLine((base.Marca).ToString());
            sb.Append("C\u00f3DIGO DE BARRAS: ");
            sb.AppendLine((base._codigoBarra).ToString());
            sb.Append("PRECIO: ");
            sb.AppendLine((base.Precio).ToString());
            sb.Append("TIPO: ");
            sb.AppendLine((this._tipo).ToString());
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// Invoca al metodo MostrarHarina
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarHarina();
        }

        #endregion
    }
}
