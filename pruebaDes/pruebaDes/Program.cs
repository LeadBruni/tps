using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaDes
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            ControladorFachada Fachada = new ControladorFachada();
            Console.WriteLine("el siguiente programa demostrara la encriptacion de una cadena que ud ingrese utilizando tres metodos de encriptacion");
            Console.WriteLine("los algoritmos de encriptacion que se utilizan  son ,CESAR , AES y NULO (el cual no devuelve una cadena encriptada");
            Console.WriteLine("Ingrese Cadena a Encriptar");

            cadena = Console.ReadLine();
            //Nuestro es el encriptador que decidimos utilizar

            Console.WriteLine("La cadena encriptada con CESAR es: " + Fachada.EncriptarCadena(cadena, "Cesar"));
            Console.WriteLine("La cadena encriptada con AES es: " + Fachada.EncriptarCadena(cadena, "AES"));
            Console.WriteLine("La cadena encriptada con Nulo es: " + Fachada.EncriptarCadena(cadena, "Null"));
            Console.WriteLine("La cadena encriptada con Nuestro es: " + Fachada.EncriptarCadena(cadena, "Nuestro"));
            Console.ReadKey();


        }
    }

}
