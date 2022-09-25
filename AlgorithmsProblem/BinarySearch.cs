using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsProblem
{
    public class BinarySearch
    {
        public void Search(string filePath)
        {
            string data = File.ReadAllText(filePath);
            string[] words= data.Split(" ");
            Console.WriteLine("Enter word to search");
            string seaech = Console.ReadLine();
            foreach (var item in words)
            {
                if(seaech.ToLower().Equals(item.ToLower()))
                {
                    Console.WriteLine("Word found");
                    return;
                }
            }
            Console.WriteLine("word not found");
        }
    }
}
