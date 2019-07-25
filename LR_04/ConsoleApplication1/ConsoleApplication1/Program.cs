using System;

class Matrix
{
    public int[,] m;
    public int n;
    public Matrix()
    {
        n = 10;
        m = new int[10, 10];
    }
    public Matrix(int n)
    {
        this.n = n;
        m = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.SetCursorPosition(j * 7, i + 1);
                m[i, j] = Int32.Parse(Console.ReadLine());
            }
        }
        Console.Clear();
    }
    public static void Sum(Matrix a, Matrix b)
    {
        Matrix.Show(a, b);
        Console.WriteLine("Матрица, равная сумме матриц А и В");
        for (int i = 0; i < a.n; i++)
        {
            for (int j = 0; j < a.n; j++)
            {
                Console.SetCursorPosition(j * 7, i + 2 * b.n + 3);
                Console.WriteLine("{0}", a.m[i, j] + b.m[i, j]);
            }
        }
        Console.WriteLine("0: Вернуться в меню");
        Console.ReadLine();
        Console.Clear();
    }

    public static void Dif(Matrix a, Matrix b)
    {
        Matrix.Show(a, b);
        Console.WriteLine("Матрица, равная разности матриц А и В");
        for (int i = 0; i < a.n; i++)
        {
            for (int j = 0; j < a.n; j++)
            {
                Console.SetCursorPosition(j * 7, i + 2 * b.n + 3);
                Console.WriteLine("{0}", a.m[i, j] - b.m[i, j]);
            }
        }
        Console.WriteLine("0: Вернуться в меню");
        Console.ReadLine();
        Console.Clear();
    }

    public static void Show(Matrix a, Matrix b)
    {
        Console.Clear();
        Console.WriteLine("Матрица А");
        for (int i = 0; i < a.n; i++)
        {
            for (int j = 0; j < a.n; j++)
            {
                Console.SetCursorPosition(j * 7, i + 1);
                Console.WriteLine(a.m[i, j]);
            }
        }
        Console.WriteLine("Матрица B");
        for (int i = 0; i < b.n; i++)
        {
            for (int j = 0; j < b.n; j++)
            {
                Console.SetCursorPosition(j * 7, i + b.n + 2);
                Console.WriteLine(b.m[i, j]);
            }
        }
    }

    public static void Compose(Matrix a, Matrix b)
    {
        Matrix.Show(a, b);
        Console.WriteLine("Матрица, равная произведению матриц А и В");
        for (int i = 0; i < a.n; i++)
        {
            for (int j = 0; j < a.n; j++)
            {
                Console.SetCursorPosition(j * 7, i + 2 * b.n + 3);
                int element = 0;
                for (int c = 0; c < a.n; c++)
                {
                    element += a.m[i, c] * b.m[c, j];
                }
                Console.WriteLine(element);
            }
        }
        Console.WriteLine("0: Вернуться в меню");
        Console.ReadLine();
        Console.Clear();
    }
}

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание:\n" +
                              "1: Матрицы\n" +
                              "2: Двоичные числа");
            string task = Console.ReadLine();
            Console.Clear();
            if (task == "1")
            {
                int n = 11;
                while (n > 10 || n < 1)
                {
                    Console.WriteLine("Введите размер квадратной матрицы");
                    n = Int32.Parse(Console.ReadLine());
                    if (n > 10 || n < 1)
                        Console.WriteLine("Некорректные данные");
                }
                Console.Clear();
                Console.WriteLine("Введите матрицу А");
                Matrix a = new Matrix(n);
                Console.WriteLine("Введите матрицу B");
                Matrix b = new Matrix(n);
                string buf = "1";
                while (buf != "0")
                {
                    Console.WriteLine("Выберите операцию:\n" +
                                      "1: Сумма матриц А и В\n" +
                                      "2: Разность матриц А и В\n" +
                                      "3: Произведение матриц\n" +
                                      "0: Выход");
                    buf = Console.ReadLine();
                    switch (buf)
                    {
                        case "1":
                            Matrix.Sum(a, b);
                            break;
                        case "2":
                            Matrix.Dif(a, b);
                            break;
                        case "3":
                            Matrix.Compose(a, b);
                            break;
                        case "0":
                            break;
                        default:
                            Console.WriteLine("Некорректные данные");
                            break;
                    }
                }
            }
            else
            {
                if (task == "2")
                {
                    int[] binary_num = new int[30];
                    int num, size = 0;
                    Console.WriteLine("Введите десятичное число");
                    num = Int32.Parse(Console.ReadLine());

                    // переводим число в двоичную с.с., выводим на экран
                    Console.WriteLine("Число в десятичной системе счисления: " + num);
                    if (num == 0)
                        size++;
                    while (num > 0)
                    {
                        binary_num[size] += num % 2;
                        num /= 2;
                        size++;
                    }
                    Console.Write("Число в двоичной системе счисления: ");
                    for (int i = size - 1; i >= 0; i--)
                    {
                        Console.Write(binary_num[i]);
                    }
                    Console.WriteLine();

                    // меняем триады, выводим на экран
                    while (size < 9 || size % 3 > 0)
                    {
                        size++;
                    }
                    Console.Write("Число в двоичной системе счисления до смены триад: ");
                    for (int i = size - 1; i >= 0; i--)
                    {
                        Console.Write(binary_num[i]);
                    }
                    Console.WriteLine();
                    for (int i = 1; i <= 3; i++)
                    {
                        int swap = binary_num[size - i];
                        binary_num[size - i] = binary_num[size - (i + 6)];
                        binary_num[size - (i + 6)] = swap;
                    }
                    Console.Write("Число в двоичной системе счисления после смены триад: ");
                    for (int i = size - 1; i >= 0; i--)
                    {
                        Console.Write(binary_num[i]);
                    }
                    Console.WriteLine();

                    // Переводим новое число в десятичное, выводим на экран
                    for (int i = size - 1; i >= 0; i--)
                    {
                        num += binary_num[i] * Convert.ToInt32(Math.Pow(2, i));
                    }
                    Console.WriteLine("Новое число в десятичной системе счисления: " + num);
                }
                else
                {
                    Console.WriteLine("Такого задания не существует");
                    Console.ReadLine();
                }
            }
        }
    }
}