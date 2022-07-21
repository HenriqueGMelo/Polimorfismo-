using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaEPolimorfismo.src
{
    public class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Especie { get; set; }
        Categoria Tipo { get; set; }

        public Animal(Categoria tipo, string nome, int idade, string especie)
        {
            Tipo = tipo;
            Nome = nome;
            Idade = idade;
            Especie = especie;
        } 

        public virtual void Quadrupede()
        {
            Console.WriteLine($"quantidade de patas/pés");
        }
        public virtual void Bipede()
        {
            Console.WriteLine($"quantidade de patas/pés");
        }
        public void Pulo()
        {
            Console.WriteLine($"Me movo pulando");
        }
        public void Ando()
        {
            Console.WriteLine($"Me movo andando");
        }
        public void Rastejo()
        {
            Console.WriteLine($"Me movo rastejando");
        }

        public enum Categoria
        {
            Terrestre,
            Aquático,
            Aéreo
        }

    }
}
