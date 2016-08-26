using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02选择排序
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectionSort ss = new SelectionSort();
            int[] nums = new int[] { 1, 2, 3, 5, 2, 3, 6 };

            /*
            int min = nums[0];
            //找数组中的最小值
            for (int i = 0; i < nums.Length - 1;i++ )
            {
                if(min>nums[i+1])
                {
                    min = nums[i + 1];
                }
            }
            Console.WriteLine("数组最小元素：{0}", min);
            */


            Console.WriteLine(ss.selectionSort(nums, nums.Length));

            Console.ReadKey();
        }
    }

    class SelectionSort
    {
        public int[] selectionSort(int[] A,int n)
        {
            //int min = 0;
            //for (int i = 0; i < A.Length - 1; i++)
            //{
            //    for(int j=0;j<A.Length-1-i;j++)
            //    {
            //        min = A[j];
            //        if(min>A[j+1])
            //        {
            //            min = A[j + 1];
            //        }

            //        //交换值
            //        int temp = A[i];
            //        A[i] = min;
            //        A[j] = temp;
            //    }
            //}

            for (int i = 0; i < A.Length - 1; i++)
            {
                int minIndex=0;
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    //先找到比较数组中的最小值
                    if (A[minIndex] > A[j])
                    {
                        minIndex = j;
                    }
                }

                //把最小元素放在数组前面，然后剩下的元素继续比较
                if (minIndex != i)
                {
                    int temp = A[minIndex];
                    A[minIndex] = A[i];
                    A[i] = temp;
                }
            }

            return A;
        }
    }
}
