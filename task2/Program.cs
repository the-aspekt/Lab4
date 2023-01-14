using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;          
            int i = 0;
            do
            {
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                    i++;
                else if (N < 0)
                    i--;
               
            } while (N!=0);
            if (i>0)
            {
                Console.WriteLine("Положительных чисел больше на {0}", i);
            }
            else if (i==0)
                Console.WriteLine("Количество положительных и отрицательных чисел равно");
            else
            {
                Console.WriteLine("Отрицательных чисел больше на {0}", Math.Abs(i));
            }
             
            Console.ReadLine();  
        }
    }
}
