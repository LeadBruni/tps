using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo;
            int divisor;
            Fachada fachada = new Fachada();
            try
            {
                Console.WriteLine("Ingrese dividendo ");
                dividendo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese divisor");
                divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("el resultado de su division es" + fachada.Dividir(dividendo, divisor));
            }
            catch (DivisionPorCeroException excepcion)
            {
                Console.WriteLine("el divisor no puede ser cero");
                Console.WriteLine(excepcion.StackTrace);
                Console.ReadKey();
            }
        }
    }
}
