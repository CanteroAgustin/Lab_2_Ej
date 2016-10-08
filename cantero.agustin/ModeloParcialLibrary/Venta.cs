using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloParcialLibrary;
using ModeloParcialLibrary2;

namespace ModeloParcialLibrary1
{
    public class Venta
    {
        private Articulo _articuloVendido;
        private int _cantidad;

        public float RetornarGanancia()
        {
            float resultado = 0;
            resultado = this._articuloVendido.PrecioVenta * this._cantidad;
            return resultado;
        }

        public Venta(Articulo articuloVendido, int cantidad)
        {
            this._articuloVendido = articuloVendido;
            this._cantidad = cantidad;
        }
    }
}
