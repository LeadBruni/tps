using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaDes
{
   public class FabricaEncriptadores
    {
        private static FabricaEncriptadores cInstancia;
        private IDictionary<string, IEncriptador> iEncriptadores;

       
        // Constructor de la fabrica. 
        // Crea el diccionario de encriptadores en donde la clave sera el nombre.
        // Agrega los 3 encriptadores al cesar se le paza desplazamiento 3.     
        private FabricaEncriptadores()
        {
            this.iEncriptadores = new Dictionary<string, IEncriptador>();

            this.iEncriptadores.Add("Cesar", new EncriptadorCesar(9));
            this.iEncriptadores.Add("AES", new EncriptadorAES());
            this.iEncriptadores.Add("Null", new EncriptadorNulo());
            this.iEncriptadores.Add("Nuestro", new EncriptadorNuestro());
        }

        
        // Devuelve un encriptador.    
        // pNombre Nombre del encriptador a devolver
        //devuelve Encriptador con el nombre ingresado
        public IEncriptador GetEncriptador(string pNombre)
        {
            if (this.iEncriptadores.ContainsKey(pNombre)) //busca si contiene la clave en el dictionary iEncriptadores
            {
                return this.iEncriptadores[pNombre];
            }
            else
            {
                return this.iEncriptadores["Null"];
            }
        }
        
        // Propiedad de la fabrica de encriptadores que devuelve la instancia de la misma. 
        // Si esta no fue asignada, se le asigna.
        // singleton
   
        public static FabricaEncriptadores Instancia
        {
            get
            {
                if (cInstancia == null)
                {
                    cInstancia = new FabricaEncriptadores();
                }
                return cInstancia;
            }
        }
    }
}

