using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2
{
    class Matematica
    {

        public Double Dividir(int pDividendo, int pDivisor)
        {
            if (pDivisor != 0)
            { return Convert.ToDouble(pDividendo) / Convert.ToDouble(pDivisor); }
            else
            { throw new DivisionPorCeroException("no se puede dividir por cero"); }
        }
    }
}
