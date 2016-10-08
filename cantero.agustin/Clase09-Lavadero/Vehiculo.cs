using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09_Lavadero
{
    public class Vehiculo
    {
        private string _patente;
        private Byte _cantRuedas;
        private EMarcas _marca;

        public string Patente
        {
            get { return _patente; }
        }

        public EMarcas Marca
        {
            get { return _marca; }
        }

        public Vehiculo(string patente, Byte cantRuedas, EMarcas marca)
        {
            this._patente = patente;
            this._cantRuedas = cantRuedas;
            this._marca = marca;
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" -Patente: ");
            sb.Append(_patente);
            sb.Append(" -Marca: ");
            sb.Append(_marca);
            sb.Append(" -CantRuedas: ");
            sb.Append(_cantRuedas);

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if(v1._patente.Equals(v2._patente) && v1._marca == v2._marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1==v2);
        }
    }
}
