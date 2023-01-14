using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа измеряет, сколько квадратов со стороной С влазит в прямоугольник со сторонами АхВ методом перебора");
            Console.WriteLine("Введите сторону А прямоугольника АxВ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону В прямоугольника АxВ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону С квадрата");
            int C = Convert.ToInt32(Console.ReadLine());
            int initialB = B;
            int initialA = A;
            int number = 0;
            while ((A-C) >= 0)
            {
                B = initialB;
                while ((B - C) >= 0)
                {
                    B -= C;
                    number++;
                }
                A -= C;
            }
            Console.WriteLine("В ваш прямоугольник {2}x{3}влезло {0} квадратов со стороной {1}", number, C, initialA, initialB);
            Console.ReadLine();

        }
    }
}
