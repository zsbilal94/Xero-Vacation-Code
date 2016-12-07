using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int range = 100;
            int fizz = 3;
            int buzz = 5;
            for (int n = 1; n <= range; n++)
            {
   
                if (n % fizz == 0 && n % buzz == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                }

                else if (n % fizz == 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                
                else if (n % buzz == 0)
                {
                    System.Console.WriteLine("Buzz");
                }

                else
                {
                    System.Console.WriteLine("{0}", n);
                }
            }
            System.Console.Read();
        }
    }
}
