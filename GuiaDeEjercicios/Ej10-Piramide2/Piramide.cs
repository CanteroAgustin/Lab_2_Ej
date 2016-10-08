using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10_Piramide2
{
    class Piramide
    {
        public void dibujarPiramide(int altura)
        {
            StringBuilder sb = new StringBuilder();
            int aux=0, j = altura;
            
            for (int i = 0; i <= altura; i++)
            {
                if (i > 0)
                {
                    aux = i - 1;
                }
                sb.Append(' ', j);
                sb.Append('*', i+aux);
                sb.AppendLine("");
                j--;
            }
            Console.WriteLine(sb);
        }
    }
}
