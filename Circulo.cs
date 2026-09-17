using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Circulo : FormaGeometrica
    {
        public double raio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * raio * raio;
        }
    }
}