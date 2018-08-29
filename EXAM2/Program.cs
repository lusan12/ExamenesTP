using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Program

       
    {
        static void Main(string[] args)
        {
            Figura ObjFiguras = new Figura();
            int menu;

            Console.WriteLine("Seleciona la Figura \n1) Cuadrado\n2) Triangulo\n3) Circulo\n4");
            menu = Convert.ToInt16(Console.ReadLine());

            switch (menu)
                {

                case 1:
                    Console.WriteLine("Escogiste cuadrado, dame el lado");
                    Console.ReadLine();
                    Convert.ToInt16(Console.ReadLine());
                    ObjFiguras.CalcularArea();
                    break;
                case 2:
                    Console.WriteLine("Escogiste Triangulo, dame la base y la altura");
                    ObjFiguras.CalcularArea();
                    break;
                case 3:
                    Console.WriteLine("Escogiste Circulo, dame el radio");
                    ObjFiguras.CalcularArea();
                    break;

            }
            
            
        }
    }
}
