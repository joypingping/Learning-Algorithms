using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06堆排序
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class HeapSort
    {
        public int[] heapSort(int[] A,int n)
        {
            heapSort(A);
            return A;
        }

        public void heapSort(int[] A)
        {
            for(int i=A.Length/2-1;i>=0;i--)
            {
                heapAdjust(A, i, A.Length-1);
            }
            int temp;
            for(int i=A.Length-1;i>0;)
            {
                temp = A[i];
                A[i] = A[0];
                A[0] = temp;
                i--;
                heapAdjust(A, 0, i);
            }
        }

        //构建堆
        public void heapAdjust(int[] A,int parent,int length)
        {
            int temp = A[parent];
            for (int child = 2 * parent + 1; child <= length; child *= 2 )
            {
                if (child < length && A[child] < A[child + 1])
                {
                    child++;
                }
                if (temp >= A[child])
                {
                    break;
                }

                A[parent] = A[child];
                parent = child;
            }
            A[parent] = temp;
        }
    }
}
