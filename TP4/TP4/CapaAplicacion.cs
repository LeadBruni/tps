using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class CapaAplicacion
    {
        public void Ejecutar()
        {
            try
            {//ejecuto el de dominio.ejecutar
                CapaDominio dominio = new CapaDominio();
                dominio.Ejecutar();
            }

            catch (ErrorPuntualException exception)//aca llega la exc. de la capa de persistencia 
            {//throw la nueva excepcion que deberia decir que en el caso de gran dt que se complico la operacion , intente nuevamente
                throw (new CapaAplicacionException("Alerta legible  para el usuario", exception));// con la excepcion que venia como inner exception
            }

        }







    }
}
