using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        
          

            Console.WriteLine("DIME TU NOMBRE");

            string nombre= Console.ReadLine();

            Console.WriteLine("Dime tu edad");

            string edad = Console.ReadLine();

            Console.WriteLine("Hola. {0}, tienes {1} años ", nombre, edad);

            int _edad = Int32.Parse(edad);

            if (_edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad"); 

            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
            Console.ReadLine();
        }
    }
}
