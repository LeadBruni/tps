using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class ErrorPuntualException:ApplicationException
    {
          public ErrorPuntualException(string mensajeError, DateTime momentoError) : base(mensajeError + momentoError) { }


    }
}
