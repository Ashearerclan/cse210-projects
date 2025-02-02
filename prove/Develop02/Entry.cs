using System;

namespace JournalProgram
{
    public class Entry
    {
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }

        public Entry(string date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }

        // Returns a formatted string suitable for displaying
        public override string ToString()
        {
            return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
        }

        // Formats the entry data for saving to a file.
        // Uses "~|~" as the field separator.
        public string ToFileString()
        {
            return $"{Date}~|~{Prompt}~|~{Response}";
        }

        // Creates an entry object from a formatted file string.
        public static Entry FromFileString(string fileLine)
        {
            string[] parts = fileLine.Split(new string[] { "~|~" }, StringSplitOptions.None);
            if (parts.Length >= 3)
            {
                return new Entry(parts[0], parts[1], parts[2]);
            }
            else
            {
                throw new FormatException("File line is not in the correct format.");
            }
        }
    }
}
