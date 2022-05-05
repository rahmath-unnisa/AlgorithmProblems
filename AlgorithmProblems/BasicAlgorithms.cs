using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class BasicAlgorithms
    {
        public void Binary()
        {
            int start = 0;
            const string Data_filepath = @"D:\Practice Problems\AlgorithmProblems\AlgorithmProblems\AlgorithmProblems\Data.txt";
            string list = File.ReadAllText(Data_filepath);
            string[] arr = list.Split(" ");
            int end = arr.Length-1;
            int result;
            bool check=false;
            Console.WriteLine("Enter The Word");
            string name = Console.ReadLine();
            //while (start <= end)
            //{
            //    int m= start+(end-start)/2;
            //    int res=name.CompareTo(arr[m]);
            //        if (res == 0)
            //            return m;
            //        if (res > 0)
            //            end = m - 1;
            //        else
            //            end = m + 1;

            //}
            //return -1;
            //if (result == -1)
            //{
            //    Console.WriteLine("Element not present");
            //}
            //else
            //    Console.WriteLine("Element is present");
            foreach (string value in arr)
            {
                if (value.Equals(name))
                {
                    check = true;
                    Console.WriteLine("Element is present");
                }

            }
            if (check == false)
            {
                Console.WriteLine("Element is not present");
            }

        }
   

        }
}
