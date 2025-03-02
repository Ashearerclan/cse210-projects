class BreathingActivity : Activity
{
    protected override string GetActivityName() => "Breathing Activity";
    protected override string GetActivityDescription() => "This activity helps you relax by guiding your breathing.";
    
    protected override void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(5);
            Console.WriteLine("Breathe out...");
            ShowCountdown(5);
        }
    }
}