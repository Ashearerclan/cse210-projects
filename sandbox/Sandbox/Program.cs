using System;

class Program
{
    static void Main(string[] args)
    {
        // This is a comment
        string adjective = GetAdjective();
        string noun = GetNoun();

        int number = Multiply(3, 4);

        Console.WriteLine($"I looked out the window and saw {number} {adjective} {noun}s");
    }

    static int Multiply(int number1, int number2)
    {
        int product = number1 * number2;

        return product;
    }

    static string GetAdjective()
    {
        List<string> words = new List<string>();
        words.Add("blue");
        words.Add("yellow");
        words.Add("big");
        words.Add("small");

        string adjective = words[2];

        return adjective;
    }

    static string GetNoun()
    {
        string word = "bird";

        return word;
    }
}