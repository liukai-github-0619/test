using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5, 2, 6, -1, 2, 78, 23, -99, 122 };
            sort2(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arr"></param>
        public static void sort1(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// 归并排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static int[] sort2(int[] a, int left, int right)
        {
            int mid = (left + right) / 2;
            if (left < right)
            {
                sort2(a, left, mid);
                sort2(a, mid + 1, right);
                //左右归并
                merge(a, left, mid, right);
            }
            return a;
        }


        public static void merge(int[] arr, int left,  int mid,int right)
        {
            int i = left;
            int j = mid + 1;
            int t = 0;
            int[] tmp = new int[right - left + 1];
            //将左右两边较小的数添加到临时数组中
            while (i <= mid && j <= right)
            {
                if (arr[i] < arr[j])
                {
                    tmp[t] = arr[i];
                    t++;
                    i++;
                }
                else
                {
                    tmp[t] = arr[j];
                    t++;
                    j++;
                }

            }

            //将数组中剩余的元素依次添加到临时数组中
            while (i <= mid)
            {
                tmp[t] = arr[i];
                t++;
                i++;
            }
            while (j <= right)
            {
                tmp[t] = arr[j];
                t++;
                j++;
            }

            // 把新数组中的数覆盖nums数组
            for (int x = 0; x < tmp.Length; x++)
            {
                arr[x + left] = tmp[x];
            }


        }




    }
}
