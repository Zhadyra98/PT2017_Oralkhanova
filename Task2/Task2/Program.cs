using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            string[] s = sr.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            if (a < b)
            {
                for(int i=a; i>0; i--)
                {
                    if(a%i==0 && b % i == 0)
                    {
                        sw.WriteLine(i + " ");
                    }
                }
            }

            if (b < a)
            {
                for (int i = b; i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        sw.WriteLine(i + " ");

                    }
                }
            }

            sr.Close();
            sw.Close();

        }
    }
}
