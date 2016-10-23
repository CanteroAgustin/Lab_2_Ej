using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Galletita))]
    public class Galletita : Producto
    {
        public float _peso;
        public static bool DeConsumo;

        #region Constructores

        public Galletita()
        {

        }

        /// <summary>
        /// Iniializa DeConsumo en true
        /// </summary>
        static Galletita()
        {
            DeConsumo = true;
        }

        /// <summary>
        /// Inicializa el atributo propio e invoca al constructor padre
        /// </summary>
        /// <param name="codigoBarra"></param>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="peso"></param>
        public Galletita(int codigoBarra,float precio,EMarcaProducto marca, float peso)
            : base(codigoBarra, marca, precio)
        {
            this._peso = peso;    
        }

        #endregion;

        #region Propiedades

        /// <summary>
        /// Devuelve el valor del costo de produccion de galletita
        /// </summary>
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (_precio * 0.33F);
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Devuelve una cadena con los datos de galletita
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        private string MostrarGalletita(Galletita g)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MARCA: ");
            sb.AppendLine((g.Marca).ToString());
            sb.Append("C\u00f3DIGO DE BARRAS: ");
            sb.AppendLine((g._codigoBarra).ToString());
            sb.Append("PRECIO: ");
            sb.AppendLine((g.Precio).ToString());
            sb.Append("PESO: ");
            sb.AppendLine(this._peso.ToString());
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// Invoca al metodo MstrarGalletita
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarGalletita(this);
        }

        /// <summary>
        /// Devuelve la cadena "Comestible"
        /// </summary>
        /// <returns></returns>
        public override string Consumir()
        {
            return "Comestible";
        }

        #endregion

        
    }
}
