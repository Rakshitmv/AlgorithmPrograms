using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        public void BinarySearchIterative(string userInput)
        {
            string[] strInputArray = { "My", "name", "is", "rakshit", "vaghasia" };
            int min = 0, mid = 0, result = -1;
            int max = strInputArray.Length - 1;

            Console.WriteLine("Array values are:\n");
            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine(strInputArray[i]);
            }
            

            while (min <= max)
            {
                mid = min + (min - 1) / 2;

                if (userInput.Equals(strInputArray[mid]))
                {
                    result = 0;
                }

                if (result == 0)
                {
                    Console.WriteLine("match found");
                }

                int val = Convert.ToInt32(userInput.CompareTo(strInputArray[mid]));

                if (val == 1)
                {
                    min = mid + 1;
                    result = 1;
                }
                else
                {
                    max = mid - 1;
                    result = 1;
                }
            }

            if (result == -1)
            {
                Console.WriteLine("String not found");
            }
            else if (result == 1)
            {
                Console.WriteLine("String found");
            }

        }
    }
}
