using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodoveloadingApp
{
    internal class Program
    {
        public class Methodoveloading
        {
            public int display_Add(int a, int b)  
            {
                return a + b;
            }
            public int display_Add(int a, int b, int c)             
            {
                return a + b + c;
            }
        }
        static void Main(string[] args)
        {
            Methodoveloading method = new Methodoveloading();
            Console.WriteLine("Sum of a and b : " +method.display_Add(1, 2));
            Console.WriteLine("Sum of a, b and c : " + method.display_Add(1, 2, 3));
            Console.ReadKey();
        }
    }
}
