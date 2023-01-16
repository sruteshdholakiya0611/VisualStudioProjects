using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    internal class Program
    {
        public delegate void Display();
        class Delegate
        {
            public static void display_Name()
            {
                Console.WriteLine("Srutesh Dholakiya");
            }
            public static void display_Id()
            {
                Console.WriteLine("19IT472");
            }
        }
        static void Main(string[] args)
        {
            Display d1 = Delegate.display_Name;
            Display d2 = Delegate.display_Id;

            d1();
            d2();
            Console.ReadKey();
        }
    }
}
