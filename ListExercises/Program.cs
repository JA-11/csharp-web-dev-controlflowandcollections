using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {

           static int sumEven(List<int> arr)
            {
                int total = 0;
                foreach (int item in arr)
                {
                    if (item % 2 == 0)
                    {
                        total += item;
                    }
                }
                return total;
            }

            List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine(sumEven(numberList));


            static void fiveLetterWords(List<string> wordList)
                {
                    foreach (string word in wordList)
                    {
                        if (word.Length == 5)
                        {
                            Console.WriteLine(word);
                        }
                    }
                }

            Console.WriteLine("Please enter a word: ");
            string userInput = Console.ReadLine();

            List<string> words = new List<string> { "dog", "cat", "dance", "lunch" };

            words.Add(userInput);

            fiveLetterWords(words);


            
            Console.WriteLine("Please enter a word length to search for: ");

            string userWordLength = Console.ReadLine();
            int lengthNum = int.Parse(userWordLength);


            static void printXLetterWords(List<string> wordList, int wordLength)
            {
                foreach (string word in wordList)
                {
                    if (word.Length == wordLength)
                    {
                        Console.WriteLine(word);
                    }
                }
            }

            printXLetterWords(words, lengthNum);


            //Console.WriteLine("Hello Lists!");
        }
    }
}
