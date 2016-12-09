using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaDes
{
    public class EncriptadorNuestro : Encriptador
    {
        public EncriptadorNuestro() : base("Nuestro") { }


        public override string Encriptar(string pCadena)
        {

            byte[] byt = System.Text.Encoding.UTF8.GetBytes(pCadena);
            return Convert.ToBase64String(byt); }
        
        
       
            
        
    

        public override string Desencriptar(string pCadena)
        {
            byte[] b = Convert.FromBase64String(pCadena);
            return System.Text.Encoding.UTF8.GetString(b);
            
        }
    }
}
