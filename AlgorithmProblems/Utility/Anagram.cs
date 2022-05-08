using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems.Utility
{
    public class Anagram
    {
        int count = 0;
        public void CheckAnagram()
        {
            Console.WriteLine("Enter 1st string value: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd string value: ");
            string str2 = Console.ReadLine();
            int first_Length = str1.Length;
            int second_Length = str2.Length;
            bool check = true;
            if (first_Length != second_Length)
            {
                check = false;
            }
            else
            {
                char[] first_array = str1.ToLower().ToCharArray();
                char[] second_array = str2.ToLower().ToCharArray();
                Array.Sort(first_array);
                Array.Sort(second_array);
                check = second_array.Equals(first_array);

                for (int i = 0; i < first_Length && first_Length == second_Length; i++)
                {
                    if (first_array[i] != second_array[i])
                    {
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Entered Value is anagram");
            }
            else
            {
                Console.WriteLine("Enterd Value is not anagram");
            }
        }
    }
}
