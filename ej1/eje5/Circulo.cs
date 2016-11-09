using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje5
{
    class Circulo
    {
        private double iRadio;
        private Punto iCentro;

        public Circulo(Punto Centro, double Radio)
        {
            this.iRadio = Radio;
            this.iCentro = Centro;

        }

        public Circulo(double pX, double pY, double Radio)
        {
            this.iCentro = new Punto(pX, pY);
            this.iRadio = Radio;
        }

        public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }

        public double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }

        public double Area
        {
            get { return ((Math.Pow(iRadio, 2)) * Math.PI); }
        }

        public double Perimetro { get { return (2 * Math.PI * iRadio); } }


        public Circulo(double radio) : this(null, radio) {}
    }
}
