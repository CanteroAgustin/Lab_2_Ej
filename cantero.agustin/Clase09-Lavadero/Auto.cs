using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09_Lavadero
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;

        public Auto(int cantidadAsientos, string patente, Byte cantRuedas, EMarcas marca)
            : base(patente, cantRuedas, marca)
        {
            this._cantidadAsientos = cantidadAsientos;
        }

        public string MostrarAuto()
        {
            return base.Mostrar();
        }
    }
}
