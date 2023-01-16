using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorApp
{
    internal class Program
    {
        class Destructor
        {
            string Name;
            int id;
            public Destructor()
            {
                Console.WriteLine("Costructor Is Called.");
            }

            public Destructor(string Name, int id)
            {
                this.Name = Name; this.id = id;
            }
            public void display_Name()
            {
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("Id No. : " + id);
            }
            ~Destructor()
            {
                Console.WriteLine("Destructor Is Called.");
            }
        }
        static void Main(string[] args)
        {
            Destructor app = new Destructor("Srutesh Dholakiya", 472);
            app.display_Name();
            Console.ReadKey();
        }
    }
}
