using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16_Alumnos
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void CalcularFinal()
        {
            Random rnd = new Random();

            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                int resultado;
                resultado = (_nota1 + _nota2) / 2;
                _notaFinal = rnd.Next(resultado, resultado);
            }
            else
            {
                _notaFinal = rnd.Next(-1,-1);
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
            
        }

        public void Mostrar()
        {
            Console.WriteLine("\nNombre del alumno: " + nombre + apellido);
            Console.WriteLine("\nLegajo:" + legajo);
            Console.WriteLine("\nPrimer parcial: " + _nota1);
            Console.WriteLine("\nSegundo parcial: " + _nota2);
            if ((int)_notaFinal > -1)
            {
                Console.WriteLine("\nNota final: " + _notaFinal);
            }
        }
    }
}
