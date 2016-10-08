using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Empresa
    {

//Codificar un constructor privado por defecto. Este será el único lugar donde se instanciará la nómina de empleados.
//Codificar otro constructor que reciba como parámetro la razón social, dirección y ganancias de la Empresa.
//Sobrecarga del operador + (Empresa, Empleado). Si el empleado no existe, lo agrega a la nómina.
//Método MostrarEmpresa() : string. Retornará la lista de empleados con el siguiente formato:
  //      La empresa [razón social] sita en la calle [dirección] cuenta con ganancias por [ganancias] y con [cantidad de empleados] empleados:
    //    NOMBRE: [nombre]
     //   APELLIDO: [apellido]
      //  LEGAJO: [legajo]
      //  SALARIO: $[salario]

        private ListaDeEmpleados _nominaEmpleados;
        private string _razonSocial;
        private string _direccion;
        private float _ganancias;

        private Empresa(ListaDeEmpleados nomina)
        {
            NominaEmpleados = nomina;
        }

        public Empresa(ListaDeEmpleados nomina)
        {
            NominaEmpleados = nomina;

        }
        public ListaDeEmpleado NominaEmpleados
        {
            get { return _nominaEmpleados; }
            set { _nominaEmpleados = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        public float Ganancias
        {
            get { return _ganancias; }
            set { _ganancias = value; }
        }

        public string MostrarEmpresa()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nLa empresa ");
            sb.Append(_razonSocial);
            sb.Append(" sita en la calle ");
            sb.Append(_direccion);
            sb.Append(" cuenta con ganancias por ");
            sb.Append(_ganancias); 
            sb.Append(" y \ncon ");
            sb.Append(_nominaEmpleados.Lenght);
            sb.Append(" empleados: ");
            return sb;
        }
    }
}
