using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class CapaVista
    {
        public void Ejecutar()
        {
            try
            {
                CapaControlador controlador = new CapaControlador();
                controlador.Ejecutar();
            }
            //aca llega la excepcion lanzada por la capa aplicacion ,esta la ataja  y escribe la inner exception (la del error
            // de hybernate que nos dijo el profe
            catch (CapaAplicacionException excepcion)
            {
                Console.WriteLine("Ha ocurrido primero una excepcion del tipo {0}", excepcion.InnerException.Message);
                Console.WriteLine("La excepcion 'Error Puntual' se enmascaro con  {0}", excepcion.Message);
                Console.WriteLine("callstack {0}", excepcion);
            }
        }
    }
}
