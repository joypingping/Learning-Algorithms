using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05快速排序
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }

    class QuickSort
    {
        public int[] quickSort(int[] A,int n)
        {
            sort(A, 0, n - 1);
            return A;
        }

        public void sort(int[] A,int left,int right)
        {
            if(left<right)
            {
                int key = A[(left + right) / 2];
                int i = left - 1;
                int j = right + 1;
                while(true)
                {
                    while (A[++i] < key) ;
                    while (A[--j] > key) ;
                    if(i>=j)
                    {
                        break;
                    }
                    swap(A, i, j);
                }
                sort(A, left, i - 1);
                sort(A, j + 1, right);
            }
        }

        public void swap(int[] A,int i,int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
    }
}
