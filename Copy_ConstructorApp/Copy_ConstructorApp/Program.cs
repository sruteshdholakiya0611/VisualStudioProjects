using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_ConstructorApp
{
    internal class Program
    {
        private string name;
        private int id;

        Program(Program p)
        {
            name = p.name;
            id = p.id;
        }
        Program(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public string Display
        {
            get { return "Name : " + name.ToString() + "\nId NO : " + id.ToString(); }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program("Srutesh Dholakiya", 472);
            Program p2 = new Program(p1);

            Console.WriteLine(p2.Display);
            Console.ReadKey();
        }
    }
}
