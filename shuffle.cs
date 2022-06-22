namespace messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public struct HackerProfile
    {

        public class GoStart
        {

            public string Shuffle ()
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
                    string newAlphabet = string.Join(", ", shuffledAlpha);
                    //Console.WriteLine(newAlphabet);
                    //Console.WriteLine(string.Join(", ", shuffledAlpha));

                    string decrypt = CrackMessage;

                    return newAlphabet;
            }
            

            private static string CrackMessage
            {
                get
                {
                    int userLevel = 0;
                    List<string> messageList = new List<string>() { "Hello, Welcome to this game",
                                                                    "Hacking is fun"};
                    string message = messageList[index: userLevel];
                    Console.WriteLine(message);
                    return message;
                }
            }
        
        }

        public static void Main(string[] args)
        {
            // call first class
            var gs = new GoStart();
            var shuffled = gs.Shuffle();
            Console.WriteLine("Hello Test");
            // shuffled = new Alphabet
            Console.WriteLine(shuffled);
        }

    }
}
