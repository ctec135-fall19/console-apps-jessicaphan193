using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** CA2 ****");
            string texts = Console.ReadLine();
            Console.WriteLine(texts);

            int i = 0;
            while (i < 4)
            {
                Console.WriteLine(texts);
                Console.WriteLine("\n Random: {0}", texts); 
            }
        }
    }
}
