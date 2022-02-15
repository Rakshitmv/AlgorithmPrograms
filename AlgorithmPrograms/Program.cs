using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs\n" + "Enter 1: Binary Search\n" + "Enter 2: Insertion Sort\n" + "Enter 3:Bubble Sort\n" + "Enter 4: Merge Sort\n" + "Enter 5: Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearch binarySearch = new BinarySearch();
                    System.Console.WriteLine("Enter string value to search:");
                    string userInput = Console.ReadLine();
                    System.Console.WriteLine("User input is :" + userInput);
                    binarySearch.BinarySearchIterative(userInput);
                    break;
                case 2:
                    InsertionSort insertionSort = new InsertionSort();
                    int[] arr = { 39, 65, 32, 1, 18, 78, 10 };
                    insertionSort.Sort(arr);
                    insertionSort.printArray(arr);
                    break;
                case 3:
                    BubbleSort bubbleSort = new BubbleSort();
                    int[] array = { 20, 56, 89, 2, 32 };
                    BubbleSort.BubbleSortInArray(array);
                    BubbleSort.PrintArray(array);
                    break;
                case 4:
                    int[] array1 = { 45, 90, 56, 81, 1, 423};
                    MergeSort.Sort(array1, 0, array1.Length - 1);
                    MergeSort.PrintArray(array1);
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("enter valid option");
                    break;

            }
            Console.ReadLine();
        }
    }
}
