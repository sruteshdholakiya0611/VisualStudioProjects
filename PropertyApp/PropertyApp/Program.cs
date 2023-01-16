using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    internal class Program
    {
        class MyClass
        {
            private int n;
            public void Set(int i)
            {
                n = i;
            }
            public int Get()
            {
                return n;
            }
        }
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Set(472);
            int nVal = mc.Get();
            Console.WriteLine("The Value Of n : " +nVal);
            Console.ReadKey();
        }
    }
}
