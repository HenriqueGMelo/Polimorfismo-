using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁreaDeFormasGeometricas.src
{
    public class Formas
    {
        public double Basee { get; set; }
        public double Altura { get; set; }
        public double Lado { get; set; }

        public Formas(double basee, double altura)
        {
            Basee = basee;
            Altura = altura;
        }
        public Formas(double lado)
        {
            Lado = lado;
        }

        public virtual void AreaRetangulo()
        {
            Console.WriteLine("Calculo para área é Base * Altura");
        }
        public virtual void AreaQuadrado()
        {
            Console.WriteLine("Calculo para área é Lado * Lado");
        }
        public virtual void AreaTriangulo()
        {
            Console.WriteLine("Calculo para área é Base * Altura / 2");
        }
    }
}


