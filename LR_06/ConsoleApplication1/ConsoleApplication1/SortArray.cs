using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    public class SortArray
    {
        private int[] a;

        public int Size
        {
            get { return a.Length; }
        }

        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < this.Size)
                    return a[i];
                else
                    return 0;
            }
            set
            {
                if (i >= 0 && i < this.Size)
                    a[i] = value;
            }
        }

        public SortArray (){}

        public SortArray(int n)
        {
            a = new int[(n > 0) ? n : 10];
        }

        public void FillArray()
        {
            for (int i = 0; i < this.Size; i++)
            {
                this[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public override string ToString()
        {
            string st = "";
            foreach (int x in a)
            {
                st += Convert.ToString(x) + " ";
            }
            return st;
        }

        private void Swap(int i, int j)
        {
            int swap = this[i];
            this[i] = this[j];
            this[j] = swap;
        }

        public void BubbleSort()
        {
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size - 1; j++)
                {
                    if (this[j] < this[j + 1])
                    {
                        Swap(j, j + 1);
                    }
                }
            }
        }

        public void SelectSort()
        {
            for (int i = 0; i < this.Size - 1; i++)
            {
                int k = i, min = this[i];
                for (int j = i + 1; j < this.Size; j++)
                {
                    if (this[j] < min)
                    {
                        k = j;
                        min = this[j];
                    }
                }
                this[k] = this[i];
                this[i] = min;
            }
        }

        public void QSort(int left, int right)
        {
            int i = left, j = right;
            int middle = this[(i + j) / 2];
            do
            {
                while (this[i] < middle)
                    i++;
                while (this[j] > middle)
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
    }
}