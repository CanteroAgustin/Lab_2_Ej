using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloParcialLibrary;
using ModeloParcialLibrary1;

namespace ModeloParcialLibrary2
{
    public class Articulo
    {
        private int _codigo;
        private string _nombre;
        private float _precioCosto;
        private float precioVenta;
        private int _stock;

        public string NombreYCodigo
        {
            get { return _codigo+"--"+_nombre; }
        }

        public float PrecioCosto
        {
            set { 
                _precioCosto = value;
                this.precioVenta = value * 1.3f;
            }
        }

        public float PrecioVenta
        {
            get { return precioVenta; }
        }

        public int Stock
        {
            set { _stock = value; }
        }

        public Articulo(int codigo, string nombre, float precioCosto, int cantidad)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._precioCosto = precioCosto;
            this._stock = cantidad;
            this.precioVenta = this._precioCosto*1.3f;
        }

        public bool HayStock(int cantidad)
        {
            bool retorno = false;
            if (this._stock >= cantidad)
            {
                retorno = true;
            }
            else
            {
                Console.WriteLine("El siguiente articulo no tiene stock para la venta!!!");
                Console.WriteLine(this.NombreYCodigo);
            }
            return retorno;
        }

        public static bool operator ==(Articulo articuloUno, Articulo articuloDos){
            bool retorno = false;
            if(articuloUno._nombre.Equals(articuloDos._nombre) && articuloUno._codigo == articuloDos._codigo)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Articulo articuloUno, Articulo articuloDos)
        {
            return !(articuloUno == articuloDos);
        }

        public static int operator +(Articulo articuloUno, Articulo articuloDos)
        {
            int resultado = 0;
            if (articuloUno == articuloDos)
            {
                resultado = articuloUno._stock + articuloDos._stock;
            }
            return resultado;
        }

        public static int operator -(Articulo articuloUno, int cantidad)
        {
            int resultado = articuloUno._stock;
            if (articuloUno._stock == cantidad)
            {
                resultado = articuloUno._stock - cantidad;
            }
            return resultado;
        }
    }
}
