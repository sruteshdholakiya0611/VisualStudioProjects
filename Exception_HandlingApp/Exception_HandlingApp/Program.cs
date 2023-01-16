using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_HandlingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 0;
                int div = 100 / n;
                Console.WriteLine("Not executed line");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block Exception");
            }
            Console.ReadKey();
        }
    }
}
