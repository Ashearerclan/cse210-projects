using System;

class Program
{
static void Main()
{
    Scripture scripture = new Scripture();
    scripture.LoadScriptures();
    scripture.SelectRandomScripture();

    while (true)
    {
        Console.Clear();
        Console.WriteLine(scripture.RenderScripture());

        if (scripture.AllWordsHidden())
        {
            Console.WriteLine("\nAll words are hidden. Press Enter to end the program.");
            Console.ReadLine();
            break;
        }

        Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
        string input = Console.ReadLine();
        if (input.ToLower() == "quit")
            break;

        scripture.HideRandomWords(3);
    }
}
}