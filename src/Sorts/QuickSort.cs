using System;
using System.Collections.Generic;
using System.Text;

namespace Sorts
{
    public class QuickSort<T>
    {
        private IComparer<T> comparer = null;
        public QuickSort(IComparer<T> comparer = null)
        {
            this.comparer = comparer ?? Comparer<T>.Default;
        }
        
        private int Partition(T[] list, int left, int right, int pivotidx)
        {
            T pivot = list[pivotidx];
            swap(list, right, pivotidx);

            for (int i = left; i < right; i++)
            {
                if (comparer.Compare(list[i], pivot) < 0)
                {
                    swap(list, i, left);
                    left++;
                }
            }

            swap(list, left, right);
            return left;
        }

        private void Sort(T[] list, int left, int right)
        {
            if (right > left)
            {
                int pivotidx = left;
                pivotidx = Partition(list, left, right, pivotidx);
                Sort(list, left, pivotidx);
                Sort(list, pivotidx + 1, right);
            }
        }

        private void swap(T[] list, int a, int b)
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        public T[] Sort(T[] list)
        {
            Sort(list, 0, list.Length - 1);
            return list;
        }
    }
}
