using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsProblem
{
    internal class Anagarm
    {
        public bool AnagramDetection()
        {
            Console.WriteLine("Please enter the two strings to find if they are anagrams or not. :");
            string First = Console.ReadLine();
            string Last = Console.ReadLine();
            if (First.Length != Last.Length)
            {
                Console.WriteLine("Please enter two strings of same length!");
                return false;
            }
            char[] FirstCharArray = First.ToLower().ToCharArray();
            char[] LastCharArray = Last.ToLower().ToCharArray();
            Array.Sort(FirstCharArray);
            Array.Sort(LastCharArray);
            for (int i = 0; i < FirstCharArray.Length; i++)
            {
                if (FirstCharArray[i] != LastCharArray[i])
                    return false;
            }
            return true;
        }
    }
}
