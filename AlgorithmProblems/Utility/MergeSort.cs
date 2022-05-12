using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems.Utility
{
        public class MergeSort
        {
            public int[] Sorting(int[] array)
            {
                int[] firstHalf;
                int[] secondHalf;
                int[] result = new int[array.Length];
                if (array.Length <= 1)
                {
                    return array;
                }
                int midPoint = array.Length / 2;
                firstHalf = new int[midPoint];
                if (array.Length % 2 == 0)
                {
                    secondHalf = new int[midPoint];
                }
                else
                {
                    secondHalf = new int[midPoint + 1];
                }
                for (int i = 0; i < midPoint; i++)
                {
                    firstHalf[i] = array[i];
                }
                int j = 0;
                for (int i = midPoint; i < array.Length; i++)
                {
                    secondHalf[j] = array[i];
                    j++;
                }
                firstHalf = Sorting(firstHalf);
                secondHalf = Sorting(secondHalf);
                result = Merge(firstHalf, secondHalf);
                return result;
            }
            public int[] Merge(int[] firstHalf, int[] secondHalf)
            {
                int resultLength = firstHalf.Length + secondHalf.Length;
                int[] result = new int[resultLength];
                int firstHalfIndex = 0, secondHalfIndex = 0;
                int resultIndex = 0;
                while (firstHalfIndex < firstHalf.Length || secondHalfIndex < secondHalf.Length)
                {
                    if (firstHalfIndex < firstHalf.Length && secondHalfIndex < secondHalf.Length)
                    {
                        if (firstHalf[firstHalfIndex] <= secondHalf[secondHalfIndex])
                        {
                            result[resultIndex] = firstHalf[firstHalfIndex];
                            firstHalfIndex++;
                            resultIndex++;
                        }
                        else
                        {
                            result[resultIndex] = secondHalf[secondHalfIndex];
                            secondHalfIndex++;
                            resultIndex++;
                        }
                    }
                }
                return result;
            }
        }
    }
