using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int n;
            Console.WriteLine("Escriba un numero");
            aux = Console.ReadLine();

            int.TryParse(aux, out n);

            if(n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }else if(n %3 == 0 && !(n % 5 == 0))
                {
                Console.WriteLine("Fizz");              
                }
            else if(!(n % 3 == 0) && n % 5 == 0)
                {
                Console.WriteLine("Buzz");
                }
            else
            {
            Console.WriteLine("{0}", n);
            }  
           
        }
    }
}
