using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloParcialLibrary1;
using ModeloParcialLibrary2;

namespace ModeloParcialLibrary
{
    public class Comercio
    {
        private string _dueño;
        private List<Articulo> _misArticulos;
        private List<Venta> _misVentas;

        public Comercio(string dueño)
        {
            this._dueño = dueño;
            this._misArticulos = new List<Articulo>();
            this._misVentas = new List<Venta>();
        }

        public void ComprarArticulo(Articulo articuloComprado)
        {
            bool encontrado = false;
            
            for (int i = 0; i < _misArticulos.Count; i++)
            {
                if (this._misArticulos[i] == articuloComprado)
                {
                    _misArticulos[i].Stock = _misArticulos[i] + articuloComprado;
                    encontrado = true;
                    break;
                }
            }
            
            if(!encontrado)
            {
                this._misArticulos.Add(articuloComprado);
            }
        }

        public static void MostrarArticulos(Comercio ComercioAMostrar)
        {
            Console.WriteLine("Los Productos existentes son: ");
            foreach (Articulo articulo in ComercioAMostrar._misArticulos)
            {
                Console.WriteLine(articulo.NombreYCodigo);
            }
        }

        public static void MostrarGanancia(Comercio ComercioParaResumen)
        {
            float ganancia = 0;
            foreach (Venta ventas in ComercioParaResumen._misVentas)
            {
                ganancia += ventas.RetornarGanancia();
            }
            Console.WriteLine(ganancia);
        }

        public void VenderArticulo(Articulo articulosolicitado, int cantidad)
        {
            bool bandera = false;
            for (int i = 0; i < this._misArticulos.Count; i++)
            {
                if (this._misArticulos[i] == articulosolicitado && this._misArticulos[i].HayStock(cantidad))
                {
                    Venta venta = new Venta(articulosolicitado, cantidad);
                    this._misVentas.Add(venta);
                    this._misArticulos[i].Stock = this._misArticulos[i] - cantidad;
                    bandera = true;
                }
             }
            if (!bandera )
            {
                Console.WriteLine("El siguiente producto no existe en nuestro comercio !!!");
                Console.WriteLine(articulosolicitado.NombreYCodigo);
            }
        }
    }
}
