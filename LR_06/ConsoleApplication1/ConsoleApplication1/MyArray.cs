using System;
namespace ConsoleApplication1
{
    public class MyArray
    {
        private int[,] a;
        private int m, n;
        private int[] arr;

        public int this[int i, int j]
        {
            get
            {
                if (i >= 0 && i < m && j >= 0 && j < n)
                    return a[i, j];
                return 0;
            }
            set
            {
                if (i >= 0 && i < m && j >= 0 && j < n)
                    a[i, j] = value;
            }
        }

        public int M
        {
            get { return m; }
        }

        public int N
        {
            get { return n; }
        }
        
        public MyArray(){}

        public MyArray(int m, int n)
        {
            this.m = m;
            this.n = n;
            a = new int[m, n];
            arr = new int[n];
            Random gen = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    this[i, j] = gen.Next(-100, 101);
                    arr[j] += this[i, j];
                }
            }
            
        }

        public void ShowArray()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(this[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private void Swap(int i, int j)
        {
            int swap = arr[i];
            arr[i] = arr[j];
            arr[j] = swap;
            for (int k = 0; k < m; k++)
            {
                swap = this[k, i];
                this[k, i] = this[k, j];
                this[k, j] = swap;
            }
        }

        private void QSort(int left, int right)
        {
            int i = left, j = right;
            int middle = arr[(i + j) / 2];
            do
            {
                while (arr[i] < middle)
                    i++;
                while (arr[j] > middle)
                    j--;
                if (i <= j)
                {
                    Swap(i, j);
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j)
                this.QSort(left, j);
            if (i < right)
                this.QSort(i, right);
        }

        public void SortUp()
        {
            this.QSort(0, n - 1);
        }
        
        public void SortDown()
        {
            this.QSort(0, n - 1);
            for (int i = 0; i < n / 2; i++)
            {
                Swap(i, n - i - 1);
            }
        }
    }
}