using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ЛР00
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int a;
            double z1, z2;
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите а (a != 0, a != 2)");
            a = Convert.ToInt32(Console.ReadLine());
            z1 = Math.Pow((1 + a + a*a)/(2*a + a*a) + 2 - (1 - a + a*a)/(2*a - a*a), -1) * (5 - 2*a*a);
            z2 = (4 - a * a) / 2;
            Console.WriteLine("z1 = " + z1 + " z2 = " + z2);
            Console.WriteLine("Press Enter...");
            Console.ReadLine(); 

            // task 2
            double x, y = 0;
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            if ((x >= -7) && (x < -6))
            {
                y = 2;
            }
            if ((x >= -6) && (x < -2))
            {
                y = 0.25 * x + 0.5;
            }
            if ((x >= -2) && (x < 0))
            {
                y = -1*Math.Sqrt(4 - (x + 2) * (x + 2)) + 2;
            }
            if ((x >= 0) && (x < 2))
            {
                y = Math.Sqrt(4 - x*x);
            }
            if ((x >= 2) && (x <= 3))
            {
                y = -1 * x + 2;
            }
            if ((x < -7) || (x > 3))
            {
                Console.WriteLine("Функция не определена");
            }
            else
            {
                Console.WriteLine("y = " + y);
            }
            Console.WriteLine("Press Enter...");
            Console.ReadLine();  
 
            // task 3
            double f;
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToDouble(Console.ReadLine());
            f = (x - 2) * (x - 2) - 3;
            if (((y >= 0) && (y <= x) && (y >= f)) || ((y < 0) && (y >= f) && (y <= -1 * x)))
            {
                Console.WriteLine("выстрел попал в мишень");
            }
            else 
            {
                Console.WriteLine("выстрел не попал в мишень");
            }
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
