using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Gato : Animal
    {
        public string Raca { get; set; }
        public Gato(string nome, string raca) : base(nome)
        {
            raca = raca;

        }
        public void Miar()
        {
            Console.WriteLine($"{Nome} esta miando!! miau miau miau");

        }
    }
}