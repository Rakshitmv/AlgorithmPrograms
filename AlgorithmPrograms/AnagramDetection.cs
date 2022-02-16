using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AnagramDetection
    {
        public void Anagram()
        {
            Console.WriteLine("Enter two string values:");
            string inputStr1 = Console.ReadLine();
            string inputStr2 = Console.ReadLine();

            char[] storeChar1 = inputStr1.ToLower().ToCharArray();
            char[] storeChar2 = inputStr2.ToLower().ToCharArray();

            Array.Sort(storeChar1);
            Array.Sort(storeChar2);

            string temp1 = new string(storeChar1);
            string temp2 = new string(storeChar2);

            if (temp1.Equals(temp2))
            {
                Console.WriteLine("Both strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both strings are not Anagrams");
            }
        }

    }
}


    
