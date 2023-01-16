using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_HandlingthrowApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("Invalid Division");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Block : " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
