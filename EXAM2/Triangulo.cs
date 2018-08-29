using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Triangulo : Figura
    {
        public void Triangulo()

        {

            Console.WriteLine("Ingresa la base");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la altura");
            y = Convert.ToDouble(Console.ReadLine());
            Area = x * y / 2;
            Console.WriteLine("El area es: " + Area);
            Console.ReadKey();


        }

        public override void CalcularArea()
        {

        }
    }
}
