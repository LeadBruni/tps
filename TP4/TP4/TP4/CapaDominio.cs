﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class CapaDominio
    {

        public void Ejecutar()
        {//sigo ejecutando el  de persistencia
            CapaPersistencia persistencia = new CapaPersistencia();
            persistencia.Ejecutar();

        }


    }
}
