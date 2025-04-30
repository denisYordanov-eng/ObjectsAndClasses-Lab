using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            Random rndm = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
              
                int pos2 = rndm.Next(0, words.Length);

                string newPositionWords = words[pos2];
                string oldPositionWords = words[pos1];

                words[pos1] = newPositionWords;
                words[pos2] = oldPositionWords;
                
            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
