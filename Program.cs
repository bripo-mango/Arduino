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
            int auxInt;
            Console.WriteLine("Escriba un numero");
            aux = Console.ReadLine();

            int.TryParse(aux, out auxInt);

            if(auxInt % 3 == 0 && auxInt % 5 == 0)
            {
                Console.WriteLine("El numero {0} es multiplo de 3 y de 5", auxInt);
            }else if(auxInt %3 == 0 && !(auxInt % 5 == 0))
                {
                Console.WriteLine("El numero {0} es multilpo de 3 pero NO de 5", auxInt);              
                }
            else if(!(auxInt % 3 == 0) && auxInt % 5 == 0)
                {
                Console.WriteLine("El numero {0} es multilpo de 5 pero no de 3", auxInt);
                }
            else
            {
            Console.WriteLine("El numero {0} no es multiplo ni de 3 ni de 5", auxInt);
            }
           
        }
    }
}
