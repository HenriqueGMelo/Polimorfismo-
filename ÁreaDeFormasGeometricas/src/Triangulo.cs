using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁreaDeFormasGeometricas.src
{
    public class Triangulo : Formas
    {
        public Triangulo(double basee, double altura) : base(basee, altura)
        {
        }

        public override void AreaTriangulo()
        {
            double resultado = (Basee * Altura) / 2;
            Console.WriteLine($"Resultado da área de um triangulo com base {Basee} e altura {Altura} é dado com {Basee} * {Altura} / 2 = {resultado} \n");
        }
    }
}
