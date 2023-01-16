using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterized_ConstructorApp
{
    internal class Program
    {
        class Parameterized_Constructor
        {
            string name;
            int id;
            public Parameterized_Constructor(string name, int id)
            {
                this.name = name;
                this.id = id;
            }
            public void display()
            {
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Id NO : " + id);
            }
        }
        static void Main(string[] args)
        {
            Parameterized_Constructor pc = new Parameterized_Constructor("Srutesh Dholakiya", 472);
            pc.display();
            Console.ReadKey();
        }
    }
}
