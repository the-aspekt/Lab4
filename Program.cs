using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://github.com/the-aspekt/Lab4.git

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            int NSquared = 0;
            for (int i = 1; i <= N; i++)
            {
                NSquared += 2 * i - 1;
                Console.WriteLine(NSquared);
            }
            Console.ReadKey();
        }
    }
}
