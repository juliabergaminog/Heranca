using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Cachorro : Animal
    {
        public string Raca { get; set; }
        public Cachorro(string nome, string raca) : base(nome)
        {
            raca = raca;

        }
        public void Latir()
        {
            Console.WriteLine($"{Nome} esta latindo!! au au au!");

        }
    }
}