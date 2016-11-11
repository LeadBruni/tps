using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje6
{
    class Fachada
    {
      Cuenta Cuenta = new Cuenta(10000000, 30000);
        Cuenta CajaAhorro = new Cuenta(8000000, 100000);


        public double saldoCuentaco(Cuenta Cuenta)
        { return Cuenta.Saldo; }

        public double acuerdoCuentaco(Cuenta Cuenta)
        { return Cuenta.Acuerdo; }

        public void acreditarsaldocuentaco(double monto)
        { Cuenta.AcreditarSaldo(monto); }

        public bool debitarsaldocuentaco(double monto)
        { return Cuenta.DebitarSaldo(monto); }

        public double saldoCaja(Cuenta Cuenta)
        { return CajaAhorro.Saldo; }

        public double acuerdoCaja(Cuenta Cuenta)
        { return CajaAhorro.Acuerdo; }

        public void acreditarsaldocaja(double monto)
        { CajaAhorro.AcreditarSaldo(monto); }

        public bool debitarsaldocaja(double monto)
        { return CajaAhorro.DebitarSaldo(monto); }

        public void transferirCuentaCaja(double monto)
        { Cuenta.Transferir(Cuenta, CajaAhorro, monto); }

        public void transferirCajaaCuenta(double monto)
        { Cuenta.Transferir(CajaAhorro, Cuenta, monto); }


        public void infocuentas()
        {
            Console.WriteLine("el saldo actual de la cuenta corriente es" + Cuenta.Saldo);
            Console.WriteLine("el saldo actual de la caja de ahorro es" + CajaAhorro.Saldo);
        }
    }
}
