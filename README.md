using System;

class Program
{
    static void Main()
    {
        string[] wordList = { "apple", "banana", "orange", "grape", "melon" };

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
