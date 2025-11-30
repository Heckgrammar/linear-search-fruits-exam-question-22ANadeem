namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found
            
            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names
            using System;



        Console.WriteLine("Enter the word you would like to find:");
        string targetWord = Console.ReadLine();

        bool isFound = FindWordLinearSearch(wordList, targetWord);

        if (isFound)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

    static bool FindWordLinearSearch(string[] words, string searchWord)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == searchWord)
            {
                return true;
            }
        }
        return false;
    }
}
