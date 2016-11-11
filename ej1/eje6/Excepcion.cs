using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje6
{
    class Excepcion:ApplicationException
    {
        public Excepcion() : base("") { }
        public Excepcion(string message) : base(message) { }
        public Excepcion(string message, Exception innerException) : base(message, innerException) { }
    }
}
