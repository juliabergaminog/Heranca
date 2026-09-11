using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Desenvolvedor : Funcionario
    {
        public double Bonus { get; set; }
        public Desenvolvedor(string nome, double bonus) : base(nome)
        {
            Bonus = bonus;

        }
        public override double CalcularBonusAnual()
        {
            return (Salario * 0.12) + Bonus;

        }
    }
}