using System;
using System.Collections.Generic;
using System.Linq;

namespace WordBreaker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("-- The Word Breaker --");
            Console.WriteLine("-- Given a string and words, I'll determine if those words are in the string! --");

            bool runAgain = false;

            do
            {
                Run();
                runAgain = RunAgain();
            } while (runAgain);

            Console.Write("Exiting...");
            Console.ReadKey();
        }

        private static void Run()
        {
            Console.WriteLine();
            Console.Write(">> Please enter a string: ");
            string theString = Console.ReadLine();

            Console.Write(">> Please enter a list of words, separated by commas: ");
            List<string> theWordList = Console.ReadLine().Split(',').ToList();

            Console.WriteLine();

            TheWordBreaker wordBreaker = new TheWordBreaker();

            if (wordBreaker.DoesStringContainAnyProvidedWords(theString, theWordList))
            {
                Console.WriteLine(wordBreaker.ResultsMessage);
            }
            else
            {
                Console.WriteLine(wordBreaker.NoResultsMessage);
            }
        }

        private static bool RunAgain()
        {
            int attemptCount = 0;
            const int attemptMax = 5;

            do
            {
                Console.Write(">> Run again? y/n: ");
                string input = Console.ReadLine().ToLower().Trim();

                if (input.Equals("y"))
                {
                    return true;
                }
                else if (input.Equals("n"))
                {
                    return false;
                }

                attemptCount++;
            } while (attemptCount < attemptMax);

            return false;
        }
    }
}