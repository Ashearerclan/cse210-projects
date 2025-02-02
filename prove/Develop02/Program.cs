using System;

namespace JournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();
            bool quit = false;

            while (!quit)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? (Enter Number here): ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        WriteEntry(journal, promptGenerator);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        LoadJournal(journal);
                        break;
                    case "4":
                        SaveJournal(journal);
                        break;
                    case "5":
                        quit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        // Handles the "Write" option by obtaining a random prompt, capturing the user’s response, and adding a new entry to the journal.
        static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
        {
            string prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine("Prompt:");
            Console.WriteLine(prompt);
            Console.Write("Your response: ");
            string response = Console.ReadLine();

            string dateText = DateTime.Now.ToShortDateString();
            Entry entry = new Entry(dateText, prompt, response);
            journal.AddEntry(entry);

            Console.WriteLine("Your entry has been added to the journal.");
        }

        // Prompts the user for a filename and saves the current journal entries.
        static void SaveJournal(Journal journal)
        {
            Console.Write("Enter the filename to save to: ");
            string filename = Console.ReadLine();
            journal.SaveToFile(filename);
        }

        // Prompts the user for a filename and loads journal entries from the file.
        static void LoadJournal(Journal journal)
        {
            Console.Write("Enter the filename to load from: ");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);
        }
    }
}
