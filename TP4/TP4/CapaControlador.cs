using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class CapaControlador
    {
        public void Ejecutar()
        {// ejecuta la capa de aplicacion (crea una ocurrencia nueva y ejecuta su metodo ejecutar
            CapaAplicacion aplicacion = new CapaAplicacion();
            aplicacion.Ejecutar();

        }
    }
}
