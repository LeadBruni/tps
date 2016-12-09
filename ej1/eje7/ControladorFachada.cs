using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje7
{
    public class ControladorFachada
    {
        public string EncriptarCadena(string pCadena, string pEncriptador)
        {
            return FabricaEncriptadores.Instancia.GetEncriptador(pEncriptador).Encriptar(pCadena);
        }

        
        public string DesencriptarCadena(string pCadena, string pEncriptador)
        {
            return FabricaEncriptadores.Instancia.GetEncriptador(pEncriptador).Desencriptar(pCadena);
        }

      
    }
}

