using System;
using System.Collections.Specialized;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // task 1
            Console.WriteLine("Задание 1.\nВведите размер массива");
            SortArray mas = new SortArray(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Введите элементы массива:");
            mas.FillArray();
            Console.WriteLine("Исходный массив: " + mas.ToString());
            mas.SelectSort();
            Console.WriteLine("Сортировка выбором по возрастанию: " + mas.ToString());
            mas.BubbleSort();
            Console.WriteLine("Сортировка пузырьком по убыванию: " + mas.ToString());
            mas.QSort(0, mas.Size - 1);
            Console.WriteLine("Быстрая сортировка по возрастанию: " + mas.ToString());
            Console.WriteLine("Нажмите Enter, чтобы продолжить");
            Console.ReadLine();
            Console.Clear();

            // task 2
            int m, n;
            Console.WriteLine("Задание 2\nВведите число строк");
            m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\tИсходная матрица");
            MyArray matrix = new MyArray(m, n);
            matrix.ShowArray();
            Console.WriteLine("Матрица сортирована по возрастанию сумм элементов столбцов");
            matrix.SortUp();
            matrix.ShowArray();
            Console.WriteLine("Матрица сортирована по убыванию сумм элементов столбцов");
            matrix.SortDown();
            matrix.ShowArray();
            Console.WriteLine("Нажмите Enter, чтобы продолжить");
            Console.ReadLine();
            Console.Clear();
            
            // task 3
            Console.WriteLine("Задание 3\nВведите число строк ступенчатого массива");
            StepArray vector = new StepArray(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Введите элементы ступенчатого массива");
            vector.FillArray();
            Console.WriteLine("Ступнчатый массив, сортированный по возрастанию");
            vector.SortUp();
            vector.ShowArray();
            Console.WriteLine("Ступнчатый массив, сортированный по убыванию");
            vector.SortDown();
            vector.ShowArray();
            Console.WriteLine("Нажмите Enter, чтобы продолжить");
            Console.ReadLine();
        }
    }
}