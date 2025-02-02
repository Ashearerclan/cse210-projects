using System;
using System.Collections.Generic;
using System.IO;

namespace JournalProgram
{
    public class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        // Adds a new entry to the journal.
        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        // Iterates through all entries and displays them on the console.
        public void DisplayEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("No entries in the journal yet.");
                return;
            }

            Console.WriteLine("Journal Entries:");
            Console.WriteLine("-----------------------------");
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.ToString());
                Console.WriteLine("-----------------------------");
            }
        }

        // Saves all journal entries to the specified file.
        public void SaveToFile(string filename)
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry entry in entries)
                    {
                        outputFile.WriteLine(entry.ToFileString());
                    }
                }
                Console.WriteLine($"Journal successfully saved to {filename}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving file: {ex.Message}");
            }
        }

        // Loads journal entries from the specified file.
        // Any existing entries will be replaced.
        public void LoadFromFile(string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    Console.WriteLine("File not found.");
                    return;
                }

                string[] lines = File.ReadAllLines(filename);
                entries.Clear();
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Entry entry = Entry.FromFileString(line);
                        entries.Add(entry);
                    }
                }
                Console.WriteLine($"Journal successfully loaded from {filename}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }
        }
    }
}
