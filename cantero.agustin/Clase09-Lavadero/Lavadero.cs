using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09_Lavadero
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        float _precioMoto;

        public List<Vehiculo> Vehiculos
        {
            get { return _vehiculos; }
        }

        public string lavadero
        {
            get {
                StringBuilder sb = new StringBuilder();

                sb.Append("- Precio por auto: ");
                sb.Append(_precioAuto);
                sb.Append("- Precio por camion: ");
                sb.Append(_precioCamion);
                sb.Append("- Precio por moto: ");
                sb.Append(_precioMoto);

                foreach(Vehiculo v in _vehiculos){
                    if (v is Auto)
                    {
                        sb.AppendLine(((Auto)v).MostrarAuto());
                    }
                    else if (v is Camion)
                    {
                        sb.AppendLine(((Camion)v).MostrarCamion());
                    }
                    else
                    {
                        sb.AppendLine(((Moto)v).MostrarMoto());
                    }
                }

                return sb.ToString(); 
            }
        }

        
        public Lavadero()
        {
            _vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto):this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }

        public Double MostrarTotalFacturado()
        {
            double total = 0;

            total += MostrarTotalFacturado(EVehiculos.Auto);
            total += MostrarTotalFacturado(EVehiculos.Camion);
            total += MostrarTotalFacturado(EVehiculos.Moto);

            return total;
        }

        public Double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            double total = 0;
            float totAuto = 0;
            float totCamion = 0;
            float totMoto = 0;

            foreach (Vehiculo v in _vehiculos)
            {
                if (v is Auto)
                {
                    totAuto += _precioAuto;
                }
                else if (v is Camion)
                {
                    totCamion += _precioCamion;
                }
                else
                {
                    totMoto += _precioMoto;
                }
            }

            if (vehiculo == EVehiculos.Auto)
            {
                total = totAuto;
            }
            else if (vehiculo == EVehiculos.Camion)
            {
                total = totCamion;
            }
            else
            {
                total = totMoto;
            }
            return total;
        }

        public static bool operator ==(Lavadero l, Vehiculo v)
        {
            bool retorno = false;

            foreach (Vehiculo v1 in l._vehiculos)
            {
                if (v1 == v)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Lavadero l, Vehiculo v)
        {
            return !(l==v);
        }

        public static Lavadero operator +(Lavadero l, Vehiculo v)
        {
            if (l != v)
            {
                l._vehiculos.Add(v);
            }
            return l;
        }

        public static Lavadero operator -(Lavadero l, Vehiculo v)
        {
            if (l == v)
            {
                l._vehiculos.Remove(v);
            }
            return l;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return string.Compare(v1.Patente, v2.Patente);
        }

        public int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return string.Compare(v1.Marca.ToString(), v2.Marca.ToString());
        }
    } 
}
