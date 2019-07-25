using System;
using System.Collections.Specialized;

class Counter
{
    public int min, max, x;

    public Counter()
    {
        min = 1;
        max = 10;
        x = 1;
    }
    public Counter(int x, int min, int max)
    {
        if (min > max)
        {
            int swap = min;
            min = max;
            max = swap;
        }
        this.max = max;
        this.min = min;
        if (x > max || x < min)
            this.x = x > max ? 10 : 1;
        else
            this.x = x;
    }
    public void Inc()
    {
        if (x == max)
            x = min - 1;
        x++;
    }

    public void Dec()
    {
        if (x == min)
            x = max + 1;
        x--;
    }

    public int GetX()
    {
        return x;
    }

}
class Polynomial
{
    public double a, b, c;
    public Polynomial() { }
    public Polynomial(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public string Answers()
    {
        if (a == 0)
        {
            return "Один корень х = " + Convert.ToString(-c / b);
        }
        double D = b * b - 4 * a * c;
        if (D >= 0)
        {
            if (D == 0)
                return "Один корень х = " + Convert.ToString(-b / 2 / a);
            else
            {
                return "2 корня. Х1 = " + Convert.ToString((-b + Math.Sqrt(D)) / 2) + "  Х2 = " +
                       Convert.ToString((-b - Math.Sqrt(D)) / 2);
            }
        }
        else
        {
            return "Корней нет";
        }
    }
}

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Task_one()
        {
            string mode = "1";
            while (mode != "0")
            {
                Console.WriteLine("Выберите режим\n" +
                                  "1: По умолчанию (х = 1, min = 1, max = 10)\n" +
                                  "2: С заданным х, min, max\n" +
                                  "0: Вернуться в меню");
                mode = Console.ReadLine();
                Console.Clear();
                Counter count;
                switch (mode)
                {
                    case "2":
                        int min, max, x;
                        Console.WriteLine("Введите минимальную границу");
                        min = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Введите максимальную границу");
                        max = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Введите значение счётчика");
                        x = Int32.Parse(Console.ReadLine());
                        count = new Counter(x, min, max);
                        Console.Clear();
                        break;
                    default:
                        count = new Counter();
                        break;
                }
                Console.WriteLine("Выберите опцию\n" +
                                  "+: Увеличить значение счётчика\n" +
                                  "-: Уменьшить значение счётчика\n" +
                                  "=: Текущее значениe\n" +
                                  "0: Вернуться в меню\n");
                while (mode != "0")
                {
                    mode = Console.ReadLine();
                    switch (mode)
                    {
                        case "+": count.Inc(); break;
                        case "-": count.Dec(); break;
                        case "=": Console.WriteLine("Текущее значение " + count.GetX()); break;
                        case "0": break;
                        default: Console.WriteLine("Некорректная операция"); break;
                    }
                }

            }

        }
        public static void Task_two()
        {
            double a, b, c;
            Console.WriteLine("Введите а");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = double.Parse(Console.ReadLine());
            Polynomial x = new Polynomial(a, b, c);
            Console.WriteLine("У многочлена: " + x.Answers() + "\n0: Вернуться в меню");
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            string task = "1";
            while (task != "0")
            {
                Console.WriteLine("Выберите задание\n" +
                                  "1: Десятичный счётчик\n" +
                                  "2: Многочлен\n" +
                                  "0: Выход");
                task = Console.ReadLine();
                Console.Clear();
                switch (task)
                {
                    case "1":
                        Task_one();
                        Console.Clear();
                        break;
                    case "2":
                        Task_two();
                        Console.Clear();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Некорректные данные. Выберете заново");
                        break;
                }
            }

        }
    }
}