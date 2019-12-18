using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaDemo ans = new AreaDemo();
            Console.WriteLine("Enter Radius :");          
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area of the circle is " + ans.getArea(r));

            Console.WriteLine("Enter width of rectangle :");
            int width = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter height of rectangle :");
            int height = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The area of the Rectangle is " + ans.getArea(width,height));

            Console.WriteLine("Enter base of triangle :");
            double basee= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of triangle :");
            double vertical_height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area of the Triangle is " + ans.getArea(basee, vertical_height));

            Console.WriteLine("Enter size of Square :");
            int size = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The area of the Square is " + ans.getArea(size));




        }
    }

    class AreaDemo
    {
        public const double PI = 3.14159;
        
        public double getArea(double radius)
        {
            return PI * radius * radius;
        }

        public int getArea(int w, int h)
        {
            return w * h;
        }

        public double getArea( double b , double h)
        {
            return 0.5 * b * h;
        }

        public int getArea(int s)
        {
            return s * s;
        }
    }
   
}
