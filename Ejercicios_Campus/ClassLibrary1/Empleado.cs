using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiLibreria
{
    
    public class Empleado
    {
        private string _nombre;
        private string _apellido;
        private string _legajo;
        private EPuestoJerarquico _puesto;
        private int _salario;
        
        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._legajo = legajo;
            this._puesto = puesto;
            this._salario = salario;
        }

        public static bool operator == (Empleado e1, Empleado e2)
        {
            bool retorno = false;
            if (e1._legajo.Equals(e2._legajo))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator != (Empleado e1, Empleado e2){
            return !(e1 == e2);
        }

        public string mostrar(Empleado e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nNombre: ");
            sb.Append(e._nombre);
            sb.Append("\nApellido: ");
            sb.Append(e._apellido);
            sb.Append("\nLegajo: ");
            sb.Append(e._legajo);
            sb.Append("\nPuesto: ");
            sb.Append(e._puesto);
            sb.Append("\nSalario: ");
            sb.Append(e._salario);
            return sb.ToString();
        }
    }
}
