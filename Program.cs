
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            int num2 = 0;

            Console.WriteLine("**EXAMEN 1***----TECNICAS DE PROGRAMACION----:)");

            Console.WriteLine("Dame el primer numero ENTERO");

            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Dame el segundo numero ENTERO ");
            num2 = Convert.ToInt16(Console.ReadLine());


            suma Suma1 = new suma();

            Suma1.Setnum1(num1);
            Suma1.Setnum2(num2);

            Console.WriteLine("La suma es = {0}", Suma1.GetRes());
            

            div div1 = new div();

            div1.Setnum1(num1);
            div1.Setnum2(num2);

            Console.WriteLine("La division es = {0}", div1.GetRes2());
            Console.ReadKey();

        }
    }
}
