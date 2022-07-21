﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaEPolimorfismo.src
{
    public class Aquatico : Animal
    {
        public Aquatico(Categoria tipo, string nome, int idade, string especie) : base(tipo, nome, idade, especie)
        {
        }
        public void Nadar()
        {
            Console.WriteLine($"Eu sou o {Nome} e sou um animal Aquático");  
        }
        public void ÁguaDoce()
        {
            Console.WriteLine("Vivo em água doce");
        }
        public void ÁguaSalgada()
        {
            Console.WriteLine("Vivo em água salgada");
        }
        public override void Quadrupede()
        {
            Console.WriteLine($"Tenho 4 patas/pés");
        }
        public override void Bipede()
        {
            Console.WriteLine($"Tenho 2 patas/pés");
        }
    }
}
