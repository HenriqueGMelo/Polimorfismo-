using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁreaDeFormasGeometricas.src
{
    public class Retangulo : Formas
    {
        public Retangulo(double basee, double altura) : base(basee, altura)
        {
        }

        public override void AreaRetangulo()
        {
            double resultado = Basee * Altura;
            Console.WriteLine($"Resultado da área de um retângulo com base {Basee} e {Altura} é dado com {Basee} * {Altura} = {resultado} \n");
        }
    }
}
