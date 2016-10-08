using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09_Lavadero
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        public Moto(float cilindrada, string patente, Byte cantRuedas, EMarcas marca)
            :base(patente, cantRuedas, marca)
        {
            this._cilindrada = cilindrada;
        }

        public string MostrarMoto(){
            return base.Mostrar();
        }
    }
}
