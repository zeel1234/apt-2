using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr = new int[4][];
            jagged_arr[0]=new int[7] {3,26,7,4,34,66,8};
            jagged_arr[1]=new int[5] {13,69,80,33,2};
            jagged_arr[2]=new int[3] {35,33,21};
            jagged_arr[3]=new int[6] {101,44,32,44,75,30};
            Array.Sort(jagged_arr[1]);
            Array.Sort(jagged_arr[2]);
            Console.WriteLine("length of the array:", jagged_arr[1].Length);
            foreach(int i in jagged_arr[1])
            {
                Console.WriteLine("First array");
                Console.WriteLine(i);
                Console.ReadLine();
            }
            foreach(int j in jagged_arr[2])
            {
                Console.WriteLine("Second array");
                Console.WriteLine(j);
                Console.ReadLine();
            }
        }
    }
}