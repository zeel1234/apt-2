using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
      
            String s1;

            Console.WriteLine("Enter String: ");
            s1 = Console.ReadLine();

            if (s1.Distinct().Count() != s1.Count())
            {
                Console.WriteLine("You entered duplicate string");
                Console.WriteLine(s1);
            }
                
                
            else
            {
                Console.WriteLine("You are not entered duplicate string");
                Console.WriteLine(s1);
            }
                
            

        }
    }
}
