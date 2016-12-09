using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje7
{

    public class EncriptadorCesar : Encriptador
    {

        private int iDesplazamiento;
        private const int alfabeto = 223;
        private const int inicioCaracter = 32;
        public EncriptadorCesar(int pDesplazamiento) : base("CESAR")
        {
            this.iDesplazamiento = pDesplazamiento;
        }



        public override string Encriptar(string pCadena)
        {
            char[] aux = pCadena.ToCharArray();
            for (int i = 0; i < aux.Length; i++)
                aux[i] = (char)(inicioCaracter + (((int)aux[i] + this.iDesplazamiento - inicioCaracter) % alfabeto));
            return (new string(aux)); ;
        }

        public override string Desencriptar(string pCadena)
        {
            char[] aux = pCadena.ToCharArray();
            for (int i = 0; i < aux.Length; i++)
                aux[i] = (char)(inicioCaracter + (((int)aux[i] - this.iDesplazamiento - inicioCaracter) % alfabeto));
            return (new string(aux)); ;
        }
    
}
}
