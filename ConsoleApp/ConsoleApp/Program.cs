using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        class Box
        {
            public int x, y, z;
            public Box(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public Box(Box copybox)
            {
                this.x = copybox.x;
                this.y = copybox.y;
                this.z = copybox.z;
            }
            ~Box()
            {
                Console.WriteLine("Box destructor called");
            }
        }

        static void Main(string[] args)
        {
            Box cube = new Box(10, 10, 10);
            Console.WriteLine("Dimensions of the cube are {0} {1} {2}", cube.x, cube.y, cube.z);
            Console.ReadKey();
        }
    }
}
