class ReflectionActivity : Activity
{
    private static readonly List<string> Prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    
    private static readonly List<string> Questions = new()
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    protected override string GetActivityName() => "Reflection Activity";
    protected override string GetActivityDescription() => "This activity helps you reflect on times of strength and resilience.";
    
    protected override void RunActivity()
    {
        Random rnd = new();
        Console.WriteLine(Prompts[rnd.Next(Prompts.Count)]);
        ShowCountdown(5);
        
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(Questions[rnd.Next(Questions.Count)]);
            DateTime questionEndTime = DateTime.Now.AddSeconds(15);
            while (DateTime.Now < questionEndTime)
            {
                Thread.Sleep(1000);
            }
        }
    }
}