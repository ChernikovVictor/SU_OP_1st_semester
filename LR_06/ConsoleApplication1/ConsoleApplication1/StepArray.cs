using System;
namespace ConsoleApplication1
{
    public class StepArray
    {
        private int[][] a;  // ступенчатый массив
        private SortArray arr;  // одномерный вектор, в который преобразован ступенчатый массив
        
        public StepArray(){}

        public StepArray(int m)
        {
            a = new int[m][];
            int size_of_arr = 0;
            for (int i = 0; i < m; i++)
            {
                Console.Write("Введите число столбцов в строке {0}: ", i + 1);
                int k = Int32.Parse(Console.ReadLine());
                a[i] = new int[k];
                size_of_arr += k;
            }
            arr = new SortArray(size_of_arr);
        }

        public void FillArray()
        {
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.SetCursorPosition(j * 8, i + 4 + a.Length);
                    a[i][j] = Int32.Parse(Console.ReadLine());
                    arr[k] = a[i][j];
                    k++;
                }
            }
            arr.QSort(0, k - 1);
        }

        public void ShowArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void SortUp()
        {
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = arr[k];
                    k++;
                }
            }
        }
        
        public void SortDown()
        {
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = arr[arr.Size - 1 - k];
                    k++;
                }
            }
        }
    }
}