using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class CapaAplicacionException : ApplicationException
    {

        public CapaAplicacionException() : base("") { }
        public CapaAplicacionException(string message) : base(message) { }
        public CapaAplicacionException(string message, Exception innerException) : base(message, innerException) { }





    }
}
