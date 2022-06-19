using System;
using System.Collections.Generic;
using System.Linq;

namespace messages
{

    public class shuffledLetters
    {
        private static string newAlphabet;

        public static string shuffle(string newAlphabet)
        {
            List<string> alphabet = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "U", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            List<string> shuffledAlpha = new List<string>();

            var rnd = new Random();
            var randomized = alphabet.OrderBy(item => rnd.Next());

            foreach (string letter in randomized)
            {
                //Console.Write(letter);
                shuffledAlpha.Add(letter);
            }
            Console.WriteLine(string.Join(", ", alphabet));
            Console.WriteLine(newAlphabet);
            Console.WriteLine(string.Join(", ", shuffledAlpha));

            return newAlphabet;
        }

        public static void Main(string[] args)
        {
            shuffle(newAlphabet);
            Console.WriteLine(newAlphabet);

        }

    }
    
}
