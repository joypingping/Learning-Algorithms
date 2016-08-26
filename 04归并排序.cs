using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04归并排序
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                -------归并排序：
             * 让数组中的每一个元素成为n个长度为1的有序区间，
             * 然后将相邻的长度为1的区间之间进行合并，得到最大长度为2的有序区间
             * 然后再把相邻有序区间之间进行合并，得到最大长度为4的有序区间
             * 依次往下合并，直到得到数组中所有的元素都在一个有序区间时，合并结束
            */
        }
    }

    /*
    class MergeSort1
    {
        public int[] mergeSort(int[] A,int n)
        {
            Merge2(A, 0, n-1);
            return A;
        }

        public void Merge2(int[] A,int p,int r)
        {
            if(p<r)
            {
                int q=(p+r)/2;
                Merge2(A, p, q);
                Merge2(A, q + 1, r);
                Merge1(A, p, q, r);
            }
        }

        public void Merge1(int[] A,int p,int q,int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;

            int[] L = new int[n1 + 1];
            int[] R = new int[n2 + 1];

            for(i=0;i<n1;i++)
            {
                L[i] = A[i + p];
            }
            for(j=0;j<n2;j++)
            {
                R[j] = A[j + q + 1];
            }

            i = 0;
            j = 0;
            for(k=p;k<=r;k++)
            {
                if (j == n2 || L[i] <= R[j])
                    A[k] = L[i++];
                else
                    A[k] = R[j++];
            }
        }
     */

    class MergeSort
    {
        public int[] mergeSort(int[] A,int n)
        {
            Merge2(A,0,n-1);
            return A;
        }

        public void Merge(int[] A,int low,int middle,int high)
        {
            int[] temp=new int[A.Length];
            A.CopyTo(temp,0);
            int index=low;
            int m=middle+1;
            while(low<=middle&&m<=high)
            {
                if(temp[low]<=temp[m])
                {
                    A[index++]=temp[low++];
                }
                else
                {
                    A[index++]=temp[m++];
                }
            }
            while(low<=middle)
            {
                A[index++]=temp[low++];
            }
            while(m<=high)
            {
                A[index++]=temp[m++];
            }
        }

        public void Merge2(int[] A,int low,int high)
        {
            if(low!=high)
            {
                int middle=(low+high)/2;
                Merge2(A,low,middle);
                Merge2(A,middle+1,high);
                Merge(A,low,middle,high);
            }
        }
    }
}

