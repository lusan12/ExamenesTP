using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Cuadrado : Figura
    {
        public void Cuadrado()

        {

            Console.WriteLine("Ingresa el lado");
            x = Convert.ToDouble(Console.ReadLine());
            Area = x * x;
            Console.WriteLine("El area es: " + Area);
            Console.ReadKey();


        }

        public override void CalcularArea()
        {

        }
    }
}
