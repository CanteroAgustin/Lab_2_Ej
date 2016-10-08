using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09_Lavadero  
{
    public class Camion : Vehiculo
    {
        
        protected float _tara;

        public Camion(float tara, string patente, Byte cantRuedas, EMarcas marca)
            : base(patente, cantRuedas, marca)
        {
            this._tara = tara;
        }

        public string MostrarCamion()
        {
            return base.Mostrar();
        }
    }
}
