using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej09_Piramide
{
    class Piramide
    {
        public void dibujarPiramide(int altura)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= altura*2; i+=2)
            {
                sb.Append('*', i);
                sb.AppendLine("");
            }
            Console.WriteLine(sb);
        }
    }
}
