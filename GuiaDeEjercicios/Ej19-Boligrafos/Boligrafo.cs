using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej19_BoligrafosB
{
    class Boligrafo
    {
        private ConsoleColor _color;
        private int _tinta;

        public Boligrafo(ConsoleColor color, int tinta)
        {
            this._color = color;
            this._tinta = tinta;
        }

        public ConsoleColor getColor()
        {
            return this._color;
        }
        public int getTinta()
        {
            return this._tinta;
        }

        public bool Pintar(int gasto)
        {
            bool retorno = true;

            if (_tinta - gasto < 0)
            {
                retorno = false;
            }
            else
            {
                _tinta -= gasto;
            }

            return retorno;
        }

        public void recargar()
        {
            int tintaRestante;
            if (this._color.Equals(ConsoleColor.Red))
            {
                tintaRestante = 50 - _tinta;
                _tinta += tintaRestante;
            }
            else
            {
                tintaRestante = 100 - _tinta;
                _tinta += tintaRestante;
            }
        }

    }
}
