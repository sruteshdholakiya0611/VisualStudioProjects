using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        class MyCalculator
        {
            int a, b;

            public MyCalculator(int a, int b)
            {
                this.a = a; this.b = b;
            }

            public int display_Add()
            {
                return a + b;
            }
            public int display_Sub()
            {
                return a - b;
            }
            public int display_Multi()
            {
                return a * b;
            }
            public int display_Div()
            {
                return a / b;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            MyCalculator mc = new MyCalculator(a, b);

            Console.WriteLine("Addition Operation : ");
            Console.WriteLine("Addition : " + mc.display_Add());
            Console.WriteLine("Subtraction : " + mc.display_Sub());
            Console.WriteLine("Multiplication : " + mc.display_Multi());
            Console.WriteLine("Division : " + mc.display_Div());
            Console.ReadKey();
        }
    }
}
