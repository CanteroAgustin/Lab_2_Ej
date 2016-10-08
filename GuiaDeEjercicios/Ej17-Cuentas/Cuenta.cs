using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej17_Cuentas
{
    enum ETipoInteres { TIN, TAE, TIR }

    class Cuenta
    {
        private string _nombre;
        private long _nroCuenta;
        private double _saldo;
        private ETipoInteres _tipoInteres;

        public string getNombre()
        {
            return this._nombre;
        }

        public void setNombre(string nombre)
        {
            this._nombre = nombre;
        }

        public long getNroCuenta()
        {
            return this._nroCuenta;
        }

        public void setNroCuenta(long nroCuenta)
        {
            if (nroCuenta > 0)
            {
                this._nroCuenta = nroCuenta;
            }
            else
            {
                this._nroCuenta = -1;
            }
        }

        public double getSaldo()
        {
            return this._saldo;
        }

        public void setSaldo(double saldo)
        {
            if (saldo > 0)
            {
                this._saldo = saldo;
            }
            else
            {
                this._saldo = -1;
            }
        }

        public ETipoInteres getTipoInteres()
        {
            return this._tipoInteres;
        }

        public void setTipoInteres(ETipoInteres tipoInteres)
        {
            this._tipoInteres = tipoInteres;
        }
    }

    
}
