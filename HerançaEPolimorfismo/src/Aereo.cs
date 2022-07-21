using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaEPolimorfismo.src
{
    public class Aereo : Animal
    {   
        public Aereo(Categoria tipo, string nome, int idade, string especie) : base(tipo, nome, idade, especie)
        {
        }
        public void Voar()
        {
            Console.WriteLine($"Eu sou o {Nome} e sou um animal Aéreo");
        }
        public void VooAlto()
        {
            Console.WriteLine($"voo alto");
        }
        public void VooBaixo()
        {
            Console.WriteLine($"Voo baixo");
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
