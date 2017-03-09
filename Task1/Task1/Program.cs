using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = int.Parse(s);
            Console.WriteLine(" All divisors of " + k+":");
            for(int i=1; i<=k; i++)
            {
                if (k % i == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
