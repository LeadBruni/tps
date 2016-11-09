using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje5
{
    class Fachada
    {
        Punto punto1 = new Punto(0, 0);
        Punto punto2 = new Punto(0, 0);
        Punto punto3 = new Punto(0, 0);
        double radio = 0;

        Circulo fCirculo;
        Triangulo fTriangulo;

        public double areaCirculo(double radio)
        {
            fCirculo = new Circulo(radio);
            return fCirculo.Area;
        }
        public double perimetroCirculo(double radio) {
            fCirculo = new Circulo(radio);
            return fCirculo.Perimetro;
        }


        public double areaTriangulo(double p1x,double p1y,double p2x,double p2y,double p3x,double p3y)
        { punto1 = new Punto( p1x,p1y);
            punto2 = new Punto(p2x, p2y);
            punto3 = new Punto(p3x, p3y);
            fTriangulo = new Triangulo(punto1,punto2,punto3);
            return fTriangulo.Area;
        }

        public double perimetroTriangulo(double p1x, double p1y, double p2x, double p2y, double p3x, double p3y)
        {
            punto1 = new Punto(p1x, p1y);
            punto2 = new Punto(p2x, p2y);
            punto3 = new Punto(p3x, p3y);
            fTriangulo = new Triangulo(punto1, punto2, punto3);

            return fTriangulo.Perimetro;
        }






    } }








    