using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDelegatesApp
{
    internal class Program
    {
        public delegate void Display(int a, int b);
        class Delegate
        {
            public static void input_Add(int a, int b)
            {
                Console.WriteLine("Addition : " +(a + b));
            }
            public static void input_Sub(int a, int b)
            {
                Console.WriteLine("Subtraction : " + (a - b));
            }
        }
        static void Main(string[] args)
        {
            Display d1 = Delegate.input_Add;
            Display d2 = Delegate.input_Sub;

            Console.WriteLine("Enter The Number a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter The Number b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            d1(a, b);
            d2(a, b);
            Console.ReadKey();
        }
    }
}
