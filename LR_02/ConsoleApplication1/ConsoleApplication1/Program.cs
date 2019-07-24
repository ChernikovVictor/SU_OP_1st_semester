using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string buf = "11";
            while (buf != "0")
            {
                Console.WriteLine("Меню");
                Console.WriteLine("1: Задание 1");
                Console.WriteLine("2: Задание 2");
                Console.WriteLine("3: Задание 3");
                Console.WriteLine("0: Выход");
                buf = Console.ReadLine();
                switch (buf)
                {
                    case "1":
                        double x, xmax, dx, y;
                        Console.WriteLine("Введите xmin");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите xmax");
                        xmax = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите dx");
                        dx = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0, 10 :0.00} {1, 16 :0.00} ", 'x', 'y');
                        while (xmax > x)
                        {
                            if ((x < -7) || (x > 3))
                            {
                                Console.WriteLine("{0, 10 :0.00} {1, 25} ", x, "Функция не определена");
                            }
                            else
                            {
                                if ((x >= -7) && (x < -6))
                                {
                                    y = 2;
                                }
                                else if ((x >= -6) && (x < -2))
                                {
                                    y = 0.25 * x + 0.5;
                                }
                                else if ((x >= -2) && (x < 0))
                                {
                                    y = -1 * Math.Sqrt(4 - (x + 2) * (x + 2)) + 2;
                                }
                                else if ((x >= 0) && (x < 2))
                                {
                                    y = Math.Sqrt(4 - x * x);
                                }
                                else
                                {
                                    y = -1 * x + 2;
                                }
                                Console.WriteLine("{0, 10 :0.00} {1, 16 :0.00} ", x, y);
                            }
                            x += dx;
                        }
                        Console.WriteLine("Press Enter...");
                        Console.ReadLine();
                        Console.Clear();   
                        break;
                    case "2":
                        for (int i = 0; i < 3; i++)
                        {
                            double f;
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
                        }
                        Console.WriteLine("Press Enter...");
                        Console.ReadLine();
                        Console.Clear(); 
                        break;
                    case "3":
                        Console.WriteLine("Введите x");
                        x = Convert.ToDouble(Console.ReadLine());
                        if (x <= 1.0)
                        {
                            Console.WriteLine("Формула не справедлива для заданного х");
                            break;
                        }
                        Console.WriteLine("Введите точность");
                        double q = Convert.ToDouble(Console.ReadLine());
                        if (q <= 0)
                        {
                            Console.WriteLine("Формула не справедлива для заданной точности");
                            break;
                        }
                        int n = 0;
                        double element = Math.Pow(-1, n + 1) / ((2 * n + 1) * Math.Pow(x, 2*n + 1)),
                            sum = 0.5 * Math.PI + element;
                        while (Math.Abs(element) > q)
                        {
                            n++;
                            element = Math.Pow(-1, n + 1) / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
                            sum += element;
                        }
                        n++;
                        Console.WriteLine("Сумма ряда = " + sum);
                        Console.WriteLine("Колличество элементов = " + n);
                        Console.WriteLine("Press Enter...");
                        Console.ReadLine();
                        Console.Clear(); 
                        break;
                    case "0": 
                        buf = "0";
                        break;
                    default:
                        Console.WriteLine("Некорректные данные");
                        Console.WriteLine("Press Enter...");
                        Console.ReadLine();
                        Console.Clear(); 
                        break;
                }
            }
        }
    }
}
