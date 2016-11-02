using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada Fachada = new Fachada();
            string op;

            {
                Console.Clear();
                Console.WriteLine("Seleccione una opcion ");
                Console.WriteLine("[1] Acreditar saldo");
                Console.WriteLine("[2] Debitar saldo");
                Console.WriteLine("[3] Realizar transferencia");
                op = Console.ReadLine();
                switch (op)
                {
                    case "1": //Usuario selecciona la opcion Acreditar
                        string opAcreditar;
                        do
                        {
                            Console.WriteLine("Seleccione el tipo de cuenta:");
                            Console.WriteLine("[1] Cuenta Corriente");
                            Console.WriteLine("[2] Caja de Ahorro");
                            opAcreditar = Console.ReadLine();
                            switch (opAcreditar)
                            {
                                case "1":
                                    int montoAcreditarCorriente;
                                    Console.Write("Ingrese el monto a acreditar: ");
                                    montoAcreditarCorriente = Convert.ToInt32(Console.ReadLine());
                                    Fachada.acreditarsaldocuentaco(montoAcreditarCorriente);
                                    Fachada.infocuentas();
                                    break;
                                case "2":
                                    int montoAcreditarAhorro;
                                    Console.Write("Ingrese el monto a acreditar: ");
                                    montoAcreditarAhorro = Convert.ToInt32(Console.ReadLine());
                                    Fachada.acreditarsaldocaja(montoAcreditarAhorro);
                                    Fachada.infocuentas();
                                    break;

                            }
                        } while (opAcreditar != "0");
                        break;
                    case "2": //Usuario selecciona la opcion Acreditar
                        string opDebitar;
                        do
                        {
                            Console.WriteLine("Seleccione el tipo de cuenta:");
                            Console.WriteLine("[1] Cuenta Corriente");
                            Console.WriteLine("[2] Caja de Ahorro");
                            opDebitar = Console.ReadLine();
                            switch (opDebitar)
                            {
                                case "1":
                                    int montoDebitarCorriente;
                                    Console.Write("Ingrese el monto a debitar: ");
                                    montoDebitarCorriente = Convert.ToInt32(Console.ReadLine());
                                    Fachada.debitarsaldocuentaco(montoDebitarCorriente);
                                    Fachada.infocuentas();

                                    break;
                                case "2":
                                    int montoDebitarCaja;
                                    Console.Write("Ingrese el monto a debitar: ");
                                    montoDebitarCaja = Convert.ToInt32(Console.ReadLine());
                                    Fachada.debitarsaldocaja(montoDebitarCaja);
                                    Fachada.infocuentas();

                                    break;
                            }
                        } while (opDebitar != "0");
                        break;

                    case "3": //Usuario selecciona la opcion Transferir
                        string opTransferir;
                        do
                        {
                            Console.WriteLine("Seleccione el tipo de cuenta:");
                            Console.WriteLine("[1] Cuenta Corriente a Caja de Ahorro");
                            Console.WriteLine("[2] Caja de Ahorro a Cuenta Corriente");
                            opTransferir = Console.ReadLine();
                            switch (opTransferir)
                            {
                                case "1":
                                    int montoTransferir;
                                    Console.Write("Ingrese el monto a transferir: ");
                                    montoTransferir = Convert.ToInt32(Console.ReadLine());
                                    Fachada.transferirCuentaCaja(montoTransferir);
                                    Fachada.infocuentas();

                                    break;
                                case "2":
                                    int montoTransferira;
                                    Console.Write("Ingrese el monto a transferir: ");
                                    montoTransferira = Convert.ToInt32(Console.ReadLine());
                                    Fachada.transferirCajaaCuenta(montoTransferira);
                                    Fachada.infocuentas();


                                    break;
                            }
                        } while (opTransferir != "0");
                        break;



                }

            }
            while (op != "0")

            {

            }
        }
    }
}
