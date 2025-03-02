class ListingActivity : Activity
{
    private static readonly List<string> Prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };
    
    protected override string GetActivityName() => "Listing Activity";
    protected override string GetActivityDescription() => "This activity helps you reflect on the good things in your life.";
    
    protected override void RunActivity()
    {
        Random rnd = new();
        Console.WriteLine(Prompts[rnd.Next(Prompts.Count)]);
        ShowCountdown(5);
        
        List<string> items = new();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            items.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {items.Count} items!");
    }
}