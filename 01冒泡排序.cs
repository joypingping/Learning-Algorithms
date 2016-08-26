using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class BubbleSort
    {
        public int[] bubbleSort(int[] A,int n)
        {
            for(int i=0;i<A.Length-1;i++)
            {
                for(int j=0;j<A.Length-i-1;j++)
                {
                    if(A[j]>A[j+1])
                    {
                        int temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }

            return A;
        }
    }
}
