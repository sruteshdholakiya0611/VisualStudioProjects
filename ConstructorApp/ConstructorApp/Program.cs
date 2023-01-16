using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    internal class Program
    {
        Program()
        {
            Console.WriteLine("Constructor Is Called.");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.ReadKey();
        }
    }
}
