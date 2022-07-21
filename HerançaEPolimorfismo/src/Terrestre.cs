using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaEPolimorfismo.src
{
    public class Terrestre : Animal
    {
        public Terrestre(Categoria tipo, string nome, int idade, string especie) : base(tipo, nome, idade, especie)
        {
        }
        public void Correr()
        {
            Console.WriteLine($"Eu sou o {Nome} e sou um animal Terrestre");
        }
        public void CorrerRapido()
        {
            Console.WriteLine($"Sou Rapido");
        }
        public void CorrerLento()
        {
            Console.WriteLine($"Sou Lento");
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