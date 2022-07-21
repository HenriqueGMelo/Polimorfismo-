using ÁreaDeFormasGeometricas.src;
using System;

namespace ÁreaDeFormasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Formas quadrado = new Quadrado(5);
            
            Formas triangulo = new Triangulo(5,7);

            Formas retangulo= new Retangulo(2,7);
            
            Console.WriteLine($"Quadrado com lado de medida igual a {quadrado.Lado}");
            quadrado.AreaQuadrado();

            Console.WriteLine($"Triângulo com base {triangulo.Basee} e lado {triangulo.Altura}");
            triangulo.AreaTriangulo();

            Console.WriteLine($"Retangulo com base {retangulo.Basee} e lado {retangulo.Altura}");
            retangulo.AreaRetangulo();



        }
    }
}
