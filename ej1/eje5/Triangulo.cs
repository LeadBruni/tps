using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje5
{
    class Triangulo
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;


        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }

        public Punto Punto1 { get { return this.iPunto1; } }
        public Punto Punto2 { get { return this.iPunto2; } }
        public Punto Punto3 { get { return this.iPunto3; } }


        public double Perimetro
        {
            get
            {
                return (iPunto1.CalcularDistanciaDesde(this.iPunto2) +
                          iPunto1.CalcularDistanciaDesde(this.iPunto3) +
                           iPunto2.CalcularDistanciaDesde(this.iPunto3));

            }
        }
        public double Semiperimetro { get { return (Perimetro / 2); } }
        //a continuacion la formula de area usando el semiperimetro

        public double Area
        {
            get { return (Math.Sqrt(Semiperimetro * (Semiperimetro - iPunto1.CalcularDistanciaDesde(this.iPunto2)) * (Semiperimetro - iPunto1.CalcularDistanciaDesde(this.iPunto3)) * (Semiperimetro - iPunto2.CalcularDistanciaDesde(this.iPunto3)))); }
        }


    }
}
