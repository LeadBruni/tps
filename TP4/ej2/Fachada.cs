using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2
{
    class Fachada
    {//metodo dividir de la clase fachada que utiliza la clase matematica para dividir y comunicarse con la clase program

        Matematica matematica = new Matematica();

        public double Dividir(int pDividendo, int PDivisor) { return matematica.Dividir(pDividendo,PDivisor); }














    }
}
