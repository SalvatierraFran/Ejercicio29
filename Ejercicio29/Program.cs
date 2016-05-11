using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta CuentaUno = new Cuenta("Franco", 1111111111, 25000, 25.5f);

            Cuenta.Mostrar(CuentaUno);

            Console.ReadKey();
        }
    }
}
