using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_HandlingRe_throwingApp
{
    internal class Program
    {
        class MyClass
        {
            public static void Exception()
            {
                try
                {
                    int n = 0;
                    int sum = 100 / n;
                    Console.WriteLine("Exception caught here");
                }
                catch (DivideByZeroException)
                {
                    throw;
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                MyClass.Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
