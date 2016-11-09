using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje5
{
    class Punto
    {
        private double iX;
        private double iY; 
        public double X
        {
            get
            {
                return this.iX;
            }
        }
        public double Y
        {
            get
            {
                return this.iY;
            }
        }

        public Punto(double pX,double pY)
        {
            this.iX = pX;
            this.iY = pY;

        }
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return (Math.Sqrt((Math.Pow((pPunto.X - this.iX), 2) + Math.Pow((pPunto.Y - this.iY), 2))));
        }








    }
}
