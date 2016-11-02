using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2
{
    public class DivisionPorCeroException : ApplicationException
    {
        public DivisionPorCeroException() : base("") { }
        public DivisionPorCeroException(string message) : base(message) { }


    }
}
