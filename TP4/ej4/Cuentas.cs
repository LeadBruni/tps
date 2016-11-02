using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    class Cuentas
    {
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;


        public Cuentas(Cuenta CuentaCorriente, Cuenta CajaAhorro)
        {
            this.iCuentaCorriente = CuentaCorriente;
            this.iCajaAhorro = CajaAhorro;

        }

    }
}
