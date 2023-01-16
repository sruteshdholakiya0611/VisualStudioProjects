using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    internal class Program
    {
        class Name
        {
            public void display_Name()
            {
                Console.WriteLine("Srutesh Dholakiya");
            }
        }
        class Id : Name
        {
            public void display_Id()
            {
                Console.WriteLine("19IT472");
            }
        }
        static void Main(string[] args)
        {
            Id id = new Id();
            id.display_Name();
            id.display_Id();
            Console.ReadKey();

        }
    }
}
