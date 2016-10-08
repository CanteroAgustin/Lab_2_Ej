using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Recibo
    {
        private float valorHora, importeACobrarBruto, importeACobrarNeto, totalDescuentos;
        private string nombre;
        private int antiguedad, horasTrabajadasEnElMes;

        public float ValorHora
        {
          get { return valorHora; }
          set { valorHora = value; }
        }
        public float ImporteACobrarBruto
        {
            get { return importeACobrarBruto; }
            set { importeACobrarBruto = value; }
        }
        public float ImporteACobrarNeto
        {
            get { return importeACobrarNeto; }
            set { importeACobrarNeto = value; }
        }
        public float TotalDescuentos
        {
            get { return totalDescuentos; }
            set { totalDescuentos = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Antiguedad
        {
            get { return antiguedad; }
            set { antiguedad = value; }
        }
        public int HorasTrabajadasEnElMes
        {
            get { return horasTrabajadasEnElMes; }
            set { horasTrabajadasEnElMes = value; }
        }
    }
}
