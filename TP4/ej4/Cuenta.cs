using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;
        private double NroCuenta;

        public Cuenta(double pAcuerdo)
        {
            this.iAcuerdo = pAcuerdo;
        }
        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            this.iAcuerdo = pAcuerdo;
            this.iSaldo = pSaldoInicial;


        }
        public double Saldo { get { return this.iSaldo; } }
        public double Acuerdo { get { return this.iAcuerdo; } }
        public void AcreditarSaldo(double pSaldo) { this.iSaldo = iSaldo + pSaldo; }
        public bool DebitarSaldo(double pSaldo)
        {
            if ((this.iSaldo + this.iAcuerdo) >= pSaldo) { this.iSaldo -= pSaldo; return true; } else { return false; }

        }

        public void Transferir(Cuenta cuentpartida, Cuenta cuentllegada, double monto)
        { if (puedeprestar(cuentpartida, monto)) { cuentllegada.AcreditarSaldo(monto); cuentpartida.DebitarSaldo(monto); } }

        public bool puedeprestar(Cuenta cuent, double monto)/*dada una cuenta y un monto devuelve true si la cuenta puede "dar"esa guita*/
        { if (cuent.Saldo + cuent.Acuerdo >= monto) { return true; } else { return false; } }
    }
}
