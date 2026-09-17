using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Retangulo : FormaGeometrica
    {
        public int largura { get; set; }
        public int altura { get; set; }

        public override double CalcularArea()
        {
            return largura * altura;
        }
    }
}