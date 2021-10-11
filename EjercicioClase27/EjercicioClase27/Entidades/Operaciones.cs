﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase27.Entidades
{
    class Operaciones
    {
        private double operacion1;
        private double operacion2;
        private double resultado;

        public Operaciones(double operacion1, double operacion2)
        {
            this.operacion1 = operacion1;
            this.operacion2 = operacion2;
        }

        public double Operacion1 { get => operacion1; set => operacion1 = value; }
        public double Operacion2 { get => operacion2; set => operacion2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }
    }
}
