using HerançaEPolimorfismo.src;
using System;
using static HerançaEPolimorfismo.src.Animal;

namespace HerançaEPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terrestre cachorro = new Terrestre(Animal.Categoria.Terrestre, "Rex", 5, "Cachorro");
            Aereo ave = new Aereo(Animal.Categoria.Aéreo, "Fred", 6, "Calopsita");
            Aquatico peixe = new Aquatico(Animal.Categoria.Aquático, "Golf", 3, "Golfinho");


            cachorro.Correr();
            Console.WriteLine($"Sou {cachorro.Especie}");
            cachorro.Ando();
            cachorro.Quadrupede();
            cachorro.CorrerRapido();
            Console.WriteLine($"Minha idade é de {cachorro.Idade} anos \n ");

            ave.Voar();
            Console.WriteLine($"Sou {ave.Especie}");
            ave.Bipede();
            ave.VooBaixo();
            Console.WriteLine($"Minha idade é de {ave.Idade} anos \n");

            peixe.Nadar();
            Console.WriteLine($"Sou {peixe.Especie}");
            peixe.ÁguaSalgada();
            Console.WriteLine($"Minha idade é de {peixe.Idade} anos \n");
        }
    }
}
