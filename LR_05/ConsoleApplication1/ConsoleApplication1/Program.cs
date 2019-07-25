using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Frac a = new Frac();
            Frac b = new Frac();
            string buf = "1";
            while (buf != "0")
            {
                switch (buf)
                {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Введите числитель первой дроби");
                            a.Num = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Введите знаменатель первой дроби");
                            a.Den = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Введите числитель второй дроби");
                            b.Num = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Введите знаменатель второй дроби");
                            b.Den = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Готово. Нажмите Enter");
                            buf = "4";
                            Console.ReadLine();
                            break;
                        case "2":
                            a.Reduce();
                            buf = "4";
                            break;
                        case "3":
                            b.Reduce();
                            buf = "4";
                            break;
                        case "4":
                            Console.Clear();
                            Console.Write("\tДробь1 = " + a.ToString() + "\tДробь2 = " + b.ToString() + "\n");
                            string st;
                            if (b.Num == 0)
                                st = "Деление на нуль";
                            else
                                st = (a / b).ToString();
                            Console.WriteLine("Сумма дробей: " + (a + b).ToString() + "\n" +
                                              "Разность дробей: " + (a - b).ToString() + "\n" +
                                              "Произведение дробей: " + (a * b).ToString() + "\n" +
                                              "Частное дробей: " + st + "\n" +
                                              "Меню:\n" +
                                              "1: Изменить значение дробей\n" +
                                              "2: Сократить Дробь1\n" +
                                              "3. Сократить Дробь2\n" +
                                              "0: Выход");
                            buf = Console.ReadLine();
                            break;
                        case "0":
                            break;
                        default: 
                            Console.WriteLine("Недопустимое значение");
                            Console.ReadLine();
                            break;
                }
            }
        }
    }
}