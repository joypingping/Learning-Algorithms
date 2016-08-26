using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03插入排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //插入排序：
            //位置1上元素与在它前面的位置0上元素进行比较，如果位置1上元素更小，则两元素交换位置
            //位置2上元素（记为a）先与位置1上元素进行比较，如果位置2上元素更小、交换位置；此时a再和位置0上元素进行比较，若a更小、交换位置
            //记位置k上元素为b，b依次和前面的数进行比较（若b前面的数大于b则持续比较），直到b前面的数小于或等于b，则将b插入该位置
        }
    }

    class InsertionSort
    {
        public int[] insertionSort(int[] A,int n)
        {
            for(int i=1;i<n;i++)
            {
                //判断当前元素(A[i])和前面元素的大小比较
                if(A[i]<A[i-1])
                {
                    int j = 0;
                    int temp = A[i];
                    for(j=i-1; j>=0&&temp<A[j]; j--)    //j就是前面元素的索引；循环停止的时候需要在j+1的位置上插入temp值
                    {
                        A[j + 1] = A[j];//
                    }
                    A[j + 1] = temp;
                }
            }
            return A;
        }
    }
}
