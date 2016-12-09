using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaDes
{

    public class EncriptadorCesar : Encriptador
    {

        //private int iDesplazamiento;


        //public EncriptadorCesar(int pDesplazamiento) : base("Cesar")
        //{
        //    this.iDesplazamiento = pDesplazamiento;
        //}


        //public override string Encriptar(string pCadena)
        //{
        //    string cadenaCifrada = "";
        //    string abecedario = "abcdefghijklmnñopqrstuvwxyz";
        //    if (this.iDesplazamiento > 0 && this.iDesplazamiento < abecedario.Length)
        //    {
        //        //Recorremos caracter a caracter la cadena a cifrar.
        //        for (int i = 0; i < pCadena.Length; i++)
        //        {
        //            int posCaracter = 0; //Posicion del caracter de la cadena a cifrar, dentro del abecedario.
        //            char caracter = pCadena[i];

        //            //Recorremos el abecedario.
        //            for (int j = 0; j < abecedario.Length;)
        //            {
        //                if (caracter == abecedario[i])
        //                {
        //                    posCaracter = j;
        //                    break;
        //                }
        //                else
        //                {
        //                    j++;
        //                    //break;
        //                }
        //                posCaracter = -1;
        //            }
        //            if (posCaracter != -1) //El caracter esta en el abecedario.
        //            {
        //                int posCesar = posCaracter + this.iDesplazamiento;
        //                //Si al aplicar el desplazamiento nos pasamos del abecesario empezamos desde el comienzo.
        //                while (posCesar >= abecedario.Length)
        //                {
        //                    posCesar = posCesar - abecedario.Length;
        //                }
        //                //Concatena al mensaje cifrado.
        //                cadenaCifrada += abecedario[posCesar];
        //            }
        //            else//Si el caracter no esta en el abecedario no se cifra.
        //            {
        //                cadenaCifrada += pCadena[i];
        //            }
        //        }
        //    }
        //    return cadenaCifrada;
        //}


        //public override string Desencriptar(string pCadena)
        //{
        //    string cadenaDescifrada = "";
        //    string abecedario = "abcdefghijklmnñopqrstuvwxyz";
        //    if (this.iDesplazamiento > 0 && this.iDesplazamiento < abecedario.Length)
        //    {
        //        //Recorremos caracter a caracter la cadena a descifrar.
        //        for (int i = 0; i < pCadena.Length - 1; i++)
        //        {
        //            int posCaracter = 0;
        //            char caracter = pCadena[i];
        //            //Recorremos el abecedario.
        //            for (int j = 0; j < abecedario.Length;)
        //            {
        //                if (caracter == abecedario[i])
        //                {
        //                    posCaracter = j;
        //                    break;
        //                }
        //                else
        //                {
        //                    j++;
        //                }
        //                posCaracter = -1;
        //            }
        //            if (posCaracter != -1) //El caracter esta en el abecedario.
        //            {
        //                int pos = posCaracter - this.iDesplazamiento;
        //                while (pos < 0)
        //                {
        //                    pos = pos + abecedario.Length;
        //                }
        //                cadenaDescifrada += abecedario[pos];
        //            }
        //            else
        //            {
        //                cadenaDescifrada += pCadena[i];
        //            }
        //        }

        //    }
        //    return cadenaDescifrada;
        //}
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
