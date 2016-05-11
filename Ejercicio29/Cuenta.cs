using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Cuenta
    {
        private string _nombre;
        private Int64 _nroCuenta;
        private double _saldo;
        private Single _tipoInteres;

        /*Constructores*/
        public Cuenta(string Nombre, Int64 NroCuenta, double Saldo, Single TipoInteres)
        {
            this._nombre = Nombre;
            this._nroCuenta = NroCuenta;
            this._saldo = Saldo;
            this._tipoInteres = TipoInteres;
        }

        /*Propiedades*/
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public Int64 NroCuenta
        {
            get { return this._nroCuenta; }
            set { this._nroCuenta = value; }
        }

        public double Saldo
        {
            get { return this._saldo; }
        }

        public Single TipoInteres
        {
            get { return this._tipoInteres; }
            set { this._tipoInteres = value; }
        }

        /*Metodos*/
        public void Depositar(Int64 cantidad)
        {
            this._saldo += cantidad;
        }

        public static void Mostrar(Cuenta UnaCuenta)
        {
            Console.WriteLine("\nNombre: " + UnaCuenta.Nombre + "\nNro Cuenta: " + UnaCuenta.NroCuenta + "\nSaldo: " + UnaCuenta.Saldo + "\nTipoInteres: " + UnaCuenta.TipoInteres);
        }
    }
}
