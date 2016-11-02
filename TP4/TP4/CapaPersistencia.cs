using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class CapaPersistencia
    {
        public void Ejecutar()
        {

            //aca se lanza el error del hybernate que nos dijo el profe QUE NO DEBE LLEGAR AL USUARIO
            throw (new ErrorPuntualException("Error Puntual que no debe conocer el usuario", DateTime.Now));
        }
        



    }
}
