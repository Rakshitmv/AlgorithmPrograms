using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class MergeSort
    {
        public static void Merge(int[] arr, int a, int b, int r)
        {
            int num1 = b - a + 1;
            int num2 = r - b;
            int[] leftArray = new int[num1];
            int[] rightArray = new int[num2];
            int i, j;
            for (i = 0; i < num1; ++i)
            {
                leftArray[i] = arr[a + i];
            }
            for (j = 0; j < num2; ++j)
            {
                rightArray[j] = arr[b + 1 + j];
            }

            i = 0;
            j = 0;
            int k = a;
            while (i < num1 && j < num2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }
        }
        public static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {

                int m = (l + r) / 2;
                Sort(arr, l, m);
                Sort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }
        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
                
        }
    }
}
