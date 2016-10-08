using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16_Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Agustin", "Cantero", 0001);
            //Alumno alumno2 = new Alumno("Sheldon", "Cooper", 0002);
            //Alumno alumno3 = new Alumno("Flash", "Gordon", 0003);

            alumno1.Estudiar(7,8);
            alumno1.CalcularFinal();
            alumno1.Mostrar();

            Console.ReadKey();
        }
    }
}
