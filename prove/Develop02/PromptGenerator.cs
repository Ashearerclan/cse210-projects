using System;
using System.Collections.Generic;

namespace JournalProgram
{
    public class PromptGenerator
    {
        // A list of prompts with the ability to add more in the future.
        private List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What made me smile today?",
            "What did I learn today that surprised me?",
            "What challenged me today and how did I overcome it?",
            "What moment today am I most grateful for?",
            "What did I do today that brought me closer to my goals?",
            "How did I take care of myself today?",
            "What was a highlight of my day and why?",
            "What yummy food did I eat today?"
        };

        private Random random;

        public PromptGenerator()
        {
            random = new Random();
        }

        // Returns a randomly selected prompt.
        public string GetRandomPrompt()
        {
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}
