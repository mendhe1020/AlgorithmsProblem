﻿using AlgorithmsProblem;

namespace AlgorithmsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs \n1.Binary search \n2.Insertion sort\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.Search(@"C:\Users\anura\Music\AlgorithmsProblem\AlgorithmsProblem\AlgorithmsProblem\Words.txt");
                        break;
                    case 2:
                        InsertionSort insertionsort = new InsertionSort();
                        insertionsort.Insertion();
                        break;
                }
            }
        }
    }
}
