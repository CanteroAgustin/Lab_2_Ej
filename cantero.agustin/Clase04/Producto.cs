using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Producto
    {
        private string _nombre;
        private int _codigo;
        private float _precio;

        public Producto()
        {
            this._nombre = "Sin nombre";
            this._codigo = 01;
            this._precio = 0;
        }
        public Producto(string nombre):this()
        {
            this._nombre = nombre;
            //this._codigo = 01;
            //this._precio = 0;
        }
        public Producto(string nombre, int codigo):this(nombre)
        {
            //this._nombre = nombre;
            this._codigo = codigo;
            //this._precio = 0;
        }

        public Producto(string nombre, int codigo, float precio):this(nombre, codigo)
        {
            //this._nombre = nombre;
            //this._codigo = codigo;
            this._precio = precio;
        }

        public Producto(int codigo, string nombre, float precio):this(nombre,codigo,precio)
        {
          
        }

        public Producto(string nombre, float precio, int codigo):this(nombre,codigo,precio)
        {
            
        }
        public Producto(float precio, int codigo, string nombre):this(nombre,codigo,precio)
        {

        }

        /// <summary>
        /// imprime por pantalla los atributos de la clase
        /// </summary>
        public void Mostrar()
        {
            Console.WriteLine(this._nombre);
            Console.WriteLine(this._codigo);
            Console.WriteLine(this._precio);
        }

        /// <summary>
        /// imprime por pantalla los atributos de la clase con color de letra recibido por parametro
        /// </summary>
        /// <param name="color">Color recibido para cambiar el color de letra</param>
        public void Mostrar(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            this.Mostrar();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// imprime por pantalla los atributos de la clase con color de letra y color de fondo recibidos por parametro
        /// </summary>
        /// <param name="letra">Color recibido para cambiar el color de letra</param>
        /// <param name="fondo">Color recibido para cambiar el color de fondo</param>
        public void Mostrar(ConsoleColor letra, ConsoleColor fondo)
        {
            Console.BackgroundColor = fondo;
            this.Mostrar(letra);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        
    }
}
