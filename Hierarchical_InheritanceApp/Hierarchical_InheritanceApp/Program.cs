using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_InheritanceApp
{
    internal class Program
    {
        class College
        {
            public void display_College()
            {
                Console.WriteLine("Birla Vishvkrama Mahavidhyalaya");
            }
        }
        class Student1 : College
        {
            public void display_Name1()
            {
                Console.WriteLine("Srutesh Dholakiya");
            }
        }
        class Student2 : College
        {
            public void display_Name2()
            {
                Console.WriteLine("Priti Dholakiya");
            }
        }
        static void Main(string[] args)
        {
            Student1 student1 = new Student1();
            Student2 student2 = new Student2();
            student1.display_College();
            student1.display_Name1();
            Console.WriteLine("-----------");
            student2.display_College();
            student2.display_Name2();
            Console.ReadKey();
        }
    }
}
