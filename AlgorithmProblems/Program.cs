﻿using AlgorithmProblems;
using AlgorithmProblems.Utility;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("                                   WELCOME TO ALGORITHM PROGRAMS                                   ");
        bool check = true;
        const string path = @"D:\Practice Problems\AlgorithmProblems\AlgorithmProblems\AlgorithmProblems\Data.txt";
        Console.WriteLine("1.Binary Search\n2. Insertion Sort \n3. Bubble Sort \n4.Checking Anagram \n5.Prime Number In Range \n6.Exit");
        while (check)
        {
            Console.Write("\nEnter an option to execute :");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearch binary = new BinarySearch();
                    string[] inputArray = File.ReadAllLines(path);
                    Console.WriteLine("Enter a word to search :");
                    string word = Console.ReadLine();
                    binary.Binary(inputArray, word);
                    break;
                case 2:
                    InsertionSort sort = new InsertionSort();
                    sort.Sort();
                    break;
                case 3:
                    BubbleSort bubble = new BubbleSort();
                    bubble.Sort();
                    break;
                case 4:
                    Anagram anagram = new Anagram();
                    anagram.CheckAnagram();
                    break;
                case 5:
                    PrimeNumber primeNumber=new PrimeNumber();
                    primeNumber.PrimeNumberInRange();
                    break;
                case 6:
                    Console.WriteLine("Enter The Correct Option");
                    break;
                default:
                    check = false;
                    break;
            }
        }
    }
}
