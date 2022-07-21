using System;

namespace ÁreaDeFormasGeometricas.src
{
    public class Quadrado : Formas
    {
        public Quadrado(double lado) : base(lado)
        {
        }

        public override void AreaQuadrado()
        {
            double resultado = Lado * Lado;
            Console.WriteLine($"Resultado da área de um quadrado com lado igual a {Lado} é dado com {Lado} * {Lado} = {resultado} \n");
        }
    }
}