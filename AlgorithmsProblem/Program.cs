using AlgorithmsProblem;

namespace AlgorithmsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_PATH = @"C:\Users\anura\Music\AlgorithmsProblem\AlgorithmsProblem\AlgorithmsProblem\Words.txt";
            Anagarm anagram = new Anagarm();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs \n1.Binary search \n2.Insertion sort \n3 bubbleSort \n4.Anagram");
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
                    case 3:
                        BubbleSort bubblesort = new BubbleSort();
                        bubblesort.bubbleSort(FILE_PATH);
                        break;
                    case 4:
                        if (anagram.AnagramDetection())
                            Console.WriteLine("Given words are Anagrams!");
                        else
                            Console.WriteLine("No! Given words are not Anagrams!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
