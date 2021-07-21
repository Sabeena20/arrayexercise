using System;
using System.Collections.Generic;

namespace listexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            numberList.Add(10);
            numberList.Add(2);
            numberList.Add(1);
            numberList.Add(3);
            numberList.Add(5);
            numberList.Add(46);
            numberList.Add(53);
            numberList.Add(36);
            numberList.Add(42);
            numberList.Add(0);
            int sum = FindSum.GetSumOfEven(numberList);
            Console.WriteLine(sum);

            List<String> wordList = new List<string>();
            wordList.Add("hello");
            wordList.Add("no");
            wordList.Add("flower");
            wordList.Add("cat");
            wordList.Add("rayyan");
            Console.WriteLine(Wordlength.GetLength(wordList,5));


            Console.WriteLine("Enter a word length");
            string input = Console.ReadLine();
            int wordLength = int.Parse(input);
            //Wordlength.GetLength(wordList, wordLength);

            Console.WriteLine("The word with the length " + wordLength + " is " + Wordlength.GetLength(wordList, wordLength));






        }
    }
}
