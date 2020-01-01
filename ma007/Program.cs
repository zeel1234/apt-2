using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    public delegate void CalArea(float a, float b);
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate obj = new TestDelegate();
            CalArea del_obj1 = new CalArea(obj.Rectangle);
            CalArea del_obj2 = new CalArea(obj.Triangle);
            Console.WriteLine("Enter the Length for Rectangle");
           float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth for Rectangle");
            float width = float.Parse(Console.ReadLine());
            del_obj1(length,width);
            Console.WriteLine("Enter the Breadth for Triangle ");
            float breadth = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Hieght for Triangle ");
            float hieght = float.Parse(Console.ReadLine());
            del_obj2(breadth, hieght);
            Console.ReadLine();
        }

        class TestDelegate
        {

            //public static float num = 1;
            

            public void Rectangle(float a, float b)
            {
                Console.WriteLine("Area of rectangle is :{0}", a * b);
            }
           

            public  void Triangle(float a, float b)
            {
                Console.WriteLine("Area of Triangle is :{0}", (a * b) / 2);

            }
        }
    }
}

