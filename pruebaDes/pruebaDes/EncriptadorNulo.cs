﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaDes
{// este encriptador como dice el enunciado del problema devuelve la misma cadena
   public class EncriptadorNulo:Encriptador
    { public EncriptadorNulo() : base("Null") { }
        public override string Encriptar(string pCadena)
        {
            return pCadena;
        }

        public override string Desencriptar(string pCadena)
        {
            return pCadena;
        }
    }
}
















