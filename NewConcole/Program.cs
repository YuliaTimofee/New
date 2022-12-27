using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConcole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helloy, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("My name {0}", name);
            Console.ReadKey();
        }
    }
}
