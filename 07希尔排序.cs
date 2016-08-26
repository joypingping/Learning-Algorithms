using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07希尔排序
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class ShellSort
    {
        public int[] shellSort(int[] A,int n)
        {
            for(int h=n/2;h>0;h=h/2)
            {
                for(int i=h;i<n;i++)
                {
                    int temp = A[i];
                    if(temp<A[i-h])
                    {
                        for(int j=0;j<i;j+=h)
                        {
                            if(temp<A[j])
                            {
                                temp = A[j];
                                A[j] = A[i];
                                A[i] = temp;
                            }
                        }
                    }
                }
            }
            return A;
        }
    }
}
